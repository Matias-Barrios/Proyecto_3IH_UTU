Public Class ventana_crear_calificaciones
    Private es_modificacion = False
    Private calificacion As New DataGridViewRow()
    Private CI_original As Integer

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

    Private Function Validar() As Boolean
        If String.IsNullOrEmpty(txtCrearCalificaciones_Nombre_Descriptivo.Text.Trim()) Then
            MsgBox("Debe ingresar un valor a nombre descriptivo!")
            Return False
        End If
        Return True
    End Function



    Private Sub btnCrearCalificacion_Cancelar_Click(sender As Object, e As EventArgs) Handles btnCrearCalificacion_Cancelar.Click
        Me.Dispose()
    End Sub

    Public Sub Preparar_Ventana_Modificacion(cal As DataGridViewRow)
        Try
            es_modificacion = True
            calificacion = cal
            CI_original = calificacion.Cells("CI").Value()
            txtCrearCalificaciones_Nombre_Descriptivo.Text = calificacion.Cells("nombre_calificacion").Value()
            nudCrearCalificacion_Nota.Text = calificacion.Cells("nota").Value().ToString()
            rchCrearCalificacion_Comentario.Text = calificacion.Cells("comentario").Value().ToString()


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
End Class