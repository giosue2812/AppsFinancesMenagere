CREATE PROCEDURE [dbo].[P_GetOneSensibleDataByOrganization]
	@IdSensible int
AS
BEGIN
	SELECT * FROM V_SensibleDataByOrganization WHERE IdSensible = @IdSensible
END