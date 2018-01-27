CREATE PROCEDURE [dbo].[GetRandomMessages]
	@TemplateId VARCHAR(20),
	@Level INT
AS
BEGIN

    --DECLARE @Messages TABLE (
	--	[Text] VARCHAR(100) NOT NULL
	--);

	SELECT TOP 5 [MessageId], [Text] 
	--INTO @Messages
	FROM [dbo].[Messages]
	WHERE [TemplateId] = @TemplateId
	--AND (ABS(CAST((BINARY_CHECKSUM(*) * RAND()) AS INT)) % 100) < 10
	ORDER BY (ABS(CAST((BINARY_CHECKSUM(*) * RAND()) AS INT)) % 100)
	;

	--TODO: Randomly distort the messages

END
