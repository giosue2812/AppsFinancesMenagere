CREATE PROCEDURE [dbo].[P_DeleteBill]
	@IdBill int
AS
BEGIN
	IF((SELECT IdBill FROM V_Bill WHERE IdBill = @IdBill) IS NULL)RETURN NULL
	DELETE Bill WHERE IdBill = @IdBill
END