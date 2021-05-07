CREATE PROCEDURE [dbo].[P_AddSensibleData]
	@AddStreet NVARCHAR(100),
	@AddPostalCode NVARCHAR(100),
	@AddCountry NVARCHAR(100),
	@AddNumber NVARCHAR(100)
AS
BEGIN
	INSERT INTO SensibleData (AddStreet,AddPostalCode,AddCountry,AddNumber) output inserted.IdSensible
		VALUES(@AddStreet,@AddPostalCode,@AddCountry,@AddNumber)
END