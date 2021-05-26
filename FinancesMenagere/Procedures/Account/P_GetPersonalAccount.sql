CREATE PROCEDURE [dbo].[P_GetPersonalAccount]
	@IdUser int
AS
BEGIN
	--IF((SELECT IdAccount FROM V_Account WHERE IdTitular = @IdUser)IS NULL)
	--	BEGIN
	--		SELECT @IdAccount = 0
	--	END
	--ELSE
	--	BEGIN
	--		SELECT @IdAccount = IdAccount FROM V_Account WHERE IdTitular = @IdUser AND IsAccountFamily = 0 
	--	END
	SELECT IdAccount FROM V_Account WHERE IdTitular = @IdUser AND IsAccountFamily = 0 
END