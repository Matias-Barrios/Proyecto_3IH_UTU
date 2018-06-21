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
        Me.txtCrearAlumnoApellido = New System.Windows.Forms.TextBox()
        Me.txtCrearAlumnoNombre = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoApellido = New System.Windows.Forms.Label()
        Me.lblCrear_alumno_nombre = New System.Windows.Forms.Label()
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
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.rdioCrearAlumnoHaceProyecto)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.datepickerCrearAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoEmail)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoEmail)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoApellido)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoNombre)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoApellido)
        Me.Panel1.Controls.Add(Me.lblCrear_alumno_nombre)
        Me.Panel1.Location = New System.Drawing.Point(21, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 518)
        Me.Panel1.TabIndex = 21
        '
        'rdioCrearAlumnoHaceProyecto
        '
        Me.rdioCrearAlumnoHaceProyecto.AutoSize = True
        Me.rdioCrearAlumnoHaceProyecto.Checked = True
        Me.rdioCrearAlumnoHaceProyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.rdioCrearAlumnoHaceProyecto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdioCrearAlumnoHaceProyecto.Location = New System.Drawing.Point(19, 223)
        Me.rdioCrearAlumnoHaceProyecto.Name = "rdioCrearAlumnoHaceProyecto"
        Me.rdioCrearAlumnoHaceProyecto.Size = New System.Drawing.Size(161, 28)
        Me.rdioCrearAlumnoHaceProyecto.TabIndex = 31
        Me.rdioCrearAlumnoHaceProyecto.TabStop = True
        Me.rdioCrearAlumnoHaceProyecto.Text = "Hace proyecto?"
        Me.rdioCrearAlumnoHaceProyecto.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.lblCrearAlumnoCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoCI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoCI.Location = New System.Drawing.Point(6, 9)
        Me.lblCrearAlumnoCI.Name = "lblCrearAlumnoCI"
        Me.lblCrearAlumnoCI.Size = New System.Drawing.Size(27, 24)
        Me.lblCrearAlumnoCI.TabIndex = 19
        Me.lblCrearAlumnoCI.Text = "CI"
        '
        'datepickerCrearAlumnoFechaNacimiento
        '
        Me.datepickerCrearAlumnoFechaNacimiento.Location = New System.Drawing.Point(197, 178)
        Me.datepickerCrearAlumnoFechaNacimiento.Name = "datepickerCrearAlumnoFechaNacimiento"
        Me.datepickerCrearAlumnoFechaNacimiento.Size = New System.Drawing.Size(193, 20)
        Me.datepickerCrearAlumnoFechaNacimiento.TabIndex = 29
        '
        'lblCrearAlumnoFechaNacimiento
        '
        Me.lblCrearAlumnoFechaNacimiento.AutoSize = True
        Me.lblCrearAlumnoFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoFechaNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoFechaNacimiento.Location = New System.Drawing.Point(18, 178)
        Me.lblCrearAlumnoFechaNacimiento.Name = "lblCrearAlumnoFechaNacimiento"
        Me.lblCrearAlumnoFechaNacimiento.Size = New System.Drawing.Size(164, 24)
        Me.lblCrearAlumnoFechaNacimiento.TabIndex = 28
        Me.lblCrearAlumnoFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'txtCrearAlumnoEmail
        '
        Me.txtCrearAlumnoEmail.Location = New System.Drawing.Point(197, 139)
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
        Me.lblCrearAlumnoEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoEmail.Location = New System.Drawing.Point(18, 137)
        Me.lblCrearAlumnoEmail.Name = "lblCrearAlumnoEmail"
        Me.lblCrearAlumnoEmail.Size = New System.Drawing.Size(57, 24)
        Me.lblCrearAlumnoEmail.TabIndex = 26
        Me.lblCrearAlumnoEmail.Text = "Email"
        '
        'txtCrearAlumnoApellido
        '
        Me.txtCrearAlumnoApellido.Location = New System.Drawing.Point(197, 100)
        Me.txtCrearAlumnoApellido.MaxLength = 50
        Me.txtCrearAlumnoApellido.Name = "txtCrearAlumnoApellido"
        Me.txtCrearAlumnoApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoApellido.ShortcutsEnabled = False
        Me.txtCrearAlumnoApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearAlumnoApellido.TabIndex = 24
        '
        'txtCrearAlumnoNombre
        '
        Me.txtCrearAlumnoNombre.Location = New System.Drawing.Point(197, 62)
        Me.txtCrearAlumnoNombre.MaxLength = 25
        Me.txtCrearAlumnoNombre.Name = "txtCrearAlumnoNombre"
        Me.txtCrearAlumnoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoNombre.ShortcutsEnabled = False
        Me.txtCrearAlumnoNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearAlumnoNombre.TabIndex = 22
        '
        'lblCrearAlumnoApellido
        '
        Me.lblCrearAlumnoApellido.AutoSize = True
        Me.lblCrearAlumnoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoApellido.Location = New System.Drawing.Point(18, 100)
        Me.lblCrearAlumnoApellido.Name = "lblCrearAlumnoApellido"
        Me.lblCrearAlumnoApellido.Size = New System.Drawing.Size(79, 24)
        Me.lblCrearAlumnoApellido.TabIndex = 20
        Me.lblCrearAlumnoApellido.Text = "Apellido"
        '
        'lblCrear_alumno_nombre
        '
        Me.lblCrear_alumno_nombre.AutoSize = True
        Me.lblCrear_alumno_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_alumno_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_alumno_nombre.Location = New System.Drawing.Point(18, 62)
        Me.lblCrear_alumno_nombre.Name = "lblCrear_alumno_nombre"
        Me.lblCrear_alumno_nombre.Size = New System.Drawing.Size(79, 24)
        Me.lblCrear_alumno_nombre.TabIndex = 18
        Me.lblCrear_alumno_nombre.Text = "Nombre"
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
        Me.btnCrearAlumnoCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearAlumnoCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearAlumnoCancelar.Location = New System.Drawing.Point(21, 600)
        Me.btnCrearAlumnoCancelar.Name = "btnCrearAlumnoCancelar"
        Me.btnCrearAlumnoCancelar.Size = New System.Drawing.Size(45, 45)
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
        Me.btnCrearAlumnoAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearAlumnoAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearAlumnoAceptar.Location = New System.Drawing.Point(388, 600)
        Me.btnCrearAlumnoAceptar.Name = "btnCrearAlumnoAceptar"
        Me.btnCrearAlumnoAceptar.Size = New System.Drawing.Size(45, 45)
        Me.btnCrearAlumnoAceptar.TabIndex = 19
        Me.btnCrearAlumnoAceptar.UseVisualStyleBackColor = False
        '
        'lblCrear_Alumnos_Titulo
        '
        Me.lblCrear_Alumnos_Titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCrear_Alumnos_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Alumnos_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Alumnos_Titulo.Location = New System.Drawing.Point(20, 22)
        Me.lblCrear_Alumnos_Titulo.Name = "lblCrear_Alumnos_Titulo"
        Me.lblCrear_Alumnos_Titulo.Size = New System.Drawing.Size(388, 36)
        Me.lblCrear_Alumnos_Titulo.TabIndex = 18
        Me.lblCrear_Alumnos_Titulo.Text = "Cree un nuevo Alumno..."
        '
        'ventana_crear_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(449, 662)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCrearAlumnoCancelar)
        Me.Controls.Add(Me.btnCrearAlumnoAceptar)
        Me.Controls.Add(Me.lblCrear_Alumnos_Titulo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(465, 700)
        Me.MinimumSize = New System.Drawing.Size(465, 700)
        Me.Name = "ventana_crear_alumno"
        Me.Text = "Crear Nuevo Alumno"
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
    Friend WithEvents txtCrearAlumnoApellido As TextBox
    Friend WithEvents txtCrearAlumnoNombre As TextBox
    Friend WithEvents lblCrearAlumnoApellido As Label
    Friend WithEvents lblCrear_alumno_nombre As Label
    Friend WithEvents btnCrearAlumnoCancelar As Button
    Friend WithEvents btnCrearAlumnoAceptar As Button
    Friend WithEvents lblCrear_Alumnos_Titulo As BorderLabel
End Class
