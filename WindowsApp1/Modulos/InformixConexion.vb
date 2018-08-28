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
            cerrar_conexion()
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

    Public Function NOMBRE_USUARIO(env_us As String) As String
        Return Environment.GetEnvironmentVariable(env_us)
    End Function

    Public Function CONTRASENIA(env_password) As String
        Return Environment.GetEnvironmentVariable(env_password)
    End Function


End Module
