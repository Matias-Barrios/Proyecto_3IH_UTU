Imports System.Data.Odbc

Module InformixConexion


    Public Function conectar(conn_strin As String) As OdbcConnection
        ' Dim ConnectionString As String = "Host=" + HOST + "; " + "Service=" + SERVICENUM + "; " + "Server=" + SERVER + "; " + "Database=" + DATABASE + "; " + "User Id=" + User + "; " + "Password=" + PASSWORD + "; "
        ' conn_strin = "FileDsn=c:\informix.odbc;UID=admin_proyecto;PWD=tercero2018"
        ' "Database=gestion_utu;Host=45.79.7.217;Server=miServidor;Service=50000;Protocol=onsoctcp;UID=admin_proyecto;Password=tercero2018;"
        Dim conexionODBC As New OdbcConnection
        conexionODBC.ConnectionString = conn_strin
        Try
            conexionODBC.Open()
            Console.WriteLine("Conectado a Informix")
        Catch ex As OdbcException
            MsgBox(ex.ToString())
            Throw ex
        End Try

        Return conexionODBC

    End Function

End Module
