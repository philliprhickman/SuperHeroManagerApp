CREATE TABLE [dbo].[ComicBookCompanies]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Name] VARCHAR(255) NOT NULL,
    [Description] TEXT NULL,
    [Founded] DATETIME NULL,
    [WikiPage] VARCHAR(255) NULl,
    [DateCreatedUtc] DATETIME DEFAULT(GETUTCDATE()),
    [DateUpdatedUtc] DATETIME NULL,
    [DateDeletedUtc] DATETIME NULL
)
