Public Class Form1



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
        If Validar(usersList, Me.TextBox1.Text, Me.TextBox2.Text) Then
            WindowsApp1.Form2.Show()
            Me.Hide()
        Else
            MsgBox("Either your username or your password is incorrect", 0, "Authentication error")
        End If
    End Sub
End Class
