CREATE PROCEDURE [dbo].[sp_SuperHeroes_Update]
	@Id                 INT,
    @Name               VARCHAR(100),
    @Alias              VARCHAR(100),
    @Location           VARCHAR(255),
    @Notes              TEXT,
    @ComicBookCreator   VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON

    UPDATE  [dbo].[SuperHeroes]
    SET     [Name]              = @Name,
            [Alias]             = @Alias,
            [Location]          = @Location,
            [Notes]             = @Notes,
            [ComicBookCreator]  = @ComicBookCreator,
            [DateUpdatedUtc]    = GETUTCDATE()
    WHERE   [Id]                = @Id
END
