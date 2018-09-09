CREATE TABLE [dbo].[registrationtab]
(
	[Username] VARCHAR(100) NOT NULL PRIMARY KEY, 
	[Firstname] VARCHAR(40) NOT NULL,
	[Lastname] VARCHAR(40) NOT NULL,
	[Gender] VARCHAR(40) NOT NULL,
	[Age] VARCHAR(40) NOT NULL,
	[State] VARCHAR(40) NOT NULL,
    [Email] VARCHAR(100) NULL, 
    [Password] VARCHAR(20) NOT NULL
)
