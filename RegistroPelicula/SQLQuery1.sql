create database Pelicula
use Pelicula

create table Pelicula(
PeliculaId int identity(1,1) primary key,
Titulo varchar(40) not null,
Descripcion varchar(100),
Ano int not null,
Calificacion int,
IMBD int ,
CategoriaId int,
Foto varchar(200),
Video varchar(200)

)
Create table Generos(
GeneroId int identity(1,1) primary key,
Descripcion  varchar(60)
)

create table Estudios(
EstudioId int identity(1,1),
NombreEstudio varchar(100)
)

create table Actores(
ActorId int identity(1,1) primary key,
Nombre varchar(150)
)