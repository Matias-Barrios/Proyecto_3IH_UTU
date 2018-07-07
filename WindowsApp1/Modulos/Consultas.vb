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
        Return "UPDATE Personas SET encriptacion_hash = '" & hash & "',encriptacion_sal = '" & sal & "'  WHERE CI = " & CI
    End Function
    Public Function BAJA_LOGICA_USUARIO(CI As Integer) As String
        Return "UPDATE Personas SET encriptacion_hash = null,encriptacion_sal = null  WHERE CI = " & CI
    End Function
    Public Function BAJA_LOGICA_ALUMNO(CI As Integer) As String
        Return "UPDATE Personas SET baja = 't'  WHERE CI = " & CI
    End Function
    Public Function BAJA_LOGICA_GRUPO(id_grupo As Integer) As String
        Return "UPDATE Grupos SET baja = 't'  WHERE id_grupo = " & id_grupo
    End Function
    Public Function BAJA_LOGICA_ASIGNATURA(id_asignatura As Integer) As String
        Return "UPDATE Asignaturas SET baja = 't'  WHERE id_asignatura = " & id_asignatura
    End Function
    Public Function BAJA_LOGICA_CALIFICACION(id_calificacion As Integer) As String
        Return "UPDATE Calificaciones SET baja = 't'  WHERE id_calificacion = " & id_calificacion
    End Function
    Public Function BAJA_LOGICA_DOCENTE(CI As Integer) As String
        Return "UPDATE Personas SET baja = 't'  WHERE CI = " & CI
    End Function
    Public Function BAJA_LOGICA_INSTITUTO(id_instituto As Integer) As String
        Return "UPDATE Institutos SET baja = 't'  WHERE id_instituto = " & id_instituto
    End Function
    Public Function BAJA_LOGICA_ORIENTACION(id_orientacion As Integer) As String
        Return "UPDATE Orientaciones SET baja = 't'  WHERE id_orientacion = " & id_orientacion
    End Function
    Public Function BAJA_LOGICA_CIUDAD(id_ciudad As Integer) As String
        Return "UPDATE Ciudad SET baja = 't'  WHERE id_ciudad = " & id_ciudad
    End Function
    Public Function CREAR_ALUMNO(CI As String, primer_nombre As String, segundo_nombre As String, primer_apellido As String, segundo_apellido As String, fecha_nacimiento As Date, email As String, hace_proyecto As Boolean, convertir_fecha_ingles As Boolean) As String
        Dim fecha_con_formato As String
        Dim hace_proyecto_como_letra As String = "t"
        If convertir_fecha_ingles Then
            fecha_con_formato = fecha_nacimiento.ToString("dd/MM/yyyy")
        Else
            fecha_con_formato = fecha_nacimiento.ToString("MM/dd/yyyy")
        End If
        If hace_proyecto = False Then
            hace_proyecto_como_letra = "f"
        End If
        Dim consulta As String = "INSERT INTO Personas (CI, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, fecha_nacimiento, email, grado, hace_proyecto, nota_final_pro, juicio_final, tipo, encriptacion_hash, encriptacion_sal, baja)
                VALUES(" & CI & ",'" & primer_nombre & "','" & segundo_nombre & "','" & primer_apellido & "','" & segundo_apellido & "'," & fecha_con_formato & ",'" & email & "'," & "NULL" & ",'" & hace_proyecto_como_letra & "'," & 1 & "," & "'Examen Febrero'" & "," & "'Alumno'" & "," & "NULL" & "," & "NULL" & "," & "'f'" & ")"

        Return consulta
    End Function
End Module
