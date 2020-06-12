CREATE DATABASE PFF_GEFA_TDI
use PFF_GEFA_TDI


#------------------------------------------------------------
# Table: Enseignent
#------------------------------------------------------------
CREATE TABLE Enseignent(
	ID_ensg      INT  NOT NULL ,
	Nom_ensg     VARCHAR (30)  ,
	Prenom       VARCHAR (30)  ,
	Tel          VARCHAR (10)  ,
	Email_ensg   VARCHAR (80)   ,
	CONSTRAINT Enseignent_PK PRIMARY KEY (ID_ensg)
)

insert into Enseignent values(1,'LAMOURI','Najib','0661497230','lamourinajib@gmail.com')
			     ,(2,'ALAMI','Said','0654123548','alamisaid@gmail.com')
			     ,(3,'MASAOUDI','Soufiane','0620156473','masaoudisoufiane@gmail.com')
			     ,(4,'AHMADI','Younes','0666120279','ahmadiyounes@gmail.com')	

----------------------------------------------------------------------------------------------------
create proc ListEnseignent
as
select ID_ensg as 'Identifiant',
	Nom_ensg as 'Nom',
	Prenom as 'Prénom',
	Tel as Téléphone,
	Email_ensg as 'Adresse Eléctronique' from Enseignent
----------------------------------------------------------------------------------------------
CREATE PROC Ajouter_Ensg
		@id int,
		@nom varchar(30),
		@prenom varchar(30),
		@tel varchar(10),
		@email varchar(80)
	as

INSERT INTO [PFF_GEFA_TDI].[dbo].[Enseignent]
           ([ID_ensg]
           ,[Nom_ensg]
           ,[Prenom]
           ,[Tel]
           ,[Email_ensg])
     VALUES
           (@id
           ,@nom
           ,@prenom
           ,@tel
           ,@email)
GO

------------------------------------------------------------------------------------------------------------------------------------
CREATE PROC VerifierID
@id int
as
select * from Enseignent where ID_ensg=@id
------------------------------------------------------------------------------------------
CREATE PROC RechercherEnseignent
@ID varchar(80)
as
SELECT * FROM Enseignent 
WHERE Convert(varchar,ID_ensg)+
	  Nom_ensg+
	  Prenom+
	  Tel+
	  Email_ensg LIKE '%'+@ID+'%' 
-------------------------------------------------------------------------------------------------
CREATE PROC ModifierEnseignent
		@id int,
		@nom varchar(30),
		@prenom varchar(30),
		@tel varchar(10),
		@email varchar(80)
as
UPDATE Enseignent SET
            [Nom_ensg]=@nom
           ,[Prenom]=@prenom
           ,[Tel]=@tel
           ,[Email_ensg]=@email
           WHERE ID_ensg=@id
-----------------------------------------------------------------------------------------

Create PROC SupprimerEnseignent
@ID int
as
DELETE Enseignent WHERE ID_ensg=@ID
GO
----------------------------------------------------------------------------------------

#------------------------------------------------------------
# Table: Filière
#------------------------------------------------------------
CREATE TABLE Filiere(
	ID_Filiere   INT IDENTITY(1,1) NOT NULL ,
	Filiere      VARCHAR (80)  ,
	Cours        VARCHAR (80)  ,
	CONSTRAINT Filiere_PK PRIMARY KEY (ID_Filiere))

insert into Filiere(Filiere,Cours) values('Techniques de Développement Informatique','Cours de Jour')
						   ,('Techniques de Développement Informatique','Cours de Soir')
						   ,('Techniques de Réseau Informatique','Cours de Jour')
						   ,('Techniques de Réseau Informatique','Cours de Soir')			  
select * from Filiere
--------------------------------------------------------------------------------------------------------------
#------------------------------------------------------------
# Table: Groupe
#------------------------------------------------------------

CREATE TABLE Groupe(
	ID_Groupe    INT  NOT NULL ,
	Groupe       VARCHAR (10)  ,
	ID_Filiere   INT  NOT NULL ,
	Effectife    INT  NOT NULL ,
	Niveau		 VARCHAR(11)    ,
	CONSTRAINT Groupe_PK PRIMARY KEY (ID_Groupe)

	,CONSTRAINT Groupe_Filiere_FK FOREIGN KEY (ID_Filiere) REFERENCES Filiere(ID_Filiere) ON DELETE CASCADE ON UPDATE CASCADE
);
 DROP TABLE GROUPE
 select * from Groupe

Insert into Groupe values(1,'TDI A',5,30,'1er Année'),(2,'TDI B',5,28,'1er Année'),(3,'TDI C',5,30,'1er Année')
						,(4,'TDI A',5,28,'2ème Année'),(5,'TDI B',5,29,'2ème Année'),(6,'TDI C',5,27,'2ème Année')
						,(7,'TRI A',7,30,'1er Année'),(8,'TRI B',7,28,'1er Année'),(9,'TRI C',7,29,'1er Année')
						,(10,'TRI A',7,29,'2ème Année'),(11,'TRI B',7,30,'2ème Année'),(12,'TRI C',7,30,'2ème Année')
						,(13,'TMSIR A',9,29,'1er Année'),(14,'TMSIR B',9,28,'1er Année'),(15,'TMSIR C',9,30,'1er Année')
						,(16,'TMSIR A',9,30,'2ème Année'),(17,'TMSIR B',9,30,'2ème Année'),(19,'TMSIR C',9,27,'2ème Année')
-----------------------------------------------------------------------------------
Create proc ListeGroupe
as
select G.ID_Groupe as 'Idantifiant',
	   G.Groupe ,
	   F.Filiere as 'Filière',
	   F.Cours as 'Type de Cours',
	   G.Effectife,
	   G.Niveau
	   from Groupe G inner join Filiere F
	   ON F.ID_Filiere=G.ID_Filiere

----------------------------------------------------------------------------------
CREATE PROC Ajouter_Groupe
@ID int, @Groupe varchar(10),@Filiere int, @Effectife int, @Niveau varchar(11)
as
Insert into Groupe values(@ID,@Groupe,@Filiere,@Effectife,@Niveau)
-----------------------------------------------------------------------------------
Create PROC SupprimerGroupe
@id VARCHAR(10)
as
DELETE Groupe WHERE ID_Groupe=@id;
------------------------------------------------------------------------------------
CREATE PROC ModifierGroupe
@ID int, @Groupe varchar(10),@Filiere int, @Effectife int, @Niveau varchar(11)
as
UPDATE Groupe set Groupe=@Groupe, ID_Filiere=@Filiere, Effectife=@Effectife, Niveau=@Niveau where ID_Groupe=@ID
-----------------------------------------------------------------------------------
CREATE PROC RechercherGroupe
@ID varchar(80)
as
select G.ID_Groupe as 'Idantifiant',
	   G.Groupe ,
	   F.Filiere as 'Filière',
	   G.Effectife,
	   G.Niveau
	   from Groupe G inner join Filiere F
	   ON F.ID_Filiere=G.ID_Filiere
WHERE Convert(Varchar,G.ID_Groupe)+
	  G.Groupe+
	  F.Filiere+
	  Convert(varchar,G.Effectife)+
	  G.Niveau LIKE '%'+@ID+'%' 
-------------------------------------------------------------------------------------	  
CREATE PROC VerifierIDGroupe
@id int
as
select * from Groupe where ID_Groupe=@id
-------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------





                                                                                  
