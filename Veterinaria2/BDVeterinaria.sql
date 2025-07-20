-- Creación de la base de datos
CREATE DATABASE BDVeterinaria;
GO

-- Usar la base de datos creada
USE BDVeterinaria;
GO

-- Tabla: UsuarioSistema
CREATE TABLE UsuariosRoles
(
ID INT PRIMARY KEY,
DESCRIPCION VARCHAR(30)
);

INSERT INTO UsuariosRoles
VALUES
(1, 'ADMINISTRADOR'),(2, 'EMPLEADO');

CREATE TABLE Estados
(
ID INT PRIMARY KEY,
DESCRIPCION VARCHAR(30)
);

INSERT INTO Estados
VALUES
(1, 'ACTIVO'),(2, 'ANULADO');

CREATE TABLE UsuarioSistema (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    Clave VARCHAR(100) NOT NULL,
    RolID INT FOREIGN KEY REFERENCES UsuariosRoles(ID),
	Estado INT FOREIGN KEY REFERENCES Estados(ID),
	UsuarioID INT FOREIGN KEY REFERENCES UsuarioSistema(ID)
);

-- Tabla: Veterinario
CREATE TABLE Veterinario (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Telefono VARCHAR(20),
    Correo VARCHAR(100),
    Direccion VARCHAR(200),
	Estado INT FOREIGN KEY REFERENCES Estados(ID),
	UsuarioID INT FOREIGN KEY REFERENCES UsuarioSistema(ID)
);

-- Tabla: Cliente
CREATE TABLE Cliente (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    FechaNacimiento DATE,
    Telefono VARCHAR(20),
    Correo VARCHAR(100),
    Direccion VARCHAR(200),
	Estado INT FOREIGN KEY REFERENCES Estados(ID),
	UsuarioID INT FOREIGN KEY REFERENCES UsuarioSistema(ID)
);

-- Tabla: Especie
CREATE TABLE Especie (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
	Estado INT FOREIGN KEY REFERENCES Estados(ID),
	UsuarioID INT FOREIGN KEY REFERENCES UsuarioSistema(ID)
);

-- Tabla: Raza
CREATE TABLE Raza (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NombreRaza VARCHAR(50) NOT NULL,
    EspecieID INT FOREIGN KEY REFERENCES Especie(ID),
	Estado INT FOREIGN KEY REFERENCES Estados(ID),
	UsuarioID INT FOREIGN KEY REFERENCES UsuarioSistema(ID)
);

-- Tabla: Mascota
CREATE TABLE Mascota (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    FechaNacimiento DATE,
    ClienteID INT FOREIGN KEY REFERENCES Cliente(ID),
    RazaID INT FOREIGN KEY REFERENCES Raza(ID),
    EspecieID INT FOREIGN KEY REFERENCES Especie(ID),
	Estado INT FOREIGN KEY REFERENCES Estados(ID),
	UsuarioID INT FOREIGN KEY REFERENCES UsuarioSistema(ID)
);

-- Tabla: Servicio
CREATE TABLE Servicio (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
	Estado INT FOREIGN KEY REFERENCES Estados(ID),
	UsuarioID INT FOREIGN KEY REFERENCES UsuarioSistema(ID)
);

-- Tabla: Factura
CREATE TABLE Factura (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ClienteID INT FOREIGN KEY REFERENCES Cliente(ID),
	MascotaID INT FOREIGN KEY REFERENCES Mascota(ID),
	VeterinarioID INT FOREIGN KEY REFERENCES Veterinario(ID),
	FechaInicio DATE NOT NULL,
    FechaEntregaEstimada DATE,
    FechaEntregaReal DATE,
    FechaFactura DATE NOT NULL,
	Estado INT FOREIGN KEY REFERENCES Estados(ID),
	UsuarioID INT FOREIGN KEY REFERENCES UsuarioSistema(ID)
);

-- Tabla: DetalleFactura
CREATE TABLE DetalleFactura (
    ID INT PRIMARY KEY IDENTITY(1,1),
    FacturaID INT FOREIGN KEY REFERENCES Factura(ID),
	ServicioID INT FOREIGN KEY REFERENCES Servicio(ID),
    PrecioUnitario DECIMAL(10,2),
	Descuento DECIMAL(10,2),
	Estado INT FOREIGN KEY REFERENCES Estados(ID),
	UsuarioID INT FOREIGN KEY REFERENCES UsuarioSistema(ID)
);
