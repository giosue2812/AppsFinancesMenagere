CREATE PROCEDURE [dbo].[P_AddUser]
	@FirstName NVARCHAR(100),
	@LastName NVARCHAR(100),
	@Email NVARCHAR(100),
	@Tel NVARCHAR(100),
	@BirthDate Date,
	@UPassword NVARCHAR(100),
	@IdSensibleData INT
AS
BEGIN
	DECLARE @Salt NVARCHAR(100);
	SET @Salt = NEWID()
	DECLARE @Password_Hash NVARCHAR(100)
	SET @Password_Hash = HASHBYTES('SHA2_512',CONCAT(@Salt,@UPassword,@Salt));
	INSERT INTO [User] (FirstName,LastName,Email,Tel,BirthDate,UPassword,IdSensibleData,Salt) OUTPUT inserted.IdUser
		VALUES(@FirstName,@LastName,@Email,@Tel,@BirthDate,@Password_Hash,@IdSensibleData,@Salt)

END