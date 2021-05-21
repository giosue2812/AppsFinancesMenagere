CREATE PROCEDURE [dbo].[P_SwitchActive]
	@IdAccount int
AS
BEGIN
	IF((SELECT IdAccount FROM V_Account WHERE IdAccount = @IdAccount)IS NULL)RETURN NULL
	UPDATE Account 
		SET
			IsActive = (SELECT ~ IsActive FROM Account WHERE IdAccount = @IdAccount) 
		WHERE IdAccount = @IdAccount
END