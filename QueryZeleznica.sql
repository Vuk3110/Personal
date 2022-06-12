create database ZELEZNICA
USE ZELEZNICA
create table Putnik (
JMBG varchar(13) primary key identity(1,1) not null,
ImePrezime nvarchar(40) not null,
Email nvarchar(40) not null
)
create table Kondukter (
IDKonduktera int primary key identity(1,1) not null,
ImePrezime nvarchar(40) not null,
BrojVoza int foreign key references Voz(IDVoza))

create table Voz (
IDVoza int primary key identity(1,1) not null,
Model nvarchar(30) not null,
BrojSedista int not null)

create table Stanica (
IDStanice int primary key  identity(1,1) not null,
PTT int foreign key references Mesto(PTT))
alter table Stanica
drop constraint PTT

create table Mesto (
PTT int primary key identity(1,1) not null,
Naziv nvarchar(30) not null
)

create table Karta (
BrojKarte int primary key identity(1,1) not null,
CenaKarte int not null,
IDVoza int foreign key references Voz(IDVoza),
IDPutnika varchar(13) foreign key references Putnik(JMBG),
MestoPolaska int foreign key references Mesto(PTT),
MestoDolaska int foreign key references Mesto(PTT),
VremePolaska date not null
)

create table Korisnik (
IDKorisnika int primary key identity(1,1) not null,
KorisnickoIme nvarchar(40) not null,
Lozinka nvarchar(40) not null,
IDPutnika varchar(13) foreign key references Putnik(JMBG), )

