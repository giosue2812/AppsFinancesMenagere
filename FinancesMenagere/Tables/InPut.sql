CREATE TABLE [dbo].[InPut]
(
	IdInPut INT NOT NULL IDENTITY (1,1),
	InSource NVARCHAR(100) NOT NULL,
	Balance DECIMAL(5,2) NOT NULL,
	DateInPut Date NOT NULL,
	Note NVARCHAR(100) NULL,
	IdAccount INT NOT NULL,
	CONSTRAINT PK_InPut PRIMARY KEY (IdInPut),
	CONSTRAINT FK_InPut_Account FOREIGN KEY (IdAccount) REFERENCES Account(IdAccount)
)
