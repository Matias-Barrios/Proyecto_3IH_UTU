Public Class Ventana_Bienvenida
    Private Sub btnIngresarAlSistema_Click(sender As Object, e As EventArgs) Handles btnIngresarAlSistema.Click
        Me.Hide()
        Ventana_Login.ShowDialog()
    End Sub

    Private Sub Ventana_Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar("Driver={IBM INFORMIX ODBC DRIVER};Database=gestion_utu;Host=45.79.7.217;Server=miServidor;Service=50000;Protocol=onsoctcp;UID=" & NOMBRE_USUARIO() & ";PWD=" & CONTRASENIA() & ";Client_Locale=en_US.CP1252;DB_LOCALE=en_US.819;")
        cerrar_conexion()
    End Sub
End Class