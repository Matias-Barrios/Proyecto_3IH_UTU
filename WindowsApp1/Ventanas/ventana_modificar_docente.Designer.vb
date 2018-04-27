<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_modificar_docente
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
        Me.nudModificarDocenteGrado = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdioDocente_BAJA = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtModificarDocenteCI = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoCI = New System.Windows.Forms.Label()
        Me.datepickerModificarDocenteFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblCrearAlumnoFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtModificarDocenteEmail = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoEmail = New System.Windows.Forms.Label()
        Me.txtModificarDocenteSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtModificarDocentePrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtModificarDocenteSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtModificarDocentePrimerNombre = New System.Windows.Forms.TextBox()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblCrearAlumnoPrimerApellido = New System.Windows.Forms.Label()
        Me.lblCrear_Alumno_SegundoNombre = New System.Windows.Forms.Label()
        Me.lblCrear_alumno_primer_nombre = New System.Windows.Forms.Label()
        Me.btnModificarDocenteCancelar = New System.Windows.Forms.Button()
        Me.btnModificarDocenteAceptar = New System.Windows.Forms.Button()
        Me.lblCrear_Alumnos_Titulo = New WindowsApp1.BorderLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.nudModificarDocenteGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel1.Controls.Add(Me.nudModificarDocenteGrado)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.rdioDocente_BAJA)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.datepickerModificarDocenteFechaNacimiento)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.txtModificarDocenteEmail)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoEmail)
        Me.Panel1.Controls.Add(Me.txtModificarDocenteSegundoApellido)
        Me.Panel1.Controls.Add(Me.txtModificarDocentePrimerApellido)
        Me.Panel1.Controls.Add(Me.txtModificarDocenteSegundoNombre)
        Me.Panel1.Controls.Add(Me.txtModificarDocentePrimerNombre)
        Me.Panel1.Controls.Add(Me.lblSegundoApellido)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoPrimerApellido)
        Me.Panel1.Controls.Add(Me.lblCrear_Alumno_SegundoNombre)
        Me.Panel1.Controls.Add(Me.lblCrear_alumno_primer_nombre)
        Me.Panel1.Location = New System.Drawing.Point(14, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 518)
        Me.Panel1.TabIndex = 29
        '
        'nudModificarDocenteGrado
        '
        Me.nudModificarDocenteGrado.Location = New System.Drawing.Point(197, 209)
        Me.nudModificarDocenteGrado.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.nudModificarDocenteGrado.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudModificarDocenteGrado.Name = "nudModificarDocenteGrado"
        Me.nudModificarDocenteGrado.Size = New System.Drawing.Size(193, 20)
        Me.nudModificarDocenteGrado.TabIndex = 33
        Me.nudModificarDocenteGrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudModificarDocenteGrado.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(18, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 22)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Grado"
        '
        'rdioDocente_BAJA
        '
        Me.rdioDocente_BAJA.AutoSize = True
        Me.rdioDocente_BAJA.Checked = True
        Me.rdioDocente_BAJA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.rdioDocente_BAJA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdioDocente_BAJA.Location = New System.Drawing.Point(22, 332)
        Me.rdioDocente_BAJA.Name = "rdioDocente_BAJA"
        Me.rdioDocente_BAJA.Size = New System.Drawing.Size(118, 26)
        Me.rdioDocente_BAJA.TabIndex = 31
        Me.rdioDocente_BAJA.TabStop = True
        Me.rdioDocente_BAJA.Text = "Eliminado"
        Me.rdioDocente_BAJA.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtModificarDocenteCI)
        Me.Panel2.Controls.Add(Me.lblCrearAlumnoCI)
        Me.Panel2.Location = New System.Drawing.Point(22, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 42)
        Me.Panel2.TabIndex = 30
        '
        'txtModificarDocenteCI
        '
        Me.txtModificarDocenteCI.Location = New System.Drawing.Point(175, 12)
        Me.txtModificarDocenteCI.MaxLength = 10
        Me.txtModificarDocenteCI.Name = "txtModificarDocenteCI"
        Me.txtModificarDocenteCI.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarDocenteCI.ShortcutsEnabled = False
        Me.txtModificarDocenteCI.Size = New System.Drawing.Size(190, 20)
        Me.txtModificarDocenteCI.TabIndex = 31
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
        'datepickerModificarDocenteFechaNacimiento
        '
        Me.datepickerModificarDocenteFechaNacimiento.Location = New System.Drawing.Point(197, 290)
        Me.datepickerModificarDocenteFechaNacimiento.Name = "datepickerModificarDocenteFechaNacimiento"
        Me.datepickerModificarDocenteFechaNacimiento.Size = New System.Drawing.Size(193, 20)
        Me.datepickerModificarDocenteFechaNacimiento.TabIndex = 29
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
        'txtModificarDocenteEmail
        '
        Me.txtModificarDocenteEmail.Location = New System.Drawing.Point(197, 251)
        Me.txtModificarDocenteEmail.MaxLength = 100
        Me.txtModificarDocenteEmail.Name = "txtModificarDocenteEmail"
        Me.txtModificarDocenteEmail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarDocenteEmail.ShortcutsEnabled = False
        Me.txtModificarDocenteEmail.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarDocenteEmail.TabIndex = 27
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
        'txtModificarDocenteSegundoApellido
        '
        Me.txtModificarDocenteSegundoApellido.Location = New System.Drawing.Point(197, 175)
        Me.txtModificarDocenteSegundoApellido.MaxLength = 50
        Me.txtModificarDocenteSegundoApellido.Name = "txtModificarDocenteSegundoApellido"
        Me.txtModificarDocenteSegundoApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarDocenteSegundoApellido.ShortcutsEnabled = False
        Me.txtModificarDocenteSegundoApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarDocenteSegundoApellido.TabIndex = 25
        '
        'txtModificarDocentePrimerApellido
        '
        Me.txtModificarDocentePrimerApellido.Location = New System.Drawing.Point(197, 137)
        Me.txtModificarDocentePrimerApellido.MaxLength = 50
        Me.txtModificarDocentePrimerApellido.Name = "txtModificarDocentePrimerApellido"
        Me.txtModificarDocentePrimerApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarDocentePrimerApellido.ShortcutsEnabled = False
        Me.txtModificarDocentePrimerApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarDocentePrimerApellido.TabIndex = 24
        '
        'txtModificarDocenteSegundoNombre
        '
        Me.txtModificarDocenteSegundoNombre.Location = New System.Drawing.Point(197, 97)
        Me.txtModificarDocenteSegundoNombre.MaxLength = 50
        Me.txtModificarDocenteSegundoNombre.Name = "txtModificarDocenteSegundoNombre"
        Me.txtModificarDocenteSegundoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarDocenteSegundoNombre.ShortcutsEnabled = False
        Me.txtModificarDocenteSegundoNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarDocenteSegundoNombre.TabIndex = 23
        '
        'txtModificarDocentePrimerNombre
        '
        Me.txtModificarDocentePrimerNombre.Location = New System.Drawing.Point(197, 62)
        Me.txtModificarDocentePrimerNombre.MaxLength = 25
        Me.txtModificarDocentePrimerNombre.Name = "txtModificarDocentePrimerNombre"
        Me.txtModificarDocentePrimerNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarDocentePrimerNombre.ShortcutsEnabled = False
        Me.txtModificarDocentePrimerNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarDocentePrimerNombre.TabIndex = 22
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
        'btnModificarDocenteCancelar
        '
        Me.btnModificarDocenteCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnModificarDocenteCancelar.BackColor = System.Drawing.Color.White
        Me.btnModificarDocenteCancelar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.cancel
        Me.btnModificarDocenteCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarDocenteCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarDocenteCancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDocenteCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificarDocenteCancelar.Location = New System.Drawing.Point(340, 586)
        Me.btnModificarDocenteCancelar.Name = "btnModificarDocenteCancelar"
        Me.btnModificarDocenteCancelar.Size = New System.Drawing.Size(86, 39)
        Me.btnModificarDocenteCancelar.TabIndex = 28
        Me.btnModificarDocenteCancelar.UseVisualStyleBackColor = False
        '
        'btnModificarDocenteAceptar
        '
        Me.btnModificarDocenteAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnModificarDocenteAceptar.BackColor = System.Drawing.Color.White
        Me.btnModificarDocenteAceptar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.checkmark_filled
        Me.btnModificarDocenteAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarDocenteAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarDocenteAceptar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDocenteAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificarDocenteAceptar.Location = New System.Drawing.Point(14, 586)
        Me.btnModificarDocenteAceptar.Name = "btnModificarDocenteAceptar"
        Me.btnModificarDocenteAceptar.Size = New System.Drawing.Size(86, 39)
        Me.btnModificarDocenteAceptar.TabIndex = 27
        Me.btnModificarDocenteAceptar.UseVisualStyleBackColor = False
        '
        'lblCrear_Alumnos_Titulo
        '
        Me.lblCrear_Alumnos_Titulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrear_Alumnos_Titulo.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Alumnos_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Alumnos_Titulo.Location = New System.Drawing.Point(13, 8)
        Me.lblCrear_Alumnos_Titulo.Name = "lblCrear_Alumnos_Titulo"
        Me.lblCrear_Alumnos_Titulo.Size = New System.Drawing.Size(388, 36)
        Me.lblCrear_Alumnos_Titulo.TabIndex = 26
        Me.lblCrear_Alumnos_Titulo.Text = "Modificar docente ..."
        '
        'ventana_modificar_docente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 633)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnModificarDocenteCancelar)
        Me.Controls.Add(Me.btnModificarDocenteAceptar)
        Me.Controls.Add(Me.lblCrear_Alumnos_Titulo)
        Me.Name = "ventana_modificar_docente"
        Me.Text = "Modificar docente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudModificarDocenteGrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdioDocente_BAJA As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtModificarDocenteCI As TextBox
    Friend WithEvents lblCrearAlumnoCI As Label
    Friend WithEvents datepickerModificarDocenteFechaNacimiento As DateTimePicker
    Friend WithEvents lblCrearAlumnoFechaNacimiento As Label
    Friend WithEvents txtModificarDocenteEmail As TextBox
    Friend WithEvents lblCrearAlumnoEmail As Label
    Friend WithEvents txtModificarDocenteSegundoApellido As TextBox
    Friend WithEvents txtModificarDocentePrimerApellido As TextBox
    Friend WithEvents txtModificarDocenteSegundoNombre As TextBox
    Friend WithEvents txtModificarDocentePrimerNombre As TextBox
    Friend WithEvents lblSegundoApellido As Label
    Friend WithEvents lblCrearAlumnoPrimerApellido As Label
    Friend WithEvents lblCrear_Alumno_SegundoNombre As Label
    Friend WithEvents lblCrear_alumno_primer_nombre As Label
    Friend WithEvents btnModificarDocenteCancelar As Button
    Friend WithEvents btnModificarDocenteAceptar As Button
    Friend WithEvents lblCrear_Alumnos_Titulo As BorderLabel
    Friend WithEvents nudModificarDocenteGrado As NumericUpDown
    Friend WithEvents Label1 As Label
End Class
