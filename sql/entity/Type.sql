USE ticket_system
-- ==================================================================================
-- ==================================================================================
--					PROCEDURES
-- ==================================================================================
-- ==================================================================================

-- =========================================
--	 			CREATE TYPE
-- =========================================
if OBJECT_ID('dbo.CreateType') is not null
	drop proc dbo.CreateType
GO

create proc dbo.CreateType @name varchar(63)
as
	insert into dbo.type(name) values (@name)
GO

-- =========================================
--	 			DELETE TYPE
-- =========================================
if OBJECT_ID('dbo.DeleteType') is not null
	drop proc dbo.DeleteType
GO

create proc dbo.DeleteType @id int
as
	delete from dbo.type where id = @id
go