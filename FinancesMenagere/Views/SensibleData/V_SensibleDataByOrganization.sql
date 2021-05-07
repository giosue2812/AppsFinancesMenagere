CREATE VIEW [dbo].[V_SensibleDataByOrganization]
	AS SELECT O.IdOrganization,S.IdSensible, S.AddCountry,S.AddNumber,S.AddPostalCode,S.AddStreet FROM SensibleData S
	JOIN Organization O
	ON O.IdSensibleData = S.IdSensible
