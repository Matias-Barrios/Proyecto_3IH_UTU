Public Class Ventana_Bienvenida
    Private Sub btnIngresarAlSistema_Click(sender As Object, e As EventArgs) Handles btnIngresarAlSistema.Click
        Me.Hide()
        Ventana_Login.ShowDialog()
    End Sub

    Private Sub Ventana_Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Configuracion(Application.StartupPath & "./conf/conf_nube.json")
        Try
            Console.WriteLine(GET_Configuracion_ODBC())
            conectar(GET_Configuracion_ODBC())
        Catch ex As Exception
            MsgBox("Se produjo un error conectandose a Informix!")
        End Try


    End Sub
    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Seguro que quiere salir?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            cerrar_conexion()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnModoInvitado_Click(sender As Object, e As EventArgs) Handles btnModoInvitado.Click

        Me.Hide()

        Invitado.ShowDialog()

    End Sub
End Class