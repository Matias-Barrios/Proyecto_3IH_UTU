<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agregar_a_grupo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.btnAdmin_Aceptar = New System.Windows.Forms.Button()
        Me.btnAdmin_Cancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(13, 22)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(344, 349)
        Me.CheckedListBox1.TabIndex = 0
        '
        'btnAdmin_Aceptar
        '
        Me.btnAdmin_Aceptar.BackColor = System.Drawing.Color.White
        Me.btnAdmin_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmin_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin_Aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnAdmin_Aceptar.Location = New System.Drawing.Point(278, 501)
        Me.btnAdmin_Aceptar.Name = "btnAdmin_Aceptar"
        Me.btnAdmin_Aceptar.Size = New System.Drawing.Size(183, 32)
        Me.btnAdmin_Aceptar.TabIndex = 44
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
        Me.btnAdmin_Cancelar.Location = New System.Drawing.Point(49, 501)
        Me.btnAdmin_Cancelar.Name = "btnAdmin_Cancelar"
        Me.btnAdmin_Cancelar.Size = New System.Drawing.Size(183, 32)
        Me.btnAdmin_Cancelar.TabIndex = 45
        Me.btnAdmin_Cancelar.Text = "Cancelar"
        Me.btnAdmin_Cancelar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.CheckedListBox1)
        Me.Panel1.Location = New System.Drawing.Point(49, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 431)
        Me.Panel1.TabIndex = 43
        '
        'Agregar_a_grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(470, 573)
        Me.Controls.Add(Me.btnAdmin_Aceptar)
        Me.Controls.Add(Me.btnAdmin_Cancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Agregar_a_grupo"
        Me.Text = "Agregar_a_grupo"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents btnAdmin_Aceptar As Button
    Friend WithEvents btnAdmin_Cancelar As Button
    Friend WithEvents Panel1 As Panel
End Class
