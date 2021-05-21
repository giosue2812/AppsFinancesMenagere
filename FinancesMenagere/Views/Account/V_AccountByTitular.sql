CREATE VIEW [dbo].[V_AccountByTitular]
	AS SELECT A.IdTitular,A.IdAccount,A.Account,A.Balance,A.Note FROM Account A
	JOIN [User] U
	ON U.IdUser = A.IdTitular
