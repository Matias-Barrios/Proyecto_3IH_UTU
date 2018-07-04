Module Consultas

    Public Function CONSULTAS_SELECT_ALUMNOS() As String
        Return "SELECT * FROM Personas --WHERE tipo = 'Alumno' AND baja = 'f'"
    End Function

    Public Function CONSULTAS_SELECT_INSTITUTOS() As String
        Return "SELECT * FROM Institutos"
    End Function
    Public Function CONSULTAS_SELECT_ASIGNATURAS() As String
        Return "SELECT * FROM Asignaturas"
    End Function
    Public Function CONSULTAS_SELECT_CIUDADES() As String
        Return "SELECT * FROM Ciudad AND baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_ORIENTACIONES() As String
        Return "SELECT * FROM Orientaciones AND baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_DOCENTES() As String
        Return "SELECT * FROM Personas WHERE tipo='Profesor'"
    End Function
    Public Function CONSULTAS_SELECT_GRUPOS() As String
        Return "SELECT * FROM Grupos AND baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_ADMINISTRADORES() As String
        Return "SELECT * FROM Personas WHERE tipo = 'Administrador' AND baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_ADMINS() As String
        Return "SELECT * FROM Personas WHERE tipo = 'Admin' AND baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_CALIFICACIONES() As String
        Return "SELECT * FROM Calificaciones WHERE tipo = 'Admin' AND baja = 'f'"
    End Function
End Module
