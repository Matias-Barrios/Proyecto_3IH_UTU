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
        Me.txtCrearDocenteSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtCrearDocentePrimerNombre = New System.Windows.Forms.TextBox()
        Me.lblCrearDocenteApellido = New System.Windows.Forms.Label()
        Me.lblCrear_docente_nombre = New System.Windows.Forms.Label()
        Me.lblCrear_Docente_Titulo = New WindowsApp1.BorderLabel()
        Me.btnCrearDocente_Aceptar = New System.Windows.Forms.Button()
        Me.btnCrearDocenteCancelar = New System.Windows.Forms.Button()
        Me.txtCrearDocenteSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtCrearDocentePrimerApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlCrearDocente.SuspendLayout()
        CType(Me.nudCrearDocenteGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCrearDocenteCI.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCrearDocente
        '
        Me.pnlCrearDocente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlCrearDocente.BackColor = System.Drawing.Color.Gray
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocenteSegundoApellido)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocentePrimerApellido)
        Me.pnlCrearDocente.Controls.Add(Me.Label1)
        Me.pnlCrearDocente.Controls.Add(Me.Label2)
        Me.pnlCrearDocente.Controls.Add(Me.nudCrearDocenteGrado)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteGrado)
        Me.pnlCrearDocente.Controls.Add(Me.pnlCrearDocenteCI)
        Me.pnlCrearDocente.Controls.Add(Me.datepickerCrearDocenteFechaNacimiento)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteFechaNacimiento)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocenteEmail)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteEmail)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocenteSegundoNombre)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocentePrimerNombre)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteApellido)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrear_docente_nombre)
        Me.pnlCrearDocente.Location = New System.Drawing.Point(12, 42)
        Me.pnlCrearDocente.Name = "pnlCrearDocente"
        Me.pnlCrearDocente.Size = New System.Drawing.Size(438, 383)
        Me.pnlCrearDocente.TabIndex = 25
        '
        'nudCrearDocenteGrado
        '
        Me.nudCrearDocenteGrado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudCrearDocenteGrado.Location = New System.Drawing.Point(200, 277)
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
        Me.lblCrearDocenteGrado.Location = New System.Drawing.Point(18, 275)
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
        Me.txtCrearDocenteCI.MaxLength = 8
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
        Me.datepickerCrearDocenteFechaNacimiento.Location = New System.Drawing.Point(200, 237)
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
        Me.lblCrearDocenteFechaNacimiento.Location = New System.Drawing.Point(18, 237)
        Me.lblCrearDocenteFechaNacimiento.Name = "lblCrearDocenteFechaNacimiento"
        Me.lblCrearDocenteFechaNacimiento.Size = New System.Drawing.Size(164, 24)
        Me.lblCrearDocenteFechaNacimiento.TabIndex = 28
        Me.lblCrearDocenteFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'txtCrearDocenteEmail
        '
        Me.txtCrearDocenteEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocenteEmail.Location = New System.Drawing.Point(200, 198)
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
        Me.lblCrearDocenteEmail.Location = New System.Drawing.Point(18, 198)
        Me.lblCrearDocenteEmail.Name = "lblCrearDocenteEmail"
        Me.lblCrearDocenteEmail.Size = New System.Drawing.Size(57, 24)
        Me.lblCrearDocenteEmail.TabIndex = 26
        Me.lblCrearDocenteEmail.Text = "Email"
        '
        'txtCrearDocenteSegundoNombre
        '
        Me.txtCrearDocenteSegundoNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocenteSegundoNombre.Location = New System.Drawing.Point(200, 91)
        Me.txtCrearDocenteSegundoNombre.MaxLength = 25
        Me.txtCrearDocenteSegundoNombre.Name = "txtCrearDocenteSegundoNombre"
        Me.txtCrearDocenteSegundoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocenteSegundoNombre.ShortcutsEnabled = False
        Me.txtCrearDocenteSegundoNombre.Size = New System.Drawing.Size(208, 20)
        Me.txtCrearDocenteSegundoNombre.TabIndex = 24
        '
        'txtCrearDocentePrimerNombre
        '
        Me.txtCrearDocentePrimerNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocentePrimerNombre.Location = New System.Drawing.Point(200, 62)
        Me.txtCrearDocentePrimerNombre.MaxLength = 25
        Me.txtCrearDocentePrimerNombre.Name = "txtCrearDocentePrimerNombre"
        Me.txtCrearDocentePrimerNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocentePrimerNombre.ShortcutsEnabled = False
        Me.txtCrearDocentePrimerNombre.Size = New System.Drawing.Size(208, 20)
        Me.txtCrearDocentePrimerNombre.TabIndex = 22
        '
        'lblCrearDocenteApellido
        '
        Me.lblCrearDocenteApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrearDocenteApellido.AutoSize = True
        Me.lblCrearDocenteApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteApellido.Location = New System.Drawing.Point(18, 91)
        Me.lblCrearDocenteApellido.Name = "lblCrearDocenteApellido"
        Me.lblCrearDocenteApellido.Size = New System.Drawing.Size(159, 24)
        Me.lblCrearDocenteApellido.TabIndex = 20
        Me.lblCrearDocenteApellido.Text = "Segundo nombre"
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
        Me.lblCrear_docente_nombre.Size = New System.Drawing.Size(136, 24)
        Me.lblCrear_docente_nombre.TabIndex = 18
        Me.lblCrear_docente_nombre.Text = "Primer nombre"
        '
        'lblCrear_Docente_Titulo
        '
        Me.lblCrear_Docente_Titulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrear_Docente_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Docente_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Docente_Titulo.Location = New System.Drawing.Point(16, -1)
        Me.lblCrear_Docente_Titulo.Name = "lblCrear_Docente_Titulo"
        Me.lblCrear_Docente_Titulo.Size = New System.Drawing.Size(340, 40)
        Me.lblCrear_Docente_Titulo.TabIndex = 22
        Me.lblCrear_Docente_Titulo.Text = "Cree un nuevo Docente..."
        '
        'btnCrearDocente_Aceptar
        '
        Me.btnCrearDocente_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearDocente_Aceptar.BackColor = System.Drawing.Color.White
        Me.btnCrearDocente_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearDocente_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearDocente_Aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnCrearDocente_Aceptar.Location = New System.Drawing.Point(267, 433)
        Me.btnCrearDocente_Aceptar.Name = "btnCrearDocente_Aceptar"
        Me.btnCrearDocente_Aceptar.Size = New System.Drawing.Size(183, 32)
        Me.btnCrearDocente_Aceptar.TabIndex = 39
        Me.btnCrearDocente_Aceptar.Text = "Aceptar"
        Me.btnCrearDocente_Aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCrearDocente_Aceptar.UseVisualStyleBackColor = False
        '
        'btnCrearDocenteCancelar
        '
        Me.btnCrearDocenteCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearDocenteCancelar.BackColor = System.Drawing.Color.White
        Me.btnCrearDocenteCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearDocenteCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearDocenteCancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCrearDocenteCancelar.Location = New System.Drawing.Point(12, 431)
        Me.btnCrearDocenteCancelar.Name = "btnCrearDocenteCancelar"
        Me.btnCrearDocenteCancelar.Size = New System.Drawing.Size(183, 32)
        Me.btnCrearDocenteCancelar.TabIndex = 38
        Me.btnCrearDocenteCancelar.Text = "Cancelar"
        Me.btnCrearDocenteCancelar.UseVisualStyleBackColor = False
        '
        'txtCrearDocenteSegundoApellido
        '
        Me.txtCrearDocenteSegundoApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocenteSegundoApellido.Location = New System.Drawing.Point(200, 152)
        Me.txtCrearDocenteSegundoApellido.MaxLength = 25
        Me.txtCrearDocenteSegundoApellido.Name = "txtCrearDocenteSegundoApellido"
        Me.txtCrearDocenteSegundoApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocenteSegundoApellido.ShortcutsEnabled = False
        Me.txtCrearDocenteSegundoApellido.Size = New System.Drawing.Size(208, 20)
        Me.txtCrearDocenteSegundoApellido.TabIndex = 36
        '
        'txtCrearDocentePrimerApellido
        '
        Me.txtCrearDocentePrimerApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocentePrimerApellido.Location = New System.Drawing.Point(200, 122)
        Me.txtCrearDocentePrimerApellido.MaxLength = 25
        Me.txtCrearDocentePrimerApellido.Name = "txtCrearDocentePrimerApellido"
        Me.txtCrearDocentePrimerApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocentePrimerApellido.ShortcutsEnabled = False
        Me.txtCrearDocentePrimerApellido.Size = New System.Drawing.Size(208, 20)
        Me.txtCrearDocentePrimerApellido.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(18, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Segundo apellido"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(18, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Primer apellido"
        '
        'ventana_crear_docente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(472, 486)
        Me.Controls.Add(Me.btnCrearDocente_Aceptar)
        Me.Controls.Add(Me.pnlCrearDocente)
        Me.Controls.Add(Me.btnCrearDocenteCancelar)
        Me.Controls.Add(Me.lblCrear_Docente_Titulo)
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
    Friend WithEvents txtCrearDocenteSegundoNombre As TextBox
    Friend WithEvents txtCrearDocentePrimerNombre As TextBox
    Friend WithEvents lblCrearDocenteApellido As Label
    Friend WithEvents lblCrear_docente_nombre As Label
    Friend WithEvents lblCrear_Docente_Titulo As BorderLabel
    Friend WithEvents nudCrearDocenteGrado As NumericUpDown
    Friend WithEvents lblCrearDocenteGrado As Label
    Friend WithEvents btnCrearDocente_Aceptar As Button
    Friend WithEvents btnCrearDocenteCancelar As Button
    Friend WithEvents txtCrearDocenteSegundoApellido As TextBox
    Friend WithEvents txtCrearDocentePrimerApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
