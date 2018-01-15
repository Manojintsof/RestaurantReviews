CREATE TABLE [dbo].[RestaurantTypes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TypeName] NCHAR(10) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL
)
