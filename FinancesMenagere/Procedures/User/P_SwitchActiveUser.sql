CREATE PROCEDURE [dbo].[P_SwitchActiveUser]
	@IdUser INT
AS
BEGIN
	IF((SELECT IdUser FROM V_User WHERE IdUser = @IdUser)IS NULL) RETURN NULL
	UPDATE [User] SET
		IsActive = (SELECT ~IsActive FROM [User] WHERE IdUser = @IdUser)
END