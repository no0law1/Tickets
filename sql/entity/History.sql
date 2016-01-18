USE ticket_system
-- ==================================================================================
-- ==================================================================================
--					TRIGGERS
-- ==================================================================================
-- ==================================================================================

-- Trigger Automatic registry of changes --
if  exists (select * from sys.triggers where name = 'detect_changes')
	drop trigger detect_changes
GO

create trigger detect_changes on dbo.ticket
after update
as
begin tran
BEGIN TRY
	declare @sql_command varchar(63)
	if exists(select * from deleted)
		begin
		if exists (select * from inserted)
			set @sql_command = 'Update'
		else
			set @sql_command = 'Delete'
		end
	else
		set @sql_command = 'Insert'

	declare @ticket_id int
	select @ticket_id = code from deleted
	insert into dbo.history(created_at, sql_command, db_user, ticket_id)
	values(CURRENT_TIMESTAMP, @sql_command, suser_name(), @ticket_id)
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN
END CATCH
GO