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
        Me.datagridAlumnos = New System.Windows.Forms.DataGridView()
        Me.btnAlumnosModificar = New System.Windows.Forms.Button()
        Me.btnAlumnosEliminar = New System.Windows.Forms.Button()
        Me.btnAlumnosCrearNuevo = New System.Windows.Forms.Button()
        Me.btnAlumnosImprimir = New System.Windows.Forms.Button()
        Me.pnlAlumnosFiltrar = New System.Windows.Forms.Panel()
        Me.btnAlumnosFiltrar = New System.Windows.Forms.Button()
        Me.txtAlumnosFiltrarNombre = New System.Windows.Forms.TextBox()
        Me.lblAlumnosNombre = New System.Windows.Forms.Label()
        Me.txtAlumnosFiltrarCedula = New System.Windows.Forms.TextBox()
        Me.lblAlumnosCedula = New System.Windows.Forms.Label()
        Me.lblAlumnoslblFiltrar = New System.Windows.Forms.Label()
        Me.tabPrincipalMaterias = New System.Windows.Forms.TabPage()
        Me.btnMateriasModificar = New System.Windows.Forms.Button()
        Me.btnMateriasEliminar = New System.Windows.Forms.Button()
        Me.btnMateriasCrear = New System.Windows.Forms.Button()
        Me.datagridMaterias = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMateriasFiltrar = New System.Windows.Forms.Button()
        Me.txtMateriasDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMateriasFiltrarNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMateriasImprimir = New System.Windows.Forms.Button()
        Me.tabPrincipalTareas = New System.Windows.Forms.TabPage()
        Me.datagridCalificaciones = New System.Windows.Forms.DataGridView()
        Me.tabCalificaciones_Vista = New System.Windows.Forms.TabControl()
        Me.tabCalificaciones_Vista_Por_Calificacion = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboCategoriacalifiacion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalificacionesFiltrar = New System.Windows.Forms.Button()
        Me.txtTemaCalificacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIDCalificacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabCalificaiones_Vista_Alumnos = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rdioCalificaciones_Ver_Por_Alumno = New System.Windows.Forms.RadioButton()
        Me.rdioCalificaciones_Ver_Por_Calificacion = New System.Windows.Forms.RadioButton()
        Me.cboAsignatura = New System.Windows.Forms.ComboBox()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.cboInstituto = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbxInstituto = New System.Windows.Forms.Label()
        Me.btnModificarCalificaciones = New System.Windows.Forms.Button()
        Me.btnEliminarCalificaciones = New System.Windows.Forms.Button()
        Me.btnCrearCalificaciones = New System.Windows.Forms.Button()
        Me.btnEvaluacionesImprimir = New System.Windows.Forms.Button()
        Me.tabPrincipalDocentes = New System.Windows.Forms.TabPage()
        Me.btnDocentesModificar = New System.Windows.Forms.Button()
        Me.btnDocentesEliminar = New System.Windows.Forms.Button()
        Me.btnDocentesCrearNuevo = New System.Windows.Forms.Button()
        Me.datagridDocentes = New System.Windows.Forms.DataGridView()
        Me.pnlDocentesFiltros = New System.Windows.Forms.Panel()
        Me.btnDocentesFiltrarRUN = New System.Windows.Forms.Button()
        Me.txtDocenteFiltrarNombre = New System.Windows.Forms.TextBox()
        Me.lblDocentesFiltrarNombre = New System.Windows.Forms.Label()
        Me.txtDocentesFiltrarCedula = New System.Windows.Forms.TextBox()
        Me.lblDocentesFiltrarCedula = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDocentesImprimir = New System.Windows.Forms.Button()
        Me.tabPrincipalUsuarios = New System.Windows.Forms.TabPage()
        Me.pnlUsuariosFiltro = New System.Windows.Forms.Panel()
        Me.btnUsuariosBotonFiltrarNombre = New System.Windows.Forms.Button()
        Me.pnlUsuariosFiltroNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.datagridUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnUsuariosImprimir = New System.Windows.Forms.Button()
        Me.btnUsuariosModificar = New System.Windows.Forms.Button()
        Me.btnUsuariosBotonEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnUsuariosBotonCrearNuevo = New System.Windows.Forms.Button()
        Me.tabpageInstitutos = New System.Windows.Forms.TabPage()
        Me.datagridInstitutos = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnInstitutoFiltrar = New System.Windows.Forms.Button()
        Me.txtNombreInstitutoFiltrar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIDInstitutoFiltrar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnInstitutoImprimir = New System.Windows.Forms.Button()
        Me.btnInstitutoModificar = New System.Windows.Forms.Button()
        Me.btnInstitutoEliminar = New System.Windows.Forms.Button()
        Me.btnInstitutoCrear = New System.Windows.Forms.Button()
        Me.btnTareas = New System.Windows.Forms.Button()
        Me.btnDocentes = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnVentanaPrincipalInstitutos = New System.Windows.Forms.Button()
        Me.btnVentanaPrincipalConfiguracion = New System.Windows.Forms.Button()
        Me.lblAlumnos_Titulo = New WindowsApp1.BorderLabel()
        Me.lblMaterias = New WindowsApp1.BorderLabel()
        Me.lblTareas = New WindowsApp1.BorderLabel()
        Me.lblDocentes = New WindowsApp1.BorderLabel()
        Me.lblUsuarios = New WindowsApp1.BorderLabel()
        Me.BorderLabel1 = New WindowsApp1.BorderLabel()
        Me.b_lblRol_Dinamico = New WindowsApp1.BorderLabel()
        Me.b_lblRol_fijo = New WindowsApp1.BorderLabel()
        Me.b_lblNombreUsuario_Dinamico = New WindowsApp1.BorderLabel()
        Me.b_lblusuarioLogueado_nombre = New WindowsApp1.BorderLabel()
        Me.pnlUsuario_logueado.SuspendLayout()
        Me.tabPrincipal.SuspendLayout()
        Me.tabPrincipalAlumnos.SuspendLayout()
        CType(Me.datagridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAlumnosFiltrar.SuspendLayout()
        Me.tabPrincipalMaterias.SuspendLayout()
        CType(Me.datagridMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tabPrincipalTareas.SuspendLayout()
        CType(Me.datagridCalificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCalificaciones_Vista.SuspendLayout()
        Me.tabCalificaciones_Vista_Por_Calificacion.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tabCalificaiones_Vista_Alumnos.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.tabPrincipalDocentes.SuspendLayout()
        CType(Me.datagridDocentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDocentesFiltros.SuspendLayout()
        Me.tabPrincipalUsuarios.SuspendLayout()
        Me.pnlUsuariosFiltro.SuspendLayout()
        CType(Me.datagridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageInstitutos.SuspendLayout()
        CType(Me.datagridInstitutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogoff
        '
        Me.btnLogoff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogoff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogoff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogoff.Location = New System.Drawing.Point(12, 525)
        Me.btnLogoff.Name = "btnLogoff"
        Me.btnLogoff.Size = New System.Drawing.Size(166, 39)
        Me.btnLogoff.TabIndex = 5
        Me.btnLogoff.Text = "Log off!"
        Me.btnLogoff.UseVisualStyleBackColor = False
        '
        'pnlUsuario_logueado
        '
        Me.pnlUsuario_logueado.BackColor = System.Drawing.Color.Silver
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
        Me.btnAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnMaterias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaterias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMaterias.Location = New System.Drawing.Point(12, 147)
        Me.btnMaterias.Name = "btnMaterias"
        Me.btnMaterias.Size = New System.Drawing.Size(211, 39)
        Me.btnMaterias.TabIndex = 8
        Me.btnMaterias.Text = "Asignaturas"
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
        Me.tabPrincipal.Controls.Add(Me.tabpageInstitutos)
        Me.tabPrincipal.Location = New System.Drawing.Point(229, 12)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedIndex = 0
        Me.tabPrincipal.Size = New System.Drawing.Size(844, 552)
        Me.tabPrincipal.TabIndex = 10
        '
        'tabPrincipalAlumnos
        '
        Me.tabPrincipalAlumnos.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalAlumnos.Controls.Add(Me.datagridAlumnos)
        Me.tabPrincipalAlumnos.Controls.Add(Me.btnAlumnosModificar)
        Me.tabPrincipalAlumnos.Controls.Add(Me.btnAlumnosEliminar)
        Me.tabPrincipalAlumnos.Controls.Add(Me.btnAlumnosCrearNuevo)
        Me.tabPrincipalAlumnos.Controls.Add(Me.btnAlumnosImprimir)
        Me.tabPrincipalAlumnos.Controls.Add(Me.pnlAlumnosFiltrar)
        Me.tabPrincipalAlumnos.Controls.Add(Me.lblAlumnos_Titulo)
        Me.tabPrincipalAlumnos.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalAlumnos.Name = "tabPrincipalAlumnos"
        Me.tabPrincipalAlumnos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalAlumnos.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalAlumnos.TabIndex = 0
        Me.tabPrincipalAlumnos.Text = "Alumnos"
        '
        'datagridAlumnos
        '
        Me.datagridAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datagridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridAlumnos.Location = New System.Drawing.Point(9, 209)
        Me.datagridAlumnos.Name = "datagridAlumnos"
        Me.datagridAlumnos.Size = New System.Drawing.Size(818, 272)
        Me.datagridAlumnos.TabIndex = 30
        '
        'btnAlumnosModificar
        '
        Me.btnAlumnosModificar.BackColor = System.Drawing.Color.White
        Me.btnAlumnosModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnAlumnosModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlumnosModificar.Location = New System.Drawing.Point(121, 47)
        Me.btnAlumnosModificar.Name = "btnAlumnosModificar"
        Me.btnAlumnosModificar.Size = New System.Drawing.Size(50, 50)
        Me.btnAlumnosModificar.TabIndex = 25
        Me.btnAlumnosModificar.UseVisualStyleBackColor = False
        '
        'btnAlumnosEliminar
        '
        Me.btnAlumnosEliminar.BackColor = System.Drawing.Color.White
        Me.btnAlumnosEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.btnAlumnosEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlumnosEliminar.Location = New System.Drawing.Point(65, 47)
        Me.btnAlumnosEliminar.Name = "btnAlumnosEliminar"
        Me.btnAlumnosEliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnAlumnosEliminar.TabIndex = 24
        Me.btnAlumnosEliminar.UseVisualStyleBackColor = False
        '
        'btnAlumnosCrearNuevo
        '
        Me.btnAlumnosCrearNuevo.BackColor = System.Drawing.Color.White
        Me.btnAlumnosCrearNuevo.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.btnAlumnosCrearNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosCrearNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosCrearNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosCrearNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosCrearNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlumnosCrearNuevo.Location = New System.Drawing.Point(9, 47)
        Me.btnAlumnosCrearNuevo.Name = "btnAlumnosCrearNuevo"
        Me.btnAlumnosCrearNuevo.Size = New System.Drawing.Size(50, 50)
        Me.btnAlumnosCrearNuevo.TabIndex = 23
        Me.btnAlumnosCrearNuevo.UseVisualStyleBackColor = False
        '
        'btnAlumnosImprimir
        '
        Me.btnAlumnosImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAlumnosImprimir.BackColor = System.Drawing.Color.White
        Me.btnAlumnosImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnAlumnosImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlumnosImprimir.Location = New System.Drawing.Point(792, 485)
        Me.btnAlumnosImprimir.Name = "btnAlumnosImprimir"
        Me.btnAlumnosImprimir.Size = New System.Drawing.Size(35, 35)
        Me.btnAlumnosImprimir.TabIndex = 21
        Me.btnAlumnosImprimir.UseVisualStyleBackColor = False
        '
        'pnlAlumnosFiltrar
        '
        Me.pnlAlumnosFiltrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAlumnosFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlAlumnosFiltrar.Controls.Add(Me.btnAlumnosFiltrar)
        Me.pnlAlumnosFiltrar.Controls.Add(Me.txtAlumnosFiltrarNombre)
        Me.pnlAlumnosFiltrar.Controls.Add(Me.lblAlumnosNombre)
        Me.pnlAlumnosFiltrar.Controls.Add(Me.txtAlumnosFiltrarCedula)
        Me.pnlAlumnosFiltrar.Controls.Add(Me.lblAlumnosCedula)
        Me.pnlAlumnosFiltrar.Controls.Add(Me.lblAlumnoslblFiltrar)
        Me.pnlAlumnosFiltrar.Location = New System.Drawing.Point(9, 103)
        Me.pnlAlumnosFiltrar.Name = "pnlAlumnosFiltrar"
        Me.pnlAlumnosFiltrar.Size = New System.Drawing.Size(818, 100)
        Me.pnlAlumnosFiltrar.TabIndex = 6
        '
        'btnAlumnosFiltrar
        '
        Me.btnAlumnosFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAlumnosFiltrar.BackColor = System.Drawing.Color.White
        Me.btnAlumnosFiltrar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.find_user_male
        Me.btnAlumnosFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosFiltrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosFiltrar.Location = New System.Drawing.Point(738, 30)
        Me.btnAlumnosFiltrar.Name = "btnAlumnosFiltrar"
        Me.btnAlumnosFiltrar.Size = New System.Drawing.Size(35, 35)
        Me.btnAlumnosFiltrar.TabIndex = 16
        Me.btnAlumnosFiltrar.UseVisualStyleBackColor = False
        '
        'txtAlumnosFiltrarNombre
        '
        Me.txtAlumnosFiltrarNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAlumnosFiltrarNombre.Location = New System.Drawing.Point(380, 45)
        Me.txtAlumnosFiltrarNombre.Name = "txtAlumnosFiltrarNombre"
        Me.txtAlumnosFiltrarNombre.Size = New System.Drawing.Size(338, 20)
        Me.txtAlumnosFiltrarNombre.TabIndex = 11
        '
        'lblAlumnosNombre
        '
        Me.lblAlumnosNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlumnosNombre.AutoSize = True
        Me.lblAlumnosNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnosNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnosNombre.Location = New System.Drawing.Point(297, 43)
        Me.lblAlumnosNombre.Name = "lblAlumnosNombre"
        Me.lblAlumnosNombre.Size = New System.Drawing.Size(79, 24)
        Me.lblAlumnosNombre.TabIndex = 10
        Me.lblAlumnosNombre.Text = "Nombre"
        Me.lblAlumnosNombre.UseMnemonic = False
        '
        'txtAlumnosFiltrarCedula
        '
        Me.txtAlumnosFiltrarCedula.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAlumnosFiltrarCedula.Location = New System.Drawing.Point(104, 45)
        Me.txtAlumnosFiltrarCedula.Name = "txtAlumnosFiltrarCedula"
        Me.txtAlumnosFiltrarCedula.Size = New System.Drawing.Size(185, 20)
        Me.txtAlumnosFiltrarCedula.TabIndex = 9
        '
        'lblAlumnosCedula
        '
        Me.lblAlumnosCedula.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlumnosCedula.AutoSize = True
        Me.lblAlumnosCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnosCedula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnosCedula.Location = New System.Drawing.Point(24, 42)
        Me.lblAlumnosCedula.Name = "lblAlumnosCedula"
        Me.lblAlumnosCedula.Size = New System.Drawing.Size(70, 24)
        Me.lblAlumnosCedula.TabIndex = 8
        Me.lblAlumnosCedula.Text = "Cedula"
        '
        'lblAlumnoslblFiltrar
        '
        Me.lblAlumnoslblFiltrar.AutoSize = True
        Me.lblAlumnoslblFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnoslblFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnoslblFiltrar.Location = New System.Drawing.Point(12, 8)
        Me.lblAlumnoslblFiltrar.Name = "lblAlumnoslblFiltrar"
        Me.lblAlumnoslblFiltrar.Size = New System.Drawing.Size(67, 25)
        Me.lblAlumnoslblFiltrar.TabIndex = 7
        Me.lblAlumnoslblFiltrar.Text = "Filtrar"
        '
        'tabPrincipalMaterias
        '
        Me.tabPrincipalMaterias.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasModificar)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasEliminar)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasCrear)
        Me.tabPrincipalMaterias.Controls.Add(Me.datagridMaterias)
        Me.tabPrincipalMaterias.Controls.Add(Me.Panel1)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasImprimir)
        Me.tabPrincipalMaterias.Controls.Add(Me.lblMaterias)
        Me.tabPrincipalMaterias.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalMaterias.Name = "tabPrincipalMaterias"
        Me.tabPrincipalMaterias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalMaterias.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalMaterias.TabIndex = 1
        Me.tabPrincipalMaterias.Text = "Asignaturas"
        '
        'btnMateriasModificar
        '
        Me.btnMateriasModificar.BackColor = System.Drawing.Color.White
        Me.btnMateriasModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnMateriasModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMateriasModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriasModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriasModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMateriasModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMateriasModificar.Location = New System.Drawing.Point(121, 47)
        Me.btnMateriasModificar.Name = "btnMateriasModificar"
        Me.btnMateriasModificar.Size = New System.Drawing.Size(50, 50)
        Me.btnMateriasModificar.TabIndex = 31
        Me.btnMateriasModificar.UseVisualStyleBackColor = False
        '
        'btnMateriasEliminar
        '
        Me.btnMateriasEliminar.BackColor = System.Drawing.Color.White
        Me.btnMateriasEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.delete_book_trash_education_remove_30d96a3dea2d0c0a_512x512
        Me.btnMateriasEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMateriasEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriasEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriasEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMateriasEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMateriasEliminar.Location = New System.Drawing.Point(65, 47)
        Me.btnMateriasEliminar.Name = "btnMateriasEliminar"
        Me.btnMateriasEliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnMateriasEliminar.TabIndex = 30
        Me.btnMateriasEliminar.UseVisualStyleBackColor = False
        '
        'btnMateriasCrear
        '
        Me.btnMateriasCrear.BackColor = System.Drawing.Color.White
        Me.btnMateriasCrear.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_books_read_literature_512
        Me.btnMateriasCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMateriasCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriasCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriasCrear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMateriasCrear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMateriasCrear.Location = New System.Drawing.Point(9, 47)
        Me.btnMateriasCrear.Name = "btnMateriasCrear"
        Me.btnMateriasCrear.Size = New System.Drawing.Size(50, 50)
        Me.btnMateriasCrear.TabIndex = 29
        Me.btnMateriasCrear.UseVisualStyleBackColor = False
        '
        'datagridMaterias
        '
        Me.datagridMaterias.AllowUserToAddRows = False
        Me.datagridMaterias.AllowUserToDeleteRows = False
        Me.datagridMaterias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridMaterias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datagridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridMaterias.Location = New System.Drawing.Point(9, 209)
        Me.datagridMaterias.Name = "datagridMaterias"
        Me.datagridMaterias.Size = New System.Drawing.Size(818, 272)
        Me.datagridMaterias.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMateriasFiltrar)
        Me.Panel1.Controls.Add(Me.txtMateriasDescripcion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtMateriasFiltrarNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(9, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 100)
        Me.Panel1.TabIndex = 26
        '
        'btnMateriasFiltrar
        '
        Me.btnMateriasFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnMateriasFiltrar.BackColor = System.Drawing.Color.White
        Me.btnMateriasFiltrar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.search_filled
        Me.btnMateriasFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMateriasFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriasFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriasFiltrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMateriasFiltrar.Location = New System.Drawing.Point(626, 52)
        Me.btnMateriasFiltrar.Name = "btnMateriasFiltrar"
        Me.btnMateriasFiltrar.Size = New System.Drawing.Size(35, 35)
        Me.btnMateriasFiltrar.TabIndex = 16
        Me.btnMateriasFiltrar.UseVisualStyleBackColor = False
        '
        'txtMateriasDescripcion
        '
        Me.txtMateriasDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMateriasDescripcion.Location = New System.Drawing.Point(300, 67)
        Me.txtMateriasDescripcion.Name = "txtMateriasDescripcion"
        Me.txtMateriasDescripcion.Size = New System.Drawing.Size(302, 20)
        Me.txtMateriasDescripcion.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(296, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Descripcion"
        Me.Label1.UseMnemonic = False
        '
        'txtMateriasFiltrarNombre
        '
        Me.txtMateriasFiltrarNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMateriasFiltrarNombre.Location = New System.Drawing.Point(28, 67)
        Me.txtMateriasFiltrarNombre.Name = "txtMateriasFiltrarNombre"
        Me.txtMateriasFiltrarNombre.Size = New System.Drawing.Size(185, 20)
        Me.txtMateriasFiltrarNombre.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(24, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre Asignatura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Filtrar"
        '
        'btnMateriasImprimir
        '
        Me.btnMateriasImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMateriasImprimir.BackColor = System.Drawing.Color.White
        Me.btnMateriasImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnMateriasImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMateriasImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriasImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriasImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMateriasImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMateriasImprimir.Location = New System.Drawing.Point(792, 485)
        Me.btnMateriasImprimir.Name = "btnMateriasImprimir"
        Me.btnMateriasImprimir.Size = New System.Drawing.Size(35, 35)
        Me.btnMateriasImprimir.TabIndex = 27
        Me.btnMateriasImprimir.UseVisualStyleBackColor = False
        '
        'tabPrincipalTareas
        '
        Me.tabPrincipalTareas.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalTareas.Controls.Add(Me.datagridCalificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.tabCalificaciones_Vista)
        Me.tabPrincipalTareas.Controls.Add(Me.Panel2)
        Me.tabPrincipalTareas.Controls.Add(Me.btnModificarCalificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.btnEliminarCalificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.btnCrearCalificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.btnEvaluacionesImprimir)
        Me.tabPrincipalTareas.Controls.Add(Me.lblTareas)
        Me.tabPrincipalTareas.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalTareas.Name = "tabPrincipalTareas"
        Me.tabPrincipalTareas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalTareas.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalTareas.TabIndex = 2
        Me.tabPrincipalTareas.Text = "Calificaciones"
        '
        'datagridCalificaciones
        '
        Me.datagridCalificaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridCalificaciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datagridCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridCalificaciones.Location = New System.Drawing.Point(10, 283)
        Me.datagridCalificaciones.Name = "datagridCalificaciones"
        Me.datagridCalificaciones.Size = New System.Drawing.Size(816, 196)
        Me.datagridCalificaciones.TabIndex = 35
        '
        'tabCalificaciones_Vista
        '
        Me.tabCalificaciones_Vista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabCalificaciones_Vista.Controls.Add(Me.tabCalificaciones_Vista_Por_Calificacion)
        Me.tabCalificaciones_Vista.Controls.Add(Me.tabCalificaiones_Vista_Alumnos)
        Me.tabCalificaciones_Vista.Location = New System.Drawing.Point(10, 139)
        Me.tabCalificaciones_Vista.Name = "tabCalificaciones_Vista"
        Me.tabCalificaciones_Vista.SelectedIndex = 0
        Me.tabCalificaciones_Vista.Size = New System.Drawing.Size(816, 138)
        Me.tabCalificaciones_Vista.TabIndex = 40
        '
        'tabCalificaciones_Vista_Por_Calificacion
        '
        Me.tabCalificaciones_Vista_Por_Calificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabCalificaciones_Vista_Por_Calificacion.Controls.Add(Me.Panel3)
        Me.tabCalificaciones_Vista_Por_Calificacion.Location = New System.Drawing.Point(4, 22)
        Me.tabCalificaciones_Vista_Por_Calificacion.Name = "tabCalificaciones_Vista_Por_Calificacion"
        Me.tabCalificaciones_Vista_Por_Calificacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCalificaciones_Vista_Por_Calificacion.Size = New System.Drawing.Size(808, 112)
        Me.tabCalificaciones_Vista_Por_Calificacion.TabIndex = 0
        Me.tabCalificaciones_Vista_Por_Calificacion.Text = "Calificaciones"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cboCategoriacalifiacion)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.btnCalificacionesFiltrar)
        Me.Panel3.Controls.Add(Me.txtTemaCalificacion)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtIDCalificacion)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(-4, -3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(812, 119)
        Me.Panel3.TabIndex = 33
        '
        'cboCategoriacalifiacion
        '
        Me.cboCategoriacalifiacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboCategoriacalifiacion.FormattingEnabled = True
        Me.cboCategoriacalifiacion.Location = New System.Drawing.Point(563, 76)
        Me.cboCategoriacalifiacion.Name = "cboCategoriacalifiacion"
        Me.cboCategoriacalifiacion.Size = New System.Drawing.Size(151, 21)
        Me.cboCategoriacalifiacion.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(559, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 24)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Categoria"
        Me.Label8.UseMnemonic = False
        '
        'btnCalificacionesFiltrar
        '
        Me.btnCalificacionesFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCalificacionesFiltrar.BackColor = System.Drawing.Color.White
        Me.btnCalificacionesFiltrar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.search_filled
        Me.btnCalificacionesFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalificacionesFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalificacionesFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalificacionesFiltrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalificacionesFiltrar.Location = New System.Drawing.Point(742, 61)
        Me.btnCalificacionesFiltrar.Name = "btnCalificacionesFiltrar"
        Me.btnCalificacionesFiltrar.Size = New System.Drawing.Size(35, 35)
        Me.btnCalificacionesFiltrar.TabIndex = 16
        Me.btnCalificacionesFiltrar.UseVisualStyleBackColor = False
        '
        'txtTemaCalificacion
        '
        Me.txtTemaCalificacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTemaCalificacion.Location = New System.Drawing.Point(238, 76)
        Me.txtTemaCalificacion.Name = "txtTemaCalificacion"
        Me.txtTemaCalificacion.Size = New System.Drawing.Size(302, 20)
        Me.txtTemaCalificacion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(234, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tema"
        Me.Label5.UseMnemonic = False
        '
        'txtIDCalificacion
        '
        Me.txtIDCalificacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtIDCalificacion.Location = New System.Drawing.Point(28, 76)
        Me.txtIDCalificacion.Name = "txtIDCalificacion"
        Me.txtIDCalificacion.Size = New System.Drawing.Size(185, 20)
        Me.txtIDCalificacion.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(24, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ID Calificacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(12, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Filtrar"
        '
        'tabCalificaiones_Vista_Alumnos
        '
        Me.tabCalificaiones_Vista_Alumnos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabCalificaiones_Vista_Alumnos.Controls.Add(Me.Panel6)
        Me.tabCalificaiones_Vista_Alumnos.Location = New System.Drawing.Point(4, 22)
        Me.tabCalificaiones_Vista_Alumnos.Name = "tabCalificaiones_Vista_Alumnos"
        Me.tabCalificaiones_Vista_Alumnos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCalificaiones_Vista_Alumnos.Size = New System.Drawing.Size(808, 112)
        Me.tabCalificaiones_Vista_Alumnos.TabIndex = 1
        Me.tabCalificaiones_Vista_Alumnos.Text = "Alumnos"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.TextBox2)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Location = New System.Drawing.Point(-5, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(818, 100)
        Me.Panel6.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.find_user_male
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(738, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.Location = New System.Drawing.Point(380, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(338, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(297, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 24)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Nombre"
        Me.Label13.UseMnemonic = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox2.Location = New System.Drawing.Point(104, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(185, 20)
        Me.TextBox2.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(24, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 24)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Cedula"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(12, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 25)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Filtrar"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.cboAsignatura)
        Me.Panel2.Controls.Add(Me.cboGrupo)
        Me.Panel2.Controls.Add(Me.cboInstituto)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.cbxInstituto)
        Me.Panel2.Location = New System.Drawing.Point(186, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 86)
        Me.Panel2.TabIndex = 39
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rdioCalificaciones_Ver_Por_Alumno)
        Me.Panel4.Controls.Add(Me.rdioCalificaciones_Ver_Por_Calificacion)
        Me.Panel4.Location = New System.Drawing.Point(458, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(164, 57)
        Me.Panel4.TabIndex = 25
        '
        'rdioCalificaciones_Ver_Por_Alumno
        '
        Me.rdioCalificaciones_Ver_Por_Alumno.AutoSize = True
        Me.rdioCalificaciones_Ver_Por_Alumno.BackColor = System.Drawing.Color.Transparent
        Me.rdioCalificaciones_Ver_Por_Alumno.ForeColor = System.Drawing.Color.White
        Me.rdioCalificaciones_Ver_Por_Alumno.Location = New System.Drawing.Point(35, 36)
        Me.rdioCalificaciones_Ver_Por_Alumno.Name = "rdioCalificaciones_Ver_Por_Alumno"
        Me.rdioCalificaciones_Ver_Por_Alumno.Size = New System.Drawing.Size(97, 17)
        Me.rdioCalificaciones_Ver_Por_Alumno.TabIndex = 1
        Me.rdioCalificaciones_Ver_Por_Alumno.Text = "Ver por Alumno"
        Me.rdioCalificaciones_Ver_Por_Alumno.UseVisualStyleBackColor = False
        '
        'rdioCalificaciones_Ver_Por_Calificacion
        '
        Me.rdioCalificaciones_Ver_Por_Calificacion.AutoSize = True
        Me.rdioCalificaciones_Ver_Por_Calificacion.BackColor = System.Drawing.Color.Transparent
        Me.rdioCalificaciones_Ver_Por_Calificacion.Checked = True
        Me.rdioCalificaciones_Ver_Por_Calificacion.ForeColor = System.Drawing.Color.White
        Me.rdioCalificaciones_Ver_Por_Calificacion.Location = New System.Drawing.Point(35, 12)
        Me.rdioCalificaciones_Ver_Por_Calificacion.Name = "rdioCalificaciones_Ver_Por_Calificacion"
        Me.rdioCalificaciones_Ver_Por_Calificacion.Size = New System.Drawing.Size(116, 17)
        Me.rdioCalificaciones_Ver_Por_Calificacion.TabIndex = 0
        Me.rdioCalificaciones_Ver_Por_Calificacion.TabStop = True
        Me.rdioCalificaciones_Ver_Por_Calificacion.Text = "Ver por Calificacion"
        Me.rdioCalificaciones_Ver_Por_Calificacion.UseVisualStyleBackColor = False
        '
        'cboAsignatura
        '
        Me.cboAsignatura.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboAsignatura.FormattingEnabled = True
        Me.cboAsignatura.Location = New System.Drawing.Point(310, 43)
        Me.cboAsignatura.Name = "cboAsignatura"
        Me.cboAsignatura.Size = New System.Drawing.Size(121, 21)
        Me.cboAsignatura.TabIndex = 24
        '
        'cboGrupo
        '
        Me.cboGrupo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Location = New System.Drawing.Point(169, 43)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(121, 21)
        Me.cboGrupo.TabIndex = 23
        '
        'cboInstituto
        '
        Me.cboInstituto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboInstituto.FormattingEnabled = True
        Me.cboInstituto.Location = New System.Drawing.Point(29, 43)
        Me.cboInstituto.Name = "cboInstituto"
        Me.cboInstituto.Size = New System.Drawing.Size(121, 21)
        Me.cboInstituto.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(306, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 20)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Asignatura"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(165, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 20)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Grupo"
        '
        'cbxInstituto
        '
        Me.cbxInstituto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxInstituto.AutoSize = True
        Me.cbxInstituto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxInstituto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cbxInstituto.Location = New System.Drawing.Point(25, 19)
        Me.cbxInstituto.Name = "cbxInstituto"
        Me.cbxInstituto.Size = New System.Drawing.Size(67, 20)
        Me.cbxInstituto.TabIndex = 19
        Me.cbxInstituto.Text = "Instituto"
        '
        'btnModificarCalificaciones
        '
        Me.btnModificarCalificaciones.BackColor = System.Drawing.Color.White
        Me.btnModificarCalificaciones.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnModificarCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarCalificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCalificaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificarCalificaciones.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnModificarCalificaciones.Location = New System.Drawing.Point(121, 47)
        Me.btnModificarCalificaciones.Name = "btnModificarCalificaciones"
        Me.btnModificarCalificaciones.Size = New System.Drawing.Size(50, 50)
        Me.btnModificarCalificaciones.TabIndex = 38
        Me.btnModificarCalificaciones.UseVisualStyleBackColor = False
        '
        'btnEliminarCalificaciones
        '
        Me.btnEliminarCalificaciones.BackColor = System.Drawing.Color.White
        Me.btnEliminarCalificaciones.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.delete_book_trash_education_remove_30d96a3dea2d0c0a_512x512
        Me.btnEliminarCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminarCalificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCalificaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminarCalificaciones.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEliminarCalificaciones.Location = New System.Drawing.Point(65, 47)
        Me.btnEliminarCalificaciones.Name = "btnEliminarCalificaciones"
        Me.btnEliminarCalificaciones.Size = New System.Drawing.Size(50, 50)
        Me.btnEliminarCalificaciones.TabIndex = 37
        Me.btnEliminarCalificaciones.UseVisualStyleBackColor = False
        '
        'btnCrearCalificaciones
        '
        Me.btnCrearCalificaciones.BackColor = System.Drawing.Color.White
        Me.btnCrearCalificaciones.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_books_read_literature_512
        Me.btnCrearCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrearCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearCalificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearCalificaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearCalificaciones.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCrearCalificaciones.Location = New System.Drawing.Point(9, 47)
        Me.btnCrearCalificaciones.Name = "btnCrearCalificaciones"
        Me.btnCrearCalificaciones.Size = New System.Drawing.Size(50, 50)
        Me.btnCrearCalificaciones.TabIndex = 36
        Me.btnCrearCalificaciones.UseVisualStyleBackColor = False
        '
        'btnEvaluacionesImprimir
        '
        Me.btnEvaluacionesImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEvaluacionesImprimir.BackColor = System.Drawing.Color.White
        Me.btnEvaluacionesImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnEvaluacionesImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEvaluacionesImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEvaluacionesImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluacionesImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEvaluacionesImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEvaluacionesImprimir.Location = New System.Drawing.Point(792, 485)
        Me.btnEvaluacionesImprimir.Name = "btnEvaluacionesImprimir"
        Me.btnEvaluacionesImprimir.Size = New System.Drawing.Size(35, 35)
        Me.btnEvaluacionesImprimir.TabIndex = 34
        Me.btnEvaluacionesImprimir.UseVisualStyleBackColor = False
        '
        'tabPrincipalDocentes
        '
        Me.tabPrincipalDocentes.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesModificar)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesEliminar)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesCrearNuevo)
        Me.tabPrincipalDocentes.Controls.Add(Me.datagridDocentes)
        Me.tabPrincipalDocentes.Controls.Add(Me.pnlDocentesFiltros)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesImprimir)
        Me.tabPrincipalDocentes.Controls.Add(Me.lblDocentes)
        Me.tabPrincipalDocentes.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalDocentes.Name = "tabPrincipalDocentes"
        Me.tabPrincipalDocentes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalDocentes.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalDocentes.TabIndex = 3
        Me.tabPrincipalDocentes.Text = "Docentes"
        '
        'btnDocentesModificar
        '
        Me.btnDocentesModificar.BackColor = System.Drawing.Color.White
        Me.btnDocentesModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnDocentesModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesModificar.Location = New System.Drawing.Point(121, 47)
        Me.btnDocentesModificar.Name = "btnDocentesModificar"
        Me.btnDocentesModificar.Size = New System.Drawing.Size(50, 50)
        Me.btnDocentesModificar.TabIndex = 32
        Me.btnDocentesModificar.UseVisualStyleBackColor = False
        '
        'btnDocentesEliminar
        '
        Me.btnDocentesEliminar.BackColor = System.Drawing.Color.White
        Me.btnDocentesEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.btnDocentesEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesEliminar.Location = New System.Drawing.Point(65, 47)
        Me.btnDocentesEliminar.Name = "btnDocentesEliminar"
        Me.btnDocentesEliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnDocentesEliminar.TabIndex = 31
        Me.btnDocentesEliminar.UseVisualStyleBackColor = False
        '
        'btnDocentesCrearNuevo
        '
        Me.btnDocentesCrearNuevo.BackColor = System.Drawing.Color.White
        Me.btnDocentesCrearNuevo.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.btnDocentesCrearNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesCrearNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesCrearNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesCrearNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesCrearNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesCrearNuevo.Location = New System.Drawing.Point(9, 47)
        Me.btnDocentesCrearNuevo.Name = "btnDocentesCrearNuevo"
        Me.btnDocentesCrearNuevo.Size = New System.Drawing.Size(50, 50)
        Me.btnDocentesCrearNuevo.TabIndex = 30
        Me.btnDocentesCrearNuevo.UseVisualStyleBackColor = False
        '
        'datagridDocentes
        '
        Me.datagridDocentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridDocentes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datagridDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridDocentes.Location = New System.Drawing.Point(9, 209)
        Me.datagridDocentes.Name = "datagridDocentes"
        Me.datagridDocentes.Size = New System.Drawing.Size(818, 272)
        Me.datagridDocentes.TabIndex = 29
        '
        'pnlDocentesFiltros
        '
        Me.pnlDocentesFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDocentesFiltros.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlDocentesFiltros.Controls.Add(Me.btnDocentesFiltrarRUN)
        Me.pnlDocentesFiltros.Controls.Add(Me.txtDocenteFiltrarNombre)
        Me.pnlDocentesFiltros.Controls.Add(Me.lblDocentesFiltrarNombre)
        Me.pnlDocentesFiltros.Controls.Add(Me.txtDocentesFiltrarCedula)
        Me.pnlDocentesFiltros.Controls.Add(Me.lblDocentesFiltrarCedula)
        Me.pnlDocentesFiltros.Controls.Add(Me.Label3)
        Me.pnlDocentesFiltros.Location = New System.Drawing.Point(9, 103)
        Me.pnlDocentesFiltros.Name = "pnlDocentesFiltros"
        Me.pnlDocentesFiltros.Size = New System.Drawing.Size(818, 100)
        Me.pnlDocentesFiltros.TabIndex = 27
        '
        'btnDocentesFiltrarRUN
        '
        Me.btnDocentesFiltrarRUN.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnDocentesFiltrarRUN.BackColor = System.Drawing.Color.White
        Me.btnDocentesFiltrarRUN.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.find_user_male
        Me.btnDocentesFiltrarRUN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesFiltrarRUN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesFiltrarRUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesFiltrarRUN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesFiltrarRUN.Location = New System.Drawing.Point(738, 28)
        Me.btnDocentesFiltrarRUN.Name = "btnDocentesFiltrarRUN"
        Me.btnDocentesFiltrarRUN.Size = New System.Drawing.Size(35, 35)
        Me.btnDocentesFiltrarRUN.TabIndex = 16
        Me.btnDocentesFiltrarRUN.UseVisualStyleBackColor = False
        '
        'txtDocenteFiltrarNombre
        '
        Me.txtDocenteFiltrarNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDocenteFiltrarNombre.Location = New System.Drawing.Point(385, 43)
        Me.txtDocenteFiltrarNombre.Name = "txtDocenteFiltrarNombre"
        Me.txtDocenteFiltrarNombre.Size = New System.Drawing.Size(338, 20)
        Me.txtDocenteFiltrarNombre.TabIndex = 11
        '
        'lblDocentesFiltrarNombre
        '
        Me.lblDocentesFiltrarNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDocentesFiltrarNombre.AutoSize = True
        Me.lblDocentesFiltrarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocentesFiltrarNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDocentesFiltrarNombre.Location = New System.Drawing.Point(296, 43)
        Me.lblDocentesFiltrarNombre.Name = "lblDocentesFiltrarNombre"
        Me.lblDocentesFiltrarNombre.Size = New System.Drawing.Size(79, 24)
        Me.lblDocentesFiltrarNombre.TabIndex = 10
        Me.lblDocentesFiltrarNombre.Text = "Nombre"
        Me.lblDocentesFiltrarNombre.UseMnemonic = False
        '
        'txtDocentesFiltrarCedula
        '
        Me.txtDocentesFiltrarCedula.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDocentesFiltrarCedula.Location = New System.Drawing.Point(106, 43)
        Me.txtDocentesFiltrarCedula.Name = "txtDocentesFiltrarCedula"
        Me.txtDocentesFiltrarCedula.Size = New System.Drawing.Size(185, 20)
        Me.txtDocentesFiltrarCedula.TabIndex = 9
        '
        'lblDocentesFiltrarCedula
        '
        Me.lblDocentesFiltrarCedula.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDocentesFiltrarCedula.AutoSize = True
        Me.lblDocentesFiltrarCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocentesFiltrarCedula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDocentesFiltrarCedula.Location = New System.Drawing.Point(24, 42)
        Me.lblDocentesFiltrarCedula.Name = "lblDocentesFiltrarCedula"
        Me.lblDocentesFiltrarCedula.Size = New System.Drawing.Size(70, 24)
        Me.lblDocentesFiltrarCedula.TabIndex = 8
        Me.lblDocentesFiltrarCedula.Text = "Cedula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Filtrar"
        '
        'btnDocentesImprimir
        '
        Me.btnDocentesImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDocentesImprimir.BackColor = System.Drawing.Color.White
        Me.btnDocentesImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnDocentesImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesImprimir.Location = New System.Drawing.Point(792, 485)
        Me.btnDocentesImprimir.Name = "btnDocentesImprimir"
        Me.btnDocentesImprimir.Size = New System.Drawing.Size(35, 35)
        Me.btnDocentesImprimir.TabIndex = 28
        Me.btnDocentesImprimir.UseVisualStyleBackColor = False
        '
        'tabPrincipalUsuarios
        '
        Me.tabPrincipalUsuarios.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tabPrincipalUsuarios.Controls.Add(Me.pnlUsuariosFiltro)
        Me.tabPrincipalUsuarios.Controls.Add(Me.datagridUsuarios)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosImprimir)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosModificar)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosBotonEliminarUsuario)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosBotonCrearNuevo)
        Me.tabPrincipalUsuarios.Controls.Add(Me.lblUsuarios)
        Me.tabPrincipalUsuarios.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalUsuarios.Name = "tabPrincipalUsuarios"
        Me.tabPrincipalUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalUsuarios.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalUsuarios.TabIndex = 4
        Me.tabPrincipalUsuarios.Text = "Usuarios"
        '
        'pnlUsuariosFiltro
        '
        Me.pnlUsuariosFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUsuariosFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlUsuariosFiltro.Controls.Add(Me.btnUsuariosBotonFiltrarNombre)
        Me.pnlUsuariosFiltro.Controls.Add(Me.pnlUsuariosFiltroNombreUsuario)
        Me.pnlUsuariosFiltro.Controls.Add(Me.Label12)
        Me.pnlUsuariosFiltro.Controls.Add(Me.Label14)
        Me.pnlUsuariosFiltro.Location = New System.Drawing.Point(177, 47)
        Me.pnlUsuariosFiltro.Name = "pnlUsuariosFiltro"
        Me.pnlUsuariosFiltro.Size = New System.Drawing.Size(650, 50)
        Me.pnlUsuariosFiltro.TabIndex = 28
        '
        'btnUsuariosBotonFiltrarNombre
        '
        Me.btnUsuariosBotonFiltrarNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnUsuariosBotonFiltrarNombre.BackColor = System.Drawing.Color.White
        Me.btnUsuariosBotonFiltrarNombre.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.find_user_male
        Me.btnUsuariosBotonFiltrarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsuariosBotonFiltrarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsuariosBotonFiltrarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosBotonFiltrarNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsuariosBotonFiltrarNombre.Location = New System.Drawing.Point(597, 8)
        Me.btnUsuariosBotonFiltrarNombre.Name = "btnUsuariosBotonFiltrarNombre"
        Me.btnUsuariosBotonFiltrarNombre.Size = New System.Drawing.Size(35, 35)
        Me.btnUsuariosBotonFiltrarNombre.TabIndex = 16
        Me.btnUsuariosBotonFiltrarNombre.UseVisualStyleBackColor = False
        '
        'pnlUsuariosFiltroNombreUsuario
        '
        Me.pnlUsuariosFiltroNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pnlUsuariosFiltroNombreUsuario.Location = New System.Drawing.Point(274, 23)
        Me.pnlUsuariosFiltroNombreUsuario.Name = "pnlUsuariosFiltroNombreUsuario"
        Me.pnlUsuariosFiltroNombreUsuario.Size = New System.Drawing.Size(307, 20)
        Me.pnlUsuariosFiltroNombreUsuario.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(110, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 24)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Nombre Usuario"
        Me.Label12.UseMnemonic = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(3, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 25)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Filtrar"
        '
        'datagridUsuarios
        '
        Me.datagridUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datagridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridUsuarios.Location = New System.Drawing.Point(9, 105)
        Me.datagridUsuarios.Name = "datagridUsuarios"
        Me.datagridUsuarios.Size = New System.Drawing.Size(818, 376)
        Me.datagridUsuarios.TabIndex = 19
        '
        'btnUsuariosImprimir
        '
        Me.btnUsuariosImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUsuariosImprimir.BackColor = System.Drawing.Color.White
        Me.btnUsuariosImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnUsuariosImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsuariosImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsuariosImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsuariosImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnUsuariosImprimir.Location = New System.Drawing.Point(792, 485)
        Me.btnUsuariosImprimir.Name = "btnUsuariosImprimir"
        Me.btnUsuariosImprimir.Size = New System.Drawing.Size(35, 35)
        Me.btnUsuariosImprimir.TabIndex = 20
        Me.btnUsuariosImprimir.UseVisualStyleBackColor = False
        '
        'btnUsuariosModificar
        '
        Me.btnUsuariosModificar.BackColor = System.Drawing.Color.White
        Me.btnUsuariosModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnUsuariosModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsuariosModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsuariosModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsuariosModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnUsuariosModificar.Location = New System.Drawing.Point(121, 47)
        Me.btnUsuariosModificar.Name = "btnUsuariosModificar"
        Me.btnUsuariosModificar.Size = New System.Drawing.Size(50, 50)
        Me.btnUsuariosModificar.TabIndex = 16
        Me.btnUsuariosModificar.UseVisualStyleBackColor = False
        '
        'btnUsuariosBotonEliminarUsuario
        '
        Me.btnUsuariosBotonEliminarUsuario.BackColor = System.Drawing.Color.White
        Me.btnUsuariosBotonEliminarUsuario.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.btnUsuariosBotonEliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsuariosBotonEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsuariosBotonEliminarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosBotonEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsuariosBotonEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnUsuariosBotonEliminarUsuario.Location = New System.Drawing.Point(65, 47)
        Me.btnUsuariosBotonEliminarUsuario.Name = "btnUsuariosBotonEliminarUsuario"
        Me.btnUsuariosBotonEliminarUsuario.Size = New System.Drawing.Size(50, 50)
        Me.btnUsuariosBotonEliminarUsuario.TabIndex = 15
        Me.btnUsuariosBotonEliminarUsuario.UseVisualStyleBackColor = False
        '
        'btnUsuariosBotonCrearNuevo
        '
        Me.btnUsuariosBotonCrearNuevo.BackColor = System.Drawing.Color.White
        Me.btnUsuariosBotonCrearNuevo.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.btnUsuariosBotonCrearNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsuariosBotonCrearNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsuariosBotonCrearNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosBotonCrearNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsuariosBotonCrearNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnUsuariosBotonCrearNuevo.Location = New System.Drawing.Point(9, 47)
        Me.btnUsuariosBotonCrearNuevo.Name = "btnUsuariosBotonCrearNuevo"
        Me.btnUsuariosBotonCrearNuevo.Size = New System.Drawing.Size(50, 50)
        Me.btnUsuariosBotonCrearNuevo.TabIndex = 14
        Me.btnUsuariosBotonCrearNuevo.UseVisualStyleBackColor = False
        '
        'tabpageInstitutos
        '
        Me.tabpageInstitutos.BackColor = System.Drawing.Color.Silver
        Me.tabpageInstitutos.Controls.Add(Me.datagridInstitutos)
        Me.tabpageInstitutos.Controls.Add(Me.Panel5)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoImprimir)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoModificar)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoEliminar)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoCrear)
        Me.tabpageInstitutos.Controls.Add(Me.BorderLabel1)
        Me.tabpageInstitutos.Location = New System.Drawing.Point(4, 22)
        Me.tabpageInstitutos.Name = "tabpageInstitutos"
        Me.tabpageInstitutos.Size = New System.Drawing.Size(836, 526)
        Me.tabpageInstitutos.TabIndex = 5
        Me.tabpageInstitutos.Text = "Institutos"
        '
        'datagridInstitutos
        '
        Me.datagridInstitutos.AllowUserToAddRows = False
        Me.datagridInstitutos.AllowUserToDeleteRows = False
        Me.datagridInstitutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridInstitutos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datagridInstitutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridInstitutos.Location = New System.Drawing.Point(9, 209)
        Me.datagridInstitutos.Name = "datagridInstitutos"
        Me.datagridInstitutos.Size = New System.Drawing.Size(818, 272)
        Me.datagridInstitutos.TabIndex = 34
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnInstitutoFiltrar)
        Me.Panel5.Controls.Add(Me.txtNombreInstitutoFiltrar)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.txtIDInstitutoFiltrar)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Location = New System.Drawing.Point(9, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(818, 100)
        Me.Panel5.TabIndex = 28
        '
        'btnInstitutoFiltrar
        '
        Me.btnInstitutoFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnInstitutoFiltrar.BackColor = System.Drawing.Color.White
        Me.btnInstitutoFiltrar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.find_user_male
        Me.btnInstitutoFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInstitutoFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInstitutoFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstitutoFiltrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInstitutoFiltrar.Location = New System.Drawing.Point(738, 28)
        Me.btnInstitutoFiltrar.Name = "btnInstitutoFiltrar"
        Me.btnInstitutoFiltrar.Size = New System.Drawing.Size(35, 35)
        Me.btnInstitutoFiltrar.TabIndex = 16
        Me.btnInstitutoFiltrar.UseVisualStyleBackColor = False
        '
        'txtNombreInstitutoFiltrar
        '
        Me.txtNombreInstitutoFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNombreInstitutoFiltrar.Location = New System.Drawing.Point(419, 43)
        Me.txtNombreInstitutoFiltrar.Name = "txtNombreInstitutoFiltrar"
        Me.txtNombreInstitutoFiltrar.Size = New System.Drawing.Size(298, 20)
        Me.txtNombreInstitutoFiltrar.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(330, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 24)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Nombre"
        Me.Label9.UseMnemonic = False
        '
        'txtIDInstitutoFiltrar
        '
        Me.txtIDInstitutoFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtIDInstitutoFiltrar.Location = New System.Drawing.Point(119, 43)
        Me.txtIDInstitutoFiltrar.Name = "txtIDInstitutoFiltrar"
        Me.txtIDInstitutoFiltrar.Size = New System.Drawing.Size(185, 20)
        Me.txtIDInstitutoFiltrar.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(3, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 24)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "ID Instituto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(12, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 25)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Filtrar"
        '
        'btnInstitutoImprimir
        '
        Me.btnInstitutoImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInstitutoImprimir.BackColor = System.Drawing.Color.White
        Me.btnInstitutoImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnInstitutoImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInstitutoImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInstitutoImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstitutoImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInstitutoImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnInstitutoImprimir.Location = New System.Drawing.Point(792, 485)
        Me.btnInstitutoImprimir.Name = "btnInstitutoImprimir"
        Me.btnInstitutoImprimir.Size = New System.Drawing.Size(35, 35)
        Me.btnInstitutoImprimir.TabIndex = 33
        Me.btnInstitutoImprimir.UseVisualStyleBackColor = False
        '
        'btnInstitutoModificar
        '
        Me.btnInstitutoModificar.BackColor = System.Drawing.Color.White
        Me.btnInstitutoModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnInstitutoModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInstitutoModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInstitutoModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstitutoModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInstitutoModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnInstitutoModificar.Location = New System.Drawing.Point(121, 47)
        Me.btnInstitutoModificar.Name = "btnInstitutoModificar"
        Me.btnInstitutoModificar.Size = New System.Drawing.Size(50, 50)
        Me.btnInstitutoModificar.TabIndex = 31
        Me.btnInstitutoModificar.UseVisualStyleBackColor = False
        '
        'btnInstitutoEliminar
        '
        Me.btnInstitutoEliminar.BackColor = System.Drawing.Color.White
        Me.btnInstitutoEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.btnInstitutoEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInstitutoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInstitutoEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstitutoEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInstitutoEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnInstitutoEliminar.Location = New System.Drawing.Point(65, 47)
        Me.btnInstitutoEliminar.Name = "btnInstitutoEliminar"
        Me.btnInstitutoEliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnInstitutoEliminar.TabIndex = 30
        Me.btnInstitutoEliminar.UseVisualStyleBackColor = False
        '
        'btnInstitutoCrear
        '
        Me.btnInstitutoCrear.BackColor = System.Drawing.Color.White
        Me.btnInstitutoCrear.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.btnInstitutoCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInstitutoCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInstitutoCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstitutoCrear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInstitutoCrear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnInstitutoCrear.Location = New System.Drawing.Point(9, 47)
        Me.btnInstitutoCrear.Name = "btnInstitutoCrear"
        Me.btnInstitutoCrear.Size = New System.Drawing.Size(50, 50)
        Me.btnInstitutoCrear.TabIndex = 29
        Me.btnInstitutoCrear.UseVisualStyleBackColor = False
        '
        'btnTareas
        '
        Me.btnTareas.BackColor = System.Drawing.Color.White
        Me.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTareas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTareas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTareas.Location = New System.Drawing.Point(12, 192)
        Me.btnTareas.Name = "btnTareas"
        Me.btnTareas.Size = New System.Drawing.Size(211, 39)
        Me.btnTareas.TabIndex = 11
        Me.btnTareas.Text = "Calificaciones"
        Me.btnTareas.UseVisualStyleBackColor = False
        '
        'btnDocentes
        '
        Me.btnDocentes.BackColor = System.Drawing.Color.White
        Me.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentes.Location = New System.Drawing.Point(12, 237)
        Me.btnDocentes.Name = "btnDocentes"
        Me.btnDocentes.Size = New System.Drawing.Size(211, 39)
        Me.btnDocentes.TabIndex = 12
        Me.btnDocentes.Text = "Docentes"
        Me.btnDocentes.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUsuarios.BackColor = System.Drawing.Color.White
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsuarios.Location = New System.Drawing.Point(12, 479)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(211, 39)
        Me.btnUsuarios.TabIndex = 13
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnVentanaPrincipalInstitutos
        '
        Me.btnVentanaPrincipalInstitutos.BackColor = System.Drawing.Color.White
        Me.btnVentanaPrincipalInstitutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVentanaPrincipalInstitutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaPrincipalInstitutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaPrincipalInstitutos.Location = New System.Drawing.Point(12, 282)
        Me.btnVentanaPrincipalInstitutos.Name = "btnVentanaPrincipalInstitutos"
        Me.btnVentanaPrincipalInstitutos.Size = New System.Drawing.Size(211, 39)
        Me.btnVentanaPrincipalInstitutos.TabIndex = 22
        Me.btnVentanaPrincipalInstitutos.Text = "Institutos"
        Me.btnVentanaPrincipalInstitutos.UseVisualStyleBackColor = False
        '
        'btnVentanaPrincipalConfiguracion
        '
        Me.btnVentanaPrincipalConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVentanaPrincipalConfiguracion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVentanaPrincipalConfiguracion.BackColor = System.Drawing.Color.White
        Me.btnVentanaPrincipalConfiguracion.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.configuration_gears
        Me.btnVentanaPrincipalConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVentanaPrincipalConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVentanaPrincipalConfiguracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaPrincipalConfiguracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaPrincipalConfiguracion.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnVentanaPrincipalConfiguracion.Location = New System.Drawing.Point(184, 525)
        Me.btnVentanaPrincipalConfiguracion.Name = "btnVentanaPrincipalConfiguracion"
        Me.btnVentanaPrincipalConfiguracion.Size = New System.Drawing.Size(39, 39)
        Me.btnVentanaPrincipalConfiguracion.TabIndex = 21
        Me.btnVentanaPrincipalConfiguracion.UseVisualStyleBackColor = False
        '
        'lblAlumnos_Titulo
        '
        Me.lblAlumnos_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnos_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnos_Titulo.Location = New System.Drawing.Point(6, 4)
        Me.lblAlumnos_Titulo.Name = "lblAlumnos_Titulo"
        Me.lblAlumnos_Titulo.Size = New System.Drawing.Size(136, 36)
        Me.lblAlumnos_Titulo.TabIndex = 5
        Me.lblAlumnos_Titulo.Text = "Alumnos"
        '
        'lblMaterias
        '
        Me.lblMaterias.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterias.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMaterias.Location = New System.Drawing.Point(3, 4)
        Me.lblMaterias.Name = "lblMaterias"
        Me.lblMaterias.Size = New System.Drawing.Size(168, 36)
        Me.lblMaterias.TabIndex = 11
        Me.lblMaterias.Text = "Asignaturas"
        '
        'lblTareas
        '
        Me.lblTareas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTareas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTareas.Location = New System.Drawing.Point(3, 3)
        Me.lblTareas.Name = "lblTareas"
        Me.lblTareas.Size = New System.Drawing.Size(219, 36)
        Me.lblTareas.TabIndex = 12
        Me.lblTareas.Text = "Calificaciones"
        '
        'lblDocentes
        '
        Me.lblDocentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDocentes.Location = New System.Drawing.Point(3, 3)
        Me.lblDocentes.Name = "lblDocentes"
        Me.lblDocentes.Size = New System.Drawing.Size(136, 36)
        Me.lblDocentes.TabIndex = 13
        Me.lblDocentes.Text = "Docentes"
        '
        'lblUsuarios
        '
        Me.lblUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUsuarios.Location = New System.Drawing.Point(2, 2)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(136, 36)
        Me.lblUsuarios.TabIndex = 14
        Me.lblUsuarios.Text = "Usuarios"
        '
        'BorderLabel1
        '
        Me.BorderLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorderLabel1.Location = New System.Drawing.Point(2, 1)
        Me.BorderLabel1.Name = "BorderLabel1"
        Me.BorderLabel1.Size = New System.Drawing.Size(136, 36)
        Me.BorderLabel1.TabIndex = 27
        Me.BorderLabel1.Text = "Institutos"
        '
        'b_lblRol_Dinamico
        '
        Me.b_lblRol_Dinamico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblRol_Dinamico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.b_lblRol_Dinamico.Location = New System.Drawing.Point(120, 33)
        Me.b_lblRol_Dinamico.Name = "b_lblRol_Dinamico"
        Me.b_lblRol_Dinamico.Size = New System.Drawing.Size(74, 24)
        Me.b_lblRol_Dinamico.TabIndex = 4
        Me.b_lblRol_Dinamico.Text = "rol"
        '
        'b_lblRol_fijo
        '
        Me.b_lblRol_fijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblRol_fijo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.b_lblRol_fijo.Location = New System.Drawing.Point(3, 33)
        Me.b_lblRol_fijo.Name = "b_lblRol_fijo"
        Me.b_lblRol_fijo.Size = New System.Drawing.Size(138, 36)
        Me.b_lblRol_fijo.TabIndex = 3
        Me.b_lblRol_fijo.Text = "Rol : "
        '
        'b_lblNombreUsuario_Dinamico
        '
        Me.b_lblNombreUsuario_Dinamico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblNombreUsuario_Dinamico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.b_lblNombreUsuario_Dinamico.Location = New System.Drawing.Point(122, 7)
        Me.b_lblNombreUsuario_Dinamico.Name = "b_lblNombreUsuario_Dinamico"
        Me.b_lblNombreUsuario_Dinamico.Size = New System.Drawing.Size(79, 24)
        Me.b_lblNombreUsuario_Dinamico.TabIndex = 2
        Me.b_lblNombreUsuario_Dinamico.Text = "usuario"
        '
        'b_lblusuarioLogueado_nombre
        '
        Me.b_lblusuarioLogueado_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1085, 576)
        Me.Controls.Add(Me.btnVentanaPrincipalInstitutos)
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
        CType(Me.datagridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAlumnosFiltrar.ResumeLayout(False)
        Me.pnlAlumnosFiltrar.PerformLayout()
        Me.tabPrincipalMaterias.ResumeLayout(False)
        CType(Me.datagridMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabPrincipalTareas.ResumeLayout(False)
        CType(Me.datagridCalificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCalificaciones_Vista.ResumeLayout(False)
        Me.tabCalificaciones_Vista_Por_Calificacion.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tabCalificaiones_Vista_Alumnos.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.tabPrincipalDocentes.ResumeLayout(False)
        CType(Me.datagridDocentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDocentesFiltros.ResumeLayout(False)
        Me.pnlDocentesFiltros.PerformLayout()
        Me.tabPrincipalUsuarios.ResumeLayout(False)
        Me.pnlUsuariosFiltro.ResumeLayout(False)
        Me.pnlUsuariosFiltro.PerformLayout()
        CType(Me.datagridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageInstitutos.ResumeLayout(False)
        CType(Me.datagridInstitutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
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
    Friend WithEvents pnlAlumnosFiltrar As Panel
    Friend WithEvents txtAlumnosFiltrarNombre As TextBox
    Friend WithEvents lblAlumnosNombre As Label
    Friend WithEvents txtAlumnosFiltrarCedula As TextBox
    Friend WithEvents lblAlumnosCedula As Label
    Friend WithEvents lblAlumnoslblFiltrar As Label
    Friend WithEvents btnUsuariosBotonCrearNuevo As Button
    Friend WithEvents btnUsuariosBotonEliminarUsuario As Button
    Friend WithEvents btnUsuariosModificar As Button
    Friend WithEvents btnUsuariosImprimir As Button
    Friend WithEvents datagridUsuarios As DataGridView
    Friend WithEvents btnAlumnosFiltrar As Button
    Friend WithEvents btnAlumnosImprimir As Button
    Friend WithEvents btnVentanaPrincipalConfiguracion As Button
    Friend WithEvents btnAlumnosModificar As Button
    Friend WithEvents btnAlumnosEliminar As Button
    Friend WithEvents btnAlumnosCrearNuevo As Button
    Friend WithEvents btnDocentesModificar As Button
    Friend WithEvents btnDocentesEliminar As Button
    Friend WithEvents btnDocentesCrearNuevo As Button
    Friend WithEvents datagridDocentes As DataGridView
    Friend WithEvents btnDocentesImprimir As Button
    Friend WithEvents pnlDocentesFiltros As Panel
    Friend WithEvents btnDocentesFiltrarRUN As Button
    Friend WithEvents txtDocenteFiltrarNombre As TextBox
    Friend WithEvents lblDocentesFiltrarNombre As Label
    Friend WithEvents txtDocentesFiltrarCedula As TextBox
    Friend WithEvents lblDocentesFiltrarCedula As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMateriasModificar As Button
    Friend WithEvents btnMateriasEliminar As Button
    Friend WithEvents btnMateriasCrear As Button
    Friend WithEvents datagridMaterias As DataGridView
    Friend WithEvents btnMateriasImprimir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMateriasFiltrar As Button
    Friend WithEvents txtMateriasDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMateriasFiltrarNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnModificarCalificaciones As Button
    Friend WithEvents btnEliminarCalificaciones As Button
    Friend WithEvents btnCrearCalificaciones As Button
    Friend WithEvents datagridCalificaciones As DataGridView
    Friend WithEvents btnEvaluacionesImprimir As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCalificacionesFiltrar As Button
    Friend WithEvents txtTemaCalificacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIDCalificacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tabpageInstitutos As TabPage
    Friend WithEvents btnInstitutoModificar As Button
    Friend WithEvents btnInstitutoEliminar As Button
    Friend WithEvents btnInstitutoCrear As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnInstitutoFiltrar As Button
    Friend WithEvents txtNombreInstitutoFiltrar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIDInstitutoFiltrar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BorderLabel1 As BorderLabel
    Friend WithEvents btnVentanaPrincipalInstitutos As Button
    Friend WithEvents btnInstitutoImprimir As Button
    Friend WithEvents datagridAlumnos As DataGridView
    Friend WithEvents datagridInstitutos As DataGridView
    Friend WithEvents pnlUsuariosFiltro As Panel
    Friend WithEvents btnUsuariosBotonFiltrarNombre As Button
    Friend WithEvents pnlUsuariosFiltroNombreUsuario As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cboAsignatura As ComboBox
    Friend WithEvents cboGrupo As ComboBox
    Friend WithEvents cboInstituto As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbxInstituto As Label
    Friend WithEvents cboCategoriacalifiacion As ComboBox
    Friend WithEvents tabCalificaciones_Vista As TabControl
    Friend WithEvents tabCalificaciones_Vista_Por_Calificacion As TabPage
    Friend WithEvents tabCalificaiones_Vista_Alumnos As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rdioCalificaciones_Ver_Por_Alumno As RadioButton
    Friend WithEvents rdioCalificaciones_Ver_Por_Calificacion As RadioButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
