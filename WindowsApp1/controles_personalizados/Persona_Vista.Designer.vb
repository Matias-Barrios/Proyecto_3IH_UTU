<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Persona_Vista
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNombreValue = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblCedulaValue = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblEmailValue = New System.Windows.Forms.Label()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.lblNotaValue = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(12, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 74)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(107, 19)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(50, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        '
        'lblNombreValue
        '
        Me.lblNombreValue.AutoSize = True
        Me.lblNombreValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreValue.Location = New System.Drawing.Point(194, 19)
        Me.lblNombreValue.Name = "lblNombreValue"
        Me.lblNombreValue.Size = New System.Drawing.Size(168, 13)
        Me.lblNombreValue.TabIndex = 4
        Me.lblNombreValue.Text = "XXXXXXXXXXXXXXXXXXXXXXX"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(111, 48)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(46, 13)
        Me.lblCedula.TabIndex = 5
        Me.lblCedula.Text = "Cedula"
        '
        'lblCedulaValue
        '
        Me.lblCedulaValue.AutoSize = True
        Me.lblCedulaValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaValue.Location = New System.Drawing.Point(194, 48)
        Me.lblCedulaValue.Name = "lblCedulaValue"
        Me.lblCedulaValue.Size = New System.Drawing.Size(168, 13)
        Me.lblCedulaValue.TabIndex = 6
        Me.lblCedulaValue.Text = "XXXXXXXXXXXXXXXXXXXXXXX"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(111, 80)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(37, 13)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email"
        '
        'lblEmailValue
        '
        Me.lblEmailValue.AutoSize = True
        Me.lblEmailValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailValue.Location = New System.Drawing.Point(194, 80)
        Me.lblEmailValue.Name = "lblEmailValue"
        Me.lblEmailValue.Size = New System.Drawing.Size(168, 13)
        Me.lblEmailValue.TabIndex = 8
        Me.lblEmailValue.Text = "XXXXXXXXXXXXXXXXXXXXXXX"
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota.Location = New System.Drawing.Point(409, 19)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(34, 13)
        Me.lblNota.TabIndex = 9
        Me.lblNota.Text = "Nota"
        '
        'lblNotaValue
        '
        Me.lblNotaValue.AutoSize = True
        Me.lblNotaValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotaValue.Location = New System.Drawing.Point(449, 19)
        Me.lblNotaValue.Name = "lblNotaValue"
        Me.lblNotaValue.Size = New System.Drawing.Size(21, 13)
        Me.lblNotaValue.TabIndex = 10
        Me.lblNotaValue.Text = "XX"
        '
        'Persona_Vista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblNotaValue)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.lblEmailValue)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblCedulaValue)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblNombreValue)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Persona_Vista"
        Me.Size = New System.Drawing.Size(590, 113)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblNombreValue As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblCedulaValue As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblEmailValue As Label
    Friend WithEvents lblNota As Label
    Friend WithEvents lblNotaValue As Label
End Class
