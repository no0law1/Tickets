USE ticket_system
-- ==================================================================================
-- ==================================================================================
--					PROCEDURES
-- ==================================================================================
-- ==================================================================================

-- =========================================
-- 				CREATE STEP
-- =========================================
if OBJECT_ID('dbo.CreateStep') is not null
	drop proc dbo.CreateStep
GO

create proc dbo.CreateStep (@id_type int, @description varchar(MAX))
as
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
BEGIN TRY
	declare @num_order int

	select @num_order=max(num_order)+1 from dbo.step where id_type=@id_type
	if @num_order is null
		set @num_order = 1

	insert into dbo.step(num_order, description, id_type)
	values (@num_order, @description, @id_type)

	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN
END CATCH
GO

-- =========================================
--	 			DELETE STEP
-- =========================================
if OBJECT_ID('DeleteStep') is not null
	drop proc dbo.DeleteStep
GO

create proc dbo.DeleteStep @num_order int, @id_type int
as
	delete from dbo.step where num_order=@num_order and id_type=@id_type
GO