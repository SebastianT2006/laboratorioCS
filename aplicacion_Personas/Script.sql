CREATE DATABASE db_Personas;
GO 
USE db_Personas;
GO 

CREATE TABLE [Personas] (
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Nombre] NVARCHAR(50) NOT NULL,
    [Apellido] NVARCHAR(50) NOT NULL,
    [AnioNacimiento] DATE NOT NULL,
    [Genero] NVARCHAR(30) NOT NULL
);
