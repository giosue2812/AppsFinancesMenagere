CREATE PROCEDURE [dbo].[P_GetOneAccount]
	@IdAccount int
AS
BEGIN
	SELECT * FROM V_Account WHERE IdAccount = @IdAccount
END