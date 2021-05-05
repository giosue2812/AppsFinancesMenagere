CREATE PROCEDURE [dbo].[P_SwitchIsActiveOrganization]
	@IdOrganization int
AS
BEGIN
	IF((SELECT IdOrganization FROM Organization WHERE IdOrganization = @IdOrganization) IS NULL) RETURN NULL
	UPDATE Organization SET IsActive = (SELECT ~ IsActive FROM Organization WHERE IdOrganization = @IdOrganization) WHERE IdOrganization = @IdOrganization
END
	