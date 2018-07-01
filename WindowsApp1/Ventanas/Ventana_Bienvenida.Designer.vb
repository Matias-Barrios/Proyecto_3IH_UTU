<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Bienvenida
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
        Me.btnIngresarAlSistema = New System.Windows.Forms.Button()
        Me.btnModoInvitado = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIngresarAlSistema
        '
        Me.btnIngresarAlSistema.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIngresarAlSistema.BackColor = System.Drawing.Color.White
        Me.btnIngresarAlSistema.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIngresarAlSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarAlSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIngresarAlSistema.Location = New System.Drawing.Point(39, 472)
        Me.btnIngresarAlSistema.Name = "btnIngresarAlSistema"
        Me.btnIngresarAlSistema.Size = New System.Drawing.Size(211, 39)
        Me.btnIngresarAlSistema.TabIndex = 8
        Me.btnIngresarAlSistema.Text = "Ingresar al sistema"
        Me.btnIngresarAlSistema.UseVisualStyleBackColor = False
        '
        'btnModoInvitado
        '
        Me.btnModoInvitado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModoInvitado.BackColor = System.Drawing.Color.White
        Me.btnModoInvitado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModoInvitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModoInvitado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModoInvitado.Location = New System.Drawing.Point(527, 472)
        Me.btnModoInvitado.Name = "btnModoInvitado"
        Me.btnModoInvitado.Size = New System.Drawing.Size(211, 39)
        Me.btnModoInvitado.TabIndex = 9
        Me.btnModoInvitado.Text = "Modo Invitado"
        Me.btnModoInvitado.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.isologotipo
        Me.PictureBox1.Location = New System.Drawing.Point(121, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(509, 414)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Ventana_Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnModoInvitado)
        Me.Controls.Add(Me.btnIngresarAlSistema)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Ventana_Bienvenida"
        Me.Text = "Ventana_Bienvenida"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIngresarAlSistema As Button
    Friend WithEvents btnModoInvitado As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
