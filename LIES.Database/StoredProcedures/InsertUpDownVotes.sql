CREATE PROCEDURE [dbo].[InsertUpDownVotes]
	@MessageId UNIQUEIDENTIFIER,
	@TemplateId VARCHAR(20),
	@Level INT,
	@UpVotes INT,
	@DownVotes INT
AS
BEGIN

	UPDATE [dbo].[Messages]
	SET 
		[UpVotes] = [UpVotes] + @UpVotes,
		[DownVotes] = [DownVotes] + @DownVotes
	WHERE [MessageId] = @MessageId
	AND [TemplateId] = @TemplateId

END
