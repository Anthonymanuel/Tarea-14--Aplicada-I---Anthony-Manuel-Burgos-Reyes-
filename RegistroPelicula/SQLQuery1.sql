Create Pelicula
use Pelicula

create table Pelicula(
PeliculaId int identity,
Titulo varchar(40) not null,
Descripcion varchar(100),
Ano int not null,
Calificacion int,
IMBD int ,
CategoriaId int,

)