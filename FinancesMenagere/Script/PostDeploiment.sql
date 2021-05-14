/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
EXEC P_AddRole 'Default';
EXEC P_AddRole 'Tresorie';
EXEC P_AddRole 'Course';
EXEC P_AddSensibleData 'Rue des peuplier','1485','Belgique',10,'Louvain';
EXEC P_AddSensibleData 'Rue des chanson','1455','Belgique',20,'Bruxelle'
EXEC P_AddSensibleData 'Rue des garçons','1457','Belgique',30,'Namur';
EXEC P_AddOrganization 'Voo','Communication','023554565',null,'voo@voo.be','Chantal',1;
EXEC P_AddOrganization 'Brico','Magasin','025543654',null,null,null,2;
EXEC P_AddOrganization 'Peugeot','Garage','025543654','0478565123','peugeot@p.be','Patrick',3;
EXEC P_AddBill 230.54,'2021-06-12','Facture pour le tel',1;
EXEC P_AddBill 250,'2021-07-20',null,2;
EXEC P_AddBill 301.99,'2021-06-25','Facture pour la voiture',3;