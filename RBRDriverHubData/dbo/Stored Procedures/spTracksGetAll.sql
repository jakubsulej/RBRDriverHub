CREATE PROCEDURE [dbo].[spTracksGetAll]
AS
begin
	set nocount on;
	SELECT * FROM [dbo].[Tracks]
end
