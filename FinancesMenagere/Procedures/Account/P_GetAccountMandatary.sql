CREATE PROCEDURE [dbo].[P_GetAccountMandatary]
	@IdMandatary int
AS
BEGIN
	SELECT * FROM V_AccountByMandatary WHERE IdMandatary = @IdMandatary
END
