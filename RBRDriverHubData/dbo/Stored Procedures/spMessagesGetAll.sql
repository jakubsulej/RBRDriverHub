CREATE PROCEDURE [dbo].[spMessagesGetAll]
AS
begin
	set nocount on;
	SELECT * From [dbo].[Messages]
end
