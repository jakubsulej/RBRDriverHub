﻿CREATE TABLE [dbo].[Cars]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CarBrand] NVARCHAR(50) NOT NULL, 
    [CarName] NVARCHAR(50) NOT NULL, 
    [CarClass] NCHAR(10) NOT NULL
)
