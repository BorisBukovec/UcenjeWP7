use edunovawp7;

select * from smjerovi;						

--1
insert into smjerovi
(naziv,trajanje,cijena,vaucer,izvodiseod) values
('Web programiranje',225,1245.99,1,'2024-09-07 17:00:00');

insert into smjerovi(naziv) values
--2
('Java programer'),
--3
('Serviser'),
--4
('Knjigovodstvo');

SELECT * FROM GRUPE;

insert into grupe(naziv,smjer) values
--1
('Wp6',1),
--2
('Wp7',1),
--3
('JP27',2),
--4
('k12',4);

SELECT * FROM POLAZNICI;

INSERT INTO polaznici (ime, prezime, email) VALUES 
--1-27
('Ante', 'Janković', 'antejankovic86@gmail.com'),
('Stojan', 'Carić', 'stojancaric8@gmail.com'),
('Željko', 'Lučan', 'lucko1987vk@gmail.com'),
('Petar', 'Gudelj', 'gudelj.petar2005@gmail.com'),
('Krunoslav', 'Popić', 'kpopic@gmail.com'),
('Jurica', 'Ognjenović', 'ognjenovicjurica0610@gmail.com'),
('Lea', 'Bartoš', 'talulea@gmail.com'),
('Tomislav', 'Nađ', 'tomislav.nadj@gmail.com'),
('Martin', 'Galik', 'gale1508@gmail.com'),
('Ivan', 'Mišić', 'ivanmisic983@gmail.com'),
('Mirjam', 'Koški', 'mir.jam975@gmail.com'),
('Željko', 'Koški', 'zeljko.koski@gmail.com'),
('Mirza', 'Delagić', 'mirzadelagic@gmail.com'),
('Bruno', 'Čačić', 'bruno.cacic@gmail.com'),
('David', 'Nađ', 'david08.nadj@gmail.com'),
('Antonio', 'Macanga', 'macanga.antonio@gmail.com'),
('Nina', 'Zrno', 'ninaradakovic1234@icloud.com'),
('Marko', 'Berberović', 'marko.berberovic@skole.hr'),
('Tomislav', 'Nebes', 'tomislav.nebes@gmail.com'),
('Klara', 'Nađ', 'klara.nad@gmail.com'),
('Maja', 'Šteler', 'maja5steler@gmail.com'),
('Milan', 'Drača', 'milan.draca@gmail.com'),
('Marin', 'Vranješ', 'marinvranjes123@gmail.com'),
('Boris', 'Bukovec', 'botaosijek@gmail.com'),
('Luka', 'Jurak', 'jurakluka18@gmail.com'),
('Ivan', 'Strmečki', 'ivan.strmecki8@gmail.com'),
('Bruno', 'Bašić', 'brunobasic031@gmail.com');

select * from clanovi;

insert into clanovi (grupa,polaznik) values
(2,1),(2,2),(2,3),(2,4),(2,5),(2,6),(2,7),
(2,8),(2,9),(2,10),(2,11),(2,12),(2,13),(2,14),
(2,15),(2,16),(2,17),(2,18),(2,19),(2,20),(2,21),
(2,22),(2,23),(2,24),(2,25),(2,26),(2,27),

(3,7),(3,17),(3,27);