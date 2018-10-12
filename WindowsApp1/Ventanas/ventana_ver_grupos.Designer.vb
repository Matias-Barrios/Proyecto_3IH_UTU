<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_ver_grupos
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
        Me.lstGruposDeDocente = New System.Windows.Forms.ListBox()
        Me.lblDocentes = New WindowsApp1.BorderLabel()
        Me.Alumnos = New WindowsApp1.BorderLabel()
        Me.dgvP_alumnos_del_grupo = New WindowsApp1.DGVPaginado()
        Me.SuspendLayout()
        '
        'lstGruposDeDocente
        '
        Me.lstGruposDeDocente.FormattingEnabled = True
        Me.lstGruposDeDocente.Location = New System.Drawing.Point(12, 64)
        Me.lstGruposDeDocente.Name = "lstGruposDeDocente"
        Me.lstGruposDeDocente.Size = New System.Drawing.Size(317, 537)
        Me.lstGruposDeDocente.TabIndex = 0
        '
        'lblDocentes
        '
        Me.lblDocentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDocentes.Location = New System.Drawing.Point(12, 9)
        Me.lblDocentes.Name = "lblDocentes"
        Me.lblDocentes.Size = New System.Drawing.Size(136, 36)
        Me.lblDocentes.TabIndex = 14
        Me.lblDocentes.Text = "Grupo"
        '
        'Alumnos
        '
        Me.Alumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alumnos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Alumnos.Location = New System.Drawing.Point(342, 9)
        Me.Alumnos.Name = "Alumnos"
        Me.Alumnos.Size = New System.Drawing.Size(338, 36)
        Me.Alumnos.TabIndex = 16
        Me.Alumnos.Text = "Alumno del grupo"
        '
        'dgvP_alumnos_del_grupo
        '
        Me.dgvP_alumnos_del_grupo.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_alumnos_del_grupo.Location = New System.Drawing.Point(348, 64)
        Me.dgvP_alumnos_del_grupo.Name = "dgvP_alumnos_del_grupo"
        Me.dgvP_alumnos_del_grupo.Size = New System.Drawing.Size(994, 537)
        Me.dgvP_alumnos_del_grupo.TabIndex = 17
        '
        'ventana_ver_grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1354, 613)
        Me.Controls.Add(Me.dgvP_alumnos_del_grupo)
        Me.Controls.Add(Me.Alumnos)
        Me.Controls.Add(Me.lblDocentes)
        Me.Controls.Add(Me.lstGruposDeDocente)
        Me.Name = "ventana_ver_grupos"
        Me.Text = "ventana_ver_grupos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstGruposDeDocente As ListBox
    Friend WithEvents lblDocentes As BorderLabel
    Friend WithEvents Alumnos As BorderLabel
    Friend WithEvents dgvP_alumnos_del_grupo As DGVPaginado
End Class
