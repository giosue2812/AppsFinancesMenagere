CREATE TABLE [dbo].[Organization]
(
	IdOrganization INT NOT NULL IDENTITY (1,1),
	OrName NVARCHAR(50) NOT NULL,
	Organization NVARCHAR(50) NOT NULL,
	IsActive BIT NOT NULL DEFAULT 1,
	Tel1 NVARCHAR(50) NULL,
	Tel2 NVARCHAR(50) NULL,
	Email NVARCHAR(50) NULL,
	NameContact NVARCHAR(50) NULL,
	IdSensibleData INT NULL
	CONSTRAINT PK_Organization PRIMARY KEY (IdOrganization),
	CONSTRAINT FK_Organization_SensibleData FOREIGN KEY (IdSensibleData) REFERENCES SensibleData(IdSensible)
)
