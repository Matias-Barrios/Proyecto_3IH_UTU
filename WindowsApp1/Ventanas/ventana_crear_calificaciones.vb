Public Class ventana_crear_calificaciones

    Private Sub ventana_crear_calificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim hola = Consultas.uno
        Dim pepe = Consultas.dos
        Dim cacho = Consultas.tres

        chkCrearCalificacion_Asignar_A.DataSource = hacer_consulta(CONSULTAS_SELECT_ALUMNOS_CREAR_CALIFICACIONES_LISTBOX())
        chkCrearCalificacion_Asignar_A.DisplayMember = "nombre_alumno"

    End Sub


    Public Function CONSULTAS_SELECT_ALUMNOS_CREAR_CALIFICACIONES_LISTBOX() As String


        Return "select foranea_ci_alumno,
        (select Personas.primer_nombre || ' ' || Personas.primer_apellido from Personas where Personas.CI = foranea_ci_alumno) AS nombre_alumno
        from relacion_alumno_asignatura_grupos
        where foranea_id_grupo = " & dos & "
       And foranea_id_asignatura = " & tres & "
       And foranea_id_instituto = " & uno

    End Function








End Class