-- Crear la base de datos
CREATE DATABASE GestionUsuarioDB;

-- Usar la base de datos creada
USE GestionUsuarioDB;

-- Crear la tabla de ejemplo
CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Edad INT
);

-- Insertar algunos datos de ejemplo
INSERT INTO Usuarios (Nombre, Edad)
VALUES ('Juan Pérez', 30),
       ('María Gómez', 25),
       ('Carlos López', 35);

-- 5. Verificar los datos insertados
SELECT * FROM Usuarios;
GO