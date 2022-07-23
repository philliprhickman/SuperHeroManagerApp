CREATE PROCEDURE [dbo].[sp_SuperHeroes_GetAll]
AS
BEGIN
    SET NOCOUNT ON

    SELECT  [Id],
            [Name],
            [Alias],
            [Location],
            [Notes],
            [ComicBookCreator]
    FROM    [dbo].[SuperHeroes] (NOLOCK)
    WHERE   [DateDeletedUtc] IS NULL
END
