CREATE PROCEDURE [dbo].[sp_ComicBookCompanies_GetById]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON

    SELECT  [Id],
            [Name],
            [Description],
            [Founded],
            [WikiPage]
    FROM    [dbo].[ComicBookCompanies] (NOLOCK)
    WHERE   [Id] = @Id
END
