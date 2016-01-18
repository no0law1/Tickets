USE ticket_system
-- ==================================================================================
-- ==================================================================================
--					PROCEDURES
-- ==================================================================================
-- ==================================================================================

-- =========================================
-- 				CREATE REQUEST
-- =========================================
if OBJECT_ID('dbo.CreateRequest') is not null
	drop proc dbo.CreateRequest
GO

create proc dbo.CreateRequest (@ticket_id int, @client_id int)
as
	insert into dbo.request(created_at, ticket_id, client_id)
		values	(GETDATE(), @ticket_id, @client_id);
GO

-- =========================================
-- 				RESPOND REQUEST
-- =========================================
if OBJECT_ID('dbo.RespondRequest') is not null
	drop proc dbo.RespondRequest
GO

create proc dbo.RespondRequest (@ticket_id int, @client_id int, @id int, @admin_id int, @response varchar(MAX))
as
	SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
	BEGIN TRAN
	BEGIN TRY
		-- only ticket admin or an admin involved in an action can respond
		DECLARE @count int
		SELECT @count=count(*)
		FROM dbo.ticket
		WHERE	ticket.code = @ticket_id AND 
				(ticket.admin_id = @admin_id OR (SELECT count(*) 
												FROM dbo.action 
												WHERE action.ticket_id = @ticket_id AND 
												action.admin_id = @admin_id) > 0)

		IF @count != 0
		BEGIN
			
			-- Valid admin, lets update the response
			update dbo.request set response=@response, response_date=GETDATE(), admin_id=@admin_id
			where id=@id and ticket_id=@ticket_id and client_id=@client_id 
		END
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		-- any error should rollback, throw an exception?
		ROLLBACK TRAN
	END CATCH
GO


-- ==================================================================================
-- ==================================================================================
--					TESTS
-- ==================================================================================
-- ==================================================================================

--	TEST RESPONSE OF REQUEST --
/*
exec dbo.CreateRequest 5, 1
select * from request
exec dbo.RespondRequest 5, 1, 2, 1, 'TEste'
select * from request where response like 'Teste'
delete from request where response = 'Teste'
DBCC CHECKIDENT ('request', RESEED, 0)
*/
