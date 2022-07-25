CREATE PROCEDURE [dbo].[sp_SuperHeroes_GetAll]
AS
BEGIN
    SET NOCOUNT ON

    SELECT  [Id],
            [Name],
            [Alias],
            [Location],
            [OriginStory],
            [Notes],
            [WikiPage],
            [ComicBookCompanyId]
    FROM    [dbo].[SuperHeroes] (NOLOCK)
    WHERE   [DateDeletedUtc] IS NULL
END
