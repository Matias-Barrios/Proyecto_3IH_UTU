<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_crear_admin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdmin_Aceptar = New System.Windows.Forms.Button()
        Me.btnAdmin_Cancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlAdmin_o_Administrativo = New System.Windows.Forms.Panel()
        Me.rdoAdministrativo = New System.Windows.Forms.RadioButton()
        Me.rdoAdmin = New System.Windows.Forms.RadioButton()
        Me.txtAdmin_primer_apellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAdmin_segundo_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtAdmin_CI = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoCI = New System.Windows.Forms.Label()
        Me.datepicker_Admin = New System.Windows.Forms.DateTimePicker()
        Me.lblCrearAlumnoFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtAdmin_email = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoEmail = New System.Windows.Forms.Label()
        Me.txtAdmin_segundo_apellido = New System.Windows.Forms.TextBox()
        Me.txtAdmin_primer_nombre = New System.Windows.Forms.TextBox()
        Me.lblCrearAlumnoApellido = New System.Windows.Forms.Label()
        Me.lblCrear_alumno_nombre = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnlAdmin_o_Administrativo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdmin_Aceptar
        '
        Me.btnAdmin_Aceptar.BackColor = System.Drawing.Color.White
        Me.btnAdmin_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmin_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin_Aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnAdmin_Aceptar.Location = New System.Drawing.Point(249, 473)
        Me.btnAdmin_Aceptar.Name = "btnAdmin_Aceptar"
        Me.btnAdmin_Aceptar.Size = New System.Drawing.Size(183, 32)
        Me.btnAdmin_Aceptar.TabIndex = 40
        Me.btnAdmin_Aceptar.Text = "Aceptar"
        Me.btnAdmin_Aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdmin_Aceptar.UseVisualStyleBackColor = False
        '
        'btnAdmin_Cancelar
        '
        Me.btnAdmin_Cancelar.BackColor = System.Drawing.Color.White
        Me.btnAdmin_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmin_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin_Cancelar.ForeColor = System.Drawing.Color.Red
        Me.btnAdmin_Cancelar.Location = New System.Drawing.Point(20, 473)
        Me.btnAdmin_Cancelar.Name = "btnAdmin_Cancelar"
        Me.btnAdmin_Cancelar.Size = New System.Drawing.Size(183, 32)
        Me.btnAdmin_Cancelar.TabIndex = 41
        Me.btnAdmin_Cancelar.Text = "Cancelar"
        Me.btnAdmin_Cancelar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.pnlAdmin_o_Administrativo)
        Me.Panel1.Controls.Add(Me.txtAdmin_primer_apellido)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAdmin_segundo_nombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.datepicker_Admin)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoFechaNacimiento)
        Me.Panel1.Controls.Add(Me.txtAdmin_email)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoEmail)
        Me.Panel1.Controls.Add(Me.txtAdmin_segundo_apellido)
        Me.Panel1.Controls.Add(Me.txtAdmin_primer_nombre)
        Me.Panel1.Controls.Add(Me.lblCrearAlumnoApellido)
        Me.Panel1.Controls.Add(Me.lblCrear_alumno_nombre)
        Me.Panel1.Location = New System.Drawing.Point(20, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 431)
        Me.Panel1.TabIndex = 38
        '
        'pnlAdmin_o_Administrativo
        '
        Me.pnlAdmin_o_Administrativo.BackColor = System.Drawing.Color.LightGray
        Me.pnlAdmin_o_Administrativo.Controls.Add(Me.rdoAdministrativo)
        Me.pnlAdmin_o_Administrativo.Controls.Add(Me.rdoAdmin)
        Me.pnlAdmin_o_Administrativo.Location = New System.Drawing.Point(19, 332)
        Me.pnlAdmin_o_Administrativo.Name = "pnlAdmin_o_Administrativo"
        Me.pnlAdmin_o_Administrativo.Size = New System.Drawing.Size(368, 67)
        Me.pnlAdmin_o_Administrativo.TabIndex = 36
        '
        'rdoAdministrativo
        '
        Me.rdoAdministrativo.AutoSize = True
        Me.rdoAdministrativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAdministrativo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdoAdministrativo.Location = New System.Drawing.Point(175, 24)
        Me.rdoAdministrativo.Name = "rdoAdministrativo"
        Me.rdoAdministrativo.Size = New System.Drawing.Size(179, 29)
        Me.rdoAdministrativo.TabIndex = 39
        Me.rdoAdministrativo.Text = "Administrativo"
        Me.rdoAdministrativo.UseVisualStyleBackColor = True
        '
        'rdoAdmin
        '
        Me.rdoAdmin.AutoSize = True
        Me.rdoAdmin.Checked = True
        Me.rdoAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdoAdmin.Location = New System.Drawing.Point(40, 24)
        Me.rdoAdmin.Name = "rdoAdmin"
        Me.rdoAdmin.Size = New System.Drawing.Size(95, 29)
        Me.rdoAdmin.TabIndex = 38
        Me.rdoAdmin.TabStop = True
        Me.rdoAdmin.Text = "Admin"
        Me.rdoAdmin.UseVisualStyleBackColor = True
        '
        'txtAdmin_primer_apellido
        '
        Me.txtAdmin_primer_apellido.Location = New System.Drawing.Point(191, 134)
        Me.txtAdmin_primer_apellido.MaxLength = 25
        Me.txtAdmin_primer_apellido.Name = "txtAdmin_primer_apellido"
        Me.txtAdmin_primer_apellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtAdmin_primer_apellido.ShortcutsEnabled = False
        Me.txtAdmin_primer_apellido.Size = New System.Drawing.Size(196, 20)
        Me.txtAdmin_primer_apellido.TabIndex = 34
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
        'txtAdmin_segundo_nombre
        '
        Me.txtAdmin_segundo_nombre.Location = New System.Drawing.Point(191, 99)
        Me.txtAdmin_segundo_nombre.MaxLength = 25
        Me.txtAdmin_segundo_nombre.Name = "txtAdmin_segundo_nombre"
        Me.txtAdmin_segundo_nombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtAdmin_segundo_nombre.ShortcutsEnabled = False
        Me.txtAdmin_segundo_nombre.Size = New System.Drawing.Size(196, 20)
        Me.txtAdmin_segundo_nombre.TabIndex = 33
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
        Me.Panel2.Controls.Add(Me.txtAdmin_CI)
        Me.Panel2.Controls.Add(Me.lblCrearAlumnoCI)
        Me.Panel2.Location = New System.Drawing.Point(16, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 42)
        Me.Panel2.TabIndex = 30
        '
        'txtAdmin_CI
        '
        Me.txtAdmin_CI.Location = New System.Drawing.Point(175, 12)
        Me.txtAdmin_CI.MaxLength = 8
        Me.txtAdmin_CI.Name = "txtAdmin_CI"
        Me.txtAdmin_CI.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtAdmin_CI.ShortcutsEnabled = False
        Me.txtAdmin_CI.Size = New System.Drawing.Size(190, 20)
        Me.txtAdmin_CI.TabIndex = 31
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
        'datepicker_Admin
        '
        Me.datepicker_Admin.Location = New System.Drawing.Point(194, 258)
        Me.datepicker_Admin.Name = "datepicker_Admin"
        Me.datepicker_Admin.Size = New System.Drawing.Size(193, 20)
        Me.datepicker_Admin.TabIndex = 37
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
        'txtAdmin_email
        '
        Me.txtAdmin_email.Location = New System.Drawing.Point(194, 219)
        Me.txtAdmin_email.MaxLength = 100
        Me.txtAdmin_email.Name = "txtAdmin_email"
        Me.txtAdmin_email.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtAdmin_email.ShortcutsEnabled = False
        Me.txtAdmin_email.Size = New System.Drawing.Size(193, 20)
        Me.txtAdmin_email.TabIndex = 36
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
        'txtAdmin_segundo_apellido
        '
        Me.txtAdmin_segundo_apellido.Location = New System.Drawing.Point(191, 170)
        Me.txtAdmin_segundo_apellido.MaxLength = 25
        Me.txtAdmin_segundo_apellido.Name = "txtAdmin_segundo_apellido"
        Me.txtAdmin_segundo_apellido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtAdmin_segundo_apellido.ShortcutsEnabled = False
        Me.txtAdmin_segundo_apellido.Size = New System.Drawing.Size(196, 20)
        Me.txtAdmin_segundo_apellido.TabIndex = 35
        '
        'txtAdmin_primer_nombre
        '
        Me.txtAdmin_primer_nombre.Location = New System.Drawing.Point(191, 63)
        Me.txtAdmin_primer_nombre.MaxLength = 25
        Me.txtAdmin_primer_nombre.Name = "txtAdmin_primer_nombre"
        Me.txtAdmin_primer_nombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtAdmin_primer_nombre.ShortcutsEnabled = False
        Me.txtAdmin_primer_nombre.Size = New System.Drawing.Size(196, 20)
        Me.txtAdmin_primer_nombre.TabIndex = 32
        '
        'lblCrearAlumnoApellido
        '
        Me.lblCrearAlumnoApellido.AutoSize = True
        Me.lblCrearAlumnoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAlumnoApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAlumnoApellido.Location = New System.Drawing.Point(15, 167)
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
        'ventana_crear_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(453, 519)
        Me.Controls.Add(Me.btnAdmin_Aceptar)
        Me.Controls.Add(Me.btnAdmin_Cancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ventana_crear_admin"
        Me.Text = "Crear Admin/Administrativo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlAdmin_o_Administrativo.ResumeLayout(False)
        Me.pnlAdmin_o_Administrativo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdmin_Aceptar As Button
    Friend WithEvents btnAdmin_Cancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlAdmin_o_Administrativo As Panel
    Friend WithEvents rdoAdministrativo As RadioButton
    Friend WithEvents rdoAdmin As RadioButton
    Friend WithEvents txtAdmin_primer_apellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdmin_segundo_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtAdmin_CI As TextBox
    Friend WithEvents lblCrearAlumnoCI As Label
    Friend WithEvents datepicker_Admin As DateTimePicker
    Friend WithEvents lblCrearAlumnoFechaNacimiento As Label
    Friend WithEvents txtAdmin_email As TextBox
    Friend WithEvents lblCrearAlumnoEmail As Label
    Friend WithEvents txtAdmin_segundo_apellido As TextBox
    Friend WithEvents txtAdmin_primer_nombre As TextBox
    Friend WithEvents lblCrearAlumnoApellido As Label
    Friend WithEvents lblCrear_alumno_nombre As Label
End Class
