CREATE TABLE [dbo].[Account]
(
	IdAccount INT NOT NULL IDENTITY (1,1),
	Balance DECIMAL NOT NULL,
	CreationDate DATETIME2 NOT NULL,
	Note NVARCHAR(100) Null,
	IdMandatary INT NOT NULL,
	IdTitular INT NULL,
	CONSTRAINT PK_Account PRIMARY KEY (IdAccount),
	CONSTRAINT FK_Account_Mandatary_User FOREIGN KEY (IdMandatary) REFERENCES [User] (IdUser),
	CONSTRAINT FK_Account_Titular_User FOREIGN KEY (IdTitular) REFERENCES [User] (IdUser)
)
