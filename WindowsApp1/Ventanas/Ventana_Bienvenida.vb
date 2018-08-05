Public Class Ventana_Bienvenida
    Private Sub btnIngresarAlSistema_Click(sender As Object, e As EventArgs) Handles btnIngresarAlSistema.Click
        Me.Hide()
        Ventana_Login.ShowDialog()
    End Sub

    Private Sub Ventana_Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(NOMBRE_USUARIO()) Or String.IsNullOrEmpty(CONTRASENIA()) Then
            MsgBox("Parece que el sistema no puede leer las variables de entorno necesarias para conectarse con Informix. Puede que no hayan sido seteadas.")
            Environment.Exit(8)
        End If

        Try
            conectar("Driver={IBM INFORMIX ODBC DRIVER (64-bit)};Database=gestion_utu;Host=45.79.7.217;Server=miServidor;Service=50000;Protocol=onsoctcp;UID=" & NOMBRE_USUARIO() & ";PWD=" & CONTRASENIA() & ";Client_Locale=en_US.CP1252;DB_LOCALE=en_US.819;")
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
End Class