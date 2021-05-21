CREATE PROCEDURE [dbo].[P_LoginUser]
	@Email NVARCHAR(100),
	@Password NVARCHAR(100)
AS
BEGIN
	DECLARE @Salt NVARCHAR(100)
	SELECT @Salt = Salt FROM [User] WHERE Email LIKE @Email
	IF @Salt IS NULL RETURN NULL
	ELSE
		BEGIN
			DECLARE @Password_Hash NVARCHAR(100)
			SET @Password_Hash = HASHBYTES('SHA2_512',CONCAT(@Salt,@Password,@Salt));
			DECLARE @IdUser INT
			SELECT @IdUser = IdUser FROM [User] WHERE Email LIKE @Email AND UPassword = @Password_Hash

			SELECT * FROM V_User WHERE IdUser = @IdUser
		END
END