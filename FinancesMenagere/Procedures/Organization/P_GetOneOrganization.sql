CREATE PROCEDURE [dbo].[P_GetOneOrganization]
	@IdOrganization int
AS
BEGIN
	SELECT * FROM V_Organization WHERE IdOrganization = @IdOrganization
END
