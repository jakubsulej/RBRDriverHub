CREATE TABLE [dbo].[Messages]
(
	[MessageId] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [MessageSubject] NVARCHAR(50) NOT NULL, 
    [MessageContent] NVARCHAR(MAX) NULL, 
    [MessageAttachment] NVARCHAR(50) NULL, 
    [MessageAdresseeId] NVARCHAR(128) NOT NULL, 
    [MessageSenderId] NVARCHAR(128) NOT NULL, 
    [MessageDate] DATETIME DEFAULT (getutcdate()) NULL, 
    [UserId] NVARCHAR(128) NOT NULL
)
