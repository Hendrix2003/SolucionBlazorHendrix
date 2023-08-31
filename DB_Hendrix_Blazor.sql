CREATE DATABASE DB_CRUD_BLAZOR

USE DB_CRUD_BLAZOR

CREATE TABLE Departamento(
IdDepartamento int primary key identity(1,1),
Nombre varchar(50)not null
)

CREATE TABLE Empleado(
IdEmpleado int primary key identity(1,1),
NombreCompleto varchar(50)not null,
IdDepartamento int references Departamento(IdDepartamento)not null,
Salario int not null,
FechaContrato date not null
)

INSERT INTO Departamento(Nombre)VALUES
('Administración'),
('Makerting'),
('Ventas'),
('Comercio')

INSERT INTO Empleado(NombreCompleto,IdDepartamento,Salario,FechaContrato)VALUES
('Hendrix Polanco',1,50000,getdate())

SELECT * FROM Departamento
SELECT * FROM Empleado