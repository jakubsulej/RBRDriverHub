CREATE PROCEDURE [dbo].[spCarsGetAll]
AS
begin
	set nocount on;
	SELECT Id, CarBrand, CarName, CarClass FROM [dbo].[Cars]
end
