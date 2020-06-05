CREATE PROCEDURE [dbo].[spTournamentTrackInsert]
	@TournamentId nvarchar(128),
	@TrackId int,
	@StageOrderInTournament int,
	@TournamentStageId nvarchar(128)
AS
begin
	Insert into [dbo].[TournamentTracks](TournamentId, TrackId, StageOrderInTournament, TournamentStageId) 
	values (@TournamentId, @TrackId, @StageOrderInTournament, @TournamentStageId)
end
