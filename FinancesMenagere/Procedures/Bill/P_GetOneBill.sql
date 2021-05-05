CREATE PROCEDURE [dbo].[P_GetOneBill]
	@IdBill int
AS
BEGIN
	SELECT * FROM V_BillWithOrganization WHERE IdBill = @IdBill
END
