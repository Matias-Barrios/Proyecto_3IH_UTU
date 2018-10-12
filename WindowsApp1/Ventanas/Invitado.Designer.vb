<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invitado
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
        Me.txtalumnosci = New System.Windows.Forms.TextBox()
        Me.lblingreseci = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.lblnotapro = New System.Windows.Forms.Label()
        Me.lblvalornotapro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnotafinalaprobacion = New System.Windows.Forms.Label()
        Me.DgvCalificacion = New WindowsApp1.DGVPaginado()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtalumnosci
        '
        Me.txtalumnosci.Location = New System.Drawing.Point(188, 40)
        Me.txtalumnosci.MaxLength = 8
        Me.txtalumnosci.Name = "txtalumnosci"
        Me.txtalumnosci.Size = New System.Drawing.Size(100, 20)
        Me.txtalumnosci.TabIndex = 0
        '
        'lblingreseci
        '
        Me.lblingreseci.AutoSize = True
        Me.lblingreseci.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblingreseci.ForeColor = System.Drawing.Color.White
        Me.lblingreseci.Location = New System.Drawing.Point(30, 40)
        Me.lblingreseci.Name = "lblingreseci"
        Me.lblingreseci.Size = New System.Drawing.Size(117, 20)
        Me.lblingreseci.TabIndex = 1
        Me.lblingreseci.Text = "Ingrese Cedula"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnconsultar)
        Me.Panel1.Controls.Add(Me.lblingreseci)
        Me.Panel1.Controls.Add(Me.txtalumnosci)
        Me.Panel1.Location = New System.Drawing.Point(26, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 100)
        Me.Panel1.TabIndex = 3
        '
        'btnconsultar
        '
        Me.btnconsultar.BackColor = System.Drawing.Color.White
        Me.btnconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnconsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnconsultar.Location = New System.Drawing.Point(337, 40)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(201, 20)
        Me.btnconsultar.TabIndex = 5
        Me.btnconsultar.Text = "Consultar"
        Me.btnconsultar.UseVisualStyleBackColor = False
        '
        'lblnotapro
        '
        Me.lblnotapro.AutoSize = True
        Me.lblnotapro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotapro.ForeColor = System.Drawing.Color.White
        Me.lblnotapro.Location = New System.Drawing.Point(37, 354)
        Me.lblnotapro.Name = "lblnotapro"
        Me.lblnotapro.Size = New System.Drawing.Size(147, 20)
        Me.lblnotapro.TabIndex = 3
        Me.lblnotapro.Text = "Nota Final Proyecto"
        '
        'lblvalornotapro
        '
        Me.lblvalornotapro.AutoSize = True
        Me.lblvalornotapro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalornotapro.ForeColor = System.Drawing.Color.White
        Me.lblvalornotapro.Location = New System.Drawing.Point(188, 354)
        Me.lblvalornotapro.Name = "lblvalornotapro"
        Me.lblvalornotapro.Size = New System.Drawing.Size(0, 20)
        Me.lblvalornotapro.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(346, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nota Final Aprobacion Curso"
        '
        'lblnotafinalaprobacion
        '
        Me.lblnotafinalaprobacion.AutoSize = True
        Me.lblnotafinalaprobacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotafinalaprobacion.ForeColor = System.Drawing.Color.White
        Me.lblnotafinalaprobacion.Location = New System.Drawing.Point(564, 354)
        Me.lblnotafinalaprobacion.Name = "lblnotafinalaprobacion"
        Me.lblnotafinalaprobacion.Size = New System.Drawing.Size(0, 20)
        Me.lblnotafinalaprobacion.TabIndex = 6
        '
        'DgvCalificacion
        '
        Me.DgvCalificacion.BackColor = System.Drawing.Color.AliceBlue
        Me.DgvCalificacion.Location = New System.Drawing.Point(26, 122)
        Me.DgvCalificacion.Name = "DgvCalificacion"
        Me.DgvCalificacion.Size = New System.Drawing.Size(687, 218)
        Me.DgvCalificacion.TabIndex = 7
        '
        'Invitado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(736, 395)
        Me.Controls.Add(Me.DgvCalificacion)
        Me.Controls.Add(Me.lblnotafinalaprobacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblvalornotapro)
        Me.Controls.Add(Me.lblnotapro)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Invitado"
        Me.Text = "Invitado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtalumnosci As TextBox
    Friend WithEvents lblingreseci As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblnotapro As Label
    Friend WithEvents lblvalornotapro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblnotafinalaprobacion As Label
    Friend WithEvents DgvCalificacion As DGVPaginado
    Friend WithEvents btnconsultar As Button
End Class
