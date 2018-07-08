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
        Me.pnlAlumnoAtributosModificacion = New System.Windows.Forms.Panel()
        Me.txtModificarAlumnoJuici_Final = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkHaceProyecto = New System.Windows.Forms.CheckBox()
        Me.txtCrearAlumnoPrimerApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCrearAlumnoSegundoNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCrearAlumnoCI = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoCI = New System.Windows.Forms.Label()
        Me.datepickerCrearAlumnoFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblCrearAlumnoFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtCrearAlumnoEmail = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoEmail = New System.Windows.Forms.Label()
        Me.txtCrearAlumnoSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtCrearAlumnoPrimerNombre = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoApellido = New System.Windows.Forms.Label()
        Me.lblCrear_alumno_nombre = New System.Windows.Forms.Label()
        Me.btnModificar_Usuario_Aceptar = New System.Windows.Forms.Button()
        Me.btnModificarUsuario_Cancelar = New System.Windows.Forms.Button()
        Me.lblCrear_Alumnos_Titulo = New WindowsApp1.BorderLabel()
        Me.Panel1.SuspendLayout()
        Me.pnlAlumnoAtributosModificacion.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.pnlAlumnoAtributosModificacion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.chkHaceProyecto)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoPrimerApellido)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoSegundoNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.datepickerCrearAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoEmail)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoEmail)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoSegundoApellido)
        Me.Panel1.Controls.Add(Me.txtCrearAlumnoPrimerNombre)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoApellido)
        Me.Panel1.Controls.Add(Me.lblCrear_alumno_nombre)
        Me.Panel1.Location = New System.Drawing.Point(21, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 431)
        Me.Panel1.TabIndex = 21
        '
        'pnlAlumnoAtributosModificacion
        '
        Me.pnlAlumnoAtributosModificacion.Controls.Add(Me.txtModificarAlumnoJuici_Final)
        Me.pnlAlumnoAtributosModificacion.Controls.Add(Me.Label5)
        Me.pnlAlumnoAtributosModificacion.Controls.Add(Me.NumericUpDown1)
        Me.pnlAlumnoAtributosModificacion.Controls.Add(Me.Label4)
        Me.pnlAlumnoAtributosModificacion.Location = New System.Drawing.Point(19, 328)
        Me.pnlAlumnoAtributosModificacion.Name = "pnlAlumnoAtributosModificacion"
        Me.pnlAlumnoAtributosModificacion.Size = New System.Drawing.Size(368, 97)
        Me.pnlAlumnoAtributosModificacion.TabIndex = 38
        Me.pnlAlumnoAtributosModificacion.Visible = False
        '
        'txtModificarAlumnoJuici_Final
        '
        Me.txtModificarAlumnoJuici_Final.Enabled = False
        Me.txtModificarAlumnoJuici_Final.Location = New System.Drawing.Point(166, 63)
        Me.txtModificarAlumnoJuici_Final.MaxLength = 25
        Me.txtModificarAlumnoJuici_Final.Name = "txtModificarAlumnoJuici_Final"
        Me.txtModificarAlumnoJuici_Final.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarAlumnoJuici_Final.ShortcutsEnabled = False
        Me.txtModificarAlumnoJuici_Final.Size = New System.Drawing.Size(196, 20)
        Me.txtModificarAlumnoJuici_Final.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(21, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 24)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Juicio Final"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(242, 18)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 40
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(21, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 24)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Nota final proyecto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(40, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 24)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Hace proyecto?"
        '
        'chkHaceProyecto
        '
        Me.chkHaceProyecto.AutoSize = True
        Me.chkHaceProyecto.Location = New System.Drawing.Point(19, 308)
        Me.chkHaceProyecto.Name = "chkHaceProyecto"
        Me.chkHaceProyecto.Size = New System.Drawing.Size(15, 14)
        Me.chkHaceProyecto.TabIndex = 36
        Me.chkHaceProyecto.UseVisualStyleBackColor = True
        '
        'txtCrearAlumnoPrimerApellido
        '
        Me.txtCrearAlumnoPrimerApellido.Location = New System.Drawing.Point(191, 134)
        Me.txtCrearAlumnoPrimerApellido.MaxLength = 25
        Me.txtCrearAlumnoPrimerApellido.Name = "txtCrearAlumnoPrimerApellido"
        Me.txtCrearAlumnoPrimerApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoPrimerApellido.ShortcutsEnabled = False
        Me.txtCrearAlumnoPrimerApellido.Size = New System.Drawing.Size(196, 20)
        Me.txtCrearAlumnoPrimerApellido.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 24)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Primer Apellido"
        '
        'txtCrearAlumnoSegundoNombre
        '
        Me.txtCrearAlumnoSegundoNombre.Location = New System.Drawing.Point(191, 99)
        Me.txtCrearAlumnoSegundoNombre.MaxLength = 25
        Me.txtCrearAlumnoSegundoNombre.Name = "txtCrearAlumnoSegundoNombre"
        Me.txtCrearAlumnoSegundoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoSegundoNombre.ShortcutsEnabled = False
        Me.txtCrearAlumnoSegundoNombre.Size = New System.Drawing.Size(196, 20)
        Me.txtCrearAlumnoSegundoNombre.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Segundo Nombre"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtCrearAlumnoCI)
        Me.Panel2.Controls.Add(Me.lblCrearAlumnoCI)
        Me.Panel2.Location = New System.Drawing.Point(16, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 42)
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
        Me.datepickerCrearAlumnoFechaNacimiento.Location = New System.Drawing.Point(194, 258)
        Me.datepickerCrearAlumnoFechaNacimiento.Name = "datepickerCrearAlumnoFechaNacimiento"
        Me.datepickerCrearAlumnoFechaNacimiento.Size = New System.Drawing.Size(193, 20)
        Me.datepickerCrearAlumnoFechaNacimiento.TabIndex = 29
        '
        'lblCrearAlumnoFechaNacimiento
        '
        Me.lblCrearAlumnoFechaNacimiento.AutoSize = True
        Me.lblCrearAlumnoFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoFechaNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoFechaNacimiento.Location = New System.Drawing.Point(15, 258)
        Me.lblCrearAlumnoFechaNacimiento.Name = "lblCrearAlumnoFechaNacimiento"
        Me.lblCrearAlumnoFechaNacimiento.Size = New System.Drawing.Size(164, 24)
        Me.lblCrearAlumnoFechaNacimiento.TabIndex = 28
        Me.lblCrearAlumnoFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'txtCrearAlumnoEmail
        '
        Me.txtCrearAlumnoEmail.Location = New System.Drawing.Point(194, 219)
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
        Me.lblCrearAlumnoEmail.Location = New System.Drawing.Point(15, 217)
        Me.lblCrearAlumnoEmail.Name = "lblCrearAlumnoEmail"
        Me.lblCrearAlumnoEmail.Size = New System.Drawing.Size(57, 24)
        Me.lblCrearAlumnoEmail.TabIndex = 26
        Me.lblCrearAlumnoEmail.Text = "Email"
        '
        'txtCrearAlumnoSegundoApellido
        '
        Me.txtCrearAlumnoSegundoApellido.Location = New System.Drawing.Point(194, 180)
        Me.txtCrearAlumnoSegundoApellido.MaxLength = 25
        Me.txtCrearAlumnoSegundoApellido.Name = "txtCrearAlumnoSegundoApellido"
        Me.txtCrearAlumnoSegundoApellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoSegundoApellido.ShortcutsEnabled = False
        Me.txtCrearAlumnoSegundoApellido.Size = New System.Drawing.Size(193, 20)
        Me.txtCrearAlumnoSegundoApellido.TabIndex = 24
        '
        'txtCrearAlumnoPrimerNombre
        '
        Me.txtCrearAlumnoPrimerNombre.Location = New System.Drawing.Point(191, 63)
        Me.txtCrearAlumnoPrimerNombre.MaxLength = 25
        Me.txtCrearAlumnoPrimerNombre.Name = "txtCrearAlumnoPrimerNombre"
        Me.txtCrearAlumnoPrimerNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAlumnoPrimerNombre.ShortcutsEnabled = False
        Me.txtCrearAlumnoPrimerNombre.Size = New System.Drawing.Size(196, 20)
        Me.txtCrearAlumnoPrimerNombre.TabIndex = 22
        '
        'lblCrearAlumnoApellido
        '
        Me.lblCrearAlumnoApellido.AutoSize = True
        Me.lblCrearAlumnoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoApellido.Location = New System.Drawing.Point(15, 180)
        Me.lblCrearAlumnoApellido.Name = "lblCrearAlumnoApellido"
        Me.lblCrearAlumnoApellido.Size = New System.Drawing.Size(162, 24)
        Me.lblCrearAlumnoApellido.TabIndex = 20
        Me.lblCrearAlumnoApellido.Text = "Segundo Apellido"
        '
        'lblCrear_alumno_nombre
        '
        Me.lblCrear_alumno_nombre.AutoSize = True
        Me.lblCrear_alumno_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_alumno_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_alumno_nombre.Location = New System.Drawing.Point(15, 63)
        Me.lblCrear_alumno_nombre.Name = "lblCrear_alumno_nombre"
        Me.lblCrear_alumno_nombre.Size = New System.Drawing.Size(139, 24)
        Me.lblCrear_alumno_nombre.TabIndex = 18
        Me.lblCrear_alumno_nombre.Text = "Primer Nombre"
        '
        'btnModificar_Usuario_Aceptar
        '
        Me.btnModificar_Usuario_Aceptar.BackColor = System.Drawing.Color.White
        Me.btnModificar_Usuario_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar_Usuario_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar_Usuario_Aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnModificar_Usuario_Aceptar.Location = New System.Drawing.Point(250, 449)
        Me.btnModificar_Usuario_Aceptar.Name = "btnModificar_Usuario_Aceptar"
        Me.btnModificar_Usuario_Aceptar.Size = New System.Drawing.Size(183, 32)
        Me.btnModificar_Usuario_Aceptar.TabIndex = 37
        Me.btnModificar_Usuario_Aceptar.Text = "Aceptar"
        Me.btnModificar_Usuario_Aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar_Usuario_Aceptar.UseVisualStyleBackColor = False
        '
        'btnModificarUsuario_Cancelar
        '
        Me.btnModificarUsuario_Cancelar.BackColor = System.Drawing.Color.White
        Me.btnModificarUsuario_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarUsuario_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarUsuario_Cancelar.ForeColor = System.Drawing.Color.Red
        Me.btnModificarUsuario_Cancelar.Location = New System.Drawing.Point(21, 449)
        Me.btnModificarUsuario_Cancelar.Name = "btnModificarUsuario_Cancelar"
        Me.btnModificarUsuario_Cancelar.Size = New System.Drawing.Size(183, 32)
        Me.btnModificarUsuario_Cancelar.TabIndex = 36
        Me.btnModificarUsuario_Cancelar.Text = "Cancelar"
        Me.btnModificarUsuario_Cancelar.UseVisualStyleBackColor = False
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
        Me.lblCrear_Alumnos_Titulo.Size = New System.Drawing.Size(388, 82)
        Me.lblCrear_Alumnos_Titulo.TabIndex = 18
        Me.lblCrear_Alumnos_Titulo.Text = "Cree un nuevo Alumno..."
        '
        'ventana_crear_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(449, 493)
        Me.Controls.Add(Me.btnModificar_Usuario_Aceptar)
        Me.Controls.Add(Me.btnModificarUsuario_Cancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblCrear_Alumnos_Titulo)
        Me.MaximizeBox = False
        Me.Name = "ventana_crear_alumno"
        Me.Text = "Crear Nuevo Alumno"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlAlumnoAtributosModificacion.ResumeLayout(False)
        Me.pnlAlumnoAtributosModificacion.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCrearAlumnoCI As TextBox
    Friend WithEvents lblCrearAlumnoCI As Label
    Friend WithEvents datepickerCrearAlumnoFechaNacimiento As DateTimePicker
    Friend WithEvents lblCrearAlumnoFechaNacimiento As Label
    Friend WithEvents txtCrearAlumnoEmail As TextBox
    Friend WithEvents lblCrearAlumnoEmail As Label
    Friend WithEvents txtCrearAlumnoSegundoApellido As TextBox
    Friend WithEvents txtCrearAlumnoPrimerNombre As TextBox
    Friend WithEvents lblCrearAlumnoApellido As Label
    Friend WithEvents lblCrear_alumno_nombre As Label
    Friend WithEvents lblCrear_Alumnos_Titulo As BorderLabel
    Friend WithEvents txtCrearAlumnoPrimerApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCrearAlumnoSegundoNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificar_Usuario_Aceptar As Button
    Friend WithEvents btnModificarUsuario_Cancelar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents chkHaceProyecto As CheckBox
    Friend WithEvents pnlAlumnoAtributosModificacion As Panel
    Friend WithEvents txtModificarAlumnoJuici_Final As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
End Class
