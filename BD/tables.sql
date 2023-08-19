USE [MatriculaWeb]
-- Creación de las tablas
-- Eliminación de las tablas en orden inverso (empezando por las que tienen dependencias)

DROP TABLE IF EXISTS CarrerasGrados;
DROP TABLE IF EXISTS CursosMatricula;
DROP TABLE IF EXISTS Matricula;
DROP TABLE IF EXISTS Cursos;
DROP TABLE IF EXISTS Funcionarios;
DROP TABLE IF EXISTS Usuarios;
DROP TABLE IF EXISTS Estudiantes;
DROP TABLE IF EXISTS Carreras;
DROP TABLE IF EXISTS Grados;

-- Creación de las tablas

-- Tabla: Grados
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Grados')
BEGIN
    CREATE TABLE Grados (
        IdGrado int IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Nombre varchar(50) NOT NULL
    );
END

-- Tabla: Carreras
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Carreras')
BEGIN
    CREATE TABLE Carreras (
        Codigo varchar(20) NOT NULL PRIMARY KEY,
        Nombre varchar(50) NOT NULL,
        Estado bit NOT NULL
    );
END

-- Tabla intermedia: CarrerasGrados
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CarrerasGrados')
BEGIN
    CREATE TABLE CarrerasGrados (
        IdCarreraGrado int IDENTITY(1,1) NOT NULL PRIMARY KEY,
        CodigoCarrera varchar(20) NOT NULL,
        IdGrado int NOT NULL,
        FOREIGN KEY (CodigoCarrera) REFERENCES Carreras (Codigo),
        FOREIGN KEY (IdGrado) REFERENCES Grados (IdGrado)
    );
END



-- Tabla: Estudiantes
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Estudiantes')
BEGIN
    CREATE TABLE Estudiantes (
        Identificacion varchar(20) NOT NULL PRIMARY KEY,
        Nombre varchar(50) NOT NULL,
        Apellidos varchar(50) NOT NULL,
        Carrera varchar(50) NOT NULL,
        Telefono int NOT NULL,
        Correo varchar(50) NOT NULL,
        Beca bit NOT NULL
    );
END

-- Tabla: Matricula
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Matricula')
BEGIN
    CREATE TABLE Matricula (
        IdMatricula int IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Costo float NOT NULL,
        Identificacion varchar(20) NOT NULL,
        Beca float NOT NULL,
        FOREIGN KEY (Identificacion) REFERENCES Estudiantes (Identificacion)
    );
END

-- Tabla: Cursos
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cursos')
BEGIN
    CREATE TABLE Cursos (
        Codigo varchar(20) NOT NULL PRIMARY KEY,
        Nombre varchar(50) NOT NULL,
        Creditos int NOT NULL,
        NotaMinima int NOT NULL,
        Cant_Min int NOT NULL,
        Cant_Max int NOT NULL,
        Grado varchar(50) NOT NULL,
        Estado bit NOT NULL,
        Costo float NOT NULL,
        CodigoCarrera varchar(20) NOT NULL,
        FOREIGN KEY (CodigoCarrera) REFERENCES Carreras (Codigo)
    );
END

-- Tabla: CursosMatricula
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CursosMatricula')
BEGIN
    CREATE TABLE CursosMatricula (
        CursoMatricula int IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Codigo varchar(20) NOT NULL,
        IdMatricula int NOT NULL,
        FOREIGN KEY (Codigo) REFERENCES Cursos (Codigo),
        FOREIGN KEY (IdMatricula) REFERENCES Matricula (IdMatricula)
    );
END

-- Tabla: Funcionarios
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Funcionarios')
BEGIN
    CREATE TABLE Funcionarios (
        Usuario varchar(50) NOT NULL PRIMARY KEY,
        Contrasena varchar(20) NOT NULL,
        Identificacion varchar(20) NOT NULL,
        Nombre varchar(50) NOT NULL,
        PrimerApellido varchar(50) NOT NULL,
        SegundoApellido varchar(50) NOT NULL,
        Estado bit NOT NULL
    );
END

-- Tabla: Usuarios
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Usuarios')
BEGIN
    CREATE TABLE Usuarios (
        Usuario varchar(50) NOT NULL PRIMARY KEY,
        Contrasena varchar(20) NOT NULL
    );
END

