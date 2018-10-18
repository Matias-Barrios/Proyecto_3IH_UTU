<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_Login))
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.b_lblPassword = New WindowsApp1.BorderLabel()
        Me.b_lblNombreUsuario = New WindowsApp1.BorderLabel()
        Me.picUserLogin = New System.Windows.Forms.PictureBox()
        CType(Me.picUserLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(31, 163)
        Me.txtNombreUsuario.MaxLength = 8
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtNombreUsuario.Size = New System.Drawing.Size(201, 20)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(31, 232)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtPassword.Size = New System.Drawing.Size(201, 20)
        Me.txtPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(31, 270)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(201, 39)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Log in!"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'b_lblPassword
        '
        Me.b_lblPassword.AutoSize = True
        Me.b_lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.b_lblPassword.Location = New System.Drawing.Point(58, 192)
        Me.b_lblPassword.Name = "b_lblPassword"
        Me.b_lblPassword.Size = New System.Drawing.Size(134, 31)
        Me.b_lblPassword.TabIndex = 6
        Me.b_lblPassword.Text = "Password"
        Me.b_lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'b_lblNombreUsuario
        '
        Me.b_lblNombreUsuario.AutoSize = True
        Me.b_lblNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.b_lblNombreUsuario.Location = New System.Drawing.Point(72, 119)
        Me.b_lblNombreUsuario.Name = "b_lblNombreUsuario"
        Me.b_lblNombreUsuario.Size = New System.Drawing.Size(100, 31)
        Me.b_lblNombreUsuario.TabIndex = 5
        Me.b_lblNombreUsuario.Text = "Cedula"
        Me.b_lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picUserLogin
        '
        Me.picUserLogin.Image = Global.WindowsApp1.My.Resources.Resources.user_group_icon_32334
        Me.picUserLogin.Location = New System.Drawing.Point(68, 12)
        Me.picUserLogin.Name = "picUserLogin"
        Me.picUserLogin.Size = New System.Drawing.Size(126, 101)
        Me.picUserLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUserLogin.TabIndex = 7
        Me.picUserLogin.TabStop = False
        '
        'Ventana_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(259, 342)
        Me.Controls.Add(Me.picUserLogin)
        Me.Controls.Add(Me.b_lblPassword)
        Me.Controls.Add(Me.b_lblNombreUsuario)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(275, 380)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(275, 380)
        Me.Name = "Ventana_Login"
        Me.Text = "Login"
        CType(Me.picUserLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents b_lblNombreUsuario As BorderLabel
    Friend WithEvents b_lblPassword As BorderLabel
    Friend WithEvents picUserLogin As PictureBox
End Class
