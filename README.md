# Gestión Vehicular - Permisos de Circulación

Sistema para la gestión de pagos de permisos de circulación de una organización gubernamental.

## Tecnologías
* C# / .NET
* Windows Forms
* SQL Server

## Estructura del Proyecto
- **/Forms**: Formularios de la aplicación.
- **/Models**: Clases de datos (Contribuyente y Vehículo).
- **/Data**: Lógica de conexión a base de datos.


## Creación de la Base de Datos `GestionVehicularDB`

- Importar archivo "gestionpermisos.sql" en SQL Server Management Studio para crear la base de datos y las tablas necesarias.

- O ejecutar el siguiente script SQL para crear la base de datos y las tablas:

```
-- 1. Crear la base de datos
CREATE DATABASE GestionPermisos;
USE GestionPermisos;

-- 2. Crear la tabla Contribuyente
CREATE TABLE Contribuyente (
    rut VARCHAR(12) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    nacionalidad VARCHAR(30),
    direccion VARCHAR(100),
    comuna VARCHAR(50)
);

-- 3. Crear la tabla Vehiculo
CREATE TABLE Vehiculo (
    patente VARCHAR(8) PRIMARY KEY,
    marca VARCHAR(30) NOT NULL,
    modelo VARCHAR(30) NOT NULL,
    color VARCHAR(20),
    anio INT,
    rut_contribuyente VARCHAR(12),
    CONSTRAINT fk_propietario 
        FOREIGN KEY (rut_contribuyente) 
        REFERENCES Contribuyente(rut)
        ON DELETE CASCADE 
        ON UPDATE CASCADE
);

-- Insertar datos de ejemplo

-- Insertar un contribuyente de ejemplo
INSERT INTO Contribuyente (rut, nombre, apellido, nacionalidad, direccion, comuna)
VALUES ('1-1', 'Allan', 'Brown', 'chileno', 'Direccion Temporal', 'Comuna Temporal');

-- Insertar un vehículo de ejemplo asociado al contribuyente
INSERT INTO Vehiculo (patente, marca, modelo, color, anio, rut_contribuyente)
VALUES ('CCBB10', 'Hyundai', 'Carretero', 'Fucsia', 2000, '1-1');
```