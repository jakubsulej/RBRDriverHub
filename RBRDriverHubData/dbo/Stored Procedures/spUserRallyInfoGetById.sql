CREATE PROCEDURE [dbo].[spUserRallyInfoGetById]
	@Id nvarchar(128)
AS
begin
	set nocount on;

	SELECT * FROM [dbo].[UserRallyInfo] WHERE UserId = @Id;
end
