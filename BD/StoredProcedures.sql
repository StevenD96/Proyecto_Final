--Use MatriculaWeb;


CREATE PROCEDURE ModificarFuncionario (
    @Identificacion varchar(20),
    @NuevoEstado bit = NULL,
    @NuevoNombre varchar(50) = NULL,
    @NuevosApellidos varchar(50) = NULL,
    @NuevoTelefono int = NULL,
    @NuevoCorreo varchar(50) = NULL
)
AS
BEGIN
    -- Actualizar la tabla de Funcionarios
    IF @NuevoEstado IS NOT NULL
    BEGIN
        UPDATE Funcionarios
        SET Estado = @NuevoEstado
        WHERE IdPersona = @Identificacion;
    END
    
    -- Actualizar la tabla de Personas si hay cambios en la información
    IF @NuevoNombre IS NOT NULL OR @NuevosApellidos IS NOT NULL OR @NuevoTelefono IS NOT NULL OR @NuevoCorreo IS NOT NULL
    BEGIN
        UPDATE Personas
        SET 
            Nombre = ISNULL(@NuevoNombre, Nombre),
            Apellidos = ISNULL(@NuevosApellidos, Apellidos),
            Telefono = ISNULL(@NuevoTelefono, Telefono),
            Correo = ISNULL(@NuevoCorreo, Correo)
        WHERE Identificacion = @Identificacion;
    END
END;
