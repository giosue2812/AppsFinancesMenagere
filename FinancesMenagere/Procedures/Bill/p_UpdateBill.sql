CREATE PROCEDURE [dbo].[P_UpdateBill]
	@IdBill int,
	@Balance DECIMAL(20,2),
	@Deadline Date,
	@Note nvarchar(1000),
	@IdOrganization int
AS
BEGIN
	SET NOCOUNT OFF;
	IF((SELECT IdBill FROM V_Bill WHERE IdBill = @IdBill) IS NULL) RETURN NULL
	UPDATE Bill SET 
		Balance = @Balance,
		Deadline = @Deadline,
		NOTE = @Note,
		IdOrganization = @IdOrganization
		WHERE
			IdBill = @IdBill
		SELECT * FROM V_BillWithOrganization WHERE IdBill = @IdBill
END