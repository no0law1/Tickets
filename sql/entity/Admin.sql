USE ticket_system
-- ==================================================================================
-- ==================================================================================
--					PROCEDURES
-- ==================================================================================
-- ==================================================================================

-- =========================================
-- 				CREATE ADMIN
-- =========================================
if object_id('dbo.CreateAdmin') is not null
	drop procedure dbo.CreateAdmin 
GO

-- Retorna o id inserido
create proc dbo.CreateAdmin @name varchar(63), @email varchar(63), @res int output
as
	INSERT INTO dbo.administrator (NAME, email) VALUES (@name, @email)
	SET @res = SCOPE_IDENTITY()
GO


-- =========================================
-- 				UPDATE ADMIN
-- =========================================
if object_id('dbo.UpdateAdmin') is not null
	drop procedure dbo.UpdateAdmin 
GO

-- Retorna as linhas afectadas
create proc dbo.UpdateAdmin @id int, @name varchar(63), @res int output
as
	UPDATE dbo.administrator SET NAME = @name WHERE id = @id
	SET @res = @@ROWCOUNT
GO


-- =========================================
-- 				DELETE ADMIN
-- =========================================
if object_id('dbo.DeleteAdmin') is not null
	drop procedure dbo.DeleteAdmin 
GO

-- Retorna as linhas afectadas
create proc dbo.DeleteAdmin @id int, @res int output
as
	DELETE FROM dbo.administrator WHERE id = @id
	SET @res = @@ROWCOUNT
GO


-- =========================================
-- 				GET RANDOM ADMIN
-- =========================================
if OBJECT_ID('dbo.GetRandomAdmin') is not null
	drop proc dbo.GetRandomAdmin
GO

-- Returns admin id
create proc dbo.GetRandomAdmin
as
	return (SELECT TOP 1 id
	FROM dbo.administrator
	ORDER BY NEWID())
go


-- ==================================================================================
-- ==================================================================================
--					TESTS
-- ==================================================================================
-- ==================================================================================

/*
-- TEST GET RANDOM ADMIN --
declare @admin_id int
exec @admin_id = dbo.GetRandomAdmin
select @admin_id 
*/