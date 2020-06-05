CREATE PROCEDURE [dbo].[spTournamentInsert]
	@TournamentId nvarchar(128),
    @TournamentName nvarchar(50),
    @TournamentDescription nvarchar(Max),
    @TournamentDate dateTime,
    @TournamentUserId nvarchar (128)
AS
begin
    set nocount on;

    Insert into [dbo].[Tournaments](TournamentId, TournamentName, TournamentDescription, TournamentDate, TournamentUserId)
    values (@TournamentId, @TournamentName, @TournamentDescription, @TournamentDate, @TournamentUserId)
end