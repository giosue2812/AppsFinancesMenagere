CREATE PROCEDURE [dbo].[P_GetAccountTitular]
	@IdTitular int
AS
BEGIN
	SELECT * FROM V_AccountByTitular WHERE IdTitular = @IdTitular
END