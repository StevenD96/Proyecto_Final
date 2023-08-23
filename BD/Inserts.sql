Use MatriculaWeb;
--select * from VistaUsuariosRoles;
-- Insertar valores en la tabla Usuarios
INSERT INTO Usuarios (Usuario, Contrasena)
VALUES ('usuario1', 'contrasena1'),
       ('usuario2', 'contrasena2'),
       ('usuario3', 'contrasena3');

-- Insertar valores en la tabla Personas
INSERT INTO Personas (Identificacion, IdUsuario, Nombre, Apellidos, Telefono, Correo)
VALUES ('123456789', 1, 'Juan', 'Perez', 12345, 'juan@example.com'),
       ('987654321', 2, 'Maria', 'Gomez', 98765, 'maria@example.com'),
       ('567890123', 3, 'Carlos', 'Lopez', 56789, 'carlos@example.com');

-- Insertar valores en la tabla Estudiantes
INSERT INTO Estudiantes (IdPersona, Carrera, Beca)
VALUES ('123456789', 'Ingeniería Informática', 1),
       ('987654321', 'Medicina', 0),
       ('567890123', 'Derecho', 1);

-- Insertar valores en la tabla Funcionarios
INSERT INTO Funcionarios (IdPersona, Estado)
VALUES ('123456789', 1),
       ('567890123', 1);
