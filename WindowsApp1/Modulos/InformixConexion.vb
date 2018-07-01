Imports System.Data.Odbc

Module InformixConexion
    Dim conexionODBC As New OdbcConnection

    Public Sub conectar(conn_strin As String)
        conexionODBC.ConnectionString = conn_strin
        Try
            conexionODBC.Open()
            Console.WriteLine("Conectado a Informix")
        Catch ex As OdbcException
            MsgBox(ex.ToString())
        End Try

    End Sub

    Public Sub cerrar_conexion()
        Console.WriteLine("Cerrando conexion!")
        conexionODBC.Close()
    End Sub

    Public Function NOMBRE_USUARIO() As String
        Console.WriteLine("USERNAME " & Environment.GetEnvironmentVariable("GESTION_USERNAME") & System.Environment.GetEnvironmentVariable("COMPUTERNAME"))
        Return Environment.GetEnvironmentVariable("GESTION_USERNAME")
    End Function

    Public Function CONTRASENIA() As String
        Return Environment.GetEnvironmentVariable("GESTION_PASSWORD")
    End Function

End Module
