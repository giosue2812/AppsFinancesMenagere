CREATE PROCEDURE [dbo].[P_AddOrganization]
	@OrName NVARCHAR(50),
	@Organization NVARCHAR(50),
	@Tel1 NVARCHAR(50),
	@Tel2 NVARCHAR(50),
	@Email NVARCHAR(50),
	@NameContact NVARCHAR(50),
	@IdSensibleData int
AS
BEGIN
	INSERT INTO Organization (OrName,Organization,Tel1,Tel2,Email,NameContact,IdSensibleData) OUTPUT inserted.IdOrganization
		VALUES (@OrName,@Organization,@Tel1,@Tel2,@Email,@NameContact,@IdSensibleData)
END
