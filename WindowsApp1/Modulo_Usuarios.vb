Module Modulo_Usuarios
    Public Class User

        Public Property Name As String

        Public Property Password As String
        Public Property Rol As String

        Public Sub New(ByVal name As String, ByVal password As String, ByVal rol As String)
            Me.Name = name
            Me.Password = password
            Me.Rol = rol
        End Sub

    End Class

    Public Function Validar(usersList As List(Of User), nombre As String, password As String) As User

        For Each user As Object In usersList
            If nombre = user.Name() And password = user.Password() Then
                Return user
            End If
        Next

        Throw New UnauthorizedAccessException
    End Function


End Module
