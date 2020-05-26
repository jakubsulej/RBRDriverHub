CREATE TABLE [dbo].[UserRallyInfo]
(
	[UserId] INT NOT NULL PRIMARY KEY, 
    [TotalNumberOfKm] INT NULL, 
    [UserLicence] NVARCHAR(50) NULL, 
    [EnteredTournaments] INT NULL, 
    [FinnishedTournaments] INT NULL, 
    [WonTournaments] INT NULL, 
)
