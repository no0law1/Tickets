USE ticket_system
-- ==================================================================================
-- ==================================================================================
--					PROCEDURES
-- ==================================================================================
-- ==================================================================================

-- =========================================
--	 			CREATE CLIENT
-- =========================================
if object_id('dbo.CreateClient') is not null
	drop procedure dbo.CreateClient
GO

create proc dbo.CreateClient @name varchar(63), @email varchar(63)
as
	INSERT INTO dbo.client(name, email)
	values (@name, @email)
GO

-- =========================================
--	 			UPDATE CLIENT
-- =========================================
if object_id('dbo.UpdateClient') is not null
	drop procedure dbo.UpdateClient
GO

create proc dbo.UpdateClient @id int, @name varchar(63), @email varchar(63)
as
	update dbo.client
	set name = @name, email = @email
	where id=@id
GO

-- =========================================
--	 			DELETE CLIENT
-- =========================================
if object_id('dbo.DeleteClient') is not null
	drop procedure dbo.DeleteClient
GO

create proc dbo.DeleteClient @id int, @name varchar(63), @email varchar(63)
as
	delete from dbo.client
	where id=@id
GO

-- =========================================
--	 			SETERS
-- =========================================
if object_id('dbo.SetClientEMail') is not null
	drop procedure dbo.SetClientEMail
go

create proc dbo.SetClientEMail @id int, @email varchar(63)
as
	update dbo.client
	set email = @email
	where id=@id
GO

if object_id('dbo.SetClientName') is not null
	drop procedure dbo.SetClientName
GO

create proc dbo.SetClientName @id int, @name varchar(63)
as
	update dbo.client
	set name = @name
	where id=@id
GO

-- ==================================================================================
-- ==================================================================================
--					TESTS
-- ==================================================================================
-- ==================================================================================