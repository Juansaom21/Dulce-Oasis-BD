create database Dulce_Oasis
use Dulce_Oasis

create table producto(
cod_prod int not null primary key,
nombre_prod varchar(50) not null,
cantidad_prod int not null,
descrip varchar(50),
precio bigint not null,)

create table ingrediente(
cod_ingr int not null primary key,
nombre_ingr varchar(50) not null,
cantidad_ingr int not null)

create table usuario(
id int not null primary key,
nombre varchar(50) not null,
correo varchar(50) not null,
contra varchar(50) not null,
rol varchar(50) not null check(rol in('admin', 'empleado')))

create table factura(
cod_factura int not null primary key,
id int not null foreign key references usuario(id),
cod_prod int not null foreign key references producto(cod_prod),
fecha date not null,
total bigint not null)

create view inventario
as
select i.*, p.*
from ingrediente i, producto p

select*
from inventario