USE ticket_system
-- ==================================================================================
-- ==================================================================================
--					PROCEDURES
-- ==================================================================================
-- ==================================================================================

-- =========================================
-- 				CREATE ACTION 			  --
-- =========================================
if OBJECT_ID('dbo.CreateAction') is not null
	drop proc dbo.CreateAction
GO

create proc dbo.CreateAction (@note varchar(255), @ticket_id int, @admin_id int, @step_order int, @id_type int)
as
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	BEGIN TRAN
	BEGIN TRY
		DECLARE @state varchar(63)
		DECLARE @should varchar(63) = 'In Progress'

		-- ticket must be In Progress
		SELECT @state=state FROM dbo.ticket WHERE code = @ticket_id

		IF @state = @should
		BEGIN
			-- insert the action
			insert into dbo.action (created_at, ended_at, note, ticket_id, admin_id, step_order, id_type)
			values (CURRENT_TIMESTAMP, null, @note, @ticket_id, @admin_id, @step_order, @id_type)
		END
		
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		-- any error should rollback, throw an exception?
		ROLLBACK TRAN
	END CATCH
GO


-- =========================================
-- 				CLOSE ACTION
-- =========================================
if object_id('dbo.CloseAction') is not null
	drop procedure dbo.CloseAction 
GO

-- Set ended date
create proc dbo.CloseAction (@id int)
as
	UPDATE dbo.action SET ended_at = getdate() 
	WHERE	id = @id
GO
