CREATE TABLE [dbo].[Reviews]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NCHAR(10) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [StarRating] DECIMAL(1, 1) NOT NULL, 
    [RestaurantId] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_Reviews_Restaurant.Id] FOREIGN KEY (RestaurantId) REFERENCES [Restaurant]([Id]), 
    CONSTRAINT [FK_Reviews_User] FOREIGN KEY (UserId) REFERENCES [User]([Id])
)
