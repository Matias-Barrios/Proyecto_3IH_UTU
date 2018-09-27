<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ventana_ver_alumnado
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
        Me.pnlCrearAsignatura = New System.Windows.Forms.Panel()
        Me.lblCrearAsignatura_Descripcion = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_ver_alumnado = New System.Windows.Forms.Label()
        Me.btnver_alumnado_aceptar = New System.Windows.Forms.Button()
        Me.btnCrearAsignaturaCancelar = New System.Windows.Forms.Button()
        Me.dgvP_ver_alumnado = New WindowsApp1.DGVPaginado()
        Me.pnlCrearAsignatura.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCrearAsignatura
        '
        Me.pnlCrearAsignatura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCrearAsignatura.BackColor = System.Drawing.Color.Gray
        Me.pnlCrearAsignatura.Controls.Add(Me.dgvP_ver_alumnado)
        Me.pnlCrearAsignatura.Controls.Add(Me.lblCrearAsignatura_Descripcion)
        Me.pnlCrearAsignatura.Controls.Add(Me.Panel2)
        Me.pnlCrearAsignatura.Location = New System.Drawing.Point(12, 12)
        Me.pnlCrearAsignatura.Name = "pnlCrearAsignatura"
        Me.pnlCrearAsignatura.Size = New System.Drawing.Size(1080, 522)
        Me.pnlCrearAsignatura.TabIndex = 26
        '
        'lblCrearAsignatura_Descripcion
        '
        Me.lblCrearAsignatura_Descripcion.AutoSize = True
        Me.lblCrearAsignatura_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAsignatura_Descripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAsignatura_Descripcion.Location = New System.Drawing.Point(28, 73)
        Me.lblCrearAsignatura_Descripcion.Name = "lblCrearAsignatura_Descripcion"
        Me.lblCrearAsignatura_Descripcion.Size = New System.Drawing.Size(85, 24)
        Me.lblCrearAsignatura_Descripcion.TabIndex = 32
        Me.lblCrearAsignatura_Descripcion.Text = "Alumnos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_ver_alumnado)
        Me.Panel2.Location = New System.Drawing.Point(22, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1043, 42)
        Me.Panel2.TabIndex = 30
        '
        'lbl_ver_alumnado
        '
        Me.lbl_ver_alumnado.AutoSize = True
        Me.lbl_ver_alumnado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ver_alumnado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_ver_alumnado.Location = New System.Drawing.Point(6, 9)
        Me.lbl_ver_alumnado.Name = "lbl_ver_alumnado"
        Me.lbl_ver_alumnado.Size = New System.Drawing.Size(63, 24)
        Me.lbl_ver_alumnado.TabIndex = 19
        Me.lbl_ver_alumnado.Text = "Grupo"
        '
        'btnver_alumnado_aceptar
        '
        Me.btnver_alumnado_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnver_alumnado_aceptar.BackColor = System.Drawing.Color.White
        Me.btnver_alumnado_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnver_alumnado_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnver_alumnado_aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnver_alumnado_aceptar.Location = New System.Drawing.Point(860, 542)
        Me.btnver_alumnado_aceptar.Name = "btnver_alumnado_aceptar"
        Me.btnver_alumnado_aceptar.Size = New System.Drawing.Size(232, 32)
        Me.btnver_alumnado_aceptar.TabIndex = 42
        Me.btnver_alumnado_aceptar.Text = "Aceptar"
        Me.btnver_alumnado_aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnver_alumnado_aceptar.UseVisualStyleBackColor = False
        '
        'btnCrearAsignaturaCancelar
        '
        Me.btnCrearAsignaturaCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearAsignaturaCancelar.BackColor = System.Drawing.Color.White
        Me.btnCrearAsignaturaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearAsignaturaCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearAsignaturaCancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCrearAsignaturaCancelar.Location = New System.Drawing.Point(12, 540)
        Me.btnCrearAsignaturaCancelar.Name = "btnCrearAsignaturaCancelar"
        Me.btnCrearAsignaturaCancelar.Size = New System.Drawing.Size(247, 32)
        Me.btnCrearAsignaturaCancelar.TabIndex = 43
        Me.btnCrearAsignaturaCancelar.Text = "Desvincular alumno del grupo"
        Me.btnCrearAsignaturaCancelar.UseVisualStyleBackColor = False
        '
        'dgvP_ver_alumnado
        '
        Me.dgvP_ver_alumnado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_ver_alumnado.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_ver_alumnado.Location = New System.Drawing.Point(22, 100)
        Me.dgvP_ver_alumnado.Name = "dgvP_ver_alumnado"
        Me.dgvP_ver_alumnado.Size = New System.Drawing.Size(1043, 407)
        Me.dgvP_ver_alumnado.TabIndex = 42
        '
        'ventana_ver_alumnado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1104, 591)
        Me.Controls.Add(Me.btnCrearAsignaturaCancelar)
        Me.Controls.Add(Me.btnver_alumnado_aceptar)
        Me.Controls.Add(Me.pnlCrearAsignatura)
        Me.MaximumSize = New System.Drawing.Size(1120, 629)
        Me.MinimumSize = New System.Drawing.Size(1120, 629)
        Me.Name = "ventana_ver_alumnado"
        Me.Text = "ventana_ver_alumnado"
        Me.pnlCrearAsignatura.ResumeLayout(False)
        Me.pnlCrearAsignatura.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCrearAsignatura As Panel
    Friend WithEvents lblCrearAsignatura_Descripcion As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_ver_alumnado As Label
    Friend WithEvents btnver_alumnado_aceptar As Button
    Friend WithEvents btnCrearAsignaturaCancelar As Button
    Friend WithEvents dgvP_ver_alumnado As DGVPaginado
End Class
