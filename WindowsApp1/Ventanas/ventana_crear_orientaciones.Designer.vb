<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_crear_orientaciones
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_crear_orientaciones_nombre = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoCI = New System.Windows.Forms.Label()
        Me.rch_crear_orientaciones_ = New System.Windows.Forms.RichTextBox()
        Me.lblCrearAsignatura_Descripcion = New System.Windows.Forms.Label()
        Me.btn_crear_grupo_aceptar = New System.Windows.Forms.Button()
        Me.btn_crear_orientacion_cancelar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_crear_orientaciones_nombre)
        Me.Panel2.Controls.Add(Me.lblCrearAlumnoCI)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 42)
        Me.Panel2.TabIndex = 43
        '
        'txt_crear_orientaciones_nombre
        '
        Me.txt_crear_orientaciones_nombre.Location = New System.Drawing.Point(91, 12)
        Me.txt_crear_orientaciones_nombre.MaxLength = 50
        Me.txt_crear_orientaciones_nombre.Name = "txt_crear_orientaciones_nombre"
        Me.txt_crear_orientaciones_nombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_crear_orientaciones_nombre.ShortcutsEnabled = False
        Me.txt_crear_orientaciones_nombre.Size = New System.Drawing.Size(274, 20)
        Me.txt_crear_orientaciones_nombre.TabIndex = 31
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
        'rch_crear_orientaciones_
        '
        Me.rch_crear_orientaciones_.Location = New System.Drawing.Point(16, 105)
        Me.rch_crear_orientaciones_.MaxLength = 500
        Me.rch_crear_orientaciones_.Name = "rch_crear_orientaciones_"
        Me.rch_crear_orientaciones_.Size = New System.Drawing.Size(367, 207)
        Me.rch_crear_orientaciones_.TabIndex = 44
        Me.rch_crear_orientaciones_.Text = ""
        '
        'lblCrearAsignatura_Descripcion
        '
        Me.lblCrearAsignatura_Descripcion.AutoSize = True
        Me.lblCrearAsignatura_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAsignatura_Descripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAsignatura_Descripcion.Location = New System.Drawing.Point(12, 67)
        Me.lblCrearAsignatura_Descripcion.Name = "lblCrearAsignatura_Descripcion"
        Me.lblCrearAsignatura_Descripcion.Size = New System.Drawing.Size(110, 24)
        Me.lblCrearAsignatura_Descripcion.TabIndex = 45
        Me.lblCrearAsignatura_Descripcion.Text = "Descripcion"
        '
        'btn_crear_grupo_aceptar
        '
        Me.btn_crear_grupo_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_crear_grupo_aceptar.BackColor = System.Drawing.Color.White
        Me.btn_crear_grupo_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_crear_grupo_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear_grupo_aceptar.ForeColor = System.Drawing.Color.Green
        Me.btn_crear_grupo_aceptar.Location = New System.Drawing.Point(200, 323)
        Me.btn_crear_grupo_aceptar.Name = "btn_crear_grupo_aceptar"
        Me.btn_crear_grupo_aceptar.Size = New System.Drawing.Size(183, 32)
        Me.btn_crear_grupo_aceptar.TabIndex = 47
        Me.btn_crear_grupo_aceptar.Text = "Aceptar"
        Me.btn_crear_grupo_aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_crear_grupo_aceptar.UseVisualStyleBackColor = False
        '
        'btn_crear_orientacion_cancelar
        '
        Me.btn_crear_orientacion_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_crear_orientacion_cancelar.BackColor = System.Drawing.Color.White
        Me.btn_crear_orientacion_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_crear_orientacion_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear_orientacion_cancelar.ForeColor = System.Drawing.Color.Red
        Me.btn_crear_orientacion_cancelar.Location = New System.Drawing.Point(16, 323)
        Me.btn_crear_orientacion_cancelar.Name = "btn_crear_orientacion_cancelar"
        Me.btn_crear_orientacion_cancelar.Size = New System.Drawing.Size(183, 32)
        Me.btn_crear_orientacion_cancelar.TabIndex = 46
        Me.btn_crear_orientacion_cancelar.Text = "Cancelar"
        Me.btn_crear_orientacion_cancelar.UseVisualStyleBackColor = False
        '
        'ventana_crear_orientaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(399, 367)
        Me.Controls.Add(Me.btn_crear_grupo_aceptar)
        Me.Controls.Add(Me.btn_crear_orientacion_cancelar)
        Me.Controls.Add(Me.rch_crear_orientaciones_)
        Me.Controls.Add(Me.lblCrearAsignatura_Descripcion)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ventana_crear_orientaciones"
        Me.Text = "Crear orientacion"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_crear_orientaciones_nombre As TextBox
    Friend WithEvents lblCrearAlumnoCI As Label
    Friend WithEvents rch_crear_orientaciones_ As RichTextBox
    Friend WithEvents lblCrearAsignatura_Descripcion As Label
    Friend WithEvents btn_crear_grupo_aceptar As Button
    Friend WithEvents btn_crear_orientacion_cancelar As Button
End Class
