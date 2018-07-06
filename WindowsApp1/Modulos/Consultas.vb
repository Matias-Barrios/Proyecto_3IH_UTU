Module Consultas


    Public Function CONSULTAS_SELECT_ALUMNOS() As String
        Return "SELECT * FROM Personas WHERE tipo = 'Alumno' AND baja = 'f'"
    End Function

    Public Function CONSULTAS_SELECT_INSTITUTOS() As String
        Return "SELECT * FROM Institutos WHERE baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_ASIGNATURAS() As String
        Return "SELECT * FROM Asignaturas WHERE baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_CIUDADES() As String
        Return "SELECT * FROM Ciudad WHERE baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_ORIENTACIONES() As String
        Return "SELECT * FROM Orientaciones WHERE baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_DOCENTES() As String
        Return "SELECT * FROM Personas WHERE tipo='Profesor' AND baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_GRUPOS() As String
        Return "SELECT Grupos.id_grupo,Grupos.nombre_grupo,Institutos.nombre,Orientaciones.nombre_orientacion FROM Grupos,Institutos,Orientaciones WHERE Grupos.baja = 'f' and Grupos.foranea_id_instituto = Institutos.id_instituto and Grupos.foranea_id_orientacion = Orientaciones.id_orientacion and  Grupos.baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_ADMINISTRADORES() As String
        Return "SELECT * FROM Personas WHERE tipo = 'Administrador' AND baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_ADMINS() As String
        Return "SELECT * FROM Personas WHERE tipo = 'Admin' AND baja = 'f'"
    End Function
    Public Function CONSULTAS_SELECT_CALIFICACIONES() As String
        Return "SELECT * FROM Calificaciones WHERE baja = 'f'"
    End Function

    Public Function CONSULTAS_SELECT_USUARIOS() As String
        Return "SELECT * FROM Personas WHERE baja = 'f' AND encriptacion_hash is not null AND baja = 'f'"
    End Function

    Public Function CONSULTAS_SELECT_POTENCIALES_USUARIOS() As String
        Return "SELECT * FROM Personas WHERE baja = 'f' AND tipo IN ('Admin','Profesor','Administrativo')"
    End Function

    Public Function CREAR_USUARIO(CI As Integer, hash As String, sal As String) As String
        Return "UPDATE Personas set encriptacion_hash = '" & hash & "',encriptacion_sal = '" & sal & "'  WHERE CI = " & CI
    End Function
    Public Function BAJA_LOGICA_USUARIO(CI As Integer) As String
        Return "UPDATE Personas set encriptacion_hash = null,encriptacion_sal = null  WHERE CI = " & CI
    End Function
End Module
