use master;
go
drop database if exists vjezbaispitnirok;
go
create database vjezbaispitnirok;
go
use vjezbaispitnirok;
go

create table IspitniRok(
sifra int,
predmet varchar(50),
vrstaIspita varchar(50),
datum datetime,
pristupio bit
);

create table Pristupnici(
ispitniRok int,
studnet varchar(50),
brojBodova int,
ocjena int
);