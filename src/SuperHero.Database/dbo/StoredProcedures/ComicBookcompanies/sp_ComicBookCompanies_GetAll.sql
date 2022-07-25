CREATE PROCEDURE [dbo].[sp_ComicBookCompanies_GetAll]
AS
BEGIN
    SET NOCOUNT ON

    SELECT  [Id],
            [Name],
            [Description],
            [Founded],
            [WikiPage]
    FROM    [dbo].[ComicBookCompanies] (NOLOCK)
    WHERE   [DateDeletedUtc] IS NULL
END
