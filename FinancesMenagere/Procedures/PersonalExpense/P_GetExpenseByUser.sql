CREATE PROCEDURE [dbo].[P_GetExpenseByUser]
	@IdUser int
AS
BEGIN
	SELECT * FROM V_PersonalExpense WHERE IdUser = @IdUser
END