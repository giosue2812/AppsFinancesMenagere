CREATE TABLE [dbo].[Bill]
(
	IdBill INT NOT NULL IDENTITY (1,1),
	Balance DECIMAl NOT NULL,
	Deadline DATETIME2 NOT NULL,
	Postponement DATETIME2 NULL,
	PaymentDate DATETIME2 NULL,
	NOTE NVARCHAR(1000) NULL,
	IdOrganization INT NOT NULL
	CONSTRAINT PK_Bill PRIMARY KEY (IdBill),
	CONSTRAINT FK_Bill_Organization FOREIGN KEY (IdOrganization) REFERENCES Organization(IdOrganization)
)
