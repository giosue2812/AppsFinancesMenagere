CREATE PROCEDURE [dbo].[P_GetOneSensibleDataByOrganization]
	@IdOrganization int
AS
BEGIN
	SELECT * FROM V_SensibleDataByOrganization WHERE IdOrganization = @IdOrganization
END