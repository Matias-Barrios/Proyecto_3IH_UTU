<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_modificar_password_usuario
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
        Me.pnlCrearDocenteCI = New System.Windows.Forms.Panel()
        Me.lbl_DAtos_usuario_a_modificar = New System.Windows.Forms.Label()
        Me.btnModificar_Usuario_Aceptar = New System.Windows.Forms.Button()
        Me.btnModificarUsuario_Cancelar = New System.Windows.Forms.Button()
        Me.txt_Modificar_Usuario_RepetirPassword = New System.Windows.Forms.TextBox()
        Me.lblModificarUsuario_RepitaPAssword = New System.Windows.Forms.Label()
        Me.txtModificarUsuario_Password = New System.Windows.Forms.TextBox()
        Me.lblModificarUsuarioPassword = New System.Windows.Forms.Label()
        Me.pnlCrearDocenteCI.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCrearDocenteCI
        '
        Me.pnlCrearDocenteCI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCrearDocenteCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlCrearDocenteCI.Controls.Add(Me.lbl_DAtos_usuario_a_modificar)
        Me.pnlCrearDocenteCI.Controls.Add(Me.btnModificar_Usuario_Aceptar)
        Me.pnlCrearDocenteCI.Controls.Add(Me.btnModificarUsuario_Cancelar)
        Me.pnlCrearDocenteCI.Controls.Add(Me.txt_Modificar_Usuario_RepetirPassword)
        Me.pnlCrearDocenteCI.Controls.Add(Me.lblModificarUsuario_RepitaPAssword)
        Me.pnlCrearDocenteCI.Controls.Add(Me.txtModificarUsuario_Password)
        Me.pnlCrearDocenteCI.Controls.Add(Me.lblModificarUsuarioPassword)
        Me.pnlCrearDocenteCI.Location = New System.Drawing.Point(12, 12)
        Me.pnlCrearDocenteCI.MaximumSize = New System.Drawing.Size(725, 112)
        Me.pnlCrearDocenteCI.MinimumSize = New System.Drawing.Size(725, 112)
        Me.pnlCrearDocenteCI.Name = "pnlCrearDocenteCI"
        Me.pnlCrearDocenteCI.Size = New System.Drawing.Size(725, 112)
        Me.pnlCrearDocenteCI.TabIndex = 32
        '
        'lbl_DAtos_usuario_a_modificar
        '
        Me.lbl_DAtos_usuario_a_modificar.AutoSize = True
        Me.lbl_DAtos_usuario_a_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DAtos_usuario_a_modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_DAtos_usuario_a_modificar.Location = New System.Drawing.Point(17, 15)
        Me.lbl_DAtos_usuario_a_modificar.Name = "lbl_DAtos_usuario_a_modificar"
        Me.lbl_DAtos_usuario_a_modificar.Size = New System.Drawing.Size(150, 24)
        Me.lbl_DAtos_usuario_a_modificar.TabIndex = 36
        Me.lbl_DAtos_usuario_a_modificar.Text = "??????????????"
        '
        'btnModificar_Usuario_Aceptar
        '
        Me.btnModificar_Usuario_Aceptar.BackColor = System.Drawing.Color.White
        Me.btnModificar_Usuario_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar_Usuario_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar_Usuario_Aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnModificar_Usuario_Aceptar.Location = New System.Drawing.Point(456, 41)
        Me.btnModificar_Usuario_Aceptar.Name = "btnModificar_Usuario_Aceptar"
        Me.btnModificar_Usuario_Aceptar.Size = New System.Drawing.Size(234, 32)
        Me.btnModificar_Usuario_Aceptar.TabIndex = 35
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
        Me.btnModificarUsuario_Cancelar.Location = New System.Drawing.Point(456, 79)
        Me.btnModificarUsuario_Cancelar.Name = "btnModificarUsuario_Cancelar"
        Me.btnModificarUsuario_Cancelar.Size = New System.Drawing.Size(234, 29)
        Me.btnModificarUsuario_Cancelar.TabIndex = 34
        Me.btnModificarUsuario_Cancelar.Text = "Cancelar"
        Me.btnModificarUsuario_Cancelar.UseVisualStyleBackColor = False
        '
        'txt_Modificar_Usuario_RepetirPassword
        '
        Me.txt_Modificar_Usuario_RepetirPassword.Location = New System.Drawing.Point(202, 83)
        Me.txt_Modificar_Usuario_RepetirPassword.MaxLength = 50
        Me.txt_Modificar_Usuario_RepetirPassword.Name = "txt_Modificar_Usuario_RepetirPassword"
        Me.txt_Modificar_Usuario_RepetirPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Modificar_Usuario_RepetirPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_Modificar_Usuario_RepetirPassword.ShortcutsEnabled = False
        Me.txt_Modificar_Usuario_RepetirPassword.Size = New System.Drawing.Size(248, 20)
        Me.txt_Modificar_Usuario_RepetirPassword.TabIndex = 33
        '
        'lblModificarUsuario_RepitaPAssword
        '
        Me.lblModificarUsuario_RepitaPAssword.AutoSize = True
        Me.lblModificarUsuario_RepitaPAssword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarUsuario_RepitaPAssword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblModificarUsuario_RepitaPAssword.Location = New System.Drawing.Point(17, 79)
        Me.lblModificarUsuario_RepitaPAssword.Name = "lblModificarUsuario_RepitaPAssword"
        Me.lblModificarUsuario_RepitaPAssword.Size = New System.Drawing.Size(149, 24)
        Me.lblModificarUsuario_RepitaPAssword.TabIndex = 32
        Me.lblModificarUsuario_RepitaPAssword.Text = "Repita password"
        '
        'txtModificarUsuario_Password
        '
        Me.txtModificarUsuario_Password.Location = New System.Drawing.Point(202, 47)
        Me.txtModificarUsuario_Password.MaxLength = 50
        Me.txtModificarUsuario_Password.Name = "txtModificarUsuario_Password"
        Me.txtModificarUsuario_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtModificarUsuario_Password.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtModificarUsuario_Password.ShortcutsEnabled = False
        Me.txtModificarUsuario_Password.Size = New System.Drawing.Size(248, 20)
        Me.txtModificarUsuario_Password.TabIndex = 31
        '
        'lblModificarUsuarioPassword
        '
        Me.lblModificarUsuarioPassword.AutoSize = True
        Me.lblModificarUsuarioPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarUsuarioPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblModificarUsuarioPassword.Location = New System.Drawing.Point(17, 49)
        Me.lblModificarUsuarioPassword.Name = "lblModificarUsuarioPassword"
        Me.lblModificarUsuarioPassword.Size = New System.Drawing.Size(92, 24)
        Me.lblModificarUsuarioPassword.TabIndex = 19
        Me.lblModificarUsuarioPassword.Text = "Password"
        '
        'ventana_modificar_password_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(749, 133)
        Me.Controls.Add(Me.pnlCrearDocenteCI)
        Me.Name = "ventana_modificar_password_usuario"
        Me.Text = "Modificar password"
        Me.pnlCrearDocenteCI.ResumeLayout(False)
        Me.pnlCrearDocenteCI.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCrearDocenteCI As Panel
    Friend WithEvents lbl_DAtos_usuario_a_modificar As Label
    Friend WithEvents btnModificar_Usuario_Aceptar As Button
    Friend WithEvents btnModificarUsuario_Cancelar As Button
    Friend WithEvents txt_Modificar_Usuario_RepetirPassword As TextBox
    Friend WithEvents lblModificarUsuario_RepitaPAssword As Label
    Friend WithEvents txtModificarUsuario_Password As TextBox
    Friend WithEvents lblModificarUsuarioPassword As Label
End Class
