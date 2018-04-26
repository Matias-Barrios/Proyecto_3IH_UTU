<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_crear_alumno
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdioCrearAlumnoHaceProyecto = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCrearAlumnoCI = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoCI = New System.Windows.Forms.Label()
        Me.datepickerCrearAlumnoFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblCrearAlumnoFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtCrearAlumnoEmail = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoEmail = New System.Windows.Forms.Label()
        Me.txtCrearAlumnoSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtCrearAlumnoPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtCrearAlumnoSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtCrearAlumnoPrimerNombre = New System.Windows.Forms.TextBox()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblCrearAlumnoPrimerApellido = New System.Windows.Forms.Label()
        Me.lblCrear_Alumno_SegundoNombre = New System.Windows.Forms.Label()
        Me.lblCrear_alumno_primer_nombre = New System.Windows.Forms.Label()
        Me.btnCrearAlumnoCancelar = New System.Windows.Forms.Button()
        Me.btnCrearAlumnoAceptar = New System.Windows.Forms.Button()
        Me.lblCrear_Alumnos_Titulo = New WindowsApp1.BorderLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel1.Controls.Add(Me.rdioCrearAlumnoHaceProyecto)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.datepickerCrearAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoEmail)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoEmail)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoSegundoApellido)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoPrimerApellido)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoSegundoNombre)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoPrimerNombre)
        Me.Panel1.Controls.Add(Me.lblSegundoApellido)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoPrimerApellido)
        Me.Panel1.Controls.Add(Me.lblCrear_Alumno_SegundoNombre)
        Me.Panel1.Controls.Add(Me.lblCrear_alumno_primer_nombre)
        Me.Panel1.Location = New System.Drawing.Point(21, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 518)
        Me.Panel1.TabIndex = 21
        '
        'rdioCrearAlumnoHaceProyecto
        '
        Me.rdioCrearAlumnoHaceProyecto.AutoSize = True
        Me.rdioCrearAlumnoHaceProyecto.Checked = True
        Me.rdioCrearAlumnoHaceProyecto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.rdioCrearAlumnoHaceProyecto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdioCrearAlumnoHaceProyecto.Location = New System.Drawing.Point(22, 332)
        Me.rdioCrearAlumnoHaceProyecto.Name = "rdioCrearAlumnoHaceProyecto"
        Me.rdioCrearAlumnoHaceProyecto.Size = New System.Drawing.Size(172, 26)
        Me.rdioCrearAlumnoHaceProyecto.TabIndex = 31
        Me.rdioCrearAlumnoHaceProyecto.TabStop = True
        Me.rdioCrearAlumnoHaceProyecto.Text = "Hace proyecto?"
        Me.rdioCrearAlumnoHaceProyecto.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtCrearAlumnoCI)
        Me.Panel2.Controls.Add(Me.lblCrearAlumnoCI)
        Me.Panel2.Location = New System.Drawing.Point(22, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 42)
        Me.Panel2.TabIndex = 30
        '
        'txtCrearAlumnoCI
        '
        Me.txtCrearAlumnoCI.Location = New System.Drawing.Point(175, 12)
        Me.txtCrearAlumnoCI.MaxLength = 10
        Me.txtCrearAlumnoCI.Name = "txtCrearAlumnoCI"
        Me.txtCrearAlumnoCI.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoCI.ShortcutsEnabled = False
        Me.txtCrearAlumnoCI.Size = New System.Drawing.Size(190, 20)
        Me.txtCrearAlumnoCI.TabIndex = 31
        '
        'lblCrearAlumnoCI
        '
        Me.lblCrearAlumnoCI.AutoSize = True
        Me.lblCrearAlumnoCI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoCI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoCI.Location = New System.Drawing.Point(6, 9)
        Me.lblCrearAlumnoCI.Name = "lblCrearAlumnoCI"
        Me.lblCrearAlumnoCI.Size = New System.Drawing.Size(30, 22)
        Me.lblCrearAlumnoCI.TabIndex = 19
        Me.lblCrearAlumnoCI.Text = "CI"
        '
        'datepickerCrearAlumnoFechaNacimiento
        '
        Me.datepickerCrearAlumnoFechaNacimiento.Location = New System.Drawing.Point(197, 290)
        Me.datepickerCrearAlumnoFechaNacimiento.Name = "datepickerCrearAlumnoFechaNacimiento"
        Me.datepickerCrearAlumnoFechaNacimiento.Size = New System.Drawing.Size(193, 20)
        Me.datepickerCrearAlumnoFechaNacimiento.TabIndex = 29
        '
        'lblCrearAlumnoFechaNacimiento
        '
        Me.lblCrearAlumnoFechaNacimiento.AutoSize = True
        Me.lblCrearAlumnoFechaNacimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoFechaNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoFechaNacimiento.Location = New System.Drawing.Point(18, 290)
        Me.lblCrearAlumnoFechaNacimiento.Name = "lblCrearAlumnoFechaNacimiento"
        Me.lblCrearAlumnoFechaNacimiento.Size = New System.Drawing.Size(173, 22)
        Me.lblCrearAlumnoFechaNacimiento.TabIndex = 28
        Me.lblCrearAlumnoFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'txtCrearAlumnoEmail
        '
        Me.txtCrearAlumnoEmail.Location = New System.Drawing.Point(197, 251)
        Me.txtCrearAlumnoEmail.MaxLength = 100
        Me.txtCrearAlumnoEmail.Name = "txtCrearAlumnoEmail"
        Me.txtCrearAlumnoEmail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoEmail.ShortcutsEnabled = False
        Me.txtCrearAlumnoEmail.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearAlumnoEmail.TabIndex = 27
        '
        'lblCrearAlumnoEmail
        '
        Me.lblCrearAlumnoEmail.AutoSize = True
        Me.lblCrearAlumnoEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoEmail.Location = New System.Drawing.Point(18, 251)
        Me.lblCrearAlumnoEmail.Name = "lblCrearAlumnoEmail"
        Me.lblCrearAlumnoEmail.Size = New System.Drawing.Size(61, 22)
        Me.lblCrearAlumnoEmail.TabIndex = 26
        Me.lblCrearAlumnoEmail.Text = "Email"
        '
        'txtCrearAlumnoSegundoApellido
        '
        Me.txtCrearAlumnoSegundoApellido.Location = New System.Drawing.Point(197, 175)
        Me.txtCrearAlumnoSegundoApellido.MaxLength = 50
        Me.txtCrearAlumnoSegundoApellido.Name = "txtCrearAlumnoSegundoApellido"
        Me.txtCrearAlumnoSegundoApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoSegundoApellido.ShortcutsEnabled = False
        Me.txtCrearAlumnoSegundoApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearAlumnoSegundoApellido.TabIndex = 25
        '
        'txtCrearAlumnoPrimerApellido
        '
        Me.txtCrearAlumnoPrimerApellido.Location = New System.Drawing.Point(197, 137)
        Me.txtCrearAlumnoPrimerApellido.MaxLength = 50
        Me.txtCrearAlumnoPrimerApellido.Name = "txtCrearAlumnoPrimerApellido"
        Me.txtCrearAlumnoPrimerApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoPrimerApellido.ShortcutsEnabled = False
        Me.txtCrearAlumnoPrimerApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearAlumnoPrimerApellido.TabIndex = 24
        '
        'txtCrearAlumnoSegundoNombre
        '
        Me.txtCrearAlumnoSegundoNombre.Location = New System.Drawing.Point(197, 97)
        Me.txtCrearAlumnoSegundoNombre.MaxLength = 50
        Me.txtCrearAlumnoSegundoNombre.Name = "txtCrearAlumnoSegundoNombre"
        Me.txtCrearAlumnoSegundoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoSegundoNombre.ShortcutsEnabled = False
        Me.txtCrearAlumnoSegundoNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearAlumnoSegundoNombre.TabIndex = 23
        '
        'txtCrearAlumnoPrimerNombre
        '
        Me.txtCrearAlumnoPrimerNombre.Location = New System.Drawing.Point(197, 62)
        Me.txtCrearAlumnoPrimerNombre.MaxLength = 25
        Me.txtCrearAlumnoPrimerNombre.Name = "txtCrearAlumnoPrimerNombre"
        Me.txtCrearAlumnoPrimerNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoPrimerNombre.ShortcutsEnabled = False
        Me.txtCrearAlumnoPrimerNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearAlumnoPrimerNombre.TabIndex = 22
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSegundoApellido.Location = New System.Drawing.Point(18, 171)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(171, 22)
        Me.lblSegundoApellido.TabIndex = 21
        Me.lblSegundoApellido.Text = "Segundo Apellido"
        '
        'lblCrearAlumnoPrimerApellido
        '
        Me.lblCrearAlumnoPrimerApellido.AutoSize = True
        Me.lblCrearAlumnoPrimerApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoPrimerApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoPrimerApellido.Location = New System.Drawing.Point(18, 133)
        Me.lblCrearAlumnoPrimerApellido.Name = "lblCrearAlumnoPrimerApellido"
        Me.lblCrearAlumnoPrimerApellido.Size = New System.Drawing.Size(152, 22)
        Me.lblCrearAlumnoPrimerApellido.TabIndex = 20
        Me.lblCrearAlumnoPrimerApellido.Text = "Primer Apellido"
        '
        'lblCrear_Alumno_SegundoNombre
        '
        Me.lblCrear_Alumno_SegundoNombre.AutoSize = True
        Me.lblCrear_Alumno_SegundoNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Alumno_SegundoNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Alumno_SegundoNombre.Location = New System.Drawing.Point(18, 97)
        Me.lblCrear_Alumno_SegundoNombre.Name = "lblCrear_Alumno_SegundoNombre"
        Me.lblCrear_Alumno_SegundoNombre.Size = New System.Drawing.Size(171, 22)
        Me.lblCrear_Alumno_SegundoNombre.TabIndex = 19
        Me.lblCrear_Alumno_SegundoNombre.Text = "Segundo nombre "
        '
        'lblCrear_alumno_primer_nombre
        '
        Me.lblCrear_alumno_primer_nombre.AutoSize = True
        Me.lblCrear_alumno_primer_nombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_alumno_primer_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_alumno_primer_nombre.Location = New System.Drawing.Point(18, 62)
        Me.lblCrear_alumno_primer_nombre.Name = "lblCrear_alumno_primer_nombre"
        Me.lblCrear_alumno_primer_nombre.Size = New System.Drawing.Size(152, 22)
        Me.lblCrear_alumno_primer_nombre.TabIndex = 18
        Me.lblCrear_alumno_primer_nombre.Text = "Primer nombre "
        '
        'btnCrearAlumnoCancelar
        '
        Me.btnCrearAlumnoCancelar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrearAlumnoCancelar.BackColor = System.Drawing.Color.White
        Me.btnCrearAlumnoCancelar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.cancel
        Me.btnCrearAlumnoCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrearAlumnoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearAlumnoCancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearAlumnoCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearAlumnoCancelar.Location = New System.Drawing.Point(347, 600)
        Me.btnCrearAlumnoCancelar.Name = "btnCrearAlumnoCancelar"
        Me.btnCrearAlumnoCancelar.Size = New System.Drawing.Size(86, 39)
        Me.btnCrearAlumnoCancelar.TabIndex = 20
        Me.btnCrearAlumnoCancelar.UseVisualStyleBackColor = False
        '
        'btnCrearAlumnoAceptar
        '
        Me.btnCrearAlumnoAceptar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrearAlumnoAceptar.BackColor = System.Drawing.Color.White
        Me.btnCrearAlumnoAceptar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.checkmark_filled
        Me.btnCrearAlumnoAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrearAlumnoAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearAlumnoAceptar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearAlumnoAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearAlumnoAceptar.Location = New System.Drawing.Point(21, 600)
        Me.btnCrearAlumnoAceptar.Name = "btnCrearAlumnoAceptar"
        Me.btnCrearAlumnoAceptar.Size = New System.Drawing.Size(86, 39)
        Me.btnCrearAlumnoAceptar.TabIndex = 19
        Me.btnCrearAlumnoAceptar.UseVisualStyleBackColor = False
        '
        'lblCrear_Alumnos_Titulo
        '
        Me.lblCrear_Alumnos_Titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrear_Alumnos_Titulo.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Alumnos_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Alumnos_Titulo.Location = New System.Drawing.Point(20, 22)
        Me.lblCrear_Alumnos_Titulo.Name = "lblCrear_Alumnos_Titulo"
        Me.lblCrear_Alumnos_Titulo.Size = New System.Drawing.Size(388, 36)
        Me.lblCrear_Alumnos_Titulo.TabIndex = 18
        Me.lblCrear_Alumnos_Titulo.Text = "Cree un nuevo alumno..."
        '
        'ventana_crear_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(449, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCrearAlumnoCancelar)
        Me.Controls.Add(Me.btnCrearAlumnoAceptar)
        Me.Controls.Add(Me.lblCrear_Alumnos_Titulo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(465, 700)
        Me.MinimumSize = New System.Drawing.Size(465, 700)
        Me.Name = "ventana_crear_alumno"
        Me.Text = "Crear nuevo alumno"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdioCrearAlumnoHaceProyecto As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCrearAlumnoCI As TextBox
    Friend WithEvents lblCrearAlumnoCI As Label
    Friend WithEvents datepickerCrearAlumnoFechaNacimiento As DateTimePicker
    Friend WithEvents lblCrearAlumnoFechaNacimiento As Label
    Friend WithEvents txtCrearAlumnoEmail As TextBox
    Friend WithEvents lblCrearAlumnoEmail As Label
    Friend WithEvents txtCrearAlumnoSegundoApellido As TextBox
    Friend WithEvents txtCrearAlumnoPrimerApellido As TextBox
    Friend WithEvents txtCrearAlumnoSegundoNombre As TextBox
    Friend WithEvents txtCrearAlumnoPrimerNombre As TextBox
    Friend WithEvents lblSegundoApellido As Label
    Friend WithEvents lblCrearAlumnoPrimerApellido As Label
    Friend WithEvents lblCrear_Alumno_SegundoNombre As Label
    Friend WithEvents lblCrear_alumno_primer_nombre As Label
    Friend WithEvents btnCrearAlumnoCancelar As Button
    Friend WithEvents btnCrearAlumnoAceptar As Button
    Friend WithEvents lblCrear_Alumnos_Titulo As BorderLabel
End Class
