drop database ФитнесКлуб;
create database ФитнесКлуб;
use ФитнесКлуб;


create table Услуги
(IDУслуги int(5) unsigned  key,
НазваниеУслуги varchar(15),
ДлительностьЗанятия varchar(5),
ПродолжительностьЗанятия int,
ЦенаЗаЗанятие int);

create table Тренера
(IDТренера int(5) unsigned  key,
ФИО varchar(50), 
НомерТелефона varchar(13),
Стаж int,
Возраст int,
Пол varchar(7),
Адрес varchar(100));

create view ПредставлениеТренера as select
	ФИО, НомерТелефона, Стаж, Возраст, Пол, Адрес from Тренера;

create table Группы
(НомерГруппы int(5) unsigned key,
КоличествоЧеловек int,
МакКоличествоЧеловек int,
IDТренера int(5) unsigned,
IDУслуги int(5) unsigned,
foreign key O(IDУслуги) references Услуги(IDУслуги) on delete cascade,
foreign key O1(IDТренера) references Тренера(IDТренера) on delete cascade);

create view ПредставлениеГруппы as select
	(Группы.НомерГруппы) as №, Тренера.ФИО, Услуги.НазваниеУслуги, Группы.КоличествоЧеловек, Группы.МакКоличествоЧеловек from Группы
    inner join Тренера on Тренера.IDТренера = Группы.IDТренера
    inner join Услуги on Услуги.IDУслуги = Группы.IDУслуги;
    

create table Расписание
(IDРасписания int(5) unsigned  key,
Дата date,
ВремяНачала datetime,
Зал int,
НомерГруппы int(5) unsigned,
foreign key O2 (НомерГруппы) references Группы(НомерГруппы) on delete cascade);

create table Посетители
(IDПосетителя int(5) unsigned key,
ФИО varchar(50),
Возраст int,
Пол varchar(7),
НомерТелефона varchar(13));

create view ПредставлениеПосетители as select
	ФИО, Возраст, Пол, НомерТелефона from Посетители;

create table ЗаписьГруппы 
(НомерЗаписи int(5) unsigned key,
ДатаЗаписи date,
КоличествоОплаченыхЗанятий int,
НомерГруппы int(5) unsigned,
IDПосетителя int(5) unsigned,
foreign key (НомерГруппы) references Группы(НомерГруппы) on delete cascade,
foreign key (IDПосетителя) references Посетители(IDПосетителя) on delete cascade);

create view ПредставлениеЗаписьГруппы as select
	(ЗаписьГруппы.НомерЗаписи) as №, Посетители.ФИО, Услуги.НазваниеУслуги, ЗаписьГруппы.ДатаЗаписи, ЗаписьГруппы.КоличествоОплаченыхЗанятий
    from ЗаписьГруппы
    inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы
    inner join Услуги on Услуги.IDУслуги = Группы.IDУслуги
    inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя;
    
create table Посещения
(НомерПосещения int(5) unsigned key,
ДатаПосещения varchar(50),
НомерЗаписи int(5) unsigned,
foreign key (НомерЗаписи) references ЗаписьГруппы(НомерЗаписи) on delete cascade);

create view ПредставлениеПосещения as select
	(Посещения.НомерПосещения) as №, Посетители.ФИО, Услуги.НазваниеУслуги, Посещения.ДатаПосещения 
    from Посещения
    inner join ЗаписьГруппы on Посещения.НомерЗаписи = ЗаписьГруппы.НомерЗаписи
    inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы
    inner join Услуги on Услуги.IDУслуги = Группы.IDУслуги
    inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя;
    
    

