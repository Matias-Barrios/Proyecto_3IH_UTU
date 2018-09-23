Imports System.Text.RegularExpressions


Public Class ventana_crear_admin
    Private es_modificacion = False
    Private un_admin As DataGridViewRow
    Private CI_original As Integer

    Private Sub btnAdmin_Cancelar_Click(sender As Object, e As EventArgs) Handles btnAdmin_Cancelar.Click
        Me.Dispose()
    End Sub
    Private Function validar_inputs()

        If Regex.Matches(txtAdmin_CI.Text, CEDULA_VALIDA()).Count <> 1 Then
            MsgBox("Debe completar el campo 'CI' correctamente!")
            Return False
        End If

        If Regex.Matches(txtAdmin_primer_nombre.Text, NOMBRE_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Nombre' correctamente!")
            Return False
        End If

        If Regex.Matches(txtAdmin_primer_apellido.Text, NOMBRE_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Apellido' correctamente!")
            Return False
        End If

        If Regex.Matches(txtAdmin_email.Text, EMAIL_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Email' correctamente!")
            Return False
        End If


        'Si ta todo bien ta todo bien
        Return True
    End Function

    Private Sub btnAdmin_Aceptar_Click(sender As Object, e As EventArgs) Handles btnAdmin_Aceptar.Click
        If Not es_modificacion Then
            If validar_inputs() Then
                hacer_consulta(CREAR_ADMIN(txtAdmin_CI.Text, txtAdmin_primer_nombre.Text, txtAdmin_segundo_nombre.Text, txtAdmin_primer_apellido.Text, txtAdmin_segundo_apellido.Text, datepicker_Admin.Value(), txtAdmin_email.Text, rdoAdmin.Checked, True))
                Ventana_Principal.dgv_Admins_Administrativos.Cargar_datos(hacer_consulta(CONSULTA_SELECT_ADMINS_ADMINISTRATIVOS()))
                Me.Dispose()
            End If
        Else
            If validar_inputs() Then
                Preparar_Admin()
                hacer_consulta(MODIFICAR_ADMIN_ADMINISTRATIVO(CI_original, un_admin, True))
                Ventana_Principal.dgv_Admins_Administrativos.Cargar_datos(hacer_consulta(CONSULTA_SELECT_ADMINS_ADMINISTRATIVOS()))
                Me.Dispose()
            End If
        End If

    End Sub
    Private Sub Cerrar_Ventana(sender As Object, e As EventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
    Public Sub Preparar_Ventana_Modificacion(algun_admin As DataGridViewRow)
        Try
            es_modificacion = True
            un_admin = algun_admin
            CI_original = un_admin.Cells("CI").Value()
            txtAdmin_CI.Text = un_admin.Cells("CI").Value()
            txtAdmin_primer_nombre.Text = un_admin.Cells("primer_nombre").Value()
            txtAdmin_segundo_nombre.Text = un_admin.Cells("segundo_nombre").Value()
            txtAdmin_primer_apellido.Text = un_admin.Cells("primer_apellido").Value()
            txtAdmin_segundo_apellido.Text = un_admin.Cells("segundo_apellido").Value()
            txtAdmin_email.Text = un_admin.Cells("email").Value()

            If un_admin.Cells("tipo").Value() = "Administrativo" Then
                rdoAdministrativo.Checked = True
            Else
                rdoAdmin.Checked = True
            End If
            datepicker_Admin.Value = un_admin.Cells("fecha_nacimiento").Value()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Public Sub Preparar_Admin()
        un_admin.Cells("CI").Value = txtAdmin_CI.Text
        un_admin.Cells("primer_nombre").Value = txtAdmin_primer_nombre.Text
        un_admin.Cells("segundo_nombre").Value = txtAdmin_segundo_nombre.Text
        un_admin.Cells("primer_apellido").Value = txtAdmin_primer_apellido.Text
        un_admin.Cells("segundo_apellido").Value = txtAdmin_segundo_apellido.Text
        un_admin.Cells("email").Value = txtAdmin_email.Text
        un_admin.Cells("fecha_nacimiento").Value = datepicker_Admin.Value
    End Sub

    Private Sub ventana_crear_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtAdmin_CI, TipoValidacion.Solo_cedulas)
        Adherir_Validacion(txtAdmin_primer_nombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtAdmin_primer_apellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtAdmin_segundo_nombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtAdmin_segundo_apellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtAdmin_email, TipoValidacion.Solo_Email)
        datepicker_Admin.MaxDate = Date.Now
    End Sub
End Class