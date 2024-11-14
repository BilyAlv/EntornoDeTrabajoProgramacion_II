-- 1. Crear la base de datos
CREATE DATABASE MiBaseDeDatos;
GO

-- 2. Usar la base de datos creada
USE MiBaseDeDatos;
GO

-- 3. Crear la tabla de Usuarios
CREATE TABLE Usuarios (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100),
    Email NVARCHAR(100)
);
GO

-- 4. Insertar datos de prueba en la tabla Usuarios
INSERT INTO Usuarios (Nombre, Email) VALUES ('Juan Pérez', 'juan@example.com');
INSERT INTO Usuarios (Nombre, Email) VALUES ('Ana Gómez', 'ana@example.com');
INSERT INTO Usuarios (Nombre, Email) VALUES ('Carlos Martínez', 'carlos@example.com');
INSERT INTO Usuarios (Nombre, Email) VALUES ('Marta López', 'marta@example.com');
INSERT INTO Usuarios (Nombre, Email) VALUES ('Pedro Sánchez', 'pedro@example.com');
GO

-- 5. Verificar los datos insertados
SELECT * FROM Usuarios;
GO
