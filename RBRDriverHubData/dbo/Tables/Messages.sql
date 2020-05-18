CREATE TABLE [dbo].[Messages]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [MessageTopic] NVARCHAR(50) NOT NULL, 
    [MessageContent] NVARCHAR(MAX) NULL, 
    [MessageAttachment] NVARCHAR(50) NULL, 
    [MessageAdressee] NVARCHAR(50) NOT NULL, 
    [MessageSender] NVARCHAR(50) NOT NULL, 
    [MessageDate] DATETIME DEFAULT (getutcdate()) NULL
)
