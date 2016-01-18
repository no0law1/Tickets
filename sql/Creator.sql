--use master
--drop database ticket_system
IF db_id('ticket_system') IS NULL
	CREATE DATABASE ticket_system
GO

USE ticket_system
GO

IF object_id('dbo.type') IS NULL
	CREATE TABLE dbo.type (
		id INT PRIMARY KEY identity(1,1),
		NAME VARCHAR(63) UNIQUE,
		);

IF object_id('dbo.administrator') IS NULL
	CREATE TABLE dbo.administrator (
		id INT PRIMARY KEY identity(1,1),
		NAME VARCHAR(63) NOT NULL,
		email varchar(63)
		);

IF object_id('dbo.client') IS NULL
	CREATE TABLE dbo.client (
		id INT PRIMARY KEY identity(1,1),
		NAME VARCHAR(63),
		email VARCHAR(63) unique not null,
		);

IF object_id('dbo.ticket') IS NULL
	CREATE TABLE dbo.ticket (
		code INT PRIMARY KEY identity(1,1),
		STATE VARCHAR(63) NOT NULL, /* WAITING, IN PROGRESS, CLOSED */
		description VARCHAR(MAX) NOT NULL,
		created_at DATETIME NOT NULL,
		closed_at DATETIME,
		priority VARCHAR(63),
		deleted_at DATETIME,

		admin_id INT FOREIGN KEY REFERENCES dbo.administrator(id) NOT NULL,
		client_id INT FOREIGN KEY REFERENCES dbo.client(id) NOT NULL,
		id_type INT FOREIGN KEY REFERENCES dbo.type(id),

		constraint state_types check (state in ('Waiting','In Progress','Closed')),
		constraint priority_types check (priority in ('Urgent','High-Priority','Normal'))
		);

IF object_id('dbo.step') IS NULL
	CREATE TABLE dbo.step (
		num_order INT NOT NULL,
		description VARCHAR(MAX),
		id_type INT FOREIGN KEY REFERENCES dbo.type(id),
		PRIMARY KEY (
			num_order,
			id_type
			),

		constraint positive_order check (num_order>0)
		);

IF object_id('dbo.action') IS NULL
	CREATE TABLE dbo.action (
		id int primary key identity(1,1),
		created_at DATETIME NOT NULL,
		ended_at DATETIME,
		note VARCHAR(255),
		ticket_id INT FOREIGN KEY REFERENCES dbo.ticket(code) not null,
		admin_id INT FOREIGN KEY REFERENCES dbo.administrator(id) not null,
		step_order INT not null,
		id_type INT not null,
		FOREIGN KEY (
			step_order,
			id_type
			) REFERENCES dbo.step(num_order, id_type),
		check (created_at<ended_at)
	);

IF object_id('dbo.request') IS NULL
	CREATE TABLE dbo.request (
		id INT identity(1,1),
		created_at DATETIME NOT NULL,
		response_date DATETIME,
		response VARCHAR(MAX),
		ticket_id INT FOREIGN KEY REFERENCES dbo.ticket(code),
		client_id INT FOREIGN KEY REFERENCES dbo.client(id),
		admin_id INT FOREIGN KEY REFERENCES dbo.administrator(id),
		PRIMARY KEY (
			id,
			ticket_id,
			client_id
			)
		);

IF object_id('dbo.history') IS NULL
	CREATE TABLE dbo.history (
		id INT identity(1,1),
		created_at DATETIME NOT NULL,
		sql_command VARCHAR(255),
		db_user VARCHAR(100) NOT NULL,
		ticket_id INT FOREIGN KEY REFERENCES dbo.ticket(code) NOT NULL,
		PRIMARY KEY (id)
		);