<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_historial
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
        Me.rch_query = New System.Windows.Forms.RichTextBox()
        Me.lbl_info = New WindowsApp1.BorderLabel()
        Me.SuspendLayout()
        '
        'rch_query
        '
        Me.rch_query.Enabled = False
        Me.rch_query.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rch_query.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.rch_query.Location = New System.Drawing.Point(12, 153)
        Me.rch_query.Name = "rch_query"
        Me.rch_query.Size = New System.Drawing.Size(1058, 458)
        Me.rch_query.TabIndex = 17
        Me.rch_query.Text = ""
        '
        'lbl_info
        '
        Me.lbl_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_info.Location = New System.Drawing.Point(12, 9)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(1058, 132)
        Me.lbl_info.TabIndex = 27
        '
        'ventana_historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1082, 623)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.rch_query)
        Me.MaximumSize = New System.Drawing.Size(1098, 661)
        Me.MinimumSize = New System.Drawing.Size(1098, 661)
        Me.Name = "ventana_historial"
        Me.Text = "Detalle de historial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rch_query As RichTextBox
    Friend WithEvents lbl_info As BorderLabel
End Class
