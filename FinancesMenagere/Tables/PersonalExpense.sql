﻿CREATE TABLE [dbo].[PersonalExpense]
(
	IdExpense INT NOT NULL IDENTITY (1,1),
	ELabel NVARCHAR(100) NOT NULL,
	Balance DECIMAL NOT NULL,
	DateExpense DATETIME2 NOT NULL,
	IdUser INT NOT NULL,
	CONSTRAINT PK_PersonalExpense PRIMARY KEY (IdExpense),
	CONSTRAINT FK_PersonalExpense_User FOREIGN KEY (IdUser) REFERENCES [User](IdUser)
)
