﻿CREATE TABLE [dbo].[Tournaments]
(
	[TorunamentId] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [TournamentName] NVARCHAR(50) NOT NULL, 
    [TournamentDescription] NVARCHAR(MAX) NULL, 
    [TournamentDate] DATETIME2 NOT NULL
)
