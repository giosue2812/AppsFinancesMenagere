CREATE PROCEDURE [dbo].[P_AddPersonalExpense]
	@IdAccount int,
	@Elabel NVARCHAR(100),
	@Balance DECIMAL(20,2),
	@DateExpense Date,
	@IdUser INT
AS
BEGIN
	IF((SELECT IdUser FROM [V_User] WHERE IdUser = @IdUser) IS NULL) RETURN NULL
	IF((SELECT IdTitular FROM V_AccountByTitular WHERE IdTitular = @IdUser AND IdAccount = @IdAccount AND Balance > @Balance) IS NULL)
	IF((SELECT IdMandatary FROM V_AccountByMandatary WHERE IdMandatary = @IdUser AND IdAccount = @IdAccount AND Balance > @Balance) IS NULL)
	RETURN NULL
	UPDATE Account SET Balance = (Balance - @Balance) WHERE IdAccount = @IdAccount;
	INSERT INTO PersonalExpense (ELabel,Balance,DateExpense,IdUser) output inserted.IdExpense 
	VALUES (@Elabel,@Balance,@DateExpense,@IdUser)
END