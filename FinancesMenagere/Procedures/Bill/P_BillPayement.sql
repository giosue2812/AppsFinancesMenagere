CREATE PROCEDURE [dbo].[P_BillPayement]
	@IdBill int
AS
BEGIN
	IF((SELECT IdBill FROM Bill WHERE IdBill = @IdBill) IS NULL)RETURN NULL
	UPDATE Bill SET PaymentDate = GETDATE() WHERE IdBill = @IdBill
	UPDATE Account SET Balance = Balance - (SELECT Balance FROM Bill WHERE IdBill = @IdBill) WHERE IsAccountFamily = 1
END