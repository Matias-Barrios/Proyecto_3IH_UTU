<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_crear_grupo
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
        Me.btnCrearGrupo_Aceptar = New System.Windows.Forms.Button()
        Me.btnCrearGrupo_Cancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstCrearGrupo_Turno = New System.Windows.Forms.ListBox()
        Me.lstCrearGrupo_Orientacion = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstCrearGrupo_Instituto = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCrearGrupoNombre = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoCI = New System.Windows.Forms.Label()
        Me.lblCrear_alumno_nombre = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCrearGrupo_Aceptar
        '
        Me.btnCrearGrupo_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearGrupo_Aceptar.BackColor = System.Drawing.Color.White
        Me.btnCrearGrupo_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearGrupo_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearGrupo_Aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnCrearGrupo_Aceptar.Location = New System.Drawing.Point(237, 441)
        Me.btnCrearGrupo_Aceptar.Name = "btnCrearGrupo_Aceptar"
        Me.btnCrearGrupo_Aceptar.Size = New System.Drawing.Size(183, 32)
        Me.btnCrearGrupo_Aceptar.TabIndex = 40
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
        Me.btnCrearGrupo_Cancelar.Location = New System.Drawing.Point(8, 441)
        Me.btnCrearGrupo_Cancelar.Name = "btnCrearGrupo_Cancelar"
        Me.btnCrearGrupo_Cancelar.Size = New System.Drawing.Size(183, 32)
        Me.btnCrearGrupo_Cancelar.TabIndex = 39
        Me.btnCrearGrupo_Cancelar.Text = "Cancelar"
        Me.btnCrearGrupo_Cancelar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.lstCrearGrupo_Turno)
        Me.Panel1.Controls.Add(Me.lstCrearGrupo_Orientacion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lstCrearGrupo_Instituto)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblCrear_alumno_nombre)
        Me.Panel1.Location = New System.Drawing.Point(8, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 431)
        Me.Panel1.TabIndex = 38
        '
        'lstCrearGrupo_Turno
        '
        Me.lstCrearGrupo_Turno.FormattingEnabled = True
        Me.lstCrearGrupo_Turno.Items.AddRange(New Object() {"Vespertino", "Matutino", "Nocturno"})
        Me.lstCrearGrupo_Turno.Location = New System.Drawing.Point(191, 63)
        Me.lstCrearGrupo_Turno.Name = "lstCrearGrupo_Turno"
        Me.lstCrearGrupo_Turno.Size = New System.Drawing.Size(190, 43)
        Me.lstCrearGrupo_Turno.TabIndex = 36
        '
        'lstCrearGrupo_Orientacion
        '
        Me.lstCrearGrupo_Orientacion.FormattingEnabled = True
        Me.lstCrearGrupo_Orientacion.Location = New System.Drawing.Point(16, 290)
        Me.lstCrearGrupo_Orientacion.Name = "lstCrearGrupo_Orientacion"
        Me.lstCrearGrupo_Orientacion.Size = New System.Drawing.Size(371, 121)
        Me.lstCrearGrupo_Orientacion.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 24)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Orientacion"
        '
        'lstCrearGrupo_Instituto
        '
        Me.lstCrearGrupo_Instituto.FormattingEnabled = True
        Me.lstCrearGrupo_Instituto.Location = New System.Drawing.Point(16, 139)
        Me.lstCrearGrupo_Instituto.Name = "lstCrearGrupo_Instituto"
        Me.lstCrearGrupo_Instituto.Size = New System.Drawing.Size(371, 108)
        Me.lstCrearGrupo_Instituto.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Instituto"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtCrearGrupoNombre)
        Me.Panel2.Controls.Add(Me.lblCrearAlumnoCI)
        Me.Panel2.Location = New System.Drawing.Point(16, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 42)
        Me.Panel2.TabIndex = 30
        '
        'txtCrearGrupoNombre
        '
        Me.txtCrearGrupoNombre.Location = New System.Drawing.Point(175, 12)
        Me.txtCrearGrupoNombre.MaxLength = 10
        Me.txtCrearGrupoNombre.Name = "txtCrearGrupoNombre"
        Me.txtCrearGrupoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearGrupoNombre.ShortcutsEnabled = False
        Me.txtCrearGrupoNombre.Size = New System.Drawing.Size(190, 20)
        Me.txtCrearGrupoNombre.TabIndex = 31
        '
        'lblCrearAlumnoCI
        '
        Me.lblCrearAlumnoCI.AutoSize = True
        Me.lblCrearAlumnoCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoCI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoCI.Location = New System.Drawing.Point(6, 9)
        Me.lblCrearAlumnoCI.Name = "lblCrearAlumnoCI"
        Me.lblCrearAlumnoCI.Size = New System.Drawing.Size(137, 24)
        Me.lblCrearAlumnoCI.TabIndex = 19
        Me.lblCrearAlumnoCI.Text = "Nombre Grupo"
        '
        'lblCrear_alumno_nombre
        '
        Me.lblCrear_alumno_nombre.AutoSize = True
        Me.lblCrear_alumno_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_alumno_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_alumno_nombre.Location = New System.Drawing.Point(15, 63)
        Me.lblCrear_alumno_nombre.Name = "lblCrear_alumno_nombre"
        Me.lblCrear_alumno_nombre.Size = New System.Drawing.Size(61, 24)
        Me.lblCrear_alumno_nombre.TabIndex = 18
        Me.lblCrear_alumno_nombre.Text = "Turno"
        '
        'ventana_crear_grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(436, 478)
        Me.Controls.Add(Me.btnCrearGrupo_Aceptar)
        Me.Controls.Add(Me.btnCrearGrupo_Cancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ventana_crear_grupo"
        Me.Text = "Crear Grupo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCrearGrupo_Aceptar As Button
    Friend WithEvents btnCrearGrupo_Cancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCrearGrupoNombre As TextBox
    Friend WithEvents lblCrearAlumnoCI As Label
    Friend WithEvents lblCrear_alumno_nombre As Label
    Friend WithEvents lstCrearGrupo_Turno As ListBox
    Friend WithEvents lstCrearGrupo_Orientacion As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstCrearGrupo_Instituto As ListBox
End Class
