CREATE PROCEDURE [dbo].[InsertMessage]
	@TemplateId VARCHAR(20),
	@Level INT,
	@Text VARCHAR(100)
AS
BEGIN

	IF NOT EXISTS(SELECT 1 FROM [dbo].[Messages] WHERE [Text] = @Text)
	BEGIN
		INSERT [dbo].[Messages] (
			[MessageId],
			[TimestampUtc],
			[TemplateId],
			[Text]
		) VALUES (
			NEWID(),
			GETUTCDATE(),
			@TemplateId,
			@Text
		)
	END

END
