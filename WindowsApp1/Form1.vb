Public Class Form1

    Private Class User

        Public Property Name As String

        Public Property Password As String



        Public Sub New(ByVal name As String, ByVal password As String)
            Me.Name = name
            Me.Password = password
        End Sub



    End Class

    Private usersList As New List(Of User)


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usersList.Add(New User("Matias", "Barrios"))
        usersList.Add(New User("Gimena", "Barrios"))
        Button1.Enabled = False

    End Sub

    Public Function Validar(nombre As String, password As String) As Boolean

        For Each user As Object In usersList
            If nombre = user.Name() And password = user.Password() Then
                Return True
            End If
        Next


    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True


        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Validar(Me.TextBox1.Text, Me.TextBox2.Text) Then
            WindowsApp1.Form2.Show()
            Me.Hide()
        Else
            MsgBox("Either your username or your password is incorrect", 0, "Authentication error")
        End If
    End Sub
End Class
