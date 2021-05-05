CREATE VIEW [dbo].[V_Organization]
	AS SELECT IdOrganization,OrName,Organization,Tel1,Tel2,Email,NameContact FROM Organization WHERE IsActive = 1
