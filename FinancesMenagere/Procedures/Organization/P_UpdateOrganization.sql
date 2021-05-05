CREATE PROCEDURE [dbo].[P_UpdateOrganization]
	@IdOrganization int,
	@OrName NVARCHAR(50),
	@Organization NVARCHAR(50),
	@Tel1 NVARCHAR(50),
	@Tel2 NVARCHAR(50),
	@Email NVARCHAR(50),
	@NameContact NVARCHAR(50)
AS
BEGIN
	IF((SELECT IdOrganization FROM Organization WHERE IdOrganization = @IdOrganization) IS NULL) RETURN NULL
	UPDATE Organization SET 
		OrName = @OrName,
		Organization = @Organization,
		Tel1 = @Tel2,
		Tel2 = @Tel2,
		Email = @Email,
		NameContact = @NameContact
	WHERE IdOrganization = @IdOrganization
	SELECT * FROM V_Organization WHERE IdOrganization = @IdOrganization
END
