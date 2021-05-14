CREATE PROCEDURE [dbo].[P_GetOneRole]
	@IdRole int
AS
BEGIN
	SELECT * FROM V_Role WHERE IdRole = @IdRole
END