USE ticket_system
-- ==================================================================================
-- ==================================================================================
--					PROCEDURES
-- ==================================================================================
-- ==================================================================================

-- =========================================
-- 				CREATE TICKET
-- =========================================
if OBJECT_ID('dbo.CreateTicket') is not null
	drop proc dbo.CreateTicket
GO

create proc dbo.CreateTicket
	@client_id int,
	@description varchar(max)
as
	insert into dbo.ticket(state, description, created_at, closed_at, priority, admin_id, client_id, id_type, deleted_at)
		values	('Waiting', @description, CURRENT_TIMESTAMP, null, null, null, @client_id, null, null);
GO

-- =========================================
-- 				DELETE TICKET
-- =========================================
if OBJECT_ID('dbo.DeleteTicket') is not null
	drop proc dbo.DeleteTicket
GO

create proc dbo.DeleteTicket
	@code int
as
	-- soft delete
	 update dbo.ticket set deleted_at = getdate() where code = @code
GO

-- =========================================
-- 				UPDATE TICKET
-- =========================================
if OBJECT_ID('dbo.UpdateTicket') is not null
	drop proc dbo.UpdateTicket
GO

create proc dbo.UpdateTicket
	@code int,
	@state varchar(63),
	@closed_at datetime,
	@priority varchar(63),
	@id_type int
as
	declare @current_priority varchar(63) = (select priority from ticket where code=@code)
	if @current_priority='Urgent' or (@current_priority='High-Priority' and @priority='Normal')
		return;
	update dbo.ticket
	set STATE = @state, closed_at=@closed_at, id_type=@id_type
	where code = @code
GO

-- =========================================
-- 				UPDATE TICKET PRIORITY
-- =========================================
if OBJECT_ID('dbo.UpdateTicketPriority') is not null
	drop proc dbo.UpdateTicketPriority
GO

create proc dbo.UpdateTicketPriority
	@code int
as
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	begin tran
	begin try

		declare @priority varchar(63) = (select priority from ticket where code=@code)
		declare @res varchar(63)
		if @priority='High-Priority'
			set @res = 'Urgent'
		if @priority='Normal'
			set @res = 'High-Priority'

		update dbo.ticket set priority=@res
		where code = @code
		commit tran
	end try
	begin catch
		rollback tran
	end catch
GO

-- =========================================
-- 				CLOSE TICKET
-- =========================================
if OBJECT_ID('dbo.CloseTicket') is not null
	drop proc dbo.CloseTicket
GO

create proc dbo.CloseTicket
	@code int
as
	update dbo.ticket set closed_at = CURRENT_TIMESTAMP, STATE = 'Closed'
	where code = @code
GO

-- =========================================
-- 				SETERS
-- =========================================
if OBJECT_ID('dbo.SetTicketType') is not null
	drop proc dbo.SetTicketType

if OBJECT_ID('dbo.SetTicketState') is not null
	drop proc dbo.SetTicketState

if OBJECT_ID('dbo.SetTicketPriority') is not null
	drop proc dbo.SetTicketPriority
GO

create proc dbo.SetTicketType
	@code int,
	@id_type int
as
	update dbo.ticket
	set id_type=@id_type
	where code = @code 
GO

create proc dbo.SetTicketState
	@code int,
	@state varchar(63)
as
	update dbo.ticket
	set STATE = @state
	where code = @code 
GO

create proc dbo.SetTicketPriority
	@code int,
	@priority varchar(63)
as
	declare @current_priority varchar(63) = (select priority from ticket where code=@code)
	if @current_priority='Urgent' or (@current_priority='High-Priority' and @priority='Normal')
		return;
	update dbo.ticket
	set priority=@priority
	where code = @code 
GO

-- =========================================
-- Get N tickets sorted by priority not closed
-- =========================================
if object_id('dbo.GetPriorityTickets') is not null
	drop procedure dbo.GetPriorityTickets 
GO

create proc dbo.GetPriorityTickets @rows int
as
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @table table (code int, priority varchar(63), state varchar(63))

		INSERT @table SELECT TOP (@rows) code, priority, state
		FROM
			dbo.ticket
		WHERE state != 'Closed'
		ORDER BY (case when priority = 'Urgent' then 1 
					   when priority = 'High Priority' then 2
					   else 3 end)

		SELECT * FROM @table
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH

GO

-- =========================================
-- 		Remove Ticket by id
-- =========================================
if object_id('dbo.RemoveTicket') is not null
	drop procedure dbo.RemoveTicket 
GO

-- Retorna as linhas afectadas, 0 se nao existir
create proc dbo.RemoveTicket @code int, @res int output
as
	UPDATE dbo.ticket SET deleted_at = getdate() WHERE code = @code
	SET @res = @@ROWCOUNT
GO

-- =========================================
-- 		Show Ticket Info
-- =========================================
if object_id('dbo.ShowTicketInfo') is not null
	drop procedure dbo.ShowTicketInfo
GO

create proc dbo.ShowTicketInfo @code int
as
	SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
	begin tran
		select ticket.code as [ID], request.id as [Request],
				request.response_date as [Responded When],
				request.response as [Response],
				action.step_order as [Action Order],
				action.note as [Action Notes],
				action.ended_at as [Action Completed When]
		from ticket inner join dbo.type on (ticket.id_type = type.id)
					inner join dbo.step on (type.id = step.id_type)
					inner join dbo.action on (step.id_type = action.id_type and step.num_order = action.step_order and ticket.code = action.ticket_id)
					left join dbo.request on (ticket.code = request.ticket_id and ticket.client_id = request.client_id)
		where ticket.code = @code
		order by response_date
	commit
GO


-- ==================================================================================
-- ==================================================================================
--					TRIGGERS
-- ==================================================================================
-- ==================================================================================
if  exists (select * from sys.triggers where name = 'detect_insert_ticket')
	drop trigger detect_insert_ticket
GO

create trigger detect_insert_ticket on dbo.ticket
instead of insert
as
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
begin tran
begin try
	declare @state varchar(63)
	declare @description varchar(max)
	declare @created_at datetime
	declare @priority varchar(63)
	declare @client_id int
	declare @admin_id int
	exec @admin_id = dbo.GetRandomAdmin


	select @state=state,
			@description=description, @created_at=created_at,
			@priority=priority, @client_id=client_id from inserted

	insert into dbo.ticket(state, description, created_at, closed_at, priority, admin_id, client_id, id_type, deleted_at)
	values (@state, @description, @created_at, null, @priority, @admin_id, @client_id, null, null)
commit tran
end try
begin catch
	rollback tran
end catch
GO


-- ==================================================================================
-- ==================================================================================
--					VIEWS
-- ==================================================================================
-- ==================================================================================
if object_id('dbo.GetTicketsView') is not null
	drop VIEW dbo.GetTicketsView 
GO

CREATE VIEW GetTicketsView
AS
	SELECT	code,
			state,
			description, 
			priority,
			admin_id,
			id_type,
			created_at,
			closed_at,
			DATEDIFF(day, created_at, GETDATE()) as days,
			(case when priority = 'Urgent' then 1 
				   when priority = 'High-Priority' then 2
				   else 3 end) as priority_value
	FROM dbo.ticket
	WHERE deleted_at is NULL
GO

-- ==================================================================================
-- ==================================================================================
--					TESTS
-- ==================================================================================
-- ==================================================================================

/*
-- Test Trigger 'detect_insert_ticket' --

exec dbo.CreateTicket 1, 'Teste'
select * from dbo.ticket where description='Teste'
delete from dbo.ticket where description='Teste'


*/