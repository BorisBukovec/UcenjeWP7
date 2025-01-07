use master;
go
drop database if exists vjezbaispitnirok;
go
create database vjezbaispitnirok;
go
use vjezbaispitnirok;
go

create table IspitniRok(
sifra int not null primary key identity(1,1),
predmet varchar(50) not null,
vrstaIspita varchar(50) not null,
datum datetime null,
pristupio bit not null
);

create table Pristupnici(
ispitniRok int not null references IspitniRok(sifra),
studnet varchar(50) not null,
brojBodova int null,
ocjena int not null
);