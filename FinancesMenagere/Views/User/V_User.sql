CREATE VIEW [dbo].[V_User]
	AS SELECT IdUser,BirthDate,FirstName,LastName,Email,Tel,IsActive,IdSensibleData,IdRole FROM [User] WHERE IsActive = 1;
