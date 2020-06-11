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
                                                                                  
