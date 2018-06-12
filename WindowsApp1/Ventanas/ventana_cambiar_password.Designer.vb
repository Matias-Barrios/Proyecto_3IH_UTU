<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaCambiarPassword
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
        Me.btnVentanaCambiarPasswordCancel = New System.Windows.Forms.Button()
        Me.btnVentanaCambiarPasswordOK = New System.Windows.Forms.Button()
        Me.txtVentanaCambiarPasswordContraseñaActual = New System.Windows.Forms.TextBox()
        Me.lblVentanaCambiarPasswordExistente = New System.Windows.Forms.Label()
        Me.lblVentanaCambiarPasswordNuevo = New System.Windows.Forms.Label()
        Me.txtVentanaCambiarPasswordNuevo = New System.Windows.Forms.TextBox()
        Me.txtVentanaCambiarPasswordNuevoRepetido = New System.Windows.Forms.TextBox()
        Me.lblVentanaCambiarPasswordNuevoRepetido = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVentanaCambiarPasswordCancel
        '
        Me.btnVentanaCambiarPasswordCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVentanaCambiarPasswordCancel.BackColor = System.Drawing.Color.White
        Me.btnVentanaCambiarPasswordCancel.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.cancel
        Me.btnVentanaCambiarPasswordCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVentanaCambiarPasswordCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVentanaCambiarPasswordCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaCambiarPasswordCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaCambiarPasswordCancel.Location = New System.Drawing.Point(74, 174)
        Me.btnVentanaCambiarPasswordCancel.Name = "btnVentanaCambiarPasswordCancel"
        Me.btnVentanaCambiarPasswordCancel.Size = New System.Drawing.Size(45, 45)
        Me.btnVentanaCambiarPasswordCancel.TabIndex = 16
        Me.btnVentanaCambiarPasswordCancel.UseVisualStyleBackColor = False
        '
        'btnVentanaCambiarPasswordOK
        '
        Me.btnVentanaCambiarPasswordOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVentanaCambiarPasswordOK.BackColor = System.Drawing.Color.White
        Me.btnVentanaCambiarPasswordOK.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.checkmark_filled
        Me.btnVentanaCambiarPasswordOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVentanaCambiarPasswordOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVentanaCambiarPasswordOK.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaCambiarPasswordOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaCambiarPasswordOK.Location = New System.Drawing.Point(259, 174)
        Me.btnVentanaCambiarPasswordOK.Name = "btnVentanaCambiarPasswordOK"
        Me.btnVentanaCambiarPasswordOK.Size = New System.Drawing.Size(45, 45)
        Me.btnVentanaCambiarPasswordOK.TabIndex = 15
        Me.btnVentanaCambiarPasswordOK.UseVisualStyleBackColor = False
        '
        'txtVentanaCambiarPasswordContraseñaActual
        '
        Me.txtVentanaCambiarPasswordContraseñaActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVentanaCambiarPasswordContraseñaActual.Location = New System.Drawing.Point(184, 22)
        Me.txtVentanaCambiarPasswordContraseñaActual.MaxLength = 50
        Me.txtVentanaCambiarPasswordContraseñaActual.Name = "txtVentanaCambiarPasswordContraseñaActual"
        Me.txtVentanaCambiarPasswordContraseñaActual.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtVentanaCambiarPasswordContraseñaActual.Size = New System.Drawing.Size(168, 20)
        Me.txtVentanaCambiarPasswordContraseñaActual.TabIndex = 18
        '
        'lblVentanaCambiarPasswordExistente
        '
        Me.lblVentanaCambiarPasswordExistente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVentanaCambiarPasswordExistente.AutoSize = True
        Me.lblVentanaCambiarPasswordExistente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentanaCambiarPasswordExistente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVentanaCambiarPasswordExistente.Location = New System.Drawing.Point(17, 18)
        Me.lblVentanaCambiarPasswordExistente.Name = "lblVentanaCambiarPasswordExistente"
        Me.lblVentanaCambiarPasswordExistente.Size = New System.Drawing.Size(161, 22)
        Me.lblVentanaCambiarPasswordExistente.TabIndex = 17
        Me.lblVentanaCambiarPasswordExistente.Text = "Password actual"
        '
        'lblVentanaCambiarPasswordNuevo
        '
        Me.lblVentanaCambiarPasswordNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVentanaCambiarPasswordNuevo.AutoSize = True
        Me.lblVentanaCambiarPasswordNuevo.CausesValidation = False
        Me.lblVentanaCambiarPasswordNuevo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentanaCambiarPasswordNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVentanaCambiarPasswordNuevo.Location = New System.Drawing.Point(17, 58)
        Me.lblVentanaCambiarPasswordNuevo.Name = "lblVentanaCambiarPasswordNuevo"
        Me.lblVentanaCambiarPasswordNuevo.Size = New System.Drawing.Size(162, 22)
        Me.lblVentanaCambiarPasswordNuevo.TabIndex = 19
        Me.lblVentanaCambiarPasswordNuevo.Text = "Nuevo Password"
        '
        'txtVentanaCambiarPasswordNuevo
        '
        Me.txtVentanaCambiarPasswordNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVentanaCambiarPasswordNuevo.Location = New System.Drawing.Point(184, 62)
        Me.txtVentanaCambiarPasswordNuevo.MaxLength = 50
        Me.txtVentanaCambiarPasswordNuevo.Name = "txtVentanaCambiarPasswordNuevo"
        Me.txtVentanaCambiarPasswordNuevo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtVentanaCambiarPasswordNuevo.Size = New System.Drawing.Size(168, 20)
        Me.txtVentanaCambiarPasswordNuevo.TabIndex = 20
        '
        'txtVentanaCambiarPasswordNuevoRepetido
        '
        Me.txtVentanaCambiarPasswordNuevoRepetido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVentanaCambiarPasswordNuevoRepetido.Location = New System.Drawing.Point(184, 103)
        Me.txtVentanaCambiarPasswordNuevoRepetido.MaxLength = 50
        Me.txtVentanaCambiarPasswordNuevoRepetido.Name = "txtVentanaCambiarPasswordNuevoRepetido"
        Me.txtVentanaCambiarPasswordNuevoRepetido.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtVentanaCambiarPasswordNuevoRepetido.Size = New System.Drawing.Size(168, 20)
        Me.txtVentanaCambiarPasswordNuevoRepetido.TabIndex = 22
        '
        'lblVentanaCambiarPasswordNuevoRepetido
        '
        Me.lblVentanaCambiarPasswordNuevoRepetido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVentanaCambiarPasswordNuevoRepetido.AutoSize = True
        Me.lblVentanaCambiarPasswordNuevoRepetido.CausesValidation = False
        Me.lblVentanaCambiarPasswordNuevoRepetido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentanaCambiarPasswordNuevoRepetido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVentanaCambiarPasswordNuevoRepetido.Location = New System.Drawing.Point(17, 99)
        Me.lblVentanaCambiarPasswordNuevoRepetido.Name = "lblVentanaCambiarPasswordNuevoRepetido"
        Me.lblVentanaCambiarPasswordNuevoRepetido.Size = New System.Drawing.Size(164, 22)
        Me.lblVentanaCambiarPasswordNuevoRepetido.TabIndex = 21
        Me.lblVentanaCambiarPasswordNuevoRepetido.Text = "Repita password"
        '
        'VentanaCambiarPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.txtVentanaCambiarPasswordNuevoRepetido)
        Me.Controls.Add(Me.lblVentanaCambiarPasswordNuevoRepetido)
        Me.Controls.Add(Me.txtVentanaCambiarPasswordNuevo)
        Me.Controls.Add(Me.lblVentanaCambiarPasswordNuevo)
        Me.Controls.Add(Me.txtVentanaCambiarPasswordContraseñaActual)
        Me.Controls.Add(Me.lblVentanaCambiarPasswordExistente)
        Me.Controls.Add(Me.btnVentanaCambiarPasswordCancel)
        Me.Controls.Add(Me.btnVentanaCambiarPasswordOK)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "VentanaCambiarPassword"
        Me.Text = "Cambiar Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVentanaCambiarPasswordCancel As Button
    Friend WithEvents btnVentanaCambiarPasswordOK As Button
    Friend WithEvents txtVentanaCambiarPasswordContraseñaActual As TextBox
    Friend WithEvents lblVentanaCambiarPasswordExistente As Label
    Friend WithEvents lblVentanaCambiarPasswordNuevo As Label
    Friend WithEvents txtVentanaCambiarPasswordNuevo As TextBox
    Friend WithEvents txtVentanaCambiarPasswordNuevoRepetido As TextBox
    Friend WithEvents lblVentanaCambiarPasswordNuevoRepetido As Label
End Class
