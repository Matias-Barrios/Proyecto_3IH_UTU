Imports System.Data.Odbc
Imports System.Text.RegularExpressions

Module InformixConexion
    Dim conexionODBC As New OdbcConnection

    Public Sub conectar(conn_strin As String)
        conexionODBC.ConnectionString = conn_strin
        Try
            conexionODBC.Open()
            Console.WriteLine("Conectado a Informix")
        Catch ex As OdbcException
            MsgBox("Lo lamento pero la conexion a la BD ha fallado. Autodestruccion en 3...2...1... BOOM! : " & ex.ToString())
            Environment.Exit(6)
        End Try

    End Sub

    Public Sub cerrar_conexion()
        Console.WriteLine("Cerrando conexion!")
        conexionODBC.Close()
    End Sub
    Public Function hacer_consulta(query As String) As DataTable
        Try

            Dim dt As New DataTable()
            Dim da As OdbcDataAdapter = New OdbcDataAdapter(query, conexionODBC)
            da.Fill(dt)

            Return dt
        Catch ex As OdbcException
            MsgBox(PRODUCIDO_EXCEPCION_CONSULTA() & " : " & ex.ToString())



        End Try
        Return New DataTable
    End Function

    Public Function NOMBRE_USUARIO() As String
        Return Environment.GetEnvironmentVariable("GESTION_USERNAME")
    End Function

    Public Function CONTRASENIA() As String
        Return Environment.GetEnvironmentVariable("GESTION_PASSWORD")
    End Function


End Module
