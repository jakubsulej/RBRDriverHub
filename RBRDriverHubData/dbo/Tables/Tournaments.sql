CREATE TABLE [dbo].[Tournaments]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TournamentName] NVARCHAR(50) NOT NULL, 
    [TournamentDescription] NVARCHAR(MAX) NULL, 
    [TournamentDate] DATETIME2 NOT NULL, 
    [TorunamentCarId] INT NOT NULL, 
    CONSTRAINT [FK_Tournaments_ToCars] FOREIGN KEY ([TorunamentCarId]) REFERENCES Cars([Id])
)
