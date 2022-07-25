CREATE PROCEDURE [dbo].[sp_SuperHeroes_Update]
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
    SET NOCOUNT ON

    UPDATE  [dbo].[SuperHeroes]
    SET     [Name]                  = @Name,
            [Alias]                 = @Alias,
            [Location]              = @Location,
            [OriginStory]           = @OriginStory,
            [Notes]                 = @Notes,
            [WikiPage]              = @WikiPage,
            [ComicBookCompanyId]    = @ComicBookCompanyId,
            [DateUpdatedUtc]        = GETUTCDATE()
    WHERE   [Id]                    = @Id
END
