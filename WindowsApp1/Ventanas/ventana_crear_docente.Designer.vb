<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_crear_docente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlCrearDocente = New System.Windows.Forms.Panel()
        Me.nudCrearDocenteGrado = New System.Windows.Forms.NumericUpDown()
        Me.lblCrearDocenteGrado = New System.Windows.Forms.Label()
        Me.pnlCrearDocenteCI = New System.Windows.Forms.Panel()
        Me.txtCrearDocenteCI = New System.Windows.Forms.TextBox()
        Me.lblCrearDocenteCI = New System.Windows.Forms.Label()
        Me.datepickerCrearDocenteFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblCrearDocenteFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtCrearDocenteEmail = New System.Windows.Forms.TextBox()
        Me.lblCrearDocenteEmail = New System.Windows.Forms.Label()
        Me.txtCrearDocenteApellido = New System.Windows.Forms.TextBox()
        Me.txtCrearDocenteNombre = New System.Windows.Forms.TextBox()
        Me.lblCrearDocenteApellido = New System.Windows.Forms.Label()
        Me.lblCrear_docente_nombre = New System.Windows.Forms.Label()
        Me.lblCrear_Docente_Titulo = New WindowsApp1.BorderLabel()
        Me.btnModificar_Usuario_Aceptar = New System.Windows.Forms.Button()
        Me.btnModificarUsuario_Cancelar = New System.Windows.Forms.Button()
        Me.pnlCrearDocente.SuspendLayout()
        CType(Me.nudCrearDocenteGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCrearDocenteCI.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCrearDocente
        '
        Me.pnlCrearDocente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCrearDocente.BackColor = System.Drawing.Color.Gray
        Me.pnlCrearDocente.Controls.Add(Me.nudCrearDocenteGrado)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteGrado)
        Me.pnlCrearDocente.Controls.Add(Me.pnlCrearDocenteCI)
        Me.pnlCrearDocente.Controls.Add(Me.datepickerCrearDocenteFechaNacimiento)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteFechaNacimiento)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocenteEmail)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteEmail)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocenteApellido)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocenteNombre)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteApellido)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrear_docente_nombre)
        Me.pnlCrearDocente.Location = New System.Drawing.Point(12, 52)
        Me.pnlCrearDocente.Name = "pnlCrearDocente"
        Me.pnlCrearDocente.Size = New System.Drawing.Size(438, 271)
        Me.pnlCrearDocente.TabIndex = 25
        '
        'nudCrearDocenteGrado
        '
        Me.nudCrearDocenteGrado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudCrearDocenteGrado.Location = New System.Drawing.Point(200, 218)
        Me.nudCrearDocenteGrado.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.nudCrearDocenteGrado.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCrearDocenteGrado.Name = "nudCrearDocenteGrado"
        Me.nudCrearDocenteGrado.Size = New System.Drawing.Size(144, 20)
        Me.nudCrearDocenteGrado.TabIndex = 32
        Me.nudCrearDocenteGrado.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCrearDocenteGrado
        '
        Me.lblCrearDocenteGrado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrearDocenteGrado.AutoSize = True
        Me.lblCrearDocenteGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteGrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteGrado.Location = New System.Drawing.Point(18, 216)
        Me.lblCrearDocenteGrado.Name = "lblCrearDocenteGrado"
        Me.lblCrearDocenteGrado.Size = New System.Drawing.Size(62, 24)
        Me.lblCrearDocenteGrado.TabIndex = 31
        Me.lblCrearDocenteGrado.Text = "Grado"
        '
        'pnlCrearDocenteCI
        '
        Me.pnlCrearDocenteCI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCrearDocenteCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlCrearDocenteCI.Controls.Add(Me.txtCrearDocenteCI)
        Me.pnlCrearDocenteCI.Controls.Add(Me.lblCrearDocenteCI)
        Me.pnlCrearDocenteCI.Location = New System.Drawing.Point(22, 14)
        Me.pnlCrearDocenteCI.Name = "pnlCrearDocenteCI"
        Me.pnlCrearDocenteCI.Size = New System.Drawing.Size(394, 42)
        Me.pnlCrearDocenteCI.TabIndex = 30
        '
        'txtCrearDocenteCI
        '
        Me.txtCrearDocenteCI.Location = New System.Drawing.Point(178, 13)
        Me.txtCrearDocenteCI.MaxLength = 10
        Me.txtCrearDocenteCI.Name = "txtCrearDocenteCI"
        Me.txtCrearDocenteCI.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocenteCI.ShortcutsEnabled = False
        Me.txtCrearDocenteCI.Size = New System.Drawing.Size(208, 20)
        Me.txtCrearDocenteCI.TabIndex = 31
        '
        'lblCrearDocenteCI
        '
        Me.lblCrearDocenteCI.AutoSize = True
        Me.lblCrearDocenteCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteCI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteCI.Location = New System.Drawing.Point(3, 9)
        Me.lblCrearDocenteCI.Name = "lblCrearDocenteCI"
        Me.lblCrearDocenteCI.Size = New System.Drawing.Size(27, 24)
        Me.lblCrearDocenteCI.TabIndex = 19
        Me.lblCrearDocenteCI.Text = "CI"
        '
        'datepickerCrearDocenteFechaNacimiento
        '
        Me.datepickerCrearDocenteFechaNacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datepickerCrearDocenteFechaNacimiento.Location = New System.Drawing.Point(200, 178)
        Me.datepickerCrearDocenteFechaNacimiento.Name = "datepickerCrearDocenteFechaNacimiento"
        Me.datepickerCrearDocenteFechaNacimiento.Size = New System.Drawing.Size(208, 20)
        Me.datepickerCrearDocenteFechaNacimiento.TabIndex = 29
        '
        'lblCrearDocenteFechaNacimiento
        '
        Me.lblCrearDocenteFechaNacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrearDocenteFechaNacimiento.AutoSize = True
        Me.lblCrearDocenteFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteFechaNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteFechaNacimiento.Location = New System.Drawing.Point(18, 178)
        Me.lblCrearDocenteFechaNacimiento.Name = "lblCrearDocenteFechaNacimiento"
        Me.lblCrearDocenteFechaNacimiento.Size = New System.Drawing.Size(164, 24)
        Me.lblCrearDocenteFechaNacimiento.TabIndex = 28
        Me.lblCrearDocenteFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'txtCrearDocenteEmail
        '
        Me.txtCrearDocenteEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocenteEmail.Location = New System.Drawing.Point(200, 139)
        Me.txtCrearDocenteEmail.MaxLength = 100
        Me.txtCrearDocenteEmail.Name = "txtCrearDocenteEmail"
        Me.txtCrearDocenteEmail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocenteEmail.ShortcutsEnabled = False
        Me.txtCrearDocenteEmail.Size = New System.Drawing.Size(208, 20)
        Me.txtCrearDocenteEmail.TabIndex = 27
        '
        'lblCrearDocenteEmail
        '
        Me.lblCrearDocenteEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrearDocenteEmail.AutoSize = True
        Me.lblCrearDocenteEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteEmail.Location = New System.Drawing.Point(18, 139)
        Me.lblCrearDocenteEmail.Name = "lblCrearDocenteEmail"
        Me.lblCrearDocenteEmail.Size = New System.Drawing.Size(57, 24)
        Me.lblCrearDocenteEmail.TabIndex = 26
        Me.lblCrearDocenteEmail.Text = "Email"
        '
        'txtCrearDocenteApellido
        '
        Me.txtCrearDocenteApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocenteApellido.Location = New System.Drawing.Point(200, 103)
        Me.txtCrearDocenteApellido.MaxLength = 50
        Me.txtCrearDocenteApellido.Name = "txtCrearDocenteApellido"
        Me.txtCrearDocenteApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocenteApellido.ShortcutsEnabled = False
        Me.txtCrearDocenteApellido.Size = New System.Drawing.Size(208, 20)
        Me.txtCrearDocenteApellido.TabIndex = 24
        '
        'txtCrearDocenteNombre
        '
        Me.txtCrearDocenteNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocenteNombre.Location = New System.Drawing.Point(200, 62)
        Me.txtCrearDocenteNombre.MaxLength = 25
        Me.txtCrearDocenteNombre.Name = "txtCrearDocenteNombre"
        Me.txtCrearDocenteNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocenteNombre.ShortcutsEnabled = False
        Me.txtCrearDocenteNombre.Size = New System.Drawing.Size(208, 20)
        Me.txtCrearDocenteNombre.TabIndex = 22
        '
        'lblCrearDocenteApellido
        '
        Me.lblCrearDocenteApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrearDocenteApellido.AutoSize = True
        Me.lblCrearDocenteApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteApellido.Location = New System.Drawing.Point(18, 101)
        Me.lblCrearDocenteApellido.Name = "lblCrearDocenteApellido"
        Me.lblCrearDocenteApellido.Size = New System.Drawing.Size(79, 24)
        Me.lblCrearDocenteApellido.TabIndex = 20
        Me.lblCrearDocenteApellido.Text = "Apellido"
        '
        'lblCrear_docente_nombre
        '
        Me.lblCrear_docente_nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrear_docente_nombre.AutoSize = True
        Me.lblCrear_docente_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_docente_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_docente_nombre.Location = New System.Drawing.Point(18, 62)
        Me.lblCrear_docente_nombre.Name = "lblCrear_docente_nombre"
        Me.lblCrear_docente_nombre.Size = New System.Drawing.Size(84, 24)
        Me.lblCrear_docente_nombre.TabIndex = 18
        Me.lblCrear_docente_nombre.Text = "Nombre "
        '
        'lblCrear_Docente_Titulo
        '
        Me.lblCrear_Docente_Titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrear_Docente_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Docente_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Docente_Titulo.Location = New System.Drawing.Point(17, 9)
        Me.lblCrear_Docente_Titulo.Name = "lblCrear_Docente_Titulo"
        Me.lblCrear_Docente_Titulo.Size = New System.Drawing.Size(340, 40)
        Me.lblCrear_Docente_Titulo.TabIndex = 22
        Me.lblCrear_Docente_Titulo.Text = "Cree un nuevo Docente..."
        '
        'btnModificar_Usuario_Aceptar
        '
        Me.btnModificar_Usuario_Aceptar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar_Usuario_Aceptar.BackColor = System.Drawing.Color.White
        Me.btnModificar_Usuario_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar_Usuario_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar_Usuario_Aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnModificar_Usuario_Aceptar.Location = New System.Drawing.Point(267, 338)
        Me.btnModificar_Usuario_Aceptar.Name = "btnModificar_Usuario_Aceptar"
        Me.btnModificar_Usuario_Aceptar.Size = New System.Drawing.Size(183, 32)
        Me.btnModificar_Usuario_Aceptar.TabIndex = 39
        Me.btnModificar_Usuario_Aceptar.Text = "Aceptar"
        Me.btnModificar_Usuario_Aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar_Usuario_Aceptar.UseVisualStyleBackColor = False
        '
        'btnModificarUsuario_Cancelar
        '
        Me.btnModificarUsuario_Cancelar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificarUsuario_Cancelar.BackColor = System.Drawing.Color.White
        Me.btnModificarUsuario_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarUsuario_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarUsuario_Cancelar.ForeColor = System.Drawing.Color.Red
        Me.btnModificarUsuario_Cancelar.Location = New System.Drawing.Point(12, 338)
        Me.btnModificarUsuario_Cancelar.Name = "btnModificarUsuario_Cancelar"
        Me.btnModificarUsuario_Cancelar.Size = New System.Drawing.Size(183, 32)
        Me.btnModificarUsuario_Cancelar.TabIndex = 38
        Me.btnModificarUsuario_Cancelar.Text = "Cancelar"
        Me.btnModificarUsuario_Cancelar.UseVisualStyleBackColor = False
        '
        'ventana_crear_docente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(472, 398)
        Me.Controls.Add(Me.btnModificar_Usuario_Aceptar)
        Me.Controls.Add(Me.pnlCrearDocente)
        Me.Controls.Add(Me.btnModificarUsuario_Cancelar)
        Me.Controls.Add(Me.lblCrear_Docente_Titulo)
        Me.Location = New System.Drawing.Point(488, 436)
        Me.MaximumSize = New System.Drawing.Size(488, 436)
        Me.Name = "ventana_crear_docente"
        Me.Text = "Crear nuevo docente"
        Me.pnlCrearDocente.ResumeLayout(False)
        Me.pnlCrearDocente.PerformLayout()
        CType(Me.nudCrearDocenteGrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCrearDocenteCI.ResumeLayout(False)
        Me.pnlCrearDocenteCI.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCrearDocente As Panel
    Friend WithEvents pnlCrearDocenteCI As Panel
    Friend WithEvents txtCrearDocenteCI As TextBox
    Friend WithEvents lblCrearDocenteCI As Label
    Friend WithEvents datepickerCrearDocenteFechaNacimiento As DateTimePicker
    Friend WithEvents lblCrearDocenteFechaNacimiento As Label
    Friend WithEvents txtCrearDocenteEmail As TextBox
    Friend WithEvents lblCrearDocenteEmail As Label
    Friend WithEvents txtCrearDocenteApellido As TextBox
    Friend WithEvents txtCrearDocenteNombre As TextBox
    Friend WithEvents lblCrearDocenteApellido As Label
    Friend WithEvents lblCrear_docente_nombre As Label
    Friend WithEvents lblCrear_Docente_Titulo As BorderLabel
    Friend WithEvents nudCrearDocenteGrado As NumericUpDown
    Friend WithEvents lblCrearDocenteGrado As Label
    Friend WithEvents btnModificar_Usuario_Aceptar As Button
    Friend WithEvents btnModificarUsuario_Cancelar As Button
End Class
