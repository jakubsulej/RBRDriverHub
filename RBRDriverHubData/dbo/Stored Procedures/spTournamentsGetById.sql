CREATE PROCEDURE [dbo].[spTournamentsGetById]
	@TournamentId nvarchar(128)
AS
begin
	set nocount on;
	SELECT * From dbo.Tournaments Where TournamentId = @TournamentId
end
