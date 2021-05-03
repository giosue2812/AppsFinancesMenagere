CREATE PROCEDURE [dbo].[P_AddBill]
	@Balance DECIMAL(5,2),
	@Deadline Date,
	@Note NVARCHAR(1000)
AS
BEGIN
	INSERT INTO Bill (Balance,Deadline,NOTE) OUTPUT inserted.IdBill VALUES(@Balance,@Deadline,@Note) 
END