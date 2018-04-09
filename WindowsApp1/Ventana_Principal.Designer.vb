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
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.btnMaterias = New System.Windows.Forms.Button()
        Me.tabPrincipal = New System.Windows.Forms.TabControl()
        Me.tabPrincipalAlumnos = New System.Windows.Forms.TabPage()
        Me.tabPrincipalMaterias = New System.Windows.Forms.TabPage()
        Me.tabPrincipalTareas = New System.Windows.Forms.TabPage()
        Me.tabPrincipalDocentes = New System.Windows.Forms.TabPage()
        Me.tabPrincipalUsuarios = New System.Windows.Forms.TabPage()
        Me.btnTareas = New System.Windows.Forms.Button()
        Me.btnDocentes = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFiltrar = New System.Windows.Forms.Label()
        Me.lblAlumnosCedula = New System.Windows.Forms.Label()
        Me.txtAlumnosCedula = New System.Windows.Forms.TextBox()
        Me.lblAlumnosNombre = New System.Windows.Forms.Label()
        Me.txtAlumnosNombre = New System.Windows.Forms.TextBox()
        Me.btnAlumnosFiltrar = New System.Windows.Forms.Button()
        Me.lblAlumnos_Titulo = New WindowsApp1.BorderLabel()
        Me.lblMaterias = New WindowsApp1.BorderLabel()
        Me.lblTareas = New WindowsApp1.BorderLabel()
        Me.lblDocentes = New WindowsApp1.BorderLabel()
        Me.lblUsuarios = New WindowsApp1.BorderLabel()
        Me.b_lblRol_Dinamico = New WindowsApp1.BorderLabel()
        Me.b_lblRol_fijo = New WindowsApp1.BorderLabel()
        Me.b_lblNombreUsuario_Dinamico = New WindowsApp1.BorderLabel()
        Me.b_lblusuarioLogueado_nombre = New WindowsApp1.BorderLabel()
        Me.pnlUsuario_logueado.SuspendLayout()
        Me.tabPrincipal.SuspendLayout()
        Me.tabPrincipalAlumnos.SuspendLayout()
        Me.tabPrincipalMaterias.SuspendLayout()
        Me.tabPrincipalTareas.SuspendLayout()
        Me.tabPrincipalDocentes.SuspendLayout()
        Me.tabPrincipalUsuarios.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogoff
        '
        Me.btnLogoff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogoff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogoff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogoff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogoff.Location = New System.Drawing.Point(12, 525)
        Me.btnLogoff.Name = "btnLogoff"
        Me.btnLogoff.Size = New System.Drawing.Size(211, 39)
        Me.btnLogoff.TabIndex = 5
        Me.btnLogoff.Text = "Log off!"
        Me.btnLogoff.UseVisualStyleBackColor = False
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
        'tabPrincipal
        '
        Me.tabPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPrincipal.Controls.Add(Me.tabPrincipalAlumnos)
        Me.tabPrincipal.Controls.Add(Me.tabPrincipalMaterias)
        Me.tabPrincipal.Controls.Add(Me.tabPrincipalTareas)
        Me.tabPrincipal.Controls.Add(Me.tabPrincipalDocentes)
        Me.tabPrincipal.Controls.Add(Me.tabPrincipalUsuarios)
        Me.tabPrincipal.Location = New System.Drawing.Point(229, 12)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedIndex = 0
        Me.tabPrincipal.Size = New System.Drawing.Size(844, 552)
        Me.tabPrincipal.TabIndex = 10
        '
        'tabPrincipalAlumnos
        '
        Me.tabPrincipalAlumnos.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabPrincipalAlumnos.Controls.Add(Me.Panel1)
        Me.tabPrincipalAlumnos.Controls.Add(Me.lblAlumnos_Titulo)
        Me.tabPrincipalAlumnos.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalAlumnos.Name = "tabPrincipalAlumnos"
        Me.tabPrincipalAlumnos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalAlumnos.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalAlumnos.TabIndex = 0
        Me.tabPrincipalAlumnos.Text = "Alumnos"
        '
        'tabPrincipalMaterias
        '
        Me.tabPrincipalMaterias.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabPrincipalMaterias.Controls.Add(Me.lblMaterias)
        Me.tabPrincipalMaterias.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalMaterias.Name = "tabPrincipalMaterias"
        Me.tabPrincipalMaterias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalMaterias.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalMaterias.TabIndex = 1
        Me.tabPrincipalMaterias.Text = "Materias"
        '
        'tabPrincipalTareas
        '
        Me.tabPrincipalTareas.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabPrincipalTareas.Controls.Add(Me.lblTareas)
        Me.tabPrincipalTareas.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalTareas.Name = "tabPrincipalTareas"
        Me.tabPrincipalTareas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalTareas.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalTareas.TabIndex = 2
        Me.tabPrincipalTareas.Text = "Tareas"
        '
        'tabPrincipalDocentes
        '
        Me.tabPrincipalDocentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabPrincipalDocentes.Controls.Add(Me.lblDocentes)
        Me.tabPrincipalDocentes.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalDocentes.Name = "tabPrincipalDocentes"
        Me.tabPrincipalDocentes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalDocentes.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalDocentes.TabIndex = 3
        Me.tabPrincipalDocentes.Text = "Docentes"
        '
        'tabPrincipalUsuarios
        '
        Me.tabPrincipalUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tabPrincipalUsuarios.Controls.Add(Me.lblUsuarios)
        Me.tabPrincipalUsuarios.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalUsuarios.Name = "tabPrincipalUsuarios"
        Me.tabPrincipalUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalUsuarios.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalUsuarios.TabIndex = 4
        Me.tabPrincipalUsuarios.Text = "Usuarios"
        '
        'btnTareas
        '
        Me.btnTareas.BackColor = System.Drawing.Color.White
        Me.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTareas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTareas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTareas.Location = New System.Drawing.Point(12, 211)
        Me.btnTareas.Name = "btnTareas"
        Me.btnTareas.Size = New System.Drawing.Size(211, 39)
        Me.btnTareas.TabIndex = 11
        Me.btnTareas.Text = "Tareas"
        Me.btnTareas.UseVisualStyleBackColor = False
        '
        'btnDocentes
        '
        Me.btnDocentes.BackColor = System.Drawing.Color.White
        Me.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentes.Location = New System.Drawing.Point(12, 266)
        Me.btnDocentes.Name = "btnDocentes"
        Me.btnDocentes.Size = New System.Drawing.Size(211, 39)
        Me.btnDocentes.TabIndex = 12
        Me.btnDocentes.Text = "Docentes"
        Me.btnDocentes.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsuarios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Location = New System.Drawing.Point(12, 479)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(211, 39)
        Me.btnUsuarios.TabIndex = 13
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAlumnosFiltrar)
        Me.Panel1.Controls.Add(Me.txtAlumnosNombre)
        Me.Panel1.Controls.Add(Me.lblAlumnosNombre)
        Me.Panel1.Controls.Add(Me.txtAlumnosCedula)
        Me.Panel1.Controls.Add(Me.lblAlumnosCedula)
        Me.Panel1.Controls.Add(Me.lblFiltrar)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 100)
        Me.Panel1.TabIndex = 6
        '
        'lblFiltrar
        '
        Me.lblFiltrar.AutoSize = True
        Me.lblFiltrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFiltrar.Location = New System.Drawing.Point(12, 8)
        Me.lblFiltrar.Name = "lblFiltrar"
        Me.lblFiltrar.Size = New System.Drawing.Size(72, 24)
        Me.lblFiltrar.TabIndex = 7
        Me.lblFiltrar.Text = "Filtrar"
        '
        'lblAlumnosCedula
        '
        Me.lblAlumnosCedula.AutoSize = True
        Me.lblAlumnosCedula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnosCedula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnosCedula.Location = New System.Drawing.Point(34, 42)
        Me.lblAlumnosCedula.Name = "lblAlumnosCedula"
        Me.lblAlumnosCedula.Size = New System.Drawing.Size(74, 22)
        Me.lblAlumnosCedula.TabIndex = 8
        Me.lblAlumnosCedula.Text = "Cedula"
        '
        'txtAlumnosCedula
        '
        Me.txtAlumnosCedula.Location = New System.Drawing.Point(131, 43)
        Me.txtAlumnosCedula.Name = "txtAlumnosCedula"
        Me.txtAlumnosCedula.Size = New System.Drawing.Size(185, 20)
        Me.txtAlumnosCedula.TabIndex = 9
        '
        'lblAlumnosNombre
        '
        Me.lblAlumnosNombre.AutoSize = True
        Me.lblAlumnosNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnosNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnosNombre.Location = New System.Drawing.Point(334, 43)
        Me.lblAlumnosNombre.Name = "lblAlumnosNombre"
        Me.lblAlumnosNombre.Size = New System.Drawing.Size(83, 22)
        Me.lblAlumnosNombre.TabIndex = 10
        Me.lblAlumnosNombre.Text = "Nombre"
        Me.lblAlumnosNombre.UseMnemonic = False
        '
        'txtAlumnosNombre
        '
        Me.txtAlumnosNombre.Location = New System.Drawing.Point(454, 47)
        Me.txtAlumnosNombre.Name = "txtAlumnosNombre"
        Me.txtAlumnosNombre.Size = New System.Drawing.Size(185, 20)
        Me.txtAlumnosNombre.TabIndex = 11
        '
        'btnAlumnosFiltrar
        '
        Me.btnAlumnosFiltrar.BackColor = System.Drawing.Color.Blue
        Me.btnAlumnosFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosFiltrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosFiltrar.ForeColor = System.Drawing.Color.White
        Me.btnAlumnosFiltrar.Location = New System.Drawing.Point(661, 35)
        Me.btnAlumnosFiltrar.Name = "btnAlumnosFiltrar"
        Me.btnAlumnosFiltrar.Size = New System.Drawing.Size(133, 37)
        Me.btnAlumnosFiltrar.TabIndex = 15
        Me.btnAlumnosFiltrar.Text = "Filtrar"
        Me.btnAlumnosFiltrar.UseVisualStyleBackColor = False
        '
        'lblAlumnos_Titulo
        '
        Me.lblAlumnos_Titulo.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnos_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnos_Titulo.Location = New System.Drawing.Point(6, 4)
        Me.lblAlumnos_Titulo.Name = "lblAlumnos_Titulo"
        Me.lblAlumnos_Titulo.Size = New System.Drawing.Size(136, 36)
        Me.lblAlumnos_Titulo.TabIndex = 5
        Me.lblAlumnos_Titulo.Text = "Alumnos"
        '
        'lblMaterias
        '
        Me.lblMaterias.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterias.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMaterias.Location = New System.Drawing.Point(3, 4)
        Me.lblMaterias.Name = "lblMaterias"
        Me.lblMaterias.Size = New System.Drawing.Size(136, 36)
        Me.lblMaterias.TabIndex = 11
        Me.lblMaterias.Text = "Materias"
        '
        'lblTareas
        '
        Me.lblTareas.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTareas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTareas.Location = New System.Drawing.Point(6, 5)
        Me.lblTareas.Name = "lblTareas"
        Me.lblTareas.Size = New System.Drawing.Size(136, 36)
        Me.lblTareas.TabIndex = 12
        Me.lblTareas.Text = "Tareas"
        '
        'lblDocentes
        '
        Me.lblDocentes.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDocentes.Location = New System.Drawing.Point(9, 8)
        Me.lblDocentes.Name = "lblDocentes"
        Me.lblDocentes.Size = New System.Drawing.Size(136, 36)
        Me.lblDocentes.TabIndex = 13
        Me.lblDocentes.Text = "Docentes"
        '
        'lblUsuarios
        '
        Me.lblUsuarios.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUsuarios.Location = New System.Drawing.Point(6, 11)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(136, 36)
        Me.lblUsuarios.TabIndex = 14
        Me.lblUsuarios.Text = "Usuarios"
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
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1085, 576)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Controls.Add(Me.btnDocentes)
        Me.Controls.Add(Me.btnTareas)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Controls.Add(Me.btnMaterias)
        Me.Controls.Add(Me.btnAlumnos)
        Me.Controls.Add(Me.pnlUsuario_logueado)
        Me.Controls.Add(Me.btnLogoff)
        Me.Name = "Ventana_Principal"
        Me.Text = "Ventana Principal"
        Me.pnlUsuario_logueado.ResumeLayout(False)
        Me.tabPrincipal.ResumeLayout(False)
        Me.tabPrincipalAlumnos.ResumeLayout(False)
        Me.tabPrincipalMaterias.ResumeLayout(False)
        Me.tabPrincipalTareas.ResumeLayout(False)
        Me.tabPrincipalDocentes.ResumeLayout(False)
        Me.tabPrincipalUsuarios.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents tabPrincipal As TabControl
    Friend WithEvents tabPrincipalAlumnos As TabPage
    Friend WithEvents tabPrincipalMaterias As TabPage
    Friend WithEvents lblMaterias As BorderLabel
    Friend WithEvents tabPrincipalTareas As TabPage
    Friend WithEvents lblTareas As BorderLabel
    Friend WithEvents btnTareas As Button
    Friend WithEvents btnDocentes As Button
    Friend WithEvents tabPrincipalDocentes As TabPage
    Friend WithEvents lblDocentes As BorderLabel
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents tabPrincipalUsuarios As TabPage
    Friend WithEvents lblUsuarios As BorderLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAlumnosFiltrar As Button
    Friend WithEvents txtAlumnosNombre As TextBox
    Friend WithEvents lblAlumnosNombre As Label
    Friend WithEvents txtAlumnosCedula As TextBox
    Friend WithEvents lblAlumnosCedula As Label
    Friend WithEvents lblFiltrar As Label
End Class
