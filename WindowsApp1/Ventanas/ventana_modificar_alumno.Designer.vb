<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ventana_modificar_alumno
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtModificarAlumnoCI = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoCI = New System.Windows.Forms.Label()
        Me.datepickerModificarAlumnoFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblCrearAlumnoFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtModificarAlumnoEmail = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoEmail = New System.Windows.Forms.Label()
        Me.txtModificarAlumnoApellido = New System.Windows.Forms.TextBox()
        Me.txtModificarAlumnoNombre = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoApellido = New System.Windows.Forms.Label()
        Me.lblCrear_alumno_nombre = New System.Windows.Forms.Label()
        Me.btnModificarAlumnoCancelar = New System.Windows.Forms.Button()
        Me.btnModificarAlumnoAceptar = New System.Windows.Forms.Button()
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
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.datepickerModificarAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.txtModificarAlumnoEmail)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoEmail)
        Me.Panel1.Controls.Add(Me.txtModificarAlumnoApellido)
        Me.Panel1.Controls.Add(Me.txtModificarAlumnoNombre)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoApellido)
        Me.Panel1.Controls.Add(Me.lblCrear_alumno_nombre)
        Me.Panel1.Location = New System.Drawing.Point(18, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 518)
        Me.Panel1.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtModificarAlumnoCI)
        Me.Panel2.Controls.Add(Me.lblCrearAlumnoCI)
        Me.Panel2.Location = New System.Drawing.Point(22, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 42)
        Me.Panel2.TabIndex = 30
        '
        'txtModificarAlumnoCI
        '
        Me.txtModificarAlumnoCI.Location = New System.Drawing.Point(175, 13)
        Me.txtModificarAlumnoCI.MaxLength = 10
        Me.txtModificarAlumnoCI.Name = "txtModificarAlumnoCI"
        Me.txtModificarAlumnoCI.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarAlumnoCI.ShortcutsEnabled = False
        Me.txtModificarAlumnoCI.Size = New System.Drawing.Size(193, 20)
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
        Me.datepickerModificarAlumnoFechaNacimiento.Location = New System.Drawing.Point(197, 178)
        Me.datepickerModificarAlumnoFechaNacimiento.Name = "datepickerModificarAlumnoFechaNacimiento"
        Me.datepickerModificarAlumnoFechaNacimiento.Size = New System.Drawing.Size(193, 20)
        Me.datepickerModificarAlumnoFechaNacimiento.TabIndex = 29
        '
        'lblCrearAlumnoFechaNacimiento
        '
        Me.lblCrearAlumnoFechaNacimiento.AutoSize = True
        Me.lblCrearAlumnoFechaNacimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoFechaNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoFechaNacimiento.Location = New System.Drawing.Point(18, 177)
        Me.lblCrearAlumnoFechaNacimiento.Name = "lblCrearAlumnoFechaNacimiento"
        Me.lblCrearAlumnoFechaNacimiento.Size = New System.Drawing.Size(173, 22)
        Me.lblCrearAlumnoFechaNacimiento.TabIndex = 28
        Me.lblCrearAlumnoFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'txtModificarAlumnoEmail
        '
        Me.txtModificarAlumnoEmail.Location = New System.Drawing.Point(197, 139)
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
        Me.lblCrearAlumnoEmail.Location = New System.Drawing.Point(18, 139)
        Me.lblCrearAlumnoEmail.Name = "lblCrearAlumnoEmail"
        Me.lblCrearAlumnoEmail.Size = New System.Drawing.Size(61, 22)
        Me.lblCrearAlumnoEmail.TabIndex = 26
        Me.lblCrearAlumnoEmail.Text = "Email"
        '
        'txtModificarAlumnoApellido
        '
        Me.txtModificarAlumnoApellido.Location = New System.Drawing.Point(197, 100)
        Me.txtModificarAlumnoApellido.MaxLength = 50
        Me.txtModificarAlumnoApellido.Name = "txtModificarAlumnoApellido"
        Me.txtModificarAlumnoApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarAlumnoApellido.ShortcutsEnabled = False
        Me.txtModificarAlumnoApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarAlumnoApellido.TabIndex = 24
        '
        'txtModificarAlumnoNombre
        '
        Me.txtModificarAlumnoNombre.Location = New System.Drawing.Point(197, 62)
        Me.txtModificarAlumnoNombre.MaxLength = 25
        Me.txtModificarAlumnoNombre.Name = "txtModificarAlumnoNombre"
        Me.txtModificarAlumnoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarAlumnoNombre.ShortcutsEnabled = False
        Me.txtModificarAlumnoNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtModificarAlumnoNombre.TabIndex = 22
        '
        'lblCrearAlumnoApellido
        '
        Me.lblCrearAlumnoApellido.AutoSize = True
        Me.lblCrearAlumnoApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoApellido.Location = New System.Drawing.Point(18, 98)
        Me.lblCrearAlumnoApellido.Name = "lblCrearAlumnoApellido"
        Me.lblCrearAlumnoApellido.Size = New System.Drawing.Size(85, 22)
        Me.lblCrearAlumnoApellido.TabIndex = 20
        Me.lblCrearAlumnoApellido.Text = "Apellido"
        '
        'lblCrear_alumno_nombre
        '
        Me.lblCrear_alumno_nombre.AutoSize = True
        Me.lblCrear_alumno_nombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_alumno_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_alumno_nombre.Location = New System.Drawing.Point(18, 62)
        Me.lblCrear_alumno_nombre.Name = "lblCrear_alumno_nombre"
        Me.lblCrear_alumno_nombre.Size = New System.Drawing.Size(88, 22)
        Me.lblCrear_alumno_nombre.TabIndex = 18
        Me.lblCrear_alumno_nombre.Text = "Nombre "
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
        Me.btnModificarAlumnoCancelar.Size = New System.Drawing.Size(45, 45)
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
        Me.btnModificarAlumnoAceptar.Location = New System.Drawing.Point(66, 586)
        Me.btnModificarAlumnoAceptar.Name = "btnModificarAlumnoAceptar"
        Me.btnModificarAlumnoAceptar.Size = New System.Drawing.Size(45, 45)
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
        Me.BackColor = System.Drawing.Color.Silver
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCrearAlumnoCI As Label
    Friend WithEvents datepickerModificarAlumnoFechaNacimiento As DateTimePicker
    Friend WithEvents lblCrearAlumnoFechaNacimiento As Label
    Friend WithEvents txtModificarAlumnoEmail As TextBox
    Friend WithEvents lblCrearAlumnoEmail As Label
    Friend WithEvents txtModificarAlumnoApellido As TextBox
    Friend WithEvents txtModificarAlumnoNombre As TextBox
    Friend WithEvents lblCrearAlumnoApellido As Label
    Friend WithEvents lblCrear_alumno_nombre As Label
    Friend WithEvents btnModificarAlumnoCancelar As Button
    Friend WithEvents btnModificarAlumnoAceptar As Button
    Friend WithEvents lblCrear_Alumnos_Titulo As BorderLabel
    Friend WithEvents txtModificarAlumnoCI As TextBox
End Class
