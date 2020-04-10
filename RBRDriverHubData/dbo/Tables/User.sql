CREATE TABLE [dbo].[User]
(
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(256) NOT NULL, 
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [Id] NVARCHAR(128) NOT NULL PRIMARY KEY, 
)
