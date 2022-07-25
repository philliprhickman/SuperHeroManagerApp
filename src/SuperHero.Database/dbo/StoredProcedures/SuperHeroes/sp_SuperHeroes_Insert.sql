CREATE PROCEDURE [dbo].[sp_SuperHeroes_Insert]
    @Id                 INT,
    @Name               VARCHAR(100),
    @Alias              VARCHAR(100),
    @Location           VARCHAR(255),
    @OriginStory        TEXT,
    @Notes              TEXT,
    @WikiPage           VARCHAR(255),
    @ComicBookCompanyId INT
AS
BEGIN
    INSERT INTO [dbo].[SuperHeroes]
    (
        [Name],
        [Alias],
        [Location],
        [OriginStory],
        [Notes],
        [WikiPage],
        [ComicBookCompanyId]
    )
    OUTPUT INSERTED.Id, INSERTED.[Name], INSERTED.[Alias], INSERTED.[Location],
            INSERTED.[OriginStory], INSERTED.[Notes], INSERTED.[WikiPage],
            INSERTED.[ComicBookCompanyId]
    VALUES
    (
        @Name,
        @Alias,
        @Location,
        @OriginStory,
        @Notes,
        @WikiPage,
        @ComicBookCompanyId
    )
END
