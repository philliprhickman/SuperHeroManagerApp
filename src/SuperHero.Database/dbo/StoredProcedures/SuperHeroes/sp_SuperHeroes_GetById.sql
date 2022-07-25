CREATE PROCEDURE [dbo].[sp_SuperHeroes_GetById]
    @Id INT
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
    WHERE   [Id] = @Id
END
