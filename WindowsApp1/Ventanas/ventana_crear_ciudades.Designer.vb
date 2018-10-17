<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_crear_ciudades
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
        Me.lstCrearGrupo_Turno = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_crar_ciudad_nombre = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoCI = New System.Windows.Forms.Label()
        Me.lblCrear_alumno_nombre = New System.Windows.Forms.Label()
        Me.btnCrearGrupo_Aceptar = New System.Windows.Forms.Button()
        Me.btnCrearGrupo_Cancelar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCrearGrupo_Turno
        '
        Me.lstCrearGrupo_Turno.FormattingEnabled = True
        Me.lstCrearGrupo_Turno.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro_Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Montevideo", "Paysandú", "Río_Negro", "Rivera", "Rocha", "Salto", "San_José", "Soriano", "Tacuarembó", "Treinta_y_Tres"})
        Me.lstCrearGrupo_Turno.Location = New System.Drawing.Point(12, 87)
        Me.lstCrearGrupo_Turno.Name = "lstCrearGrupo_Turno"
        Me.lstCrearGrupo_Turno.Size = New System.Drawing.Size(371, 251)
        Me.lstCrearGrupo_Turno.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_crar_ciudad_nombre)
        Me.Panel2.Controls.Add(Me.lblCrearAlumnoCI)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 42)
        Me.Panel2.TabIndex = 42
        '
        'txt_crar_ciudad_nombre
        '
        Me.txt_crar_ciudad_nombre.Location = New System.Drawing.Point(91, 12)
        Me.txt_crar_ciudad_nombre.MaxLength = 10
        Me.txt_crar_ciudad_nombre.Name = "txt_crar_ciudad_nombre"
        Me.txt_crar_ciudad_nombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_crar_ciudad_nombre.ShortcutsEnabled = False
        Me.txt_crar_ciudad_nombre.Size = New System.Drawing.Size(274, 20)
        Me.txt_crar_ciudad_nombre.TabIndex = 31
        '
        'lblCrearAlumnoCI
        '
        Me.lblCrearAlumnoCI.AutoSize = True
        Me.lblCrearAlumnoCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoCI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoCI.Location = New System.Drawing.Point(6, 9)
        Me.lblCrearAlumnoCI.Name = "lblCrearAlumnoCI"
        Me.lblCrearAlumnoCI.Size = New System.Drawing.Size(79, 24)
        Me.lblCrearAlumnoCI.TabIndex = 19
        Me.lblCrearAlumnoCI.Text = "Nombre"
        '
        'lblCrear_alumno_nombre
        '
        Me.lblCrear_alumno_nombre.AutoSize = True
        Me.lblCrear_alumno_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_alumno_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_alumno_nombre.Location = New System.Drawing.Point(11, 60)
        Me.lblCrear_alumno_nombre.Name = "lblCrear_alumno_nombre"
        Me.lblCrear_alumno_nombre.Size = New System.Drawing.Size(61, 24)
        Me.lblCrear_alumno_nombre.TabIndex = 41
        Me.lblCrear_alumno_nombre.Text = "Turno"
        '
        'btnCrearGrupo_Aceptar
        '
        Me.btnCrearGrupo_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearGrupo_Aceptar.BackColor = System.Drawing.Color.White
        Me.btnCrearGrupo_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearGrupo_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearGrupo_Aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnCrearGrupo_Aceptar.Location = New System.Drawing.Point(201, 344)
        Me.btnCrearGrupo_Aceptar.Name = "btnCrearGrupo_Aceptar"
        Me.btnCrearGrupo_Aceptar.Size = New System.Drawing.Size(183, 32)
        Me.btnCrearGrupo_Aceptar.TabIndex = 45
        Me.btnCrearGrupo_Aceptar.Text = "Aceptar"
        Me.btnCrearGrupo_Aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCrearGrupo_Aceptar.UseVisualStyleBackColor = False
        '
        'btnCrearGrupo_Cancelar
        '
        Me.btnCrearGrupo_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearGrupo_Cancelar.BackColor = System.Drawing.Color.White
        Me.btnCrearGrupo_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearGrupo_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearGrupo_Cancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCrearGrupo_Cancelar.Location = New System.Drawing.Point(12, 344)
        Me.btnCrearGrupo_Cancelar.Name = "btnCrearGrupo_Cancelar"
        Me.btnCrearGrupo_Cancelar.Size = New System.Drawing.Size(183, 32)
        Me.btnCrearGrupo_Cancelar.TabIndex = 44
        Me.btnCrearGrupo_Cancelar.Text = "Cancelar"
        Me.btnCrearGrupo_Cancelar.UseVisualStyleBackColor = False
        '
        'ventana_crear_ciudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(388, 381)
        Me.Controls.Add(Me.lstCrearGrupo_Turno)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblCrear_alumno_nombre)
        Me.Controls.Add(Me.btnCrearGrupo_Aceptar)
        Me.Controls.Add(Me.btnCrearGrupo_Cancelar)
        Me.Name = "ventana_crear_ciudades"
        Me.Text = "Crear Ciudad"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCrearGrupo_Turno As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_crar_ciudad_nombre As TextBox
    Friend WithEvents lblCrearAlumnoCI As Label
    Friend WithEvents lblCrear_alumno_nombre As Label
    Friend WithEvents btnCrearGrupo_Aceptar As Button
    Friend WithEvents btnCrearGrupo_Cancelar As Button
End Class
