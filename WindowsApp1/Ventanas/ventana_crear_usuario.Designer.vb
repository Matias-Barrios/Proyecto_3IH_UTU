<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_crear_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ventana_crear_usuario))
        Me.lblCrear_Docente_Titulo = New WindowsApp1.BorderLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvP_Usuarios_Seleccion = New WindowsApp1.DGVPaginado()
        Me.pnlCrearDocenteCI = New System.Windows.Forms.Panel()
        Me.btnCrear_Usuario_Aceptar = New System.Windows.Forms.Button()
        Me.btnCrearUsuario_Cancelar = New System.Windows.Forms.Button()
        Me.txt_Crear_Usuario_RepetirPassword = New System.Windows.Forms.TextBox()
        Me.lblCrearUsuario_RepitaPAssword = New System.Windows.Forms.Label()
        Me.txtCrearUsuario_Password = New System.Windows.Forms.TextBox()
        Me.lblCrearUsuarioPassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlCrearDocenteCI.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCrear_Docente_Titulo
        '
        Me.lblCrear_Docente_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Docente_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Docente_Titulo.Location = New System.Drawing.Point(12, 9)
        Me.lblCrear_Docente_Titulo.Name = "lblCrear_Docente_Titulo"
        Me.lblCrear_Docente_Titulo.Size = New System.Drawing.Size(339, 93)
        Me.lblCrear_Docente_Titulo.TabIndex = 23
        Me.lblCrear_Docente_Titulo.Text = "Cree un nuevo Usuario"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 55)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Seleccione una persona de la lista siguiente, introduzca un password dos veces y " &
    "haga click en agregar."
        '
        'dgvP_Usuarios_Seleccion
        '
        Me.dgvP_Usuarios_Seleccion.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Usuarios_Seleccion.Location = New System.Drawing.Point(15, 115)
        Me.dgvP_Usuarios_Seleccion.Name = "dgvP_Usuarios_Seleccion"
        Me.dgvP_Usuarios_Seleccion.Size = New System.Drawing.Size(693, 273)
        Me.dgvP_Usuarios_Seleccion.TabIndex = 25
        '
        'pnlCrearDocenteCI
        '
        Me.pnlCrearDocenteCI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCrearDocenteCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlCrearDocenteCI.Controls.Add(Me.Label2)
        Me.pnlCrearDocenteCI.Controls.Add(Me.btnCrear_Usuario_Aceptar)
        Me.pnlCrearDocenteCI.Controls.Add(Me.btnCrearUsuario_Cancelar)
        Me.pnlCrearDocenteCI.Controls.Add(Me.txt_Crear_Usuario_RepetirPassword)
        Me.pnlCrearDocenteCI.Controls.Add(Me.lblCrearUsuario_RepitaPAssword)
        Me.pnlCrearDocenteCI.Controls.Add(Me.txtCrearUsuario_Password)
        Me.pnlCrearDocenteCI.Controls.Add(Me.lblCrearUsuarioPassword)
        Me.pnlCrearDocenteCI.Location = New System.Drawing.Point(15, 394)
        Me.pnlCrearDocenteCI.Name = "pnlCrearDocenteCI"
        Me.pnlCrearDocenteCI.Size = New System.Drawing.Size(693, 141)
        Me.pnlCrearDocenteCI.TabIndex = 31
        '
        'btnCrear_Usuario_Aceptar
        '
        Me.btnCrear_Usuario_Aceptar.BackColor = System.Drawing.Color.White
        Me.btnCrear_Usuario_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrear_Usuario_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear_Usuario_Aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnCrear_Usuario_Aceptar.Location = New System.Drawing.Point(456, 7)
        Me.btnCrear_Usuario_Aceptar.Name = "btnCrear_Usuario_Aceptar"
        Me.btnCrear_Usuario_Aceptar.Size = New System.Drawing.Size(234, 32)
        Me.btnCrear_Usuario_Aceptar.TabIndex = 35
        Me.btnCrear_Usuario_Aceptar.Text = "Aceptar"
        Me.btnCrear_Usuario_Aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCrear_Usuario_Aceptar.UseVisualStyleBackColor = False
        '
        'btnCrearUsuario_Cancelar
        '
        Me.btnCrearUsuario_Cancelar.BackColor = System.Drawing.Color.White
        Me.btnCrearUsuario_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearUsuario_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearUsuario_Cancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCrearUsuario_Cancelar.Location = New System.Drawing.Point(456, 45)
        Me.btnCrearUsuario_Cancelar.Name = "btnCrearUsuario_Cancelar"
        Me.btnCrearUsuario_Cancelar.Size = New System.Drawing.Size(234, 29)
        Me.btnCrearUsuario_Cancelar.TabIndex = 34
        Me.btnCrearUsuario_Cancelar.Text = "Cancelar"
        Me.btnCrearUsuario_Cancelar.UseVisualStyleBackColor = False
        '
        'txt_Crear_Usuario_RepetirPassword
        '
        Me.txt_Crear_Usuario_RepetirPassword.Location = New System.Drawing.Point(202, 49)
        Me.txt_Crear_Usuario_RepetirPassword.MaxLength = 20
        Me.txt_Crear_Usuario_RepetirPassword.Name = "txt_Crear_Usuario_RepetirPassword"
        Me.txt_Crear_Usuario_RepetirPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Crear_Usuario_RepetirPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_Crear_Usuario_RepetirPassword.ShortcutsEnabled = False
        Me.txt_Crear_Usuario_RepetirPassword.Size = New System.Drawing.Size(248, 20)
        Me.txt_Crear_Usuario_RepetirPassword.TabIndex = 33
        '
        'lblCrearUsuario_RepitaPAssword
        '
        Me.lblCrearUsuario_RepitaPAssword.AutoSize = True
        Me.lblCrearUsuario_RepitaPAssword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearUsuario_RepitaPAssword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearUsuario_RepitaPAssword.Location = New System.Drawing.Point(17, 45)
        Me.lblCrearUsuario_RepitaPAssword.Name = "lblCrearUsuario_RepitaPAssword"
        Me.lblCrearUsuario_RepitaPAssword.Size = New System.Drawing.Size(149, 24)
        Me.lblCrearUsuario_RepitaPAssword.TabIndex = 32
        Me.lblCrearUsuario_RepitaPAssword.Text = "Repita password"
        '
        'txtCrearUsuario_Password
        '
        Me.txtCrearUsuario_Password.Location = New System.Drawing.Point(202, 13)
        Me.txtCrearUsuario_Password.MaxLength = 20
        Me.txtCrearUsuario_Password.Name = "txtCrearUsuario_Password"
        Me.txtCrearUsuario_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCrearUsuario_Password.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearUsuario_Password.ShortcutsEnabled = False
        Me.txtCrearUsuario_Password.Size = New System.Drawing.Size(248, 20)
        Me.txtCrearUsuario_Password.TabIndex = 31
        '
        'lblCrearUsuarioPassword
        '
        Me.lblCrearUsuarioPassword.AutoSize = True
        Me.lblCrearUsuarioPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearUsuarioPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearUsuarioPassword.Location = New System.Drawing.Point(17, 15)
        Me.lblCrearUsuarioPassword.Name = "lblCrearUsuarioPassword"
        Me.lblCrearUsuarioPassword.Size = New System.Drawing.Size(92, 24)
        Me.lblCrearUsuarioPassword.TabIndex = 19
        Me.lblCrearUsuarioPassword.Text = "Password"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(4, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(686, 61)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'ventana_crear_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(720, 543)
        Me.Controls.Add(Me.pnlCrearDocenteCI)
        Me.Controls.Add(Me.dgvP_Usuarios_Seleccion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCrear_Docente_Titulo)
        Me.MaximumSize = New System.Drawing.Size(736, 581)
        Me.MinimumSize = New System.Drawing.Size(736, 581)
        Me.Name = "ventana_crear_usuario"
        Me.Text = "Crear nuevo Usuario"
        Me.pnlCrearDocenteCI.ResumeLayout(False)
        Me.pnlCrearDocenteCI.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCrear_Docente_Titulo As BorderLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvP_Usuarios_Seleccion As DGVPaginado
    Friend WithEvents pnlCrearDocenteCI As Panel
    Friend WithEvents txt_Crear_Usuario_RepetirPassword As TextBox
    Friend WithEvents lblCrearUsuario_RepitaPAssword As Label
    Friend WithEvents txtCrearUsuario_Password As TextBox
    Friend WithEvents lblCrearUsuarioPassword As Label
    Friend WithEvents btnCrear_Usuario_Aceptar As Button
    Friend WithEvents btnCrearUsuario_Cancelar As Button
    Friend WithEvents Label2 As Label
End Class
