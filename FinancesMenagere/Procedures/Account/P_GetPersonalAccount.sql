CREATE PROCEDURE [dbo].[P_GetPersonalAccount]
	@IdUser int
AS
BEGIN
	SELECT IdAccount FROM V_Account WHERE IdTitular = @IdUser AND IsAccountFamily = 0 
END