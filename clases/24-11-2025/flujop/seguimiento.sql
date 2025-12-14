create table seguimiento
(
nrotramite int,
flujo varchar(3),
proceso varchar(3),
fechainicio datetime,
fechafinal datetime,
usuario varchar(25)
);

insert into seguimiento values(10,'F1','P2','2025/11/24  12:01:00','2025/11/26  12:01:00','msilva');
insert into seguimiento values(10,'F1','P1','2025/11/24  10:00:00','2025/11/26  12:00:00','msilva');
insert into seguimiento values(10,'F1','P2','2025/11/26  12:01:00',NULL,'kardex');
insert into seguimiento values(15,'F1','P1','2025/11/26  10:00:00','2025/11/26  12:00:00','jperez');
insert into seguimiento values(15,'F1','P2','2025/11/26  12:01:00',NULL,'jperez');

