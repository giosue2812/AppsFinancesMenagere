CREATE PROCEDURE [dbo].[P_UpdateAccount]
	@IdAccount int,
	@Account NVARCHAR(100),
	@Balance DECIMAL(20,2),
	@Note NVARCHAR(100),
	@IdTitular int
AS
BEGIN
	IF((SELECT IdAccount FROM V_Account WHERE IdAccount = @IdAccount)IS NULL) RETURN NULL
	UPDATE Account 
		SET
			Account = @Account,
			Balance = @Balance,
			IdTitular = @IdTitular,
			Note = @Note
		WHERE IdAccount = @IdAccount
	SELECT * FROM V_Account WHERE IdAccount = @IdAccount
END