Imports System.Text.RegularExpressions
Public Class ventana_crear_asignatura
    Private es_modificacion = False
    Private asignatura As DataGridViewRow


    Private Sub ventana_crear_asignatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtCrearAsignaturaNombre, TipoValidacion.solo_nombres_espacio)
    End Sub


    Private Function validar_inputs()

        If Regex.Matches(txtCrearAsignaturaNombre.Text, NOMBRE_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Nombre' correctamente!")
            Return False
        End If

        'Si ta todo bien ta todo bien
        Return True
    End Function

    Private Sub btnModificarUsuario_Cancelar_Click(sender As Object, e As EventArgs) Handles btnCrearAsignaturaCancelar.Click
        Me.Dispose()
    End Sub
    Private Sub Cerrar_Ventana(sender As Object, e As EventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub


    Private Sub btnModificar_Usuario_Aceptar_Click(sender As Object, e As EventArgs) Handles btnCrearAsignaturaAceptar.Click
        If Not es_modificacion Then
            If validar_inputs() Then
                hacer_consulta(CREAR_ASIGNATURA(txtCrearAsignaturaNombre.Text, rchCrearAsignatura_Descripcion.Text))
                Ventana_Principal.dgvP_Asignaturas.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ASIGNATURAS()))
                Me.Dispose()
            End If
        Else
            If validar_inputs() Then
                Preparar_Asignatura()
                hacer_consulta(MODIFICAR_ASIGNATURA(asignatura))
                Ventana_Principal.dgvP_Asignaturas.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ASIGNATURAS()))
                Me.Dispose()
            End If
        End If

    End Sub
    Public Sub Preparar_Ventana_Modificacion(asig As DataGridViewRow)
        Try
            es_modificacion = True
            asignatura = asig
            txtCrearAsignaturaNombre.Text = asignatura.Cells("nombre_asignatura").Value()
            rchCrearAsignatura_Descripcion.Text = asignatura.Cells("descripcion").Value()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Public Sub Preparar_Asignatura()
        asignatura.Cells("nombre_asignatura").Value() = txtCrearAsignaturaNombre.Text
        asignatura.Cells("descripcion").Value() = rchCrearAsignatura_Descripcion.Text
    End Sub


End Class