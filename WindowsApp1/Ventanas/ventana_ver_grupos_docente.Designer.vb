<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_ver_grupos_docente
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
        Me.btn_ver_grupos_docente_aceptar = New System.Windows.Forms.Button()
        Me.btn_ver_grupos_docente_cancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_ver_cedula_docente = New System.Windows.Forms.TextBox()
        Me.lbl_nombre_docente = New System.Windows.Forms.Label()
        Me.chk_grupos_asignados_docente = New System.Windows.Forms.CheckedListBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ver_grupos_docente_aceptar
        '
        Me.btn_ver_grupos_docente_aceptar.BackColor = System.Drawing.Color.White
        Me.btn_ver_grupos_docente_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ver_grupos_docente_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ver_grupos_docente_aceptar.ForeColor = System.Drawing.Color.Green
        Me.btn_ver_grupos_docente_aceptar.Location = New System.Drawing.Point(494, 495)
        Me.btn_ver_grupos_docente_aceptar.Name = "btn_ver_grupos_docente_aceptar"
        Me.btn_ver_grupos_docente_aceptar.Size = New System.Drawing.Size(183, 32)
        Me.btn_ver_grupos_docente_aceptar.TabIndex = 40
        Me.btn_ver_grupos_docente_aceptar.Text = "Aceptar"
        Me.btn_ver_grupos_docente_aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ver_grupos_docente_aceptar.UseVisualStyleBackColor = False
        '
        'btn_ver_grupos_docente_cancelar
        '
        Me.btn_ver_grupos_docente_cancelar.BackColor = System.Drawing.Color.White
        Me.btn_ver_grupos_docente_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ver_grupos_docente_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ver_grupos_docente_cancelar.ForeColor = System.Drawing.Color.Red
        Me.btn_ver_grupos_docente_cancelar.Location = New System.Drawing.Point(12, 495)
        Me.btn_ver_grupos_docente_cancelar.Name = "btn_ver_grupos_docente_cancelar"
        Me.btn_ver_grupos_docente_cancelar.Size = New System.Drawing.Size(259, 32)
        Me.btn_ver_grupos_docente_cancelar.TabIndex = 39
        Me.btn_ver_grupos_docente_cancelar.Text = "Desvincular seleccionados"
        Me.btn_ver_grupos_docente_cancelar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.chk_grupos_asignados_docente)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 453)
        Me.Panel1.TabIndex = 38
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_ver_cedula_docente)
        Me.Panel2.Controls.Add(Me.lbl_nombre_docente)
        Me.Panel2.Location = New System.Drawing.Point(16, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(639, 42)
        Me.Panel2.TabIndex = 30
        '
        'txt_ver_cedula_docente
        '
        Me.txt_ver_cedula_docente.Enabled = False
        Me.txt_ver_cedula_docente.Location = New System.Drawing.Point(436, 13)
        Me.txt_ver_cedula_docente.MaxLength = 10
        Me.txt_ver_cedula_docente.Name = "txt_ver_cedula_docente"
        Me.txt_ver_cedula_docente.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_ver_cedula_docente.ShortcutsEnabled = False
        Me.txt_ver_cedula_docente.Size = New System.Drawing.Size(190, 20)
        Me.txt_ver_cedula_docente.TabIndex = 31
        '
        'lbl_nombre_docente
        '
        Me.lbl_nombre_docente.AutoSize = True
        Me.lbl_nombre_docente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_docente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_nombre_docente.Location = New System.Drawing.Point(10, 8)
        Me.lbl_nombre_docente.Name = "lbl_nombre_docente"
        Me.lbl_nombre_docente.Size = New System.Drawing.Size(0, 24)
        Me.lbl_nombre_docente.TabIndex = 18
        Me.lbl_nombre_docente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_grupos_asignados_docente
        '
        Me.chk_grupos_asignados_docente.FormattingEnabled = True
        Me.chk_grupos_asignados_docente.Location = New System.Drawing.Point(16, 96)
        Me.chk_grupos_asignados_docente.Name = "chk_grupos_asignados_docente"
        Me.chk_grupos_asignados_docente.Size = New System.Drawing.Size(639, 349)
        Me.chk_grupos_asignados_docente.TabIndex = 31
        '
        'ventana_ver_grupos_docente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(682, 537)
        Me.Controls.Add(Me.btn_ver_grupos_docente_aceptar)
        Me.Controls.Add(Me.btn_ver_grupos_docente_cancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ventana_ver_grupos_docente"
        Me.Text = "Grupos asignados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_ver_grupos_docente_aceptar As Button
    Friend WithEvents btn_ver_grupos_docente_cancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_ver_cedula_docente As TextBox
    Friend WithEvents lbl_nombre_docente As Label
    Friend WithEvents chk_grupos_asignados_docente As CheckedListBox
End Class
