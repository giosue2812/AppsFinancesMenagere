CREATE PROCEDURE [dbo].[P_UpdateRoleUser]
	@IdUser int,
	@IdRole int
AS
BEGIN
	If((SELECT IdUser FROM V_User WHERE IdUser = @IdUser)IS NULL)RETURN NULL
	UPDATE [User] SET IdRole = @IdRole WHERE IdUser = @IdUser
END