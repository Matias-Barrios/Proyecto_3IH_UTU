Module Usuarios
    Public Class User

        Public Property Name As String

        Public Property Password As String



        Public Sub New(ByVal name As String, ByVal password As String)
            Me.Name = name
            Me.Password = password
        End Sub

    End Class

    Public Function Validar(usersList As List(Of User), nombre As String, password As String) As Boolean

        For Each user As Object In usersList
            If nombre = user.Name() And password = user.Password() Then
                Return True
            End If
        Next


    End Function


End Module
