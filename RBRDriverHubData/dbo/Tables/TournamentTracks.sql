CREATE TABLE [dbo].[TournamentTracks]
(
	[TournamentId] NVARCHAR(128) NOT NULL , 
    [TrackId] INT NOT NULL, 
    [StageOrderInTournament] INT NOT NULL, 
    [TournamentStageId] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [PK_TournamentTracks] PRIMARY KEY ([TournamentStageId])
)
