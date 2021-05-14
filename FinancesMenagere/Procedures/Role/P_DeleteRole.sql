CREATE PROCEDURE [dbo].[P_DeleteRole]
	@IdRole int
AS
BEGIN
	IF((SELECT IdRole FROM V_Role WHERE IdRole = @IdRole)IS NULL)RETURN NULL
	DELETE [Role] WHERE IdRole = @IdRole
END