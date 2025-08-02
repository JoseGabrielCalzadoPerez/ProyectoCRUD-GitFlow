create database BD_Register

create table Empleados(
Id int primary key identity(1,1),
Nombre varchar(50),
Contraseña varchar(50),
Cargo varchar(50)
);

select * from Empleados

--Creamos procedimiento para Mostrar Empleados
create procedure SP_MostrarEmpleados
as begin
select * from Empleados
end

exec SP_MostrarEmpleados

--creamos procedimiento para agregar
Create procedure SP_AgregarEmpleado
@Nombre varchar(50),
@Contraseña varchar(50),
@Cargo varchar(50)
as begin
insert into Empleados values(@Nombre, @Contraseña, @Cargo)
end

--creamos procedimiento para Modificar
create procedure SP_ModificarEmpleado
@Id int,
@Nombre varchar(50),
@Contraseña varchar(50),
@Cargo varchar(50)
as begin
update Empleados set Nombre = @Nombre, Contraseña = @Contraseña, Cargo = @Cargo
where Id = @Id
end

--creamos procedimiento para Eliminar
create procedure SP_EliminarEmpleados
@Id int
as begin
delete from Empleados where Id = @Id
end

--Si la base de datos no la puedes visualizar utiliza la siguiente line de codigo
--Use BD_Register
--select * from Empleados
-- Con esto ya estara listo
-- Y si se desconfiguran los numeros *si es que la base de datos es nueva aun y se pueden borrar los registros*
--utiliza DELETE FROM Empleados; *para borrar los registros* y DBCC CHECKIDENT ('Empleados', RESEED, 0); para reiniciar el contador

