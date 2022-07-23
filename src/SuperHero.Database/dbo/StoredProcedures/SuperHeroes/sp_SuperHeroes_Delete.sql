CREATE PROCEDURE [dbo].[sp_SuperHeroes_Delete]
    @Id  INT
AS
BEGIN
    SET NOCOUNT ON

    UPDATE  dbo.SuperHeroes
    SET     DateDeletedUtc  = GETUTCDATE()
    WHERE   Id              = @Id
END
