USE ticket_system
GO

-- Deletes
DELETE FROM dbo.request
DELETE FROM dbo.history
DELETE FROM dbo.action
DELETE FROM dbo.ticket
DELETE FROM dbo.administrator
DELETE FROM dbo.client
DELETE FROM dbo.step
DELETE FROM dbo.type
go

-- Reset ids
DBCC CHECKIDENT ('action', RESEED, 0)
DBCC CHECKIDENT ('type', RESEED, 0)
DBCC CHECKIDENT ('administrator', RESEED, 0)
DBCC CHECKIDENT ('client', RESEED, 0)
DBCC CHECKIDENT ('ticket', RESEED, 0)
DBCC CHECKIDENT ('history', RESEED, 0)
DBCC CHECKIDENT ('request', RESEED, 0)

go

-- Insert Types
exec CreateType 'Login Failed'
exec CreateType 'Cannot Create Account'
go

-- Insert Steps to Type 'Login Failed'
exec CreateStep 1, 'Step 1'
exec CreateStep 1, 'Step 2'
exec CreateStep 1, 'Step 3'

exec CreateStep 2, 'Step 1'
exec CreateStep 2, 'Step 2'
go

-- Insert Admins
exec CreateAdmin 'Nuno', 'admin_Nuno@gmail.com', null
exec CreateAdmin 'Carlos', 'admin_Carlos@gmail.com', null
exec CreateAdmin 'Admin1', 'admin_Admin1@gmail.com', null
exec CreateAdmin 'Admin2', 'admin_Admin2@gmail.com', null
go

-- Insert Clients
exec CreateClient 'Cliente1', 'cliente1@gmail.com'
exec CreateClient 'Cliente2', 'cliente2@gmail.com'
exec CreateClient 'Cliente3', 'cliente3@gmail.com'
exec CreateClient 'Cliente4', 'cliente4@gmail.com'

-- Insert Tickets
exec dbo.CreateTicket 1, 'Desc 1'
exec CreateRequest 1, 1
exec CreateRequest 1, 1
exec CreateRequest 1, 1
exec CreateRequest 1, 1
exec SetTicketState 1, 'In Progress'
exec SetTicketType 1, 1
exec SetTicketPriority 1, 'Normal'


exec dbo.CreateTicket 3, 'Desc 2'
exec SetTicketState 2, 'In Progress'
exec SetTicketType 2, 1
exec SetTicketPriority 2, 'Normal'
exec CreateAction 'Action 1', 2, 2, 1, 1
exec CreateRequest 2, 2
exec CreateAction 'Action 2', 2, 2, 2, 1
exec CreateRequest 2, 2
exec CreateRequest 2, 2
exec CreateAction 'Action 3', 2, 2, 3, 1
exec CreateRequest 2, 2
exec CreateRequest 2, 2
exec RespondRequest 2, 2, 9, 2, 'This ticket was resolved'

exec dbo.CreateTicket 2, 'Desc 3'
exec SetTicketState 3, 'In Progress'
exec SetTicketType 3, 1
exec SetTicketPriority 3, 'Normal'
exec CreateAction 'Action 1', 3, 2, 1, 1
exec CreateAction 'Action 2', 3, 2, 2, 1
exec CreateAction 'Action 3', 3, 2, 3, 1
exec CloseTicket 3

exec dbo.CreateTicket 1, 'Desc 4'


exec dbo.CreateTicket 3, 'Desc 5'


exec dbo.CreateTicket 2, 'Desc 6'
exec SetTicketState 6, 'In Progress'
exec SetTicketType 6, 2
exec SetTicketPriority 6, 'Urgent'

exec dbo.CreateTicket 2, 'Desc 7'
exec SetTicketState 7, 'In Progress'
exec SetTicketType 7, 1
exec SetTicketPriority 7, 'Urgent'
exec CloseTicket 7
exec RemoveTicket 7, null
go

WAITFOR	DELAY '00:00:02'
exec CloseAction 1
exec CloseAction 2
exec CloseAction 3