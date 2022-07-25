CREATE PROCEDURE [dbo].[sp_ComicBookCompanies_Delete]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON

    UPDATE  [dbo].[ComicBookCompanies]
    SET     [DateDeletedUtc] = GETUTCDATE()
    WHERE   [Id] = @Id
END
