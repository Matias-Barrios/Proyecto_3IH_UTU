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
        Me.pnlCrearDocenteCI = New System.Windows.Forms.Panel()
        Me.txtCrearDocenteCI = New System.Windows.Forms.TextBox()
        Me.lblCrearDocenteCI = New System.Windows.Forms.Label()
        Me.datepickerCrearDocenteFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblCrearDocenteFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtCrearDocenteEmail = New System.Windows.Forms.TextBox()
        Me.lblCrearDocenteEmail = New System.Windows.Forms.Label()
        Me.txtCrearDocenteSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtCrearDocentePrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtCrearDocenteSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtCrearDocentePrimerNombre = New System.Windows.Forms.TextBox()
        Me.lblCrearDocenteSegundoApellido = New System.Windows.Forms.Label()
        Me.lblCrearDocentePrimerApellido = New System.Windows.Forms.Label()
        Me.lblCrear_docente_SegundoNombre = New System.Windows.Forms.Label()
        Me.lblCrear_docente_primer_nombre = New System.Windows.Forms.Label()
        Me.btnCrearDocenteCancelar = New System.Windows.Forms.Button()
        Me.btnCrearDocenteAceptar = New System.Windows.Forms.Button()
        Me.lblCrear_Docente_Titulo = New WindowsApp1.BorderLabel()
        Me.lblCrearDocenteGrado = New System.Windows.Forms.Label()
        Me.nudCrearDocenteGrado = New System.Windows.Forms.NumericUpDown()
        Me.pnlCrearDocente.SuspendLayout()
        Me.pnlCrearDocenteCI.SuspendLayout()
        CType(Me.nudCrearDocenteGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCrearDocente
        '
        Me.pnlCrearDocente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlCrearDocente.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.pnlCrearDocente.Controls.Add(Me.nudCrearDocenteGrado)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteGrado)
        Me.pnlCrearDocente.Controls.Add(Me.pnlCrearDocenteCI)
        Me.pnlCrearDocente.Controls.Add(Me.datepickerCrearDocenteFechaNacimiento)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteFechaNacimiento)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocenteEmail)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteEmail)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocenteSegundoApellido)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocentePrimerApellido)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocenteSegundoNombre)
        Me.pnlCrearDocente.Controls.Add(Me.txtCrearDocentePrimerNombre)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocenteSegundoApellido)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrearDocentePrimerApellido)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrear_docente_SegundoNombre)
        Me.pnlCrearDocente.Controls.Add(Me.lblCrear_docente_primer_nombre)
        Me.pnlCrearDocente.Location = New System.Drawing.Point(27, 63)
        Me.pnlCrearDocente.Name = "pnlCrearDocente"
        Me.pnlCrearDocente.Size = New System.Drawing.Size(423, 518)
        Me.pnlCrearDocente.TabIndex = 25
        '
        'pnlCrearDocenteCI
        '
        Me.pnlCrearDocenteCI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCrearDocenteCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlCrearDocenteCI.Controls.Add(Me.txtCrearDocenteCI)
        Me.pnlCrearDocenteCI.Controls.Add(Me.lblCrearDocenteCI)
        Me.pnlCrearDocenteCI.Location = New System.Drawing.Point(22, 14)
        Me.pnlCrearDocenteCI.Name = "pnlCrearDocenteCI"
        Me.pnlCrearDocenteCI.Size = New System.Drawing.Size(368, 42)
        Me.pnlCrearDocenteCI.TabIndex = 30
        '
        'txtCrearDocenteCI
        '
        Me.txtCrearDocenteCI.Location = New System.Drawing.Point(175, 12)
        Me.txtCrearDocenteCI.MaxLength = 10
        Me.txtCrearDocenteCI.Name = "txtCrearDocenteCI"
        Me.txtCrearDocenteCI.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocenteCI.ShortcutsEnabled = False
        Me.txtCrearDocenteCI.Size = New System.Drawing.Size(190, 20)
        Me.txtCrearDocenteCI.TabIndex = 31
        '
        'lblCrearDocenteCI
        '
        Me.lblCrearDocenteCI.AutoSize = True
        Me.lblCrearDocenteCI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteCI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteCI.Location = New System.Drawing.Point(6, 9)
        Me.lblCrearDocenteCI.Name = "lblCrearDocenteCI"
        Me.lblCrearDocenteCI.Size = New System.Drawing.Size(30, 22)
        Me.lblCrearDocenteCI.TabIndex = 19
        Me.lblCrearDocenteCI.Text = "CI"
        '
        'datepickerCrearDocenteFechaNacimiento
        '
        Me.datepickerCrearDocenteFechaNacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datepickerCrearDocenteFechaNacimiento.Location = New System.Drawing.Point(197, 290)
        Me.datepickerCrearDocenteFechaNacimiento.Name = "datepickerCrearDocenteFechaNacimiento"
        Me.datepickerCrearDocenteFechaNacimiento.Size = New System.Drawing.Size(193, 20)
        Me.datepickerCrearDocenteFechaNacimiento.TabIndex = 29
        '
        'lblCrearDocenteFechaNacimiento
        '
        Me.lblCrearDocenteFechaNacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrearDocenteFechaNacimiento.AutoSize = True
        Me.lblCrearDocenteFechaNacimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteFechaNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteFechaNacimiento.Location = New System.Drawing.Point(18, 290)
        Me.lblCrearDocenteFechaNacimiento.Name = "lblCrearDocenteFechaNacimiento"
        Me.lblCrearDocenteFechaNacimiento.Size = New System.Drawing.Size(173, 22)
        Me.lblCrearDocenteFechaNacimiento.TabIndex = 28
        Me.lblCrearDocenteFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'txtCrearDocenteEmail
        '
        Me.txtCrearDocenteEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocenteEmail.Location = New System.Drawing.Point(197, 251)
        Me.txtCrearDocenteEmail.MaxLength = 100
        Me.txtCrearDocenteEmail.Name = "txtCrearDocenteEmail"
        Me.txtCrearDocenteEmail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocenteEmail.ShortcutsEnabled = False
        Me.txtCrearDocenteEmail.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearDocenteEmail.TabIndex = 27
        '
        'lblCrearDocenteEmail
        '
        Me.lblCrearDocenteEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrearDocenteEmail.AutoSize = True
        Me.lblCrearDocenteEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteEmail.Location = New System.Drawing.Point(18, 251)
        Me.lblCrearDocenteEmail.Name = "lblCrearDocenteEmail"
        Me.lblCrearDocenteEmail.Size = New System.Drawing.Size(61, 22)
        Me.lblCrearDocenteEmail.TabIndex = 26
        Me.lblCrearDocenteEmail.Text = "Email"
        '
        'txtCrearDocenteSegundoApellido
        '
        Me.txtCrearDocenteSegundoApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocenteSegundoApellido.Location = New System.Drawing.Point(197, 175)
        Me.txtCrearDocenteSegundoApellido.MaxLength = 50
        Me.txtCrearDocenteSegundoApellido.Name = "txtCrearDocenteSegundoApellido"
        Me.txtCrearDocenteSegundoApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocenteSegundoApellido.ShortcutsEnabled = False
        Me.txtCrearDocenteSegundoApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearDocenteSegundoApellido.TabIndex = 25
        '
        'txtCrearDocentePrimerApellido
        '
        Me.txtCrearDocentePrimerApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocentePrimerApellido.Location = New System.Drawing.Point(197, 137)
        Me.txtCrearDocentePrimerApellido.MaxLength = 50
        Me.txtCrearDocentePrimerApellido.Name = "txtCrearDocentePrimerApellido"
        Me.txtCrearDocentePrimerApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocentePrimerApellido.ShortcutsEnabled = False
        Me.txtCrearDocentePrimerApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearDocentePrimerApellido.TabIndex = 24
        '
        'txtCrearDocenteSegundoNombre
        '
        Me.txtCrearDocenteSegundoNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocenteSegundoNombre.Location = New System.Drawing.Point(197, 97)
        Me.txtCrearDocenteSegundoNombre.MaxLength = 50
        Me.txtCrearDocenteSegundoNombre.Name = "txtCrearDocenteSegundoNombre"
        Me.txtCrearDocenteSegundoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocenteSegundoNombre.ShortcutsEnabled = False
        Me.txtCrearDocenteSegundoNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearDocenteSegundoNombre.TabIndex = 23
        '
        'txtCrearDocentePrimerNombre
        '
        Me.txtCrearDocentePrimerNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCrearDocentePrimerNombre.Location = New System.Drawing.Point(197, 62)
        Me.txtCrearDocentePrimerNombre.MaxLength = 25
        Me.txtCrearDocentePrimerNombre.Name = "txtCrearDocentePrimerNombre"
        Me.txtCrearDocentePrimerNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearDocentePrimerNombre.ShortcutsEnabled = False
        Me.txtCrearDocentePrimerNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearDocentePrimerNombre.TabIndex = 22
        '
        'lblCrearDocenteSegundoApellido
        '
        Me.lblCrearDocenteSegundoApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrearDocenteSegundoApellido.AutoSize = True
        Me.lblCrearDocenteSegundoApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteSegundoApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteSegundoApellido.Location = New System.Drawing.Point(18, 171)
        Me.lblCrearDocenteSegundoApellido.Name = "lblCrearDocenteSegundoApellido"
        Me.lblCrearDocenteSegundoApellido.Size = New System.Drawing.Size(171, 22)
        Me.lblCrearDocenteSegundoApellido.TabIndex = 21
        Me.lblCrearDocenteSegundoApellido.Text = "Segundo Apellido"
        '
        'lblCrearDocentePrimerApellido
        '
        Me.lblCrearDocentePrimerApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrearDocentePrimerApellido.AutoSize = True
        Me.lblCrearDocentePrimerApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocentePrimerApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocentePrimerApellido.Location = New System.Drawing.Point(18, 133)
        Me.lblCrearDocentePrimerApellido.Name = "lblCrearDocentePrimerApellido"
        Me.lblCrearDocentePrimerApellido.Size = New System.Drawing.Size(152, 22)
        Me.lblCrearDocentePrimerApellido.TabIndex = 20
        Me.lblCrearDocentePrimerApellido.Text = "Primer Apellido"
        '
        'lblCrear_docente_SegundoNombre
        '
        Me.lblCrear_docente_SegundoNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrear_docente_SegundoNombre.AutoSize = True
        Me.lblCrear_docente_SegundoNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_docente_SegundoNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_docente_SegundoNombre.Location = New System.Drawing.Point(18, 97)
        Me.lblCrear_docente_SegundoNombre.Name = "lblCrear_docente_SegundoNombre"
        Me.lblCrear_docente_SegundoNombre.Size = New System.Drawing.Size(171, 22)
        Me.lblCrear_docente_SegundoNombre.TabIndex = 19
        Me.lblCrear_docente_SegundoNombre.Text = "Segundo nombre "
        '
        'lblCrear_docente_primer_nombre
        '
        Me.lblCrear_docente_primer_nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrear_docente_primer_nombre.AutoSize = True
        Me.lblCrear_docente_primer_nombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_docente_primer_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_docente_primer_nombre.Location = New System.Drawing.Point(18, 62)
        Me.lblCrear_docente_primer_nombre.Name = "lblCrear_docente_primer_nombre"
        Me.lblCrear_docente_primer_nombre.Size = New System.Drawing.Size(152, 22)
        Me.lblCrear_docente_primer_nombre.TabIndex = 18
        Me.lblCrear_docente_primer_nombre.Text = "Primer nombre "
        '
        'btnCrearDocenteCancelar
        '
        Me.btnCrearDocenteCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearDocenteCancelar.BackColor = System.Drawing.Color.White
        Me.btnCrearDocenteCancelar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.cancel
        Me.btnCrearDocenteCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrearDocenteCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearDocenteCancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearDocenteCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearDocenteCancelar.Location = New System.Drawing.Point(356, 588)
        Me.btnCrearDocenteCancelar.Name = "btnCrearDocenteCancelar"
        Me.btnCrearDocenteCancelar.Size = New System.Drawing.Size(94, 39)
        Me.btnCrearDocenteCancelar.TabIndex = 24
        Me.btnCrearDocenteCancelar.UseVisualStyleBackColor = False
        '
        'btnCrearDocenteAceptar
        '
        Me.btnCrearDocenteAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearDocenteAceptar.BackColor = System.Drawing.Color.White
        Me.btnCrearDocenteAceptar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.checkmark_filled
        Me.btnCrearDocenteAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrearDocenteAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearDocenteAceptar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearDocenteAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearDocenteAceptar.Location = New System.Drawing.Point(27, 590)
        Me.btnCrearDocenteAceptar.Name = "btnCrearDocenteAceptar"
        Me.btnCrearDocenteAceptar.Size = New System.Drawing.Size(94, 39)
        Me.btnCrearDocenteAceptar.TabIndex = 23
        Me.btnCrearDocenteAceptar.UseVisualStyleBackColor = False
        '
        'lblCrear_Docente_Titulo
        '
        Me.lblCrear_Docente_Titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrear_Docente_Titulo.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Docente_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Docente_Titulo.Location = New System.Drawing.Point(54, 9)
        Me.lblCrear_Docente_Titulo.Name = "lblCrear_Docente_Titulo"
        Me.lblCrear_Docente_Titulo.Size = New System.Drawing.Size(339, 36)
        Me.lblCrear_Docente_Titulo.TabIndex = 22
        Me.lblCrear_Docente_Titulo.Text = "Cree un nuevo docente..."
        '
        'lblCrearDocenteGrado
        '
        Me.lblCrearDocenteGrado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrearDocenteGrado.AutoSize = True
        Me.lblCrearDocenteGrado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteGrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteGrado.Location = New System.Drawing.Point(18, 343)
        Me.lblCrearDocenteGrado.Name = "lblCrearDocenteGrado"
        Me.lblCrearDocenteGrado.Size = New System.Drawing.Size(67, 22)
        Me.lblCrearDocenteGrado.TabIndex = 31
        Me.lblCrearDocenteGrado.Text = "Grado"
        '
        'nudCrearDocenteGrado
        '
        Me.nudCrearDocenteGrado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudCrearDocenteGrado.Location = New System.Drawing.Point(197, 345)
        Me.nudCrearDocenteGrado.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.nudCrearDocenteGrado.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCrearDocenteGrado.Name = "nudCrearDocenteGrado"
        Me.nudCrearDocenteGrado.Size = New System.Drawing.Size(129, 20)
        Me.nudCrearDocenteGrado.TabIndex = 32
        Me.nudCrearDocenteGrado.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ventana_crear_docente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 635)
        Me.Controls.Add(Me.pnlCrearDocente)
        Me.Controls.Add(Me.btnCrearDocenteCancelar)
        Me.Controls.Add(Me.btnCrearDocenteAceptar)
        Me.Controls.Add(Me.lblCrear_Docente_Titulo)
        Me.MaximumSize = New System.Drawing.Size(487, 674)
        Me.MinimumSize = New System.Drawing.Size(487, 674)
        Me.Name = "ventana_crear_docente"
        Me.Text = "Crear nuevo docente"
        Me.pnlCrearDocente.ResumeLayout(False)
        Me.pnlCrearDocente.PerformLayout()
        Me.pnlCrearDocenteCI.ResumeLayout(False)
        Me.pnlCrearDocenteCI.PerformLayout()
        CType(Me.nudCrearDocenteGrado, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtCrearDocenteSegundoApellido As TextBox
    Friend WithEvents txtCrearDocentePrimerApellido As TextBox
    Friend WithEvents txtCrearDocenteSegundoNombre As TextBox
    Friend WithEvents txtCrearDocentePrimerNombre As TextBox
    Friend WithEvents lblCrearDocenteSegundoApellido As Label
    Friend WithEvents lblCrearDocentePrimerApellido As Label
    Friend WithEvents lblCrear_docente_SegundoNombre As Label
    Friend WithEvents lblCrear_docente_primer_nombre As Label
    Friend WithEvents btnCrearDocenteCancelar As Button
    Friend WithEvents btnCrearDocenteAceptar As Button
    Friend WithEvents lblCrear_Docente_Titulo As BorderLabel
    Friend WithEvents nudCrearDocenteGrado As NumericUpDown
    Friend WithEvents lblCrearDocenteGrado As Label
End Class
