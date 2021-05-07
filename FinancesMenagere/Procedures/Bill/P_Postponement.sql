CREATE PROCEDURE [dbo].[P_Postponement]
	@IdBill int,
	@Date Date
AS
BEGIN
	IF((SELECT IdBill FROM Bill WHERE IdBill = @IdBill)IS NULL)RETURN NULL
	UPDATE Bill SET Postponement = @Date WHERE IdBill = @IdBill
END