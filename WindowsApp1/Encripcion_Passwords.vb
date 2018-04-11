Imports System.Security.Cryptography
Imports System.Text

Module Encripcion_Passwords
    Public Function Crear_Sal() As String
        'the following is the string that will hold the salt charachters
        Dim set_caracteres As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim sal As String = ""
        Dim aleatorio As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 100 'Length of the salt
            Dim x As Integer = aleatorio.Next(0, set_caracteres.Length - 1)
            sal &= (set_caracteres.Substring(x, 1))
        Next
        Return sal
    End Function
    Public Function Hash512(password As String, sal As String) As String
        Dim pasado_a_bytes As Byte() = Encoding.UTF8.GetBytes(password & sal)
        Dim sha512 As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = sha512.ComputeHash(pasado_a_bytes)
        Dim resultado_hash As String = Convert.ToBase64String(hashBytes)
        Return resultado_hash
    End Function
End Module
