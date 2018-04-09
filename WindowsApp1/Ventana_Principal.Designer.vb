<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventana_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLogoff = New System.Windows.Forms.Button()
        Me.pnlUsuario_logueado = New System.Windows.Forms.Panel()
        Me.b_lblRol_Dinamico = New WindowsApp1.BorderLabel()
        Me.b_lblRol_fijo = New WindowsApp1.BorderLabel()
        Me.b_lblNombreUsuario_Dinamico = New WindowsApp1.BorderLabel()
        Me.b_lblusuarioLogueado_nombre = New WindowsApp1.BorderLabel()
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.btnMaterias = New System.Windows.Forms.Button()
        Me.pnlAlumnos = New System.Windows.Forms.Panel()
        Me.lblAlumnos_Titulo = New WindowsApp1.BorderLabel()
        Me.pnlMaterias = New System.Windows.Forms.Panel()
        Me.lblMaterias = New WindowsApp1.BorderLabel()
        Me.pnlUsuario_logueado.SuspendLayout()
        Me.pnlAlumnos.SuspendLayout()
        Me.pnlMaterias.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogoff
        '
        Me.btnLogoff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogoff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogoff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogoff.Location = New System.Drawing.Point(12, 525)
        Me.btnLogoff.Name = "btnLogoff"
        Me.btnLogoff.Size = New System.Drawing.Size(211, 39)
        Me.btnLogoff.TabIndex = 5
        Me.btnLogoff.Text = "Log off!"
        Me.btnLogoff.UseVisualStyleBackColor = True
        '
        'pnlUsuario_logueado
        '
        Me.pnlUsuario_logueado.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlUsuario_logueado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlUsuario_logueado.Controls.Add(Me.b_lblRol_Dinamico)
        Me.pnlUsuario_logueado.Controls.Add(Me.b_lblRol_fijo)
        Me.pnlUsuario_logueado.Controls.Add(Me.b_lblNombreUsuario_Dinamico)
        Me.pnlUsuario_logueado.Controls.Add(Me.b_lblusuarioLogueado_nombre)
        Me.pnlUsuario_logueado.Location = New System.Drawing.Point(12, 12)
        Me.pnlUsuario_logueado.Name = "pnlUsuario_logueado"
        Me.pnlUsuario_logueado.Size = New System.Drawing.Size(211, 71)
        Me.pnlUsuario_logueado.TabIndex = 6
        '
        'b_lblRol_Dinamico
        '
        Me.b_lblRol_Dinamico.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblRol_Dinamico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.b_lblRol_Dinamico.Location = New System.Drawing.Point(120, 33)
        Me.b_lblRol_Dinamico.Name = "b_lblRol_Dinamico"
        Me.b_lblRol_Dinamico.Size = New System.Drawing.Size(74, 24)
        Me.b_lblRol_Dinamico.TabIndex = 4
        Me.b_lblRol_Dinamico.Text = "rol"
        '
        'b_lblRol_fijo
        '
        Me.b_lblRol_fijo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblRol_fijo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.b_lblRol_fijo.Location = New System.Drawing.Point(3, 33)
        Me.b_lblRol_fijo.Name = "b_lblRol_fijo"
        Me.b_lblRol_fijo.Size = New System.Drawing.Size(138, 36)
        Me.b_lblRol_fijo.TabIndex = 3
        Me.b_lblRol_fijo.Text = "Rol : "
        '
        'b_lblNombreUsuario_Dinamico
        '
        Me.b_lblNombreUsuario_Dinamico.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblNombreUsuario_Dinamico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.b_lblNombreUsuario_Dinamico.Location = New System.Drawing.Point(122, 7)
        Me.b_lblNombreUsuario_Dinamico.Name = "b_lblNombreUsuario_Dinamico"
        Me.b_lblNombreUsuario_Dinamico.Size = New System.Drawing.Size(79, 24)
        Me.b_lblNombreUsuario_Dinamico.TabIndex = 2
        Me.b_lblNombreUsuario_Dinamico.Text = "usuario"
        '
        'b_lblusuarioLogueado_nombre
        '
        Me.b_lblusuarioLogueado_nombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblusuarioLogueado_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.b_lblusuarioLogueado_nombre.Location = New System.Drawing.Point(4, 7)
        Me.b_lblusuarioLogueado_nombre.Name = "b_lblusuarioLogueado_nombre"
        Me.b_lblusuarioLogueado_nombre.Size = New System.Drawing.Size(120, 36)
        Me.b_lblusuarioLogueado_nombre.TabIndex = 1
        Me.b_lblusuarioLogueado_nombre.Text = "Bienvenido,"
        '
        'btnAlumnos
        '
        Me.btnAlumnos.BackColor = System.Drawing.Color.White
        Me.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnos.Location = New System.Drawing.Point(12, 102)
        Me.btnAlumnos.Name = "btnAlumnos"
        Me.btnAlumnos.Size = New System.Drawing.Size(211, 39)
        Me.btnAlumnos.TabIndex = 7
        Me.btnAlumnos.Text = "Alumnos"
        Me.btnAlumnos.UseVisualStyleBackColor = False
        '
        'btnMaterias
        '
        Me.btnMaterias.BackColor = System.Drawing.Color.White
        Me.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMaterias.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaterias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMaterias.Location = New System.Drawing.Point(12, 156)
        Me.btnMaterias.Name = "btnMaterias"
        Me.btnMaterias.Size = New System.Drawing.Size(211, 39)
        Me.btnMaterias.TabIndex = 8
        Me.btnMaterias.Text = "Materias"
        Me.btnMaterias.UseVisualStyleBackColor = False
        '
        'pnlAlumnos
        '
        Me.pnlAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAlumnos.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlAlumnos.Controls.Add(Me.lblAlumnos_Titulo)
        Me.pnlAlumnos.Location = New System.Drawing.Point(243, 12)
        Me.pnlAlumnos.Name = "pnlAlumnos"
        Me.pnlAlumnos.Size = New System.Drawing.Size(830, 552)
        Me.pnlAlumnos.TabIndex = 9
        Me.pnlAlumnos.Visible = False
        '
        'lblAlumnos_Titulo
        '
        Me.lblAlumnos_Titulo.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnos_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnos_Titulo.Location = New System.Drawing.Point(15, 9)
        Me.lblAlumnos_Titulo.Name = "lblAlumnos_Titulo"
        Me.lblAlumnos_Titulo.Size = New System.Drawing.Size(136, 36)
        Me.lblAlumnos_Titulo.TabIndex = 5
        Me.lblAlumnos_Titulo.Text = "Alumnos"
        '
        'pnlMaterias
        '
        Me.pnlMaterias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMaterias.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlMaterias.Controls.Add(Me.lblMaterias)
        Me.pnlMaterias.Location = New System.Drawing.Point(243, 13)
        Me.pnlMaterias.Name = "pnlMaterias"
        Me.pnlMaterias.Size = New System.Drawing.Size(830, 552)
        Me.pnlMaterias.TabIndex = 10
        Me.pnlMaterias.Visible = False
        '
        'lblMaterias
        '
        Me.lblMaterias.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterias.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMaterias.Location = New System.Drawing.Point(15, 9)
        Me.lblMaterias.Name = "lblMaterias"
        Me.lblMaterias.Size = New System.Drawing.Size(136, 36)
        Me.lblMaterias.TabIndex = 5
        Me.lblMaterias.Text = "Materias"
        '
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1085, 576)
        Me.Controls.Add(Me.pnlMaterias)
        Me.Controls.Add(Me.pnlAlumnos)
        Me.Controls.Add(Me.btnMaterias)
        Me.Controls.Add(Me.btnAlumnos)
        Me.Controls.Add(Me.pnlUsuario_logueado)
        Me.Controls.Add(Me.btnLogoff)
        Me.Name = "Ventana_Principal"
        Me.Text = "Ventana Principal"
        Me.pnlUsuario_logueado.ResumeLayout(False)
        Me.pnlAlumnos.ResumeLayout(False)
        Me.pnlMaterias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogoff As Button
    Friend WithEvents pnlUsuario_logueado As Panel
    Friend WithEvents b_lblRol_Dinamico As BorderLabel
    Friend WithEvents b_lblRol_fijo As BorderLabel
    Friend WithEvents b_lblNombreUsuario_Dinamico As BorderLabel
    Friend WithEvents b_lblusuarioLogueado_nombre As BorderLabel
    Friend WithEvents btnAlumnos As Button
    Friend WithEvents btnMaterias As Button
    Friend WithEvents lblAlumnos_Titulo As BorderLabel
    Friend WithEvents lblMaterias As BorderLabel
    Public WithEvents pnlAlumnos As Panel
    Public WithEvents pnlMaterias As Panel
End Class
