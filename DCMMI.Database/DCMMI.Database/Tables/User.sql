CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [UserLevel] INT NULL, 
    CONSTRAINT [FK_User_UserAccessLevels] FOREIGN KEY (UserLevel) REFERENCES UserAccessLevels(Id)
)
