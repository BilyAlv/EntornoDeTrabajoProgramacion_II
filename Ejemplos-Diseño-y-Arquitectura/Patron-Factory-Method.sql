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
VALUES ('Juan P�rez', 30),
       ('Mar�a G�mez', 25),
       ('Carlos L�pez', 35);

-- 5. Verificar los datos insertados
SELECT * FROM Usuarios;
GO