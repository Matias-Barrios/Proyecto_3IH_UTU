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
        Me.txtModificarDocenteApellido = New System.Windows.Forms.TextBox()
        Me.txtModificarDocenteNombre = New System.Windows.Forms.TextBox()
        Me.lblCrearDocenteApellido = New System.Windows.Forms.Label()
        Me.lblCrear_Docente_nombre = New System.Windows.Forms.Label()
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
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.nudModificarDocenteGrado)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.rdioDocente_BAJA)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.datepickerModificarDocenteFechaNacimiento)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.txtModificarDocenteEmail)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoEmail)
        Me.Panel1.Controls.Add(Me.txtModificarDocenteApellido)
        Me.Panel1.Controls.Add(Me.txtModificarDocenteNombre)
        Me.Panel1.Controls.Add(Me.lblCrearDocenteApellido)
        Me.Panel1.Controls.Add(Me.lblCrear_Docente_nombre)
        Me.Panel1.Location = New System.Drawing.Point(14, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 518)
        Me.Panel1.TabIndex = 29
        '
        'nudModificarDocenteGrado
        '
        Me.nudModificarDocenteGrado.Location = New System.Drawing.Point(197, 141)
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
        Me.Label1.Location = New System.Drawing.Point(18, 141)
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
        Me.rdioDocente_BAJA.Location = New System.Drawing.Point(22, 265)
        Me.rdioDocente_BAJA.Name = "rdioDocente_BAJA"
        Me.rdioDocente_BAJA.Size = New System.Drawing.Size(118, 26)
        Me.rdioDocente_BAJA.TabIndex = 31
        Me.rdioDocente_BAJA.TabStop = True
        Me.rdioDocente_BAJA.Text = "Eliminado"
        Me.rdioDocente_BAJA.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtModificarDocenteCI)
        Me.Panel2.Controls.Add(Me.lblCrearAlumnoCI)
        Me.Panel2.Location = New System.Drawing.Point(22, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(377, 42)
        Me.Panel2.TabIndex = 30
        '
        'txtModificarDocenteCI
        '
        Me.txtModificarDocenteCI.Location = New System.Drawing.Point(175, 12)
        Me.txtModificarDocenteCI.MaxLength = 10
        Me.txtModificarDocenteCI.Name = "txtModificarDocenteCI"
        Me.txtModificarDocenteCI.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarDocenteCI.ShortcutsEnabled = False
        Me.txtModificarDocenteCI.Size = New System.Drawing.Size(193, 20)
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
        Me.datepickerModificarDocenteFechaNacimiento.Location = New System.Drawing.Point(197, 225)
        Me.datepickerModificarDocenteFechaNacimiento.Name = "datepickerModificarDocenteFechaNacimiento"
        Me.datepickerModificarDocenteFechaNacimiento.Size = New System.Drawing.Size(193, 20)
        Me.datepickerModificarDocenteFechaNacimiento.TabIndex = 29
        '
        'lblCrearAlumnoFechaNacimiento
        '
        Me.lblCrearAlumnoFechaNacimiento.AutoSize = True
        Me.lblCrearAlumnoFechaNacimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoFechaNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoFechaNacimiento.Location = New System.Drawing.Point(18, 225)
        Me.lblCrearAlumnoFechaNacimiento.Name = "lblCrearAlumnoFechaNacimiento"
        Me.lblCrearAlumnoFechaNacimiento.Size = New System.Drawing.Size(173, 22)
        Me.lblCrearAlumnoFechaNacimiento.TabIndex = 28
        Me.lblCrearAlumnoFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'txtModificarDocenteEmail
        '
        Me.txtModificarDocenteEmail.Location = New System.Drawing.Point(197, 183)
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
        Me.lblCrearAlumnoEmail.Location = New System.Drawing.Point(18, 183)
        Me.lblCrearAlumnoEmail.Name = "lblCrearAlumnoEmail"
        Me.lblCrearAlumnoEmail.Size = New System.Drawing.Size(61, 22)
        Me.lblCrearAlumnoEmail.TabIndex = 26
        Me.lblCrearAlumnoEmail.Text = "Email"
        '
        'txtModificarDocenteApellido
        '
        Me.txtModificarDocenteApellido.Location = New System.Drawing.Point(197, 100)
        Me.txtModificarDocenteApellido.MaxLength = 50
        Me.txtModificarDocenteApellido.Name = "txtModificarDocenteApellido"
        Me.txtModificarDocenteApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarDocenteApellido.ShortcutsEnabled = False
        Me.txtModificarDocenteApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarDocenteApellido.TabIndex = 24
        '
        'txtModificarDocenteNombre
        '
        Me.txtModificarDocenteNombre.Location = New System.Drawing.Point(197, 62)
        Me.txtModificarDocenteNombre.MaxLength = 25
        Me.txtModificarDocenteNombre.Name = "txtModificarDocenteNombre"
        Me.txtModificarDocenteNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarDocenteNombre.ShortcutsEnabled = False
        Me.txtModificarDocenteNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarDocenteNombre.TabIndex = 22
        '
        'lblCrearDocenteApellido
        '
        Me.lblCrearDocenteApellido.AutoSize = True
        Me.lblCrearDocenteApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDocenteApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearDocenteApellido.Location = New System.Drawing.Point(18, 100)
        Me.lblCrearDocenteApellido.Name = "lblCrearDocenteApellido"
        Me.lblCrearDocenteApellido.Size = New System.Drawing.Size(85, 22)
        Me.lblCrearDocenteApellido.TabIndex = 20
        Me.lblCrearDocenteApellido.Text = "Apellido"
        '
        'lblCrear_Docente_nombre
        '
        Me.lblCrear_Docente_nombre.AutoSize = True
        Me.lblCrear_Docente_nombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Docente_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Docente_nombre.Location = New System.Drawing.Point(18, 62)
        Me.lblCrear_Docente_nombre.Name = "lblCrear_Docente_nombre"
        Me.lblCrear_Docente_nombre.Size = New System.Drawing.Size(83, 22)
        Me.lblCrear_Docente_nombre.TabIndex = 18
        Me.lblCrear_Docente_nombre.Text = "Nombre"
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
        Me.btnModificarDocenteCancelar.Location = New System.Drawing.Point(36, 586)
        Me.btnModificarDocenteCancelar.Name = "btnModificarDocenteCancelar"
        Me.btnModificarDocenteCancelar.Size = New System.Drawing.Size(45, 45)
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
        Me.btnModificarDocenteAceptar.Location = New System.Drawing.Point(356, 586)
        Me.btnModificarDocenteAceptar.Name = "btnModificarDocenteAceptar"
        Me.btnModificarDocenteAceptar.Size = New System.Drawing.Size(45, 45)
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
        Me.BackColor = System.Drawing.Color.Silver
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
    Friend WithEvents txtModificarDocenteApellido As TextBox
    Friend WithEvents txtModificarDocenteNombre As TextBox
    Friend WithEvents lblCrearDocenteApellido As Label
    Friend WithEvents lblCrear_Docente_nombre As Label
    Friend WithEvents btnModificarDocenteCancelar As Button
    Friend WithEvents btnModificarDocenteAceptar As Button
    Friend WithEvents lblCrear_Alumnos_Titulo As BorderLabel
    Friend WithEvents nudModificarDocenteGrado As NumericUpDown
    Friend WithEvents Label1 As Label
End Class
