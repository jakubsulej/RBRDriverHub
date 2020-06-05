CREATE PROCEDURE [dbo].[spMessagesGetById]
	@AdresseeId nvarchar(128)
AS
begin
set nocount on
	SELECT * From [dbo].[Messages] Where MessageAdresseeId = @AdresseeId
end