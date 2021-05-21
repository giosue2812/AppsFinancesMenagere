CREATE PROCEDURE [dbo].[P_GetOnePersonalExpense]
	@IdUser int
AS
BEGIN
	SELECT * FROM V_PersonalExpense WHERE IdUser = @IdUser
END