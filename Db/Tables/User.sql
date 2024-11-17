﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [UserGroup] INT NOT NULL DEFAULT 1, 
    [Status] INT NOT NULL DEFAULT 1
)
