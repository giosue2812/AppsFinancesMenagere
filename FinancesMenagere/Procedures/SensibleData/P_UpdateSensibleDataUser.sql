CREATE PROCEDURE [dbo].[P_UpdateSensibleDataUser]
	@IdSensible int,
	@AddStreet NVARCHAR(100),
	@AddPostalCode NVARCHAR(100),
	@AddCountry NVARCHAR(100),
	@AddNumber NVARCHAR(100),
	@AddCity NVARCHAR(100)
AS
BEGIN
	IF((SELECT IdSensible FROM SensibleData WHERE IdSensible = @IdSensible)IS NULL)RETURN NULL
	UPDATE SensibleData SET 
		AddStreet = @AddStreet,
		AddPostalCode = @AddPostalCode,
		AddCountry = @AddCountry,
		AddNumber = @AddNumber,
		AddCity = @AddCity
	WHERE IdSensible = @IdSensible
	SELECT * FROM V_SensibleData WHERE IdSensible = @IdSensible
END