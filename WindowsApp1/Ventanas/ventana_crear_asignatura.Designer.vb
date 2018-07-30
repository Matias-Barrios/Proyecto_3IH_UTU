<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_crear_asignatura
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
        Me.pnlCrearAsignatura = New System.Windows.Forms.Panel()
        Me.rchCrearAsignatura_Descripcion = New System.Windows.Forms.RichTextBox()
        Me.lblCrearAsignatura_Descripcion = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCrearAsignaturaNombre = New System.Windows.Forms.TextBox()
        Me.lblCrearAsignaturaNombre = New System.Windows.Forms.Label()
        Me.btnCrearAsignaturaAceptar = New System.Windows.Forms.Button()
        Me.btnCrearAsignaturaCancelar = New System.Windows.Forms.Button()
        Me.lblCrear_Asignatura_Titulo = New WindowsApp1.BorderLabel()
        Me.pnlCrearAsignatura.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCrearAsignatura
        '
        Me.pnlCrearAsignatura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCrearAsignatura.BackColor = System.Drawing.Color.Gray
        Me.pnlCrearAsignatura.Controls.Add(Me.rchCrearAsignatura_Descripcion)
        Me.pnlCrearAsignatura.Controls.Add(Me.lblCrearAsignatura_Descripcion)
        Me.pnlCrearAsignatura.Controls.Add(Me.Panel2)
        Me.pnlCrearAsignatura.Location = New System.Drawing.Point(15, 18)
        Me.pnlCrearAsignatura.Name = "pnlCrearAsignatura"
        Me.pnlCrearAsignatura.Size = New System.Drawing.Size(653, 519)
        Me.pnlCrearAsignatura.TabIndex = 25
        '
        'rchCrearAsignatura_Descripcion
        '
        Me.rchCrearAsignatura_Descripcion.Location = New System.Drawing.Point(22, 106)
        Me.rchCrearAsignatura_Descripcion.MaxLength = 500
        Me.rchCrearAsignatura_Descripcion.Name = "rchCrearAsignatura_Descripcion"
        Me.rchCrearAsignatura_Descripcion.Size = New System.Drawing.Size(609, 398)
        Me.rchCrearAsignatura_Descripcion.TabIndex = 33
        Me.rchCrearAsignatura_Descripcion.Text = ""
        '
        'lblCrearAsignatura_Descripcion
        '
        Me.lblCrearAsignatura_Descripcion.AutoSize = True
        Me.lblCrearAsignatura_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAsignatura_Descripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAsignatura_Descripcion.Location = New System.Drawing.Point(18, 73)
        Me.lblCrearAsignatura_Descripcion.Name = "lblCrearAsignatura_Descripcion"
        Me.lblCrearAsignatura_Descripcion.Size = New System.Drawing.Size(110, 24)
        Me.lblCrearAsignatura_Descripcion.TabIndex = 32
        Me.lblCrearAsignatura_Descripcion.Text = "Descripcion"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtCrearAsignaturaNombre)
        Me.Panel2.Controls.Add(Me.lblCrearAsignaturaNombre)
        Me.Panel2.Location = New System.Drawing.Point(22, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(609, 42)
        Me.Panel2.TabIndex = 30
        '
        'txtCrearAsignaturaNombre
        '
        Me.txtCrearAsignaturaNombre.Location = New System.Drawing.Point(98, 12)
        Me.txtCrearAsignaturaNombre.MaxLength = 100
        Me.txtCrearAsignaturaNombre.Name = "txtCrearAsignaturaNombre"
        Me.txtCrearAsignaturaNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAsignaturaNombre.ShortcutsEnabled = False
        Me.txtCrearAsignaturaNombre.Size = New System.Drawing.Size(508, 20)
        Me.txtCrearAsignaturaNombre.TabIndex = 31
        '
        'lblCrearAsignaturaNombre
        '
        Me.lblCrearAsignaturaNombre.AutoSize = True
        Me.lblCrearAsignaturaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAsignaturaNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAsignaturaNombre.Location = New System.Drawing.Point(6, 9)
        Me.lblCrearAsignaturaNombre.Name = "lblCrearAsignaturaNombre"
        Me.lblCrearAsignaturaNombre.Size = New System.Drawing.Size(79, 24)
        Me.lblCrearAsignaturaNombre.TabIndex = 19
        Me.lblCrearAsignaturaNombre.Text = "Nombre"
        '
        'btnCrearAsignaturaAceptar
        '
        Me.btnCrearAsignaturaAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearAsignaturaAceptar.BackColor = System.Drawing.Color.White
        Me.btnCrearAsignaturaAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearAsignaturaAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearAsignaturaAceptar.ForeColor = System.Drawing.Color.Green
        Me.btnCrearAsignaturaAceptar.Location = New System.Drawing.Point(488, 572)
        Me.btnCrearAsignaturaAceptar.Name = "btnCrearAsignaturaAceptar"
        Me.btnCrearAsignaturaAceptar.Size = New System.Drawing.Size(183, 32)
        Me.btnCrearAsignaturaAceptar.TabIndex = 41
        Me.btnCrearAsignaturaAceptar.Text = "Aceptar"
        Me.btnCrearAsignaturaAceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCrearAsignaturaAceptar.UseVisualStyleBackColor = False
        '
        'btnCrearAsignaturaCancelar
        '
        Me.btnCrearAsignaturaCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearAsignaturaCancelar.BackColor = System.Drawing.Color.White
        Me.btnCrearAsignaturaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearAsignaturaCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearAsignaturaCancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCrearAsignaturaCancelar.Location = New System.Drawing.Point(15, 572)
        Me.btnCrearAsignaturaCancelar.Name = "btnCrearAsignaturaCancelar"
        Me.btnCrearAsignaturaCancelar.Size = New System.Drawing.Size(183, 32)
        Me.btnCrearAsignaturaCancelar.TabIndex = 40
        Me.btnCrearAsignaturaCancelar.Text = "Cancelar"
        Me.btnCrearAsignaturaCancelar.UseVisualStyleBackColor = False
        '
        'lblCrear_Asignatura_Titulo
        '
        Me.lblCrear_Asignatura_Titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrear_Asignatura_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Asignatura_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Asignatura_Titulo.Location = New System.Drawing.Point(15, 18)
        Me.lblCrear_Asignatura_Titulo.Name = "lblCrear_Asignatura_Titulo"
        Me.lblCrear_Asignatura_Titulo.Size = New System.Drawing.Size(653, 0)
        Me.lblCrear_Asignatura_Titulo.TabIndex = 22
        Me.lblCrear_Asignatura_Titulo.Text = "Cree una nueva asignatura..."
        '
        'ventana_crear_asignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(683, 619)
        Me.Controls.Add(Me.btnCrearAsignaturaAceptar)
        Me.Controls.Add(Me.pnlCrearAsignatura)
        Me.Controls.Add(Me.btnCrearAsignaturaCancelar)
        Me.Controls.Add(Me.lblCrear_Asignatura_Titulo)
        Me.MaximumSize = New System.Drawing.Size(699, 657)
        Me.MinimumSize = New System.Drawing.Size(699, 657)
        Me.Name = "ventana_crear_asignatura"
        Me.Text = "Crear Asignatura"
        Me.pnlCrearAsignatura.ResumeLayout(False)
        Me.pnlCrearAsignatura.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCrearAsignatura As Panel
    Friend WithEvents rchCrearAsignatura_Descripcion As RichTextBox
    Friend WithEvents lblCrearAsignatura_Descripcion As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCrearAsignaturaNombre As TextBox
    Friend WithEvents lblCrearAsignaturaNombre As Label
    Friend WithEvents lblCrear_Asignatura_Titulo As BorderLabel
    Friend WithEvents btnCrearAsignaturaAceptar As Button
    Friend WithEvents btnCrearAsignaturaCancelar As Button
End Class
