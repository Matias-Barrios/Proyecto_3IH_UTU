<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaConfiguracion))
        Me.lblVentanaConfiguracionIPServidor = New System.Windows.Forms.Label()
        Me.txtVentanaConfiguracionIPServidor = New System.Windows.Forms.TextBox()
        Me.lblVentanaConfiguracionPuerto = New System.Windows.Forms.Label()
        Me.txtVentanaCondiguracionPuerto = New System.Windows.Forms.TextBox()
        Me.btnVentanaConfiguracionOK = New System.Windows.Forms.Button()
        Me.btnVentanaConfiguracionCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblVentanaConfiguracionIPServidor
        '
        Me.lblVentanaConfiguracionIPServidor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVentanaConfiguracionIPServidor.AutoSize = True
        Me.lblVentanaConfiguracionIPServidor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentanaConfiguracionIPServidor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVentanaConfiguracionIPServidor.Location = New System.Drawing.Point(13, 18)
        Me.lblVentanaConfiguracionIPServidor.Name = "lblVentanaConfiguracionIPServidor"
        Me.lblVentanaConfiguracionIPServidor.Size = New System.Drawing.Size(109, 22)
        Me.lblVentanaConfiguracionIPServidor.TabIndex = 9
        Me.lblVentanaConfiguracionIPServidor.Text = "IP servidor"
        '
        'txtVentanaConfiguracionIPServidor
        '
        Me.txtVentanaConfiguracionIPServidor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVentanaConfiguracionIPServidor.Location = New System.Drawing.Point(128, 22)
        Me.txtVentanaConfiguracionIPServidor.MaxLength = 15
        Me.txtVentanaConfiguracionIPServidor.Name = "txtVentanaConfiguracionIPServidor"
        Me.txtVentanaConfiguracionIPServidor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtVentanaConfiguracionIPServidor.Size = New System.Drawing.Size(114, 20)
        Me.txtVentanaConfiguracionIPServidor.TabIndex = 10
        '
        'lblVentanaConfiguracionPuerto
        '
        Me.lblVentanaConfiguracionPuerto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVentanaConfiguracionPuerto.AutoSize = True
        Me.lblVentanaConfiguracionPuerto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentanaConfiguracionPuerto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVentanaConfiguracionPuerto.Location = New System.Drawing.Point(248, 18)
        Me.lblVentanaConfiguracionPuerto.Name = "lblVentanaConfiguracionPuerto"
        Me.lblVentanaConfiguracionPuerto.Size = New System.Drawing.Size(71, 22)
        Me.lblVentanaConfiguracionPuerto.TabIndex = 11
        Me.lblVentanaConfiguracionPuerto.Text = "Puerto"
        '
        'txtVentanaCondiguracionPuerto
        '
        Me.txtVentanaCondiguracionPuerto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVentanaCondiguracionPuerto.Location = New System.Drawing.Point(329, 22)
        Me.txtVentanaCondiguracionPuerto.MaxLength = 6
        Me.txtVentanaCondiguracionPuerto.Name = "txtVentanaCondiguracionPuerto"
        Me.txtVentanaCondiguracionPuerto.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtVentanaCondiguracionPuerto.Size = New System.Drawing.Size(87, 20)
        Me.txtVentanaCondiguracionPuerto.TabIndex = 12
        '
        'btnVentanaConfiguracionOK
        '
        Me.btnVentanaConfiguracionOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVentanaConfiguracionOK.BackColor = System.Drawing.Color.White
        Me.btnVentanaConfiguracionOK.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.checkmark_filled
        Me.btnVentanaConfiguracionOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVentanaConfiguracionOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVentanaConfiguracionOK.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaConfiguracionOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaConfiguracionOK.Location = New System.Drawing.Point(65, 410)
        Me.btnVentanaConfiguracionOK.Name = "btnVentanaConfiguracionOK"
        Me.btnVentanaConfiguracionOK.Size = New System.Drawing.Size(86, 39)
        Me.btnVentanaConfiguracionOK.TabIndex = 13
        Me.btnVentanaConfiguracionOK.UseVisualStyleBackColor = False
        '
        'btnVentanaConfiguracionCancel
        '
        Me.btnVentanaConfiguracionCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVentanaConfiguracionCancel.BackColor = System.Drawing.Color.White
        Me.btnVentanaConfiguracionCancel.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.cancel
        Me.btnVentanaConfiguracionCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVentanaConfiguracionCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVentanaConfiguracionCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaConfiguracionCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaConfiguracionCancel.Location = New System.Drawing.Point(319, 410)
        Me.btnVentanaConfiguracionCancel.Name = "btnVentanaConfiguracionCancel"
        Me.btnVentanaConfiguracionCancel.Size = New System.Drawing.Size(86, 39)
        Me.btnVentanaConfiguracionCancel.TabIndex = 14
        Me.btnVentanaConfiguracionCancel.UseVisualStyleBackColor = False
        '
        'VentanaConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btnVentanaConfiguracionCancel)
        Me.Controls.Add(Me.btnVentanaConfiguracionOK)
        Me.Controls.Add(Me.txtVentanaCondiguracionPuerto)
        Me.Controls.Add(Me.lblVentanaConfiguracionPuerto)
        Me.Controls.Add(Me.txtVentanaConfiguracionIPServidor)
        Me.Controls.Add(Me.lblVentanaConfiguracionIPServidor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "VentanaConfiguracion"
        Me.Text = "Configuracion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVentanaConfiguracionIPServidor As Label
    Friend WithEvents txtVentanaConfiguracionIPServidor As TextBox
    Friend WithEvents lblVentanaConfiguracionPuerto As Label
    Friend WithEvents txtVentanaCondiguracionPuerto As TextBox
    Friend WithEvents btnVentanaConfiguracionOK As Button
    Friend WithEvents btnVentanaConfiguracionCancel As Button
End Class
