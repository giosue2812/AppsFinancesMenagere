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
EXEC P_AddOrganization 'Voo','Communication','023554565',null,'voo@voo.be','Chantal';
EXEC P_AddOrganization 'Brico','Magasin','025543654',null,null,null;
EXEC P_AddOrganization 'Peugeot','Garage','025543654','0478565123','peugeot@p.be','Patrick';
EXEC P_AddBill 230.54,'2021-06-12','Facture pour le tel',1;
EXEC P_AddBill 250,'2021-07-20',null,2;
EXEC P_AddBill 301.99,'2021-06-25','Facture pour la voiture',3;