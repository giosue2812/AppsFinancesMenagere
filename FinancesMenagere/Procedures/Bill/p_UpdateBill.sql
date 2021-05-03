CREATE PROCEDURE [dbo].[P_UpdateBill]
	@IdBill int,
	@Balance DECIMAL(5,2),
	@Deadline Date,
	@Note nvarchar(1000)
AS
BEGIN
	SET NOCOUNT OFF;
	IF((SELECT IdBill FROM V_Bill WHERE IdBill = @IdBill) IS NULL) RETURN NULL
	UPDATE Bill SET 
		Balance = @Balance,
		Deadline = @Deadline,
		NOTE = @Note
		WHERE
			IdBill = @IdBill
		SELECT * FROM V_Bill WHERE IdBill = @IdBill
END