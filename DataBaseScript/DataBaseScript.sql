create schema dbAprendeDown;

create table tbRoles(
	IdRol int unique auto_increment not null,
    Descripcion nvarchar(30),
    constraint PK_tbRoles_IdRol primary key(IdRol)
);

create table tbUsuarios(
	IdUsuario int unique auto_increment not null,
    IdRol int not null,
    Username nvarchar(30),
    Passwrd nvarchar(20),
    FechaAlta datetime,
    constraint PK_tbUsuarios_IdUsuario primary key(IdUsuario),
    constraint FK_tbUsuarios_IdRol foreign key(IdRol)
		references tbRoles(IdRol) on update cascade
);

create table tbInformacionUsuarios(
	IdInformacionUsuario int unique auto_increment not null,
    IdUsuario int not null,
    Nombre nvarchar(30),
    ApellidoPaterno nvarchar(20),
    ApellidoMaterno nvarchar(20),
    Edad int,
    FechaNacimiento date,
    LugarOrigen nvarchar(10),
    Foto mediumblob,
	FotoNombre nvarchar(10000),
    constraint PK_tbInformacionUsuarios_IdInformacionUsuario primary key(IdInformacionUsuario),
    constraint FK_tbInformacionUsuarios_IdUsuario foreign key(IdUsuario)
		references tbUsuarios(IdUsuario) on update cascade
);

create table tbFotos(
	IdFoto int unique auto_increment not null,
    IdInformacionUsuario int not null,
    Descripcion nvarchar(30),
    NombreCompleto nvarchar(50),
    Foto mediumblob,
	FotoNombre nvarchar(10000),
    constraint PK_tbFotos_IdFoto primary key(IdFoto),
    constraint FK_tbFotos_IdInformacionUsuario foreign key(IdInformacionUsuario)
		references tbInformacionUsuarios(IdInformacionUsuario) on update cascade
);

create table tbJuegosAdivina(
	IdJuegoAdivina int unique auto_increment not null,
	Nombre nvarchar(100),
	constraint PK_tbJuegosAdivina_IdJuegoAdivina primary key(IdJuegoAdivina)
);

create table tbImagenes(
	IdImagen int unique auto_increment not null,
	IdJuegoAdivina int not null,
	Descripcion nvarchar(50),
	Imagen nvarchar(10000),
	constraint PK_tbJImagenes_IdImagen primary key(IdImagen),
	constraint FK_tbImagenes_IdJuegoAdivina foreign key(IdJuegoAdivina)
		references tbJuegosAdivina(IdJuegoAdivina) on update cascade
);