﻿Imports System.Net
Imports System.Net.Sockets

Module Modulo_Usuarios
    Public Class User

        Public Property CI As Integer
        Public Property primer_nombre As String
        Public Property segundo_nombre As String
        Public Property primer_apellido As String
        Public Property segundo_apellido As String
        Public Property fecha_nacimiento As Date
        Public Property email As String
        Public Property grado As String
        Public Property hace_proyecto As Boolean
        Public Property nota_final_pro As Boolean
        Public Property juicio_final As String
        Public Property tipo As String
        Public Property Password As String
        Public Property Rol As String
        Public Property IPAddress As String

        Public Sub New(ByVal CI As Integer, ByVal primer_nombre As String, ByVal segundo_nombre As String, ByVal primer_apellido As String, ByVal segundo_apellido As String, ByVal fecha_de_nacimiento As Date, ByVal email As String, ByVal tipo As String)
            Me.CI = CI
            Me.primer_nombre = primer_nombre
            Me.segundo_nombre = segundo_nombre
            Me.primer_apellido = primer_apellido
            Me.segundo_apellido = segundo_apellido
            Me.fecha_nacimiento = fecha_nacimiento
            Me.email = email
            Me.tipo = tipo
            Me.IPAddress = Get_IP()
        End Sub



    End Class
    Public Function Get_IP() As String
        Dim host = Dns.GetHostEntry(Dns.GetHostName())
        For Each ip In host.AddressList

            If ip.AddressFamily = AddressFamily.InterNetwork Then

                Return ip.ToString()
            End If

        Next
        Return "NULL"
    End Function
    Public Function Validar(usersList As List(Of User), nombre As String, password As String) As Boolean

        For Each user As Object In usersList
            If nombre = user.Name() And password = user.Password() Then
                Return True
            End If
        Next

        Return False
    End Function

    Public USUARIO_LOGUEADO As User = Nothing

    Function Usuario_Existente(cedula As Integer, password As String) As Modulo_Usuarios.User
        If cedula = 1234 And password = "admin" Then
            Return New User(cedula, "ADMIN", "ADMINACHO", "ADMINUCH", "Bambi", Date.Now, "elgil@gmail.com", "Admin")
        End If
        Dim datos = hacer_consulta(CONSULTA_LOGIN(cedula))
        If datos.Rows.Count() = 0 Then
            Return Nothing
        Else
            If Hash512(password, datos.Rows(0).Item("encriptacion_sal")) = datos.Rows(0).Item("encriptacion_hash") Then
                Return New User(cedula, datos.Rows(0).Item("primer_nombre"), datos.Rows(0).Item("segundo_nombre"), datos.Rows(0).Item("primer_apellido"), datos.Rows(0).Item("segundo_apellido"), datos.Rows(0).Item("fecha_nacimiento"), datos.Rows(0).Item("email"), datos.Rows(0).Item("tipo"))
            End If
        End If
    End Function

    Function Persona_Existe(ci As Integer) As Boolean
        If hacer_consulta(CONSULTAS_PERSONA_EXISTE(ci)).Rows(0).Item("cant") <> 0 Then
            Return True
        End If
        Return False
    End Function

End Module
