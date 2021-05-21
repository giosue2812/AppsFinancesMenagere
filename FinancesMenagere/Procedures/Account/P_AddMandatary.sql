CREATE PROCEDURE [dbo].[P_AddMandatary]
	@IdAccount int,
	@IdMandatary int
AS
BEGIN
	UPDATE Account SET IdMandatary = @IdMandatary WHERE IdAccount = @IdAccount
	SELECT * FROM V_Account WHERE IdAccount = @IdAccount
END