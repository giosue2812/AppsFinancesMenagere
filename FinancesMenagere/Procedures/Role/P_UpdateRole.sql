CREATE PROCEDURE [dbo].[P_UpdateRole]
	@IdRole int,
	@RLabel NVARCHAR(50)
AS
BEGIN
	IF((SELECT IdRole FROM V_Role WHERE IdRole = @IdRole)IS NULL) RETURN NULL
	UPDATE [Role] SET RLabel = @RLabel WHERE IdRole = @IdRole
	SELECT * FROM V_Role WHERE IdRole = @IdRole
END