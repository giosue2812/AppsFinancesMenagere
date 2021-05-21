CREATE PROCEDURE [dbo].[P_AddAccount]
	@Account NVARCHAR(100),
	@Balance DECIMAL(20,2),
	@Note NVARCHAR(100),
	@IdTitular int,
	@IsAccountFamily BIT
AS
BEGIN
	INSERT INTO Account (Balance,CreationDate,Note,IdTitular,Account,IsAccountFamily) output inserted.IdAccount
	VALUES (@Balance,GETDATE(),@Note,@IdTitular,@Account,@IsAccountFamily)
END