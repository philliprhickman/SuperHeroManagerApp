CREATE PROCEDURE [dbo].[sp_SuperHeroes_GetById]
    @Id INT
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
    WHERE   [Id] = @Id
END
