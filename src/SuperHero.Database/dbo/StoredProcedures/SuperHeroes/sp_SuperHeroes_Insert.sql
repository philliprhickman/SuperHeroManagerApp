CREATE PROCEDURE [dbo].[sp_SuperHeroes_Insert]
    @Name               VARCHAR(100),
    @Alias              VARCHAR(100),
    @Location           VARCHAR(255),
    @Notes              TEXT,
    @ComicBookCreator   VARCHAR(100)
AS
BEGIN
    INSERT INTO [dbo].[SuperHeroes]
    (
        [Name],
        [Alias],
        [Location],
        [Notes],
        [ComicBookCreator]
    )
    VALUES
    (
        @Name,
        @Alias,
        @Location,
        @Notes,
        @ComicBookCreator
    )

    SELECT SCOPE_IDENTITY()
END
