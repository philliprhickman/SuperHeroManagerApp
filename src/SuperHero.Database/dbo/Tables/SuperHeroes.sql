CREATE TABLE [dbo].[SuperHeroes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Name] VARCHAR(100) NOT NULL,
    [Alias] VARCHAR(100) NOT NULL,
    [Location] VARCHAR(255) NOT NULL,
    [Notes] TEXT NULL,
    [ComicBookCreator] VARCHAR(100) NOT NULL,
    [DateCreatedUtc] DATETIME DEFAULT(GETUTCDATE()),
    [DateUpdatedUtc] DATETIME NULL,
    [DateDeletedUtc] DATETIME NULL
)
