

use master;
go

drop database if exists gimnastika;
go

create database gimnastika collate Croatian_CI_AS;
go

use gimnastika;
go

create table klubovi(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
adresa varchar(100) not null,
IBAN varchar(50) not null
);

create table vjezbaci(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(40) not null,
datumrodenja datetime not null,
spol varchar(20) not null,
kategorija varchar(50) not null,
email varchar(100) not null,
klub varchar(100) not null references klubovi(sifra)
);

create table treneri(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(40) not null,
oib char(11) null,
email varchar(100) not null,
klub varchar(100) not null references klubovi(sifra)
);

create table suci(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(40) not null,
oib char(11) null,
email varchar(100) not null,
kategorija_suca varchar(50) not null,
klub varchar(100) not null references klubovi(sifra)
);

create table natjecanja(
sifra int not null primary key identity(1,1),
grad varchar(40) not null,
adresa varchar(100) not null,
datum datetime not null,
iznoskotizacije int not null
);

create table klub_natjecanja(
klub int not null references klubovi(sifra),
natjecanje int not null references natjecanja(sifra)
);

select * from klubovi;

insert into klubovi
(naziv,adresa,IBAN) values
('Gd Osijek-žito','Kralja Zvonimira 5 Osijek','HR134761872638934762536');

insert into klubovi(naziv,adresa,IBAN) values
--2
('ZTD Hrvatski sokol Zagreb','Trg Republike Hrvatske 6 Zagreb','HR986473829487376263'),
--3
('Gimnastičko Društvo "Hrvatski Sokol" Valpovo','Dr. F. Tuđmana 2 Valpovo','HR1836274958374653529');

select * from vjezbaci;

insert into vjezbaci
(ime,prezime,datumrodenja,spol,kategorija,klub) values
('Ana','Anić','2015-08-13','žensko','kadetkinje','Gd Osijek-žito');


insert into vjezbaci(ime,prezime,datumrodenja,spol,kategorija,klub) values
--2
('Maria','Hes','2013-04-22','žensko','juniorke','ZTD Hrvatski sokol Zagreb'),
--3
('Ivan','Marković','2016-08-09','muško','kadet','Gimnastičko Društvo "Hrvatski Sokol" Valpovo'),
--4
('Marko','Ivić','2016-07-17','muško','kadet','Gd Osijek-žito');

select * from treneri;

insert into treneri
(ime,prezime,email,klub) values
('Boris','Bukovec','botaosijek@gmail.com','Gimnastičko Društvo "Hrvatski Sokol" Valpovo');

insert into treneri(ime,prezime,email,klub) values
--2
('Filip','Rosandić','filiprosandic@gmail.com','ZTD Hrvatski sokol Zagreb'),
--3
('Marko','Simon','markosimon@gmail.com','Gd Osijek-žito');

select * from suci;

insert into suci
(ime,prezime,oib,kategorija_suca,klub) values
('Marin','Marinić',52738294738,'nacionalni sudac','Gimnastičko Društvo "Hrvatski Sokol" Valpovo');

insert into suci(ime,prezime,oib,kategorija_suca,klub) values
--2
('Žana','Bilić','regionalni sudac','ZTD Hrvatski sokol Zagreb'),
--3
('Vladimir','Jukić','nacionalni sudac','Gd Osijek-žito');

select * from natjecanja;

insert into natjecanja
(grad,adresa,datum,iznoskotizacije) values
('Osijek','Ul. Kneza Trpimira 23','2024-12-22 09:00:00',50);
