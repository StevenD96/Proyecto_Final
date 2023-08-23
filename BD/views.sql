Use MatriculaWeb;



/*Esta vista combina la información de los usuarios, estudiantes y funcionarios, y agrega dos columnas EsEstudiante y EsFuncionario 
que contienen valores binarios (1 o 0) para indicar si el usuario es estudiante, funcionario o ambos*/

CREATE VIEW VistaUsuariosRoles AS
SELECT
    U.Usuario,
    P.Identificacion,
    P.Nombre,
    P.Apellidos,
    CASE WHEN E.IdPersona IS NOT NULL THEN 1 ELSE 0 END AS EsEstudiante,
    CASE WHEN F.IdPersona IS NOT NULL THEN 1 ELSE 0 END AS EsFuncionario
FROM Usuarios U
INNER JOIN Personas P ON U.IdUsuario = P.IdUsuario
LEFT JOIN Estudiantes E ON P.Identificacion = E.IdPersona
LEFT JOIN Funcionarios F ON P.Identificacion = F.IdPersona;
