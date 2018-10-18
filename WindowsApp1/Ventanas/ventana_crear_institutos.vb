Imports System.Text.RegularExpressions

Public Class ventana_crear_institutos
    Private es_modificacion = False
    Private instituto As DataGridViewRow

    Private Sub ventana_crear_institutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txt_crear_instituto_telefono, TipoValidacion.Solo_numeros)
        Adherir_Validacion(txt_crear_instituto_calles, TipoValidacion.solo_nombres_espacio)
        Adherir_Validacion(txt_crear_instituto_nombre, TipoValidacion.solo_nombres_espacio)
        Adherir_Validacion(txt_crear_instituto_numero_calle, TipoValidacion.Solo_numeros)
        Adherir_Validacion(txt_crear_institutos_email, TipoValidacion.Solo_Email)
        Cbo_Ciudades.DataSource = hacer_consulta(CONSULTAS_COMBO_CIUDADES())
        Cbo_Ciudades.DisplayMember = "nombre"
        If es_modificacion Then
            Cbo_Ciudades.Enabled = False
        End If
    End Sub
    Private Sub cerrar_ventana(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub crear_instituto_click(sender As Object, e As EventArgs) Handles btn_crear_instituto_aceptar.Click
        If Not es_modificacion Then
            If validar_inputs() Then
                hacer_consulta(CREAR_INSTITUTO(txt_crear_instituto_nombre.Text, txt_crear_instituto_calles.Text, txt_crear_instituto_numero_calle.Text, txt_crear_institutos_email.Text, join(chk_institutos_telefonos.Items), Cbo_Ciudades.SelectedItem("id_ciudad")))
                Ventana_Principal.dgvP_Institutos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_INSTITUTOS()))
                Me.Dispose()
            End If
        Else
            If validar_inputs() Then
                Preparar_Orientacion()
                hacer_consulta(MODIFICAR_INSTITUTO(instituto.Cells("id_instituto").Value(), txt_crear_instituto_nombre.Text, txt_crear_instituto_calles.Text, txt_crear_instituto_numero_calle.Text, txt_crear_institutos_email.Text, join(chk_institutos_telefonos.Items)))
                Ventana_Principal.dgvP_Institutos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_INSTITUTOS()))
                Me.Dispose()
            End If
        End If
    End Sub
    Public Function join(objs As CheckedListBox.ObjectCollection) As String
        Dim strs As New List(Of String)
        For Each ob In objs
            strs.Add(ob.ToString())

        Next
        Return String.Join("|", strs)
    End Function

    Public Sub Preparar_Ventana_Modificacion(ins As DataGridViewRow)
        Try
            es_modificacion = True
            instituto = ins
            txt_crear_instituto_nombre.Text = instituto.Cells("nombre").Value()
            txt_crear_instituto_calles.Text = instituto.Cells("calle").Value()
            txt_crear_instituto_numero_calle.Text = instituto.Cells("numero").Value().ToString()
            txt_crear_institutos_email.Text = instituto.Cells("email").Value().ToString()
            For Each tel In instituto.Cells("telefonos").Value().ToString().Split("|")
                chk_institutos_telefonos.Items.Add(tel)
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Public Sub Preparar_Orientacion()
        instituto.Cells("nombre").Value() = txt_crear_instituto_nombre.Text
        instituto.Cells("calle").Value() = txt_crear_instituto_calles.Text
        instituto.Cells("calle").Value() = Val(txt_crear_instituto_numero_calle.Text)
        instituto.Cells("email").Value() = txt_crear_institutos_email.Text
        instituto.Cells("telefonos").Value() = join(chk_institutos_telefonos.Items)
    End Sub
    Private Function validar_inputs()

        If Regex.Matches(txt_crear_instituto_nombre.Text, ORIEANTACION_NOMBRE_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Nombre' correctamente!")
            Return False
        End If

        'Si ta todo bien ta todo bien
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chk_institutos_telefonos.Items.Add(txt_crear_instituto_telefono.Text)
        txt_crear_instituto_telefono.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each tel In chk_institutos_telefonos.CheckedIndices
            chk_institutos_telefonos.Items.RemoveAt(tel)
        Next
    End Sub
End Class