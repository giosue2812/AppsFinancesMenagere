CREATE VIEW [dbo].[V_AccountByMandatary]
	AS SELECT A.IdAccount, A.IdMandatary,A.Account,A.Balance,A.Note FROM Account A
	JOIN [User] U
	ON U.IdUser = A.IdMandatary
