--Creamos La base de datos
create database BD_Registro

create table tblEmpleados(
Id int primary key identity(1,1),
Nombre varchar(50),
Apellido varchar(50),
Cargo varchar(50)
);

select * from tblEmpleados

insert into tblEmpleados(Nombre, Apellido, Cargo) values ('Juan','Pedro','Gerente');

--Creamos procedimiento para Mostrar Empleados
Create procedure sp_MostrarDatos
as begin
select * from tblEmpleados
end

exec sp_MostrarDatos

--creamos procedimiento para agregar
Create procedure sp_Agregar
@Nombre varchar(50),
@Apellido varchar(50),
@Cargo varchar(50)
as begin
insert into tblEmpleados values(@Nombre, @Apellido, @Cargo)
end

--creamos procedimiento para Modificar
create procedure sp_Modificar
@Id int,
@Nombre varchar(50),
@Apellido varchar(50),
@Cargo varchar(50)
as begin
update tblEmpleados set Nombre = @Nombre, Apellido = @Apellido, Cargo = @Cargo
where Id = @Id
end

--creamos procedimiento para Eliminar
create procedure sp_Eliminar
@Id int
as begin
delete from tblEmpleados where Id = @Id
end
