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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_Principal))
        Me.btnLogoff = New System.Windows.Forms.Button()
        Me.pnlUsuario_logueado = New System.Windows.Forms.Panel()
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.btnMaterias = New System.Windows.Forms.Button()
        Me.tabPrincipal = New System.Windows.Forms.TabControl()
        Me.tabPrincipalAlumnos = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAlumnosNombre = New System.Windows.Forms.TextBox()
        Me.lblAlumnosNombre = New System.Windows.Forms.Label()
        Me.txtAlumnosCedula = New System.Windows.Forms.TextBox()
        Me.lblAlumnosCedula = New System.Windows.Forms.Label()
        Me.lblFiltrar = New System.Windows.Forms.Label()
        Me.tabPrincipalMaterias = New System.Windows.Forms.TabPage()
        Me.tabPrincipalTareas = New System.Windows.Forms.TabPage()
        Me.tabPrincipalDocentes = New System.Windows.Forms.TabPage()
        Me.tabPrincipalUsuarios = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlUsuariosFiltroNombreUsuario = New System.Windows.Forms.TextBox()
        Me.pnlUsuariolblNombreUsuario = New System.Windows.Forms.Label()
        Me.pnlUsuarioslblFiltrar = New System.Windows.Forms.Label()
        Me.btnTareas = New System.Windows.Forms.Button()
        Me.btnDocentes = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnVentanaPrincipalConfiguracion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAlumnosFiltrar = New System.Windows.Forms.Button()
        Me.pnlUsuariosBotonImprimir = New System.Windows.Forms.Button()
        Me.pnlUsuariosBotonFiltrarNombre = New System.Windows.Forms.Button()
        Me.pnlUsuariosCargarUsuarios = New System.Windows.Forms.Button()
        Me.pnlUsuariosModificar = New System.Windows.Forms.Button()
        Me.pnlUsuariosBotonEliminarUsuario = New System.Windows.Forms.Button()
        Me.pnlUsuariosBotonCrearNuevo = New System.Windows.Forms.Button()
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
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tabPrincipalMaterias.SuspendLayout()
        Me.tabPrincipalTareas.SuspendLayout()
        Me.tabPrincipalDocentes.SuspendLayout()
        Me.tabPrincipalUsuarios.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogoff
        '
        Me.btnLogoff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogoff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogoff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogoff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogoff.Location = New System.Drawing.Point(12, 525)
        Me.btnLogoff.Name = "btnLogoff"
        Me.btnLogoff.Size = New System.Drawing.Size(151, 39)
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
        Me.tabPrincipalAlumnos.Controls.Add(Me.DataGridView2)
        Me.tabPrincipalAlumnos.Controls.Add(Me.Button1)
        Me.tabPrincipalAlumnos.Controls.Add(Me.Panel1)
        Me.tabPrincipalAlumnos.Controls.Add(Me.lblAlumnos_Titulo)
        Me.tabPrincipalAlumnos.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalAlumnos.Name = "tabPrincipalAlumnos"
        Me.tabPrincipalAlumnos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalAlumnos.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalAlumnos.TabIndex = 0
        Me.tabPrincipalAlumnos.Text = "Alumnos"
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 149)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(817, 330)
        Me.DataGridView2.TabIndex = 22
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
        'txtAlumnosNombre
        '
        Me.txtAlumnosNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlumnosNombre.Location = New System.Drawing.Point(385, 43)
        Me.txtAlumnosNombre.Name = "txtAlumnosNombre"
        Me.txtAlumnosNombre.Size = New System.Drawing.Size(338, 20)
        Me.txtAlumnosNombre.TabIndex = 11
        '
        'lblAlumnosNombre
        '
        Me.lblAlumnosNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlumnosNombre.AutoSize = True
        Me.lblAlumnosNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnosNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnosNombre.Location = New System.Drawing.Point(296, 43)
        Me.lblAlumnosNombre.Name = "lblAlumnosNombre"
        Me.lblAlumnosNombre.Size = New System.Drawing.Size(83, 22)
        Me.lblAlumnosNombre.TabIndex = 10
        Me.lblAlumnosNombre.Text = "Nombre"
        Me.lblAlumnosNombre.UseMnemonic = False
        '
        'txtAlumnosCedula
        '
        Me.txtAlumnosCedula.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlumnosCedula.Location = New System.Drawing.Point(106, 43)
        Me.txtAlumnosCedula.Name = "txtAlumnosCedula"
        Me.txtAlumnosCedula.Size = New System.Drawing.Size(185, 20)
        Me.txtAlumnosCedula.TabIndex = 9
        '
        'lblAlumnosCedula
        '
        Me.lblAlumnosCedula.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlumnosCedula.AutoSize = True
        Me.lblAlumnosCedula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnosCedula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnosCedula.Location = New System.Drawing.Point(24, 42)
        Me.lblAlumnosCedula.Name = "lblAlumnosCedula"
        Me.lblAlumnosCedula.Size = New System.Drawing.Size(74, 22)
        Me.lblAlumnosCedula.TabIndex = 8
        Me.lblAlumnosCedula.Text = "Cedula"
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
        Me.tabPrincipalUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tabPrincipalUsuarios.Controls.Add(Me.pnlUsuariosBotonImprimir)
        Me.tabPrincipalUsuarios.Controls.Add(Me.DataGridView1)
        Me.tabPrincipalUsuarios.Controls.Add(Me.Panel2)
        Me.tabPrincipalUsuarios.Controls.Add(Me.pnlUsuariosCargarUsuarios)
        Me.tabPrincipalUsuarios.Controls.Add(Me.pnlUsuariosModificar)
        Me.tabPrincipalUsuarios.Controls.Add(Me.pnlUsuariosBotonEliminarUsuario)
        Me.tabPrincipalUsuarios.Controls.Add(Me.pnlUsuariosBotonCrearNuevo)
        Me.tabPrincipalUsuarios.Controls.Add(Me.lblUsuarios)
        Me.tabPrincipalUsuarios.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalUsuarios.Name = "tabPrincipalUsuarios"
        Me.tabPrincipalUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalUsuarios.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalUsuarios.TabIndex = 4
        Me.tabPrincipalUsuarios.Text = "Usuarios"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(819, 362)
        Me.DataGridView1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pnlUsuariosBotonFiltrarNombre)
        Me.Panel2.Controls.Add(Me.pnlUsuariosFiltroNombreUsuario)
        Me.Panel2.Controls.Add(Me.pnlUsuariolblNombreUsuario)
        Me.Panel2.Controls.Add(Me.pnlUsuarioslblFiltrar)
        Me.Panel2.Location = New System.Drawing.Point(293, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(532, 69)
        Me.Panel2.TabIndex = 18
        '
        'pnlUsuariosFiltroNombreUsuario
        '
        Me.pnlUsuariosFiltroNombreUsuario.Location = New System.Drawing.Point(194, 41)
        Me.pnlUsuariosFiltroNombreUsuario.Name = "pnlUsuariosFiltroNombreUsuario"
        Me.pnlUsuariosFiltroNombreUsuario.Size = New System.Drawing.Size(234, 20)
        Me.pnlUsuariosFiltroNombreUsuario.TabIndex = 11
        '
        'pnlUsuariolblNombreUsuario
        '
        Me.pnlUsuariolblNombreUsuario.AutoSize = True
        Me.pnlUsuariolblNombreUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUsuariolblNombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlUsuariolblNombreUsuario.Location = New System.Drawing.Point(7, 38)
        Me.pnlUsuariolblNombreUsuario.Name = "pnlUsuariolblNombreUsuario"
        Me.pnlUsuariolblNombreUsuario.Size = New System.Drawing.Size(183, 22)
        Me.pnlUsuariolblNombreUsuario.TabIndex = 10
        Me.pnlUsuariolblNombreUsuario.Text = "Nombre de usuario"
        '
        'pnlUsuarioslblFiltrar
        '
        Me.pnlUsuarioslblFiltrar.AutoSize = True
        Me.pnlUsuarioslblFiltrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUsuarioslblFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlUsuarioslblFiltrar.Location = New System.Drawing.Point(3, 3)
        Me.pnlUsuarioslblFiltrar.Name = "pnlUsuarioslblFiltrar"
        Me.pnlUsuarioslblFiltrar.Size = New System.Drawing.Size(72, 24)
        Me.pnlUsuarioslblFiltrar.TabIndex = 8
        Me.pnlUsuarioslblFiltrar.Text = "Filtrar"
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
        'btnVentanaPrincipalConfiguracion
        '
        Me.btnVentanaPrincipalConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVentanaPrincipalConfiguracion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVentanaPrincipalConfiguracion.BackColor = System.Drawing.Color.White
        Me.btnVentanaPrincipalConfiguracion.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.configuration_gears
        Me.btnVentanaPrincipalConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVentanaPrincipalConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVentanaPrincipalConfiguracion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaPrincipalConfiguracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaPrincipalConfiguracion.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnVentanaPrincipalConfiguracion.Location = New System.Drawing.Point(169, 525)
        Me.btnVentanaPrincipalConfiguracion.Name = "btnVentanaPrincipalConfiguracion"
        Me.btnVentanaPrincipalConfiguracion.Size = New System.Drawing.Size(52, 39)
        Me.btnVentanaPrincipalConfiguracion.TabIndex = 21
        Me.btnVentanaPrincipalConfiguracion.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(12, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 35)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAlumnosFiltrar
        '
        Me.btnAlumnosFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAlumnosFiltrar.BackColor = System.Drawing.Color.White
        Me.btnAlumnosFiltrar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.find_user_male
        Me.btnAlumnosFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosFiltrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosFiltrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosFiltrar.Location = New System.Drawing.Point(729, 25)
        Me.btnAlumnosFiltrar.Name = "btnAlumnosFiltrar"
        Me.btnAlumnosFiltrar.Size = New System.Drawing.Size(55, 47)
        Me.btnAlumnosFiltrar.TabIndex = 16
        Me.btnAlumnosFiltrar.UseVisualStyleBackColor = False
        '
        'pnlUsuariosBotonImprimir
        '
        Me.pnlUsuariosBotonImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlUsuariosBotonImprimir.BackColor = System.Drawing.Color.White
        Me.pnlUsuariosBotonImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.pnlUsuariosBotonImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlUsuariosBotonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pnlUsuariosBotonImprimir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUsuariosBotonImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlUsuariosBotonImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.pnlUsuariosBotonImprimir.Location = New System.Drawing.Point(7, 489)
        Me.pnlUsuariosBotonImprimir.Name = "pnlUsuariosBotonImprimir"
        Me.pnlUsuariosBotonImprimir.Size = New System.Drawing.Size(45, 35)
        Me.pnlUsuariosBotonImprimir.TabIndex = 20
        Me.pnlUsuariosBotonImprimir.UseVisualStyleBackColor = False
        '
        'pnlUsuariosBotonFiltrarNombre
        '
        Me.pnlUsuariosBotonFiltrarNombre.BackColor = System.Drawing.Color.White
        Me.pnlUsuariosBotonFiltrarNombre.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.find_user_male
        Me.pnlUsuariosBotonFiltrarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlUsuariosBotonFiltrarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pnlUsuariosBotonFiltrarNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUsuariosBotonFiltrarNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlUsuariosBotonFiltrarNombre.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.pnlUsuariosBotonFiltrarNombre.Location = New System.Drawing.Point(464, 7)
        Me.pnlUsuariosBotonFiltrarNombre.Name = "pnlUsuariosBotonFiltrarNombre"
        Me.pnlUsuariosBotonFiltrarNombre.Size = New System.Drawing.Size(59, 57)
        Me.pnlUsuariosBotonFiltrarNombre.TabIndex = 19
        Me.pnlUsuariosBotonFiltrarNombre.UseVisualStyleBackColor = False
        '
        'pnlUsuariosCargarUsuarios
        '
        Me.pnlUsuariosCargarUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlUsuariosCargarUsuarios.BackColor = System.Drawing.Color.White
        Me.pnlUsuariosCargarUsuarios.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.database_restore
        Me.pnlUsuariosCargarUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlUsuariosCargarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pnlUsuariosCargarUsuarios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUsuariosCargarUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlUsuariosCargarUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.pnlUsuariosCargarUsuarios.Location = New System.Drawing.Point(6, 50)
        Me.pnlUsuariosCargarUsuarios.Name = "pnlUsuariosCargarUsuarios"
        Me.pnlUsuariosCargarUsuarios.Size = New System.Drawing.Size(59, 57)
        Me.pnlUsuariosCargarUsuarios.TabIndex = 17
        Me.pnlUsuariosCargarUsuarios.UseVisualStyleBackColor = False
        '
        'pnlUsuariosModificar
        '
        Me.pnlUsuariosModificar.BackColor = System.Drawing.Color.White
        Me.pnlUsuariosModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.pnlUsuariosModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlUsuariosModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pnlUsuariosModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUsuariosModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlUsuariosModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.pnlUsuariosModificar.Location = New System.Drawing.Point(206, 50)
        Me.pnlUsuariosModificar.Name = "pnlUsuariosModificar"
        Me.pnlUsuariosModificar.Size = New System.Drawing.Size(59, 57)
        Me.pnlUsuariosModificar.TabIndex = 16
        Me.pnlUsuariosModificar.UseVisualStyleBackColor = False
        '
        'pnlUsuariosBotonEliminarUsuario
        '
        Me.pnlUsuariosBotonEliminarUsuario.BackColor = System.Drawing.Color.White
        Me.pnlUsuariosBotonEliminarUsuario.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.pnlUsuariosBotonEliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlUsuariosBotonEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pnlUsuariosBotonEliminarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUsuariosBotonEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlUsuariosBotonEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.pnlUsuariosBotonEliminarUsuario.Location = New System.Drawing.Point(140, 50)
        Me.pnlUsuariosBotonEliminarUsuario.Name = "pnlUsuariosBotonEliminarUsuario"
        Me.pnlUsuariosBotonEliminarUsuario.Size = New System.Drawing.Size(59, 57)
        Me.pnlUsuariosBotonEliminarUsuario.TabIndex = 15
        Me.pnlUsuariosBotonEliminarUsuario.UseVisualStyleBackColor = False
        '
        'pnlUsuariosBotonCrearNuevo
        '
        Me.pnlUsuariosBotonCrearNuevo.BackColor = System.Drawing.Color.White
        Me.pnlUsuariosBotonCrearNuevo.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.pnlUsuariosBotonCrearNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlUsuariosBotonCrearNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pnlUsuariosBotonCrearNuevo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUsuariosBotonCrearNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlUsuariosBotonCrearNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.pnlUsuariosBotonCrearNuevo.Location = New System.Drawing.Point(74, 50)
        Me.pnlUsuariosBotonCrearNuevo.Name = "pnlUsuariosBotonCrearNuevo"
        Me.pnlUsuariosBotonCrearNuevo.Size = New System.Drawing.Size(59, 57)
        Me.pnlUsuariosBotonCrearNuevo.TabIndex = 14
        Me.pnlUsuariosBotonCrearNuevo.UseVisualStyleBackColor = False
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
        Me.Controls.Add(Me.btnVentanaPrincipalConfiguracion)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Controls.Add(Me.btnDocentes)
        Me.Controls.Add(Me.btnTareas)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Controls.Add(Me.btnMaterias)
        Me.Controls.Add(Me.btnAlumnos)
        Me.Controls.Add(Me.pnlUsuario_logueado)
        Me.Controls.Add(Me.btnLogoff)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventana_Principal"
        Me.Text = "Ventana Principal"
        Me.pnlUsuario_logueado.ResumeLayout(False)
        Me.tabPrincipal.ResumeLayout(False)
        Me.tabPrincipalAlumnos.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabPrincipalMaterias.ResumeLayout(False)
        Me.tabPrincipalTareas.ResumeLayout(False)
        Me.tabPrincipalDocentes.ResumeLayout(False)
        Me.tabPrincipalUsuarios.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents txtAlumnosNombre As TextBox
    Friend WithEvents lblAlumnosNombre As Label
    Friend WithEvents txtAlumnosCedula As TextBox
    Friend WithEvents lblAlumnosCedula As Label
    Friend WithEvents lblFiltrar As Label
    Friend WithEvents pnlUsuariosBotonCrearNuevo As Button
    Friend WithEvents pnlUsuariosBotonEliminarUsuario As Button
    Friend WithEvents pnlUsuariosModificar As Button
    Friend WithEvents pnlUsuariosCargarUsuarios As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlUsuariosFiltroNombreUsuario As TextBox
    Friend WithEvents pnlUsuariolblNombreUsuario As Label
    Friend WithEvents pnlUsuarioslblFiltrar As Label
    Friend WithEvents pnlUsuariosBotonFiltrarNombre As Button
    Friend WithEvents pnlUsuariosBotonImprimir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAlumnosFiltrar As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnVentanaPrincipalConfiguracion As Button
End Class
