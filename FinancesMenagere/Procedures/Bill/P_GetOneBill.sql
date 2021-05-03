CREATE PROCEDURE [dbo].[P_GetOneBill]
	@IdBill int
AS
BEGIN
	SELECT * FROM V_Bill WHERE IdBill = @IdBill
END
