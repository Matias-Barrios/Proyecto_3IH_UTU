Imports System.Text.RegularExpressions

Public Class ventana_crear_usuario
    Private Sub ventana_crear_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtCrearUsuario_Password, TipoValidacion.Solo_password)
        Adherir_Validacion(txt_Crear_Usuario_RepetirPassword, TipoValidacion.Solo_password)
        dgvP_Usuarios_Seleccion.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_POTENCIALES_USUARIOS()))
    End Sub

    Private Sub btnCrear_Usuario_Aceptar_Click(sender As Object, e As EventArgs) Handles btnCrear_Usuario_Aceptar.Click
        If validar_inputs() Then
            ' TODO - Aca va el codigo que crea un nuevo usuario en al BD de tipo Alumno
        End If
    End Sub
    Private Function validar_inputs()

        If Regex.Matches(txtCrearUsuario_Password.Text, PASSWORD_VALIDO()).Count <> 1 Then
            MsgBox("La contraseña tiene un formato incorrecto. Debe coincidir con esta expresion regular: " & PASSWORD_VALIDO())
            Return False
        End If

        If Regex.Matches(txtCrearUsuario_Password.Text, PASSWORD_VALIDO()).Count <> 1 Then
            MsgBox("La contraseña tiene un formato incorrecto. Debe coincidir con esta expresion regular: " & PASSWORD_VALIDO())
            Return False
        End If

        If txtCrearUsuario_Password.Text <> txt_Crear_Usuario_RepetirPassword.Text Then
            MsgBox("Las contraseñas ingresadas no coinciden!!")
            Return False
        End If


        'Si ta todo bien ta todo bien
        Return True
    End Function

    Private Sub btnCrearUsuario_Cancelar_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario_Cancelar.Click
        Me.Dispose()
    End Sub
End Class