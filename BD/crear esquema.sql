create database VIDEOTIENDA;
USE VIDEOTIENDA;

create table personas(
nro_doc numeric(11) primary key,
tipo_doc varchar(3) not null,
nombres varchar(50) not null,
celular numeric(11) not null,
correo varchar(100) not null,
direccion varchar(100) not null,
tipo_persona varchar(3) not null,
contrasena varchar(10));	


create table dominios(
tipo_dominio varchar(30) not null,
id_dominio varchar(10) not null,
vlr_dominio varchar(50) not null,
primary key(tipo_dominio,id_dominio));

create table categorias(
id_categoria numeric(11) primary key,
nom_categoria varchar(50) not null);

create table productores(
id_prod numeric(11) primary key,
nom_prod varchar(50) not null);

create table videojuegos(
nro_referencia numeric(11) primary key,
nom_videojuego varchar(50) not null,
img_videojuego varchar(100),
id_prod numeric(11) foreign key references productores);

create table cat_videojuegos(
id_cat_videojuego numeric(11) primary key,
id_categoria numeric(11)foreign key references categorias,
nro_referencia numeric(11)foreign key references videojuegos);

create table alquiler(
id_alquiler numeric(11) primary key,
fec_alquiler date not null,
fec_devolucion date not null,
vlr_alquiler decimal(5,0) not null,
vlr_multas decimal (5,0),
nro_doc numeric(11) foreign key references personas);

create table alq_videojuegos(
id_alq_videojuegos numeric(11) primary key,
id_alquiler numeric(11) foreign key references alquiler,
nro_referencia numeric(11) foreign key references personas);































