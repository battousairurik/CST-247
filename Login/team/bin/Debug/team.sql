﻿/*
Deployment script for team

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "team"
:setvar DefaultFilePrefix "team"
:setvar DefaultDataPath "C:\Users\Michael\AppData\Local\Microsoft\VisualStudio\SSDT\Week2"
:setvar DefaultLogPath "C:\Users\Michael\AppData\Local\Microsoft\VisualStudio\SSDT\Week2"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
The column [dbo].[registrationtab].[Age] on table [dbo].[registrationtab] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column [dbo].[registrationtab].[Firstname] on table [dbo].[registrationtab] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column [dbo].[registrationtab].[Gender] on table [dbo].[registrationtab] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column [dbo].[registrationtab].[Lastname] on table [dbo].[registrationtab] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.

The column [dbo].[registrationtab].[State] on table [dbo].[registrationtab] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[registrationtab])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Starting rebuilding table [dbo].[registrationtab]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_registrationtab] (
    [Username]  VARCHAR (100) NOT NULL,
    [Firstname] VARCHAR (40)  NOT NULL,
    [Lastname]  VARCHAR (40)  NOT NULL,
    [Gender]    VARCHAR (40)  NOT NULL,
    [Age]       VARCHAR (40)  NOT NULL,
    [State]     VARCHAR (40)  NOT NULL,
    [Email]     VARCHAR (100) NULL,
    [Password]  VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[registrationtab])
    BEGIN
        INSERT INTO [dbo].[tmp_ms_xx_registrationtab] ([Username], [Email], [Password])
        SELECT   [Username],
                 [Email],
                 [Password]
        FROM     [dbo].[registrationtab]
        ORDER BY [Username] ASC;
    END

DROP TABLE [dbo].[registrationtab];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_registrationtab]', N'registrationtab';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Altering [dbo].[strlogin]...';


GO
ALTER procedure [dbo].[strlogin]  
(  
   @username varchar(100),
   @firstname varchar(40),
   @lastname varchar(40),
   @gender varchar(40),
   @age varchar(40),
   @state varchar(40),
   @email varchar(100),
   @password varchar(20)  
)  
as  
insert into registrationtab values(@username,@firstname, @lastname,
	@gender, @age, @state,@email,@password )
GO
PRINT N'Refreshing [dbo].[CUser]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[CUser]';


GO
PRINT N'Update complete.';


GO
