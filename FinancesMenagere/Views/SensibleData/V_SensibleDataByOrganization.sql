CREATE VIEW [dbo].[V_SensibleDataByOrganization]
	AS SELECT O.IdOrganization,o.OrName,S.IdSensible, S.AddCountry,S.AddNumber,S.AddPostalCode,S.AddStreet,S.AddCity FROM SensibleData S
	JOIN Organization O
	ON O.IdSensibleData = S.IdSensible
