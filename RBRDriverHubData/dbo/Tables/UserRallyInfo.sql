CREATE TABLE [dbo].[UserRallyInfo]
(
	[UserId] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [TotalNumberOfKm] INT NULL, 
    [UserLicence] NVARCHAR(50) NULL, 
    [EnteredTournaments] INT NULL, 
    [FinnishedTournaments] INT NULL, 
    [WonTournaments] INT NULL, 
    CONSTRAINT [FK_UserRallyInfo_ToTable] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)
