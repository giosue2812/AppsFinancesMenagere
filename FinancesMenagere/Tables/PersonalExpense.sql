CREATE TABLE [dbo].[PersonalExpense]
(
	IdExpense INT NOT NULL IDENTITY (1,1),
	ELabel NVARCHAR(100) NOT NULL,
	Balance DECIMAL(5,2) NOT NULL,
	DateExpense Date NOT NULL,
	IdUser INT NOT NULL,
	CONSTRAINT PK_PersonalExpense PRIMARY KEY (IdExpense),
	CONSTRAINT FK_PersonalExpense_User FOREIGN KEY (IdUser) REFERENCES [User](IdUser)
)
