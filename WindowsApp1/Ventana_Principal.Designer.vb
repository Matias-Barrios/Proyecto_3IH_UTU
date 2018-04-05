<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Principal
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
        Me.btnLogoff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogoff
        '
        Me.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogoff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogoff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogoff.Location = New System.Drawing.Point(872, 525)
        Me.btnLogoff.Name = "btnLogoff"
        Me.btnLogoff.Size = New System.Drawing.Size(201, 39)
        Me.btnLogoff.TabIndex = 5
        Me.btnLogoff.Text = "Log off!"
        Me.btnLogoff.UseVisualStyleBackColor = True
        '
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1085, 576)
        Me.Controls.Add(Me.btnLogoff)
        Me.Name = "Ventana_Principal"
        Me.Text = "Ventana Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogoff As Button
End Class
