CREATE TABLE [dbo].[Bill]
(
	IdBill INT NOT NULL IDENTITY (1,1),
	Balance DECIMAL(5,2) NOT NULL,
	Deadline Date NOT NULL,
	Postponement Date NULL,
	PaymentDate Date NULL,
	NOTE NVARCHAR(1000) NULL,
	IdOrganization INT NULL
	CONSTRAINT PK_Bill PRIMARY KEY (IdBill),
	CONSTRAINT FK_Bill_Organization FOREIGN KEY (IdOrganization) REFERENCES Organization(IdOrganization)
)
