CREATE PROCEDURE [dbo].[P_GetOneSensibleData]
	@IdSensibleData int
AS
	SELECT * FROM SensibleData WHERE IdSensible = @IdSensibleData
