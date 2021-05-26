CREATE PROCEDURE [dbo].[P_UpdateUser]
	@IdUser INT,
	@FirstName NVARCHAR(100),
	@LastName NVARCHAR(100),
	@Email NVARCHAR(100),
	@Tel NVARCHAR(100),
	@BirthDate Date,
	@IdSensibleData INT
AS
BEGIN
	UPDATE [User] SET
		FirstName = @FirstName,
		LastName = @LastName,
		Email = @Email,
		Tel = @Tel,
		BirthDate = @BirthDate,
		IdSensibleData = @IdSensibleData 
			WHERE IdUser = @IdUser

		SELECT * FROM V_User WHERE IdUser = @IdUser
END
