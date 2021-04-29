CREATE TABLE [dbo].[Provision]
(
	IdProvision INT NOT NULL IDENTITY (1,1),
	Price DECIMAL NOT NULL,
	IdOrganization INT NOT NULL,
	IdOutPut INT NOT NULL,
	CONSTRAINT PK_Provision PRIMARY KEY (IdProvision),
	CONSTRAINT FK_Provision_Organization FOREIGN KEY (IdOrganization) REFERENCES Organization(IdOrganization),
	CONSTRAINT FK_Provision_OutPut FOREIGN KEY (IdOutPut) REFERENCES [OutPut](IdOutPut)
)
