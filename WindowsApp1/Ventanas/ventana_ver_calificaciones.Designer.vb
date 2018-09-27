<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_ver_calificaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCrear_Usuario_Aceptar = New System.Windows.Forms.Button()
        Me.dgvP_ver_notas_alumno = New WindowsApp1.DGVPaginado()
        Me.lblCrear_Docente_Titulo = New WindowsApp1.BorderLabel()
        Me.lbl_nombre_alumno = New WindowsApp1.BorderLabel()
        Me.SuspendLayout()
        '
        'btnCrear_Usuario_Aceptar
        '
        Me.btnCrear_Usuario_Aceptar.BackColor = System.Drawing.Color.White
        Me.btnCrear_Usuario_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrear_Usuario_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear_Usuario_Aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnCrear_Usuario_Aceptar.Location = New System.Drawing.Point(221, 464)
        Me.btnCrear_Usuario_Aceptar.Name = "btnCrear_Usuario_Aceptar"
        Me.btnCrear_Usuario_Aceptar.Size = New System.Drawing.Size(234, 32)
        Me.btnCrear_Usuario_Aceptar.TabIndex = 35
        Me.btnCrear_Usuario_Aceptar.Text = "Aceptar"
        Me.btnCrear_Usuario_Aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCrear_Usuario_Aceptar.UseVisualStyleBackColor = False
        '
        'dgvP_ver_notas_alumno
        '
        Me.dgvP_ver_notas_alumno.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_ver_notas_alumno.Location = New System.Drawing.Point(18, 90)
        Me.dgvP_ver_notas_alumno.MaximumSize = New System.Drawing.Size(693, 336)
        Me.dgvP_ver_notas_alumno.MinimumSize = New System.Drawing.Size(693, 336)
        Me.dgvP_ver_notas_alumno.Name = "dgvP_ver_notas_alumno"
        Me.dgvP_ver_notas_alumno.Size = New System.Drawing.Size(693, 336)
        Me.dgvP_ver_notas_alumno.TabIndex = 34
        '
        'lblCrear_Docente_Titulo
        '
        Me.lblCrear_Docente_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Docente_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Docente_Titulo.Location = New System.Drawing.Point(12, 7)
        Me.lblCrear_Docente_Titulo.Name = "lblCrear_Docente_Titulo"
        Me.lblCrear_Docente_Titulo.Size = New System.Drawing.Size(324, 40)
        Me.lblCrear_Docente_Titulo.TabIndex = 32
        Me.lblCrear_Docente_Titulo.Text = "Notas por materia de "
        '
        'lbl_nombre_alumno
        '
        Me.lbl_nombre_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_alumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_nombre_alumno.Location = New System.Drawing.Point(19, 47)
        Me.lbl_nombre_alumno.Name = "lbl_nombre_alumno"
        Me.lbl_nombre_alumno.Size = New System.Drawing.Size(693, 40)
        Me.lbl_nombre_alumno.TabIndex = 36
        Me.lbl_nombre_alumno.Text = "[NOMBRE]"
        '
        'ventana_ver_calificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(725, 508)
        Me.Controls.Add(Me.lbl_nombre_alumno)
        Me.Controls.Add(Me.btnCrear_Usuario_Aceptar)
        Me.Controls.Add(Me.dgvP_ver_notas_alumno)
        Me.Controls.Add(Me.lblCrear_Docente_Titulo)
        Me.Name = "ventana_ver_calificaciones"
        Me.Text = "Ver notas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCrear_Usuario_Aceptar As Button
    Friend WithEvents dgvP_ver_notas_alumno As DGVPaginado
    Friend WithEvents lblCrear_Docente_Titulo As BorderLabel
    Friend WithEvents lbl_nombre_alumno As BorderLabel
End Class
