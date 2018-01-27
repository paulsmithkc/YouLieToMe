CREATE PROCEDURE [dbo].[InsertDeathes]
	@MessageId UNIQUEIDENTIFIER,
	@TemplateId VARCHAR(20),
	@Level INT,
	@Deaths INT
AS
BEGIN

	UPDATE [dbo].[Messages]
	SET [Deaths] = [Deaths] + @Deaths
	WHERE [MessageId] = @MessageId
	AND [TemplateId] = @TemplateId

END
