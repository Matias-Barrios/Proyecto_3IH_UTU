Imports System.Text.RegularExpressions

Public Class ventana_modificar_password_usuario
    Public usuario_a_modificar As DataGridViewRow
    Private Sub ventana_modificar_password_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtModificarUsuario_Password, TipoValidacion.Solo_password)
        Adherir_Validacion(txt_Modificar_Usuario_RepetirPassword, TipoValidacion.Solo_password)
        lbl_DAtos_usuario_a_modificar.Text = usuario_a_modificar.Cells("CI").Value() & " - " & usuario_a_modificar.Cells("primer_nombre").Value() & " " & usuario_a_modificar.Cells("primer_apellido").Value()
    End Sub

    Private Sub btnModificar_Usuario_Aceptar_Click(sender As Object, e As EventArgs) Handles btnModificar_Usuario_Aceptar.Click
        If validar_inputs() Then
            Dim sal = Crear_Sal()

            hacer_consulta(CREAR_USUARIO(usuario_a_modificar.Cells("CI").Value(), Hash512(txtModificarUsuario_Password.Text, sal), sal))

            MsgBox(MENSAJE_EXITO())
            Me.Dispose()
            Ventana_Principal.dgvP_Usuarios.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_USUARIOS()))
        End If
    End Sub
    Private Function validar_inputs()

        If Regex.Matches(txtModificarUsuario_Password.Text, PASSWORD_VALIDO()).Count <> 1 Then
            MsgBox("La contraseña tiene un formato incorrecto. Debe coincidir con esta expresion regular: " & PASSWORD_VALIDO())
            Return False
        End If

        If Regex.Matches(txt_Modificar_Usuario_RepetirPassword.Text, PASSWORD_VALIDO()).Count <> 1 Then
            MsgBox("La contraseña tiene un formato incorrecto. Debe coincidir con esta expresion regular: " & PASSWORD_VALIDO())
            Return False
        End If

        If txtModificarUsuario_Password.Text <> txt_Modificar_Usuario_RepetirPassword.Text Then
            MsgBox("Las contraseñas ingresadas no coinciden!!")
            Return False
        End If

        Return True
    End Function

End Class