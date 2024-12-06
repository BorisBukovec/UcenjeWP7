﻿﻿use master;
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
ziroracun int not null
);

create table vjezbaci(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(40) not null,
datumrodenja datetime not null,
spol varchar(20) not null,
kategorija varchar(50) not null,
email varchar(100) not null,
klub int not null references klubovi(sifra)
);

create table treneri(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(40) not null,
oib char(11) null,
email varchar(100) not null,
klub int not null references klubovi(sifra)
);

create table suci(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(40) not null,
oib char(11) null,
email varchar(100) not null,
kategorija_suca varchar(50) not null,
klub int not null references klubovi(sifra)
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
(naziv,adresa,ziroracun) values
('Gd Osijek-žito','Kralja Zvonimira 5 Osijek',HR4723400091110432103);

insert into klubovi(naziv) values
--2
('ZTD Hrvatski sokol Zagreb'),
--3
('Hrvatski sokol Valpovo');

