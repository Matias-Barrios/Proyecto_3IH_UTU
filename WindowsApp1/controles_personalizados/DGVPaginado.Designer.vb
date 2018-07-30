<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGVPaginado
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.dgv_Vista = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_UltimaPagina = New System.Windows.Forms.Button()
        Me.btn_Primera = New System.Windows.Forms.Button()
        Me.btn_Prev = New System.Windows.Forms.Button()
        Me.btn_Siguiente = New System.Windows.Forms.Button()
        Me.lbl_vista_numeracion = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        CType(Me.dgv_Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Vista
        '
        Me.dgv_Vista.AllowUserToAddRows = False
        Me.dgv_Vista.AllowUserToDeleteRows = False
        Me.dgv_Vista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Vista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Vista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Vista.Location = New System.Drawing.Point(4, 24)
        Me.dgv_Vista.Name = "dgv_Vista"
        Me.dgv_Vista.ReadOnly = True
        Me.dgv_Vista.Size = New System.Drawing.Size(692, 374)
        Me.dgv_Vista.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_UltimaPagina)
        Me.Panel1.Controls.Add(Me.btn_Primera)
        Me.Panel1.Controls.Add(Me.btn_Prev)
        Me.Panel1.Controls.Add(Me.btn_Siguiente)
        Me.Panel1.Controls.Add(Me.lbl_vista_numeracion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 410)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 46)
        Me.Panel1.TabIndex = 1
        '
        'btn_UltimaPagina
        '
        Me.btn_UltimaPagina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_UltimaPagina.Location = New System.Drawing.Point(514, 13)
        Me.btn_UltimaPagina.Name = "btn_UltimaPagina"
        Me.btn_UltimaPagina.Size = New System.Drawing.Size(103, 23)
        Me.btn_UltimaPagina.TabIndex = 15
        Me.btn_UltimaPagina.Text = "Ultima pagina"
        Me.btn_UltimaPagina.UseVisualStyleBackColor = True
        '
        'btn_Primera
        '
        Me.btn_Primera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Primera.Location = New System.Drawing.Point(84, 13)
        Me.btn_Primera.Name = "btn_Primera"
        Me.btn_Primera.Size = New System.Drawing.Size(103, 23)
        Me.btn_Primera.TabIndex = 14
        Me.btn_Primera.Text = "Primera pagina"
        Me.btn_Primera.UseVisualStyleBackColor = True
        '
        'btn_Prev
        '
        Me.btn_Prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Prev.Location = New System.Drawing.Point(4, 13)
        Me.btn_Prev.Name = "btn_Prev"
        Me.btn_Prev.Size = New System.Drawing.Size(75, 23)
        Me.btn_Prev.TabIndex = 11
        Me.btn_Prev.Text = "Previo"
        Me.btn_Prev.UseVisualStyleBackColor = True
        '
        'btn_Siguiente
        '
        Me.btn_Siguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Siguiente.Location = New System.Drawing.Point(621, 13)
        Me.btn_Siguiente.Name = "btn_Siguiente"
        Me.btn_Siguiente.Size = New System.Drawing.Size(75, 23)
        Me.btn_Siguiente.TabIndex = 12
        Me.btn_Siguiente.Text = "Siguiente"
        Me.btn_Siguiente.UseVisualStyleBackColor = True
        '
        'lbl_vista_numeracion
        '
        Me.lbl_vista_numeracion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_vista_numeracion.Location = New System.Drawing.Point(4, 10)
        Me.lbl_vista_numeracion.Name = "lbl_vista_numeracion"
        Me.lbl_vista_numeracion.Size = New System.Drawing.Size(692, 24)
        Me.lbl_vista_numeracion.TabIndex = 13
        Me.lbl_vista_numeracion.Text = "0"
        Me.lbl_vista_numeracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFiltro
        '
        Me.txtFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFiltro.Location = New System.Drawing.Point(0, 0)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(699, 20)
        Me.txtFiltro.TabIndex = 2
        '
        'DGVPaginado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_Vista)
        Me.Name = "DGVPaginado"
        Me.Size = New System.Drawing.Size(699, 456)
        CType(Me.dgv_Vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Vista As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_UltimaPagina As Button
    Friend WithEvents btn_Primera As Button
    Friend WithEvents btn_Prev As Button
    Friend WithEvents btn_Siguiente As Button
    Friend WithEvents lbl_vista_numeracion As Label
    Friend WithEvents txtFiltro As TextBox
End Class
