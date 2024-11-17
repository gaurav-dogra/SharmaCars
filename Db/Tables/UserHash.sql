﻿CREATE TABLE [dbo].UserHash (
    Id INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
    [Hash] NVARCHAR(100) NOT NULL,
    [UserId] INT NOT NULL, 
    CONSTRAINT FK_UserHash_Id FOREIGN KEY (Id) REFERENCES [User](Id)
    ON DELETE CASCADE
);