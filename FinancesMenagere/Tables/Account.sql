CREATE TABLE [dbo].[Account]
(
	IdAccount INT NOT NULL IDENTITY (1,1),
	Account NVARCHAR(100) NOT NULL,
	Balance DECIMAL(20,2) NOT NULL,
	CreationDate Date NOT NULL,
	Note NVARCHAR(100) Null,
	IdMandatary INT NULL,
	IdTitular INT NOT NULL,
	IsActive BIT NOT NULL DEFAULT 1,
	IsAccountFamily BIT NOT NULL,
	CONSTRAINT PK_Account PRIMARY KEY (IdAccount),
	CONSTRAINT FK_Account_Mandatary_User FOREIGN KEY (IdMandatary) REFERENCES [User] (IdUser),
	CONSTRAINT FK_Account_Titular_User FOREIGN KEY (IdTitular) REFERENCES [User] (IdUser)
)
