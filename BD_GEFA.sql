CREATE DATABASE PFF_GEFA_TDI if Not EXISTS
use PFF_GEFA_TDI

create TABLE Login(id int primary key identity(1,1),Nom varchar(30),Password varchar(20))

insert into Login(Nom,Password) values('RIDA','admin1')
insert into Login(Nom,Password) values('SOUKAINA','admin2')
insert into Login(Nom,Password) values('HAMZA','admin3')
insert into Login(Nom,Password) values('ZINAB','admin4')
insert into Login(Nom,Password) values('Admin','admin')                                                                                   
