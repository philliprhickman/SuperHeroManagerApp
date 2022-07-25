CREATE PROCEDURE [dbo].[sp_ComicBookCompanies_Insert]
    @Name           VARCHAR(255),
    @Description    TEXT,
    @Founded        DATETIME,
    @WikiPage       VARCHAR(255)
AS
BEGIN
    INSERT INTO [dbo].[ComicBookCompanies]
    (
        [Name],
        [Description],
        [Founded],
        [WikiPage]
    )
    OUTPUT INSERTED.Id, INSERTED.[Name], INSERTED.[Description], INSERTED.Founded, INSERTED.WikiPage
    VALUES
    (
        @Name,
        @Description,
        @Founded,
        @WikiPage
    )
END
