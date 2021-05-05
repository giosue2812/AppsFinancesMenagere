CREATE VIEW [dbo].[V_BillWithOrganization]
	AS SELECT O.OrName,O.Organization,B.Balance,B.Deadline,B.NOTE,O.IdOrganization,B.IdBill FROM V_Bill B
	JOIN V_Organization O
	ON O.IdOrganization = B.IdOrganization
