CREATE PROCEDURE [dbo].[spGetTrackById]
	@TrackId int
AS
begin
	set nocount on;
	SELECT * FROM [dbo].[Tracks] Where Id = @TrackId
end
