create database Dulce_Oasis
use Dulce_Oasis

create table producto(
cod_prod int identity(1,1) not null primary key,
nombre_prod varchar(50) unique not null,
cantidad_prod int not null,
descrip varchar(50),
precio int not null)

create table ingrediente(
cod_ingr int identity(1,1) not null primary key,
nombre_ingr varchar(50) unique not null,
cantidad_ingr int not null)

create table usuario(
id int identity(1,1) not null primary key,
nombre varchar(50) not null,
correo varchar(50) not null,
contra varchar(50) not null,
rol varchar(50) not null check(rol in('admin', 'empleado')))

create table factura(
cod_factura int identity(1,1) not null primary key,
id_cliente int not null,
nombre_prod varchar(50) not null ,
fecha date not null default getdate(),
precio int not null)


-- Insert an admin user
insert into
  usuario (nombre, correo, contra, rol)
values
  (
    'mariam',
    'admin@example.com',
    '2110',
    'admin'
  );

create view inventario
as
select i.*, p.*
from ingrediente i, producto p

select*
from usuario

select*
from ingrediente

select*
from producto

select*
from factura