<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_modificar_alumno
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdioCrearAlumnoHaceProyecto = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtModificarAlumnoCI = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoCI = New System.Windows.Forms.Label()
        Me.datepickerModificarAlumnoFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblCrearAlumnoFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtModificarAlumnoEmail = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoEmail = New System.Windows.Forms.Label()
        Me.txtModificarAlumnoSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtModificarAlumnoPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtModificarAlumnoSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtModificarAlumnoPrimerNombre = New System.Windows.Forms.TextBox()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblCrearAlumnoPrimerApellido = New System.Windows.Forms.Label()
        Me.lblCrear_Alumno_SegundoNombre = New System.Windows.Forms.Label()
        Me.lblCrear_alumno_primer_nombre = New System.Windows.Forms.Label()
        Me.btnModificarAlumnoCancelar = New System.Windows.Forms.Button()
        Me.btnModificarAlumnoAceptar = New System.Windows.Forms.Button()
        Me.lblCrear_Alumnos_Titulo = New WindowsApp1.BorderLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.rdioCrearAlumnoHaceProyecto)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.datepickerModificarAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.txtModificarAlumnoEmail)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoEmail)
        Me.Panel1.Controls.Add(Me.txtModificarAlumnoSegundoApellido)
        Me.Panel1.Controls.Add(Me.txtModificarAlumnoPrimerApellido)
        Me.Panel1.Controls.Add(Me.txtModificarAlumnoSegundoNombre)
        Me.Panel1.Controls.Add(Me.txtModificarAlumnoPrimerNombre)
        Me.Panel1.Controls.Add(Me.lblSegundoApellido)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoPrimerApellido)
        Me.Panel1.Controls.Add(Me.lblCrear_Alumno_SegundoNombre)
        Me.Panel1.Controls.Add(Me.lblCrear_alumno_primer_nombre)
        Me.Panel1.Location = New System.Drawing.Point(18, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 518)
        Me.Panel1.TabIndex = 25
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(22, 433)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(368, 42)
        Me.Panel3.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(331, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nota final"
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
        Me.Panel2.Controls.Add(Me.txtModificarAlumnoCI)
        Me.Panel2.Controls.Add(Me.lblCrearAlumnoCI)
        Me.Panel2.Location = New System.Drawing.Point(22, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 42)
        Me.Panel2.TabIndex = 30
        '
        'txtModificarAlumnoCI
        '
        Me.txtModificarAlumnoCI.Location = New System.Drawing.Point(175, 12)
        Me.txtModificarAlumnoCI.MaxLength = 10
        Me.txtModificarAlumnoCI.Name = "txtModificarAlumnoCI"
        Me.txtModificarAlumnoCI.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarAlumnoCI.ShortcutsEnabled = False
        Me.txtModificarAlumnoCI.Size = New System.Drawing.Size(190, 20)
        Me.txtModificarAlumnoCI.TabIndex = 31
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
        'datepickerModificarAlumnoFechaNacimiento
        '
        Me.datepickerModificarAlumnoFechaNacimiento.Location = New System.Drawing.Point(197, 290)
        Me.datepickerModificarAlumnoFechaNacimiento.Name = "datepickerModificarAlumnoFechaNacimiento"
        Me.datepickerModificarAlumnoFechaNacimiento.Size = New System.Drawing.Size(193, 20)
        Me.datepickerModificarAlumnoFechaNacimiento.TabIndex = 29
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
        'txtModificarAlumnoEmail
        '
        Me.txtModificarAlumnoEmail.Location = New System.Drawing.Point(197, 251)
        Me.txtModificarAlumnoEmail.MaxLength = 100
        Me.txtModificarAlumnoEmail.Name = "txtModificarAlumnoEmail"
        Me.txtModificarAlumnoEmail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarAlumnoEmail.ShortcutsEnabled = False
        Me.txtModificarAlumnoEmail.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarAlumnoEmail.TabIndex = 27
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
        'txtModificarAlumnoSegundoApellido
        '
        Me.txtModificarAlumnoSegundoApellido.Location = New System.Drawing.Point(197, 175)
        Me.txtModificarAlumnoSegundoApellido.MaxLength = 50
        Me.txtModificarAlumnoSegundoApellido.Name = "txtModificarAlumnoSegundoApellido"
        Me.txtModificarAlumnoSegundoApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarAlumnoSegundoApellido.ShortcutsEnabled = False
        Me.txtModificarAlumnoSegundoApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarAlumnoSegundoApellido.TabIndex = 25
        '
        'txtModificarAlumnoPrimerApellido
        '
        Me.txtModificarAlumnoPrimerApellido.Location = New System.Drawing.Point(197, 137)
        Me.txtModificarAlumnoPrimerApellido.MaxLength = 50
        Me.txtModificarAlumnoPrimerApellido.Name = "txtModificarAlumnoPrimerApellido"
        Me.txtModificarAlumnoPrimerApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarAlumnoPrimerApellido.ShortcutsEnabled = False
        Me.txtModificarAlumnoPrimerApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarAlumnoPrimerApellido.TabIndex = 24
        '
        'txtModificarAlumnoSegundoNombre
        '
        Me.txtModificarAlumnoSegundoNombre.Location = New System.Drawing.Point(197, 97)
        Me.txtModificarAlumnoSegundoNombre.MaxLength = 50
        Me.txtModificarAlumnoSegundoNombre.Name = "txtModificarAlumnoSegundoNombre"
        Me.txtModificarAlumnoSegundoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarAlumnoSegundoNombre.ShortcutsEnabled = False
        Me.txtModificarAlumnoSegundoNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarAlumnoSegundoNombre.TabIndex = 23
        '
        'txtModificarAlumnoPrimerNombre
        '
        Me.txtModificarAlumnoPrimerNombre.Location = New System.Drawing.Point(197, 62)
        Me.txtModificarAlumnoPrimerNombre.MaxLength = 25
        Me.txtModificarAlumnoPrimerNombre.Name = "txtModificarAlumnoPrimerNombre"
        Me.txtModificarAlumnoPrimerNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarAlumnoPrimerNombre.ShortcutsEnabled = False
        Me.txtModificarAlumnoPrimerNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarAlumnoPrimerNombre.TabIndex = 22
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
        'btnModificarAlumnoCancelar
        '
        Me.btnModificarAlumnoCancelar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificarAlumnoCancelar.BackColor = System.Drawing.Color.White
        Me.btnModificarAlumnoCancelar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.cancel
        Me.btnModificarAlumnoCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarAlumnoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarAlumnoCancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarAlumnoCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificarAlumnoCancelar.Location = New System.Drawing.Point(344, 586)
        Me.btnModificarAlumnoCancelar.Name = "btnModificarAlumnoCancelar"
        Me.btnModificarAlumnoCancelar.Size = New System.Drawing.Size(86, 39)
        Me.btnModificarAlumnoCancelar.TabIndex = 24
        Me.btnModificarAlumnoCancelar.UseVisualStyleBackColor = False
        '
        'btnModificarAlumnoAceptar
        '
        Me.btnModificarAlumnoAceptar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificarAlumnoAceptar.BackColor = System.Drawing.Color.White
        Me.btnModificarAlumnoAceptar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.checkmark_filled
        Me.btnModificarAlumnoAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarAlumnoAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarAlumnoAceptar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarAlumnoAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificarAlumnoAceptar.Location = New System.Drawing.Point(18, 586)
        Me.btnModificarAlumnoAceptar.Name = "btnModificarAlumnoAceptar"
        Me.btnModificarAlumnoAceptar.Size = New System.Drawing.Size(86, 39)
        Me.btnModificarAlumnoAceptar.TabIndex = 23
        Me.btnModificarAlumnoAceptar.UseVisualStyleBackColor = False
        '
        'lblCrear_Alumnos_Titulo
        '
        Me.lblCrear_Alumnos_Titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrear_Alumnos_Titulo.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Alumnos_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Alumnos_Titulo.Location = New System.Drawing.Point(17, 8)
        Me.lblCrear_Alumnos_Titulo.Name = "lblCrear_Alumnos_Titulo"
        Me.lblCrear_Alumnos_Titulo.Size = New System.Drawing.Size(388, 36)
        Me.lblCrear_Alumnos_Titulo.TabIndex = 22
        Me.lblCrear_Alumnos_Titulo.Text = "Modificar alumno ..."
        '
        'ventana_modificar_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(447, 632)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnModificarAlumnoCancelar)
        Me.Controls.Add(Me.btnModificarAlumnoAceptar)
        Me.Controls.Add(Me.lblCrear_Alumnos_Titulo)
        Me.MaximumSize = New System.Drawing.Size(463, 671)
        Me.MinimumSize = New System.Drawing.Size(463, 671)
        Me.Name = "ventana_modificar_alumno"
        Me.Text = "Modificar alumno"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdioCrearAlumnoHaceProyecto As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCrearAlumnoCI As Label
    Friend WithEvents datepickerModificarAlumnoFechaNacimiento As DateTimePicker
    Friend WithEvents lblCrearAlumnoFechaNacimiento As Label
    Friend WithEvents txtModificarAlumnoEmail As TextBox
    Friend WithEvents lblCrearAlumnoEmail As Label
    Friend WithEvents txtModificarAlumnoSegundoApellido As TextBox
    Friend WithEvents txtModificarAlumnoPrimerApellido As TextBox
    Friend WithEvents txtModificarAlumnoSegundoNombre As TextBox
    Friend WithEvents txtModificarAlumnoPrimerNombre As TextBox
    Friend WithEvents lblSegundoApellido As Label
    Friend WithEvents lblCrearAlumnoPrimerApellido As Label
    Friend WithEvents lblCrear_Alumno_SegundoNombre As Label
    Friend WithEvents lblCrear_alumno_primer_nombre As Label
    Friend WithEvents btnModificarAlumnoCancelar As Button
    Friend WithEvents btnModificarAlumnoAceptar As Button
    Friend WithEvents lblCrear_Alumnos_Titulo As BorderLabel
    Friend WithEvents txtModificarAlumnoCI As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
