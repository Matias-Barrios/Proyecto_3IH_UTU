﻿Imports System.Text.RegularExpressions

Public Class ventana_crear_usuario
    Private Sub ventana_crear_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtCrearUsuario_Password, TipoValidacion.Solo_password)
        Adherir_Validacion(txt_Crear_Usuario_RepetirPassword, TipoValidacion.Solo_password)
        dgvP_Usuarios_Seleccion.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_POTENCIALES_USUARIOS()))
        dgvP_Usuarios_Seleccion.Set_MultiSelect(False)
    End Sub

    Private Sub btnCrear_Usuario_Aceptar_Click(sender As Object, e As EventArgs) Handles btnCrear_Usuario_Aceptar.Click
        If validar_inputs() Then

            For Each fila In dgvP_Usuarios_Seleccion.Filas_Seleccionadas()
                Dim sal = Crear_Sal()

                hacer_consulta(CREAR_USUARIO(fila.Cells("CI").Value(), Hash512(txtCrearUsuario_Password.Text, sal), sal))
            Next
            MsgBox(MENSAJE_EXITO())
            Me.Dispose()
            Ventana_Principal.dgvP_Usuarios.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_USUARIOS()))
            Ventana_Principal.Show()
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

        If dgvP_Usuarios_Seleccion.Cantidad_Selecciones() = 0 Then
            MsgBox("Debe seleccionar a una persona de la lista")
            Return False
        End If

        'Si ta todo bien ta todo bien
        Return True
    End Function

    Private Sub btnCrearUsuario_Cancelar_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario_Cancelar.Click
        Me.Dispose()
    End Sub

    Private Sub txt_Crear_Usuario_RepetirPassword_TextChanged(sender As Object, e As EventArgs) Handles txt_Crear_Usuario_RepetirPassword.TextChanged, txtCrearUsuario_Password.TextChanged
        If txt_Crear_Usuario_RepetirPassword.Text.Trim() = txtCrearUsuario_Password.Text.Trim() And txtCrearUsuario_Password.Text <> "" Then
            txtCrearUsuario_Password.BackColor = Color.FromArgb(100, 200, 100)
            txt_Crear_Usuario_RepetirPassword.BackColor = Color.FromArgb(100, 200, 100)
        Else
            txtCrearUsuario_Password.BackColor = Color.FromArgb(255, 255, 255)
            txt_Crear_Usuario_RepetirPassword.BackColor = Color.FromArgb(255, 255, 255)
        End If
    End Sub
End Class