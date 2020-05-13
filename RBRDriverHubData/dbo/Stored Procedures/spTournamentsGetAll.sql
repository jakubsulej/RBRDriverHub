CREATE PROCEDURE [dbo].[spTournamentsGetAll]
AS
begin
	set nocount on;
	SELECT * FROM [dbo].[Tournaments]
end