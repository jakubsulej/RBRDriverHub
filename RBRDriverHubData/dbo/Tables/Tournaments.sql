CREATE TABLE [dbo].[Tournaments]
(
	[TournamentId] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [TournamentName] NVARCHAR(50) NOT NULL, 
    [TournamentDescription] NVARCHAR(MAX) NULL, 
    [TournamentDate] DATETIME NOT NULL, 
    [TournamentUserId] NVARCHAR(128) NOT NULL 
)
