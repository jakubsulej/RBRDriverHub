CREATE TABLE [dbo].[Cars]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CarBrand] NCHAR(10) NOT NULL, 
    [CarModel] NCHAR(10) NOT NULL, 
    [CarClass] NCHAR(10) NOT NULL
)
