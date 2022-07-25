CREATE PROCEDURE [dbo].[sp_ComicBookCompanies_Update]
    @Id             INT,
    @Name           VARCHAR(255),
    @Description    TEXT,
    @Founded        DATETIME,
    @WikiPage       VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON

    UPDATE  [dbo].[ComicBookCompanies]
    SET     [Name]          = @Name,
            [Description]   = @Description,
            [Founded]       = @Founded,
            [WikiPage]      = @WikiPage
    WHERE   [Id]            = @Id
END