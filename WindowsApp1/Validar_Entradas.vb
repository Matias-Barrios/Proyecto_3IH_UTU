
Imports System.Text.RegularExpressions
Module Validar_Entradas
    Public Enum TipoValidacion
        Solo_numeros = 1
        Solo_caracteres = 2
        No_vacio = 3
        Solo_Email = 4
        Numero_telefono = 5
        Solo_nombres = 6
        Solo_cedulas = 7
        Solo_password = 8
        Solo_username = 9
    End Enum
    Public Sub Adherir_Validacion(ByRef CTRL As Windows.Forms.TextBox, ByVal Validation_Type As TipoValidacion)
        Dim txt As Windows.Forms.TextBox = CTRL
        Select Case Validation_Type
            Case TipoValidacion.Solo_numeros
                AddHandler txt.KeyPress, AddressOf solo_numeros
            Case TipoValidacion.Solo_caracteres
                AddHandler txt.KeyPress, AddressOf solo_characteres
            Case TipoValidacion.Solo_nombres
                AddHandler txt.KeyPress, AddressOf nombres_leave
            Case TipoValidacion.No_vacio
                AddHandler txt.Leave, AddressOf No_vacio
            Case TipoValidacion.Solo_Email
                AddHandler txt.Leave, AddressOf Solo_Email
            Case TipoValidacion.Numero_telefono
                AddHandler txt.KeyPress, AddressOf Numero_telefono
            Case TipoValidacion.Solo_cedulas
                AddHandler txt.KeyPress, AddressOf Solo_cedulas
            Case TipoValidacion.Solo_password
                AddHandler txt.KeyPress, AddressOf Solo_password
            Case TipoValidacion.Solo_username
                AddHandler txt.KeyPress, AddressOf Solo_username
        End Select
    End Sub
    Public Sub solo_numeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub
    Public Sub Solo_cedulas(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not e.KeyChar.ToString() Like "[0-9]" And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If

    End Sub
    Public Sub Solo_username(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not e.KeyChar.ToString() Like "[a-zA-Z0-9]" And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If

    End Sub
    Public Sub Solo_password(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not e.KeyChar.ToString() Like "[a-zA-Z0-9@#_\.-]" And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If

    End Sub
    Public Sub nombres_leave(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not e.KeyChar.ToString() Like "[a-zA-Z ]" And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If

    End Sub
    Public Sub Numero_telefono(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub
    Public Sub solo_characteres(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr("1234567890!@#$%^&*()_+=-", e.KeyChar) > 0 Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub
    Public Sub No_vacio(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim No As Windows.Forms.TextBox = sender
        If No.Text.Trim = "" Then
            MsgBox("Este campo no puede quedar vacio")
            No.Focus()
        End If
    End Sub
    Public Sub Solo_Email(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Email As Windows.Forms.TextBox = sender
        If Email.Text <> "" Then
            Dim rex As Match = Regex.Match(Trim(Email.Text), "^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase)
            If rex.Success = False Then
                MessageBox.Show("Se necesita una direccion de mail valida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Email.BackColor = Color.Red
                Email.Focus()
                Exit Sub
            Else
                Email.BackColor = Color.White
            End If
        End If
    End Sub
End Module
