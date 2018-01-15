CREATE TABLE [dbo].[Restaurant]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Code] NCHAR(10) NOT NULL, 
    [RestaurantTypeId] INT NULL, 
    CONSTRAINT [FK_Restaurant_RestaurantTypes_Id] FOREIGN KEY (RestaurantTypeId) REFERENCES RestaurantTypes(Id)
)
