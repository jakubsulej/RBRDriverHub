CREATE PROCEDURE [dbo].[spTournamentCarInsert]
	@TournamentId nvarchar (128),
	@CarId int
AS
begin
	Insert into [dbo].[TournamentCars](TournamentId, CarId) values (@TournamentId, @CarId)
end
