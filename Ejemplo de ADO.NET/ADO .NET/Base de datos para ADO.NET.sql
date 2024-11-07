-- Crear la base de datos
CREATE DATABASE TestDB;

-- Usar la base de datos creada
USE TestDB;

-- Crear la tabla 'Customers'
CREATE TABLE Customers (
    CustomerId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(100)
);

-- Insertar algunos datos de ejemplo
INSERT INTO Customers (CustomerName) VALUES ('John Doe');
INSERT INTO Customers (CustomerName) VALUES ('Jane Smith');
INSERT INTO Customers (CustomerName) VALUES ('Sara Lee');

-- Ver Tabla Creada
SELECT * FROM Customers