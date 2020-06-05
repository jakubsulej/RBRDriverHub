CREATE PROCEDURE [dbo].[spCarsGetById]
	@CarId int
AS
begin
	set nocount on;
	SELECT Id, CarBrand, CarName, CarClass FROM [dbo].[Cars] Where Id = @CarId
end