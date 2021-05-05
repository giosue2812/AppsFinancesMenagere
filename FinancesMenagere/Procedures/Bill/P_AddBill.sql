CREATE PROCEDURE [dbo].[P_AddBill]
	@Balance DECIMAL(20,2),
	@Deadline Date,
	@Note NVARCHAR(1000),
	@IdOrganization INT
AS
BEGIN
	INSERT INTO Bill (Balance,Deadline,NOTE,IdOrganization) OUTPUT inserted.IdBill VALUES(@Balance,@Deadline,@Note,@IdOrganization) 
END