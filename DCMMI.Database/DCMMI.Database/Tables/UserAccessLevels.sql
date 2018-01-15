CREATE TABLE [dbo].[UserAccessLevels]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [LevelCode] NCHAR(10) NOT NULL, 
    [LevelDescription] NVARCHAR(MAX) NULL
)
