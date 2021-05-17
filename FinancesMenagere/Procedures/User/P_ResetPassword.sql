CREATE PROCEDURE [dbo].[P_ResetPassword]
	@IdUser INT,
	@Email NVARCHAR(100),
	@UPassword NVARCHAR(100)
AS
BEGIN
	IF((SELECT IdUser FROM V_User WHERE IdUser = @IdUser AND Email = @Email ) IS NULL) RETURN NULL
	DECLARE @Salt NVARCHAR(100)
	SET @Salt = (SELECT Salt FROM [User] WHERE IdUser = @IdUser)
	DECLARE @Password_Hash NVARCHAR(100)
	UPDATE [User] SET
		UPassword = HASHBYTES('SHA2_512',CONCAT(@Salt,@UPassword))
		WHERE IdUser = @IdUser
END