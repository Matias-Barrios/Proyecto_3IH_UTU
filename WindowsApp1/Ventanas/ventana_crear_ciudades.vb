Imports System.Text.RegularExpressions

Public Class ventana_crear_ciudades

    Private es_modificacion = False
    Private laCiudad As DataGridViewRow


    Private Sub btnCrearGrupo_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_crear_ciudad_Cancelar.Click
        Me.Dispose()
    End Sub

    Private Sub ventana_crear_ciudades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_crear_ciudad_departamento.SetSelected(1, True)
    End Sub

    Private Sub btnCrearGrupo_Aceptar_Click(sender As Object, e As EventArgs) Handles btnCrearGrupo_Aceptar.Click
        If Not es_modificacion Then
            If validar_inputs() Then
                hacer_consulta(CREAR_CIUDAD(txt_crear_ciudad_nombre.Text, lst_crear_ciudad_departamento.SelectedItem.ToString()))
                Ventana_Principal.dgvP_Ciudades.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_CIUDADES()))
                Me.Dispose()
            End If
        Else
            If validar_inputs() Then
                Preparar_Ciudad()
                hacer_consulta(MODIFICAR_CIUDAD(laCiudad, lst_crear_ciudad_departamento.SelectedItem.ToString()))
                Ventana_Principal.dgvP_Ciudades.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_CIUDADES()))
                Me.Dispose()
            End If
        End If

    End Sub
    Public Sub Preparar_Ciudad()
        laCiudad.Cells("nombre_ciudad").Value = txt_crear_ciudad_nombre.Text
    End Sub
    Private Function validar_inputs()

        If Regex.Matches(txt_crear_ciudad_nombre.Text, CIUDAD_NOMBRE_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Nombre' correctamente! Solo se aceptan letras y espacios")
            Return False
        End If

        'Si ta todo bien ta todo bien
        Return True
    End Function
    Public Sub Preparar_Ventana_Modificacion(ciudad As DataGridViewRow)
        Try
            es_modificacion = True
            laCiudad = ciudad
            txt_crear_ciudad_nombre.Text = ciudad.Cells("nombre_ciudad").Value()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
End Class