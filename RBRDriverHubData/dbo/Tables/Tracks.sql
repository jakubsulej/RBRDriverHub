CREATE TABLE [dbo].[Tracks]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY, 
    [TrackId] NVARCHAR(128) NOT NULL , 
    [TrackName] VARCHAR(50) NULL, 
    [TrackDate] DATE NULL, 
    [TrackDescription] NVARCHAR(128) NULL
)
