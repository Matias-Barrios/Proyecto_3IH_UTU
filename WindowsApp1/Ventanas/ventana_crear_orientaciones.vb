Imports System.Text.RegularExpressions

Public Class ventana_crear_orientaciones

    Private es_modificacion = False
    Private orientacion As DataGridViewRow
    Private id_orientacion_original As Integer

    Private Sub btn_crear_grupo_aceptar_Click(sender As Object, e As EventArgs) Handles btn_crear_grupo_aceptar.Click
        If Not es_modificacion Then
            If validar_inputs() Then
                hacer_consulta(CREAR_ORIENTACION(txt_crear_orientaciones_nombre.Text, rch_crear_orientaciones_.Text))
                Ventana_Principal.dgvP_Orientaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ORIENTACIONES()))
                Me.Dispose()
            End If
        Else
            If validar_inputs() Then
                Preparar_Orientacion()
                hacer_consulta(MODIFICAR_ORIENTACION(id_orientacion_original, txt_crear_orientaciones_nombre.Text, rch_crear_orientaciones_.Text))
                Ventana_Principal.dgvP_Orientaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ORIENTACIONES()))
                Me.Dispose()
            End If
        End If
    End Sub
    Public Sub Preparar_Ventana_Modificacion(ori As DataGridViewRow)
        Try
            es_modificacion = True
            orientacion = ori
            txt_crear_orientaciones_nombre.Text = ori.Cells("nombre_orientacion").Value()
            rch_crear_orientaciones_.Text = ori.Cells("descripcion").Value()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Public Sub Preparar_Orientacion()
        orientacion.Cells("nombre_orientacion").Value = txt_crear_orientaciones_nombre.Text
        orientacion.Cells("descripcion").Value = rch_crear_orientaciones_.Text
    End Sub
    Private Function validar_inputs()

        If Regex.Matches(txt_crear_orientaciones_nombre.Text, ORIEANTACION_NOMBRE_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Nombre' correctamente!")
            Return False
        End If

        'Si ta todo bien ta todo bien
        Return True
    End Function

    Private Sub ventana_crear_orientaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_orientacion_original = orientacion.Cells("id_orientacion").Value()
    End Sub
End Class