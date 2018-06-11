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
        Me.pnlAlumnosFichas = New System.Windows.Forms.Panel()
        Me.pnlAlumnosFiltrar = New System.Windows.Forms.Panel()
        Me.txtAlumnosFiltrarNombre = New System.Windows.Forms.TextBox()
        Me.lblAlumnosNombre = New System.Windows.Forms.Label()
        Me.txtAlumnosFiltrarCedula = New System.Windows.Forms.TextBox()
        Me.lblAlumnosCedula = New System.Windows.Forms.Label()
        Me.lblAlumnoslblFiltrar = New System.Windows.Forms.Label()
        Me.tabPrincipalMaterias = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMateriasDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMateriasFiltrarNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabPrincipalTareas = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbxEvaluacionesTipoEvaluacion = New System.Windows.Forms.ListBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabPrincipalDocentes = New System.Windows.Forms.TabPage()
        Me.datagridDocentes = New System.Windows.Forms.DataGridView()
        Me.pnlDocentesFiltros = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDocentesFiltrarNombre = New System.Windows.Forms.Label()
        Me.txtDocentesFiltrarCedula = New System.Windows.Forms.TextBox()
        Me.lblDocentesFiltrarCedula = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.btnAlumnosModificar = New System.Windows.Forms.Button()
        Me.btnAlumnosEliminar = New System.Windows.Forms.Button()
        Me.btnAlumnosCrearNuevo = New System.Windows.Forms.Button()
        Me.btnAlumnosImprimir = New System.Windows.Forms.Button()
        Me.btnAlumnosFiltrar = New System.Windows.Forms.Button()
        Me.btnMateriasModificar = New System.Windows.Forms.Button()
        Me.btnMateriasEliminar = New System.Windows.Forms.Button()
        Me.btnMateriasCrear = New System.Windows.Forms.Button()
        Me.btnMateriasFiltrar = New System.Windows.Forms.Button()
        Me.btnMateriasImprimir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnEvaluacionesImprimir = New System.Windows.Forms.Button()
        Me.btnDocentesModificar = New System.Windows.Forms.Button()
        Me.btnDocentesEliminar = New System.Windows.Forms.Button()
        Me.btnDocentesCrearNuevo = New System.Windows.Forms.Button()
        Me.btnDocentesFiltrarRUN = New System.Windows.Forms.Button()
        Me.btnDocentesImprimir = New System.Windows.Forms.Button()
        Me.pnlUsuariosBotonImprimir = New System.Windows.Forms.Button()
        Me.pnlUsuariosBotonFiltrarNombre = New System.Windows.Forms.Button()
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
        Me.btnVentanaPrincipalInstitutos = New System.Windows.Forms.Button()
        Me.tabpageInstitutos = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BorderLabel1 = New WindowsApp1.BorderLabel()
        Me.pnlUsuario_logueado.SuspendLayout()
        Me.tabPrincipal.SuspendLayout()
        Me.tabPrincipalAlumnos.SuspendLayout()
        Me.pnlAlumnosFiltrar.SuspendLayout()
        Me.tabPrincipalMaterias.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tabPrincipalTareas.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.tabPrincipalDocentes.SuspendLayout()
        CType(Me.datagridDocentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDocentesFiltros.SuspendLayout()
        Me.tabPrincipalUsuarios.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tabpageInstitutos.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.tabPrincipalAlumnos.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabPrincipalAlumnos.Controls.Add(Me.pnlAlumnosFichas)
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
        'pnlAlumnosFichas
        '
        Me.pnlAlumnosFichas.Location = New System.Drawing.Point(12, 232)
        Me.pnlAlumnosFichas.Name = "pnlAlumnosFichas"
        Me.pnlAlumnosFichas.Size = New System.Drawing.Size(818, 247)
        Me.pnlAlumnosFichas.TabIndex = 26
        '
        'pnlAlumnosFiltrar
        '
        Me.pnlAlumnosFiltrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAlumnosFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlAlumnosFiltrar.Controls.Add(Me.btnAlumnosFiltrar)
        Me.pnlAlumnosFiltrar.Controls.Add(Me.txtAlumnosFiltrarNombre)
        Me.pnlAlumnosFiltrar.Controls.Add(Me.lblAlumnosNombre)
        Me.pnlAlumnosFiltrar.Controls.Add(Me.txtAlumnosFiltrarCedula)
        Me.pnlAlumnosFiltrar.Controls.Add(Me.lblAlumnosCedula)
        Me.pnlAlumnosFiltrar.Controls.Add(Me.lblAlumnoslblFiltrar)
        Me.pnlAlumnosFiltrar.Location = New System.Drawing.Point(12, 101)
        Me.pnlAlumnosFiltrar.Name = "pnlAlumnosFiltrar"
        Me.pnlAlumnosFiltrar.Size = New System.Drawing.Size(818, 100)
        Me.pnlAlumnosFiltrar.TabIndex = 6
        '
        'txtAlumnosFiltrarNombre
        '
        Me.txtAlumnosFiltrarNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlumnosFiltrarNombre.Location = New System.Drawing.Point(385, 43)
        Me.txtAlumnosFiltrarNombre.Name = "txtAlumnosFiltrarNombre"
        Me.txtAlumnosFiltrarNombre.Size = New System.Drawing.Size(338, 20)
        Me.txtAlumnosFiltrarNombre.TabIndex = 11
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
        'txtAlumnosFiltrarCedula
        '
        Me.txtAlumnosFiltrarCedula.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlumnosFiltrarCedula.Location = New System.Drawing.Point(106, 43)
        Me.txtAlumnosFiltrarCedula.Name = "txtAlumnosFiltrarCedula"
        Me.txtAlumnosFiltrarCedula.Size = New System.Drawing.Size(185, 20)
        Me.txtAlumnosFiltrarCedula.TabIndex = 9
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
        'lblAlumnoslblFiltrar
        '
        Me.lblAlumnoslblFiltrar.AutoSize = True
        Me.lblAlumnoslblFiltrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnoslblFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnoslblFiltrar.Location = New System.Drawing.Point(12, 8)
        Me.lblAlumnoslblFiltrar.Name = "lblAlumnoslblFiltrar"
        Me.lblAlumnoslblFiltrar.Size = New System.Drawing.Size(72, 24)
        Me.lblAlumnoslblFiltrar.TabIndex = 7
        Me.lblAlumnoslblFiltrar.Text = "Filtrar"
        '
        'tabPrincipalMaterias
        '
        Me.tabPrincipalMaterias.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasModificar)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasEliminar)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasCrear)
        Me.tabPrincipalMaterias.Controls.Add(Me.DataGridView2)
        Me.tabPrincipalMaterias.Controls.Add(Me.Panel1)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasImprimir)
        Me.tabPrincipalMaterias.Controls.Add(Me.lblMaterias)
        Me.tabPrincipalMaterias.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalMaterias.Name = "tabPrincipalMaterias"
        Me.tabPrincipalMaterias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalMaterias.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalMaterias.TabIndex = 1
        Me.tabPrincipalMaterias.Text = "Materias"
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(9, 209)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(817, 272)
        Me.DataGridView2.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
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
        'txtMateriasDescripcion
        '
        Me.txtMateriasDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMateriasDescripcion.Location = New System.Drawing.Point(300, 67)
        Me.txtMateriasDescripcion.Name = "txtMateriasDescripcion"
        Me.txtMateriasDescripcion.Size = New System.Drawing.Size(302, 20)
        Me.txtMateriasDescripcion.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(296, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Descripcion"
        Me.Label1.UseMnemonic = False
        '
        'txtMateriasFiltrarNombre
        '
        Me.txtMateriasFiltrarNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMateriasFiltrarNombre.Location = New System.Drawing.Point(28, 67)
        Me.txtMateriasFiltrarNombre.Name = "txtMateriasFiltrarNombre"
        Me.txtMateriasFiltrarNombre.Size = New System.Drawing.Size(185, 20)
        Me.txtMateriasFiltrarNombre.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(24, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre materia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Filtrar"
        '
        'tabPrincipalTareas
        '
        Me.tabPrincipalTareas.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabPrincipalTareas.Controls.Add(Me.Button1)
        Me.tabPrincipalTareas.Controls.Add(Me.Button2)
        Me.tabPrincipalTareas.Controls.Add(Me.Button3)
        Me.tabPrincipalTareas.Controls.Add(Me.DataGridView3)
        Me.tabPrincipalTareas.Controls.Add(Me.Panel3)
        Me.tabPrincipalTareas.Controls.Add(Me.btnEvaluacionesImprimir)
        Me.tabPrincipalTareas.Controls.Add(Me.lblTareas)
        Me.tabPrincipalTareas.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalTareas.Name = "tabPrincipalTareas"
        Me.tabPrincipalTareas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalTareas.Size = New System.Drawing.Size(836, 526)
        Me.tabPrincipalTareas.TabIndex = 2
        Me.tabPrincipalTareas.Text = "Tareas"
        '
        'DataGridView3
        '
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(12, 209)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(817, 272)
        Me.DataGridView3.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.lbxEvaluacionesTipoEvaluacion)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(12, 103)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(818, 100)
        Me.Panel3.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(559, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 22)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Tipo evaluacion"
        Me.Label8.UseMnemonic = False
        '
        'lbxEvaluacionesTipoEvaluacion
        '
        Me.lbxEvaluacionesTipoEvaluacion.FormattingEnabled = True
        Me.lbxEvaluacionesTipoEvaluacion.Items.AddRange(New Object() {"Trabajo_laboratorio", "Trabajo_domiciliario", "Trabajo_practico", "Trabajo_investigacion", "Trabajo_escrito", "Oral", "Parcial", "Primera_entrega", "Segunda_entrega", "Tercera_entrega", "Defensa_inidvidual", "Defensa_grupal"})
        Me.lbxEvaluacionesTipoEvaluacion.Location = New System.Drawing.Point(563, 70)
        Me.lbxEvaluacionesTipoEvaluacion.Name = "lbxEvaluacionesTipoEvaluacion"
        Me.lbxEvaluacionesTipoEvaluacion.Size = New System.Drawing.Size(157, 17)
        Me.lbxEvaluacionesTipoEvaluacion.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(238, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(302, 20)
        Me.TextBox2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(234, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Descripcion"
        Me.Label5.UseMnemonic = False
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(28, 67)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(185, 20)
        Me.TextBox3.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(24, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ID Evaluacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(12, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Filtrar"
        '
        'tabPrincipalDocentes
        '
        Me.tabPrincipalDocentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
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
        'datagridDocentes
        '
        Me.datagridDocentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridDocentes.Location = New System.Drawing.Point(12, 208)
        Me.datagridDocentes.Name = "datagridDocentes"
        Me.datagridDocentes.Size = New System.Drawing.Size(817, 272)
        Me.datagridDocentes.TabIndex = 29
        '
        'pnlDocentesFiltros
        '
        Me.pnlDocentesFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDocentesFiltros.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlDocentesFiltros.Controls.Add(Me.btnDocentesFiltrarRUN)
        Me.pnlDocentesFiltros.Controls.Add(Me.TextBox1)
        Me.pnlDocentesFiltros.Controls.Add(Me.lblDocentesFiltrarNombre)
        Me.pnlDocentesFiltros.Controls.Add(Me.txtDocentesFiltrarCedula)
        Me.pnlDocentesFiltros.Controls.Add(Me.lblDocentesFiltrarCedula)
        Me.pnlDocentesFiltros.Controls.Add(Me.Label3)
        Me.pnlDocentesFiltros.Location = New System.Drawing.Point(12, 102)
        Me.pnlDocentesFiltros.Name = "pnlDocentesFiltros"
        Me.pnlDocentesFiltros.Size = New System.Drawing.Size(818, 100)
        Me.pnlDocentesFiltros.TabIndex = 27
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(385, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(338, 20)
        Me.TextBox1.TabIndex = 11
        '
        'lblDocentesFiltrarNombre
        '
        Me.lblDocentesFiltrarNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDocentesFiltrarNombre.AutoSize = True
        Me.lblDocentesFiltrarNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocentesFiltrarNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDocentesFiltrarNombre.Location = New System.Drawing.Point(296, 43)
        Me.lblDocentesFiltrarNombre.Name = "lblDocentesFiltrarNombre"
        Me.lblDocentesFiltrarNombre.Size = New System.Drawing.Size(83, 22)
        Me.lblDocentesFiltrarNombre.TabIndex = 10
        Me.lblDocentesFiltrarNombre.Text = "Nombre"
        Me.lblDocentesFiltrarNombre.UseMnemonic = False
        '
        'txtDocentesFiltrarCedula
        '
        Me.txtDocentesFiltrarCedula.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocentesFiltrarCedula.Location = New System.Drawing.Point(106, 43)
        Me.txtDocentesFiltrarCedula.Name = "txtDocentesFiltrarCedula"
        Me.txtDocentesFiltrarCedula.Size = New System.Drawing.Size(185, 20)
        Me.txtDocentesFiltrarCedula.TabIndex = 9
        '
        'lblDocentesFiltrarCedula
        '
        Me.lblDocentesFiltrarCedula.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDocentesFiltrarCedula.AutoSize = True
        Me.lblDocentesFiltrarCedula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocentesFiltrarCedula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDocentesFiltrarCedula.Location = New System.Drawing.Point(24, 42)
        Me.lblDocentesFiltrarCedula.Name = "lblDocentesFiltrarCedula"
        Me.lblDocentesFiltrarCedula.Size = New System.Drawing.Size(74, 22)
        Me.lblDocentesFiltrarCedula.TabIndex = 8
        Me.lblDocentesFiltrarCedula.Text = "Cedula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Filtrar"
        '
        'tabPrincipalUsuarios
        '
        Me.tabPrincipalUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tabPrincipalUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tabPrincipalUsuarios.Controls.Add(Me.pnlUsuariosBotonImprimir)
        Me.tabPrincipalUsuarios.Controls.Add(Me.DataGridView1)
        Me.tabPrincipalUsuarios.Controls.Add(Me.Panel2)
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
        Me.btnTareas.Text = "Calificaciones"
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
        'btnAlumnosModificar
        '
        Me.btnAlumnosModificar.BackColor = System.Drawing.Color.White
        Me.btnAlumnosModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnAlumnosModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlumnosModificar.Location = New System.Drawing.Point(144, 38)
        Me.btnAlumnosModificar.Name = "btnAlumnosModificar"
        Me.btnAlumnosModificar.Size = New System.Drawing.Size(59, 57)
        Me.btnAlumnosModificar.TabIndex = 25
        Me.btnAlumnosModificar.UseVisualStyleBackColor = False
        '
        'btnAlumnosEliminar
        '
        Me.btnAlumnosEliminar.BackColor = System.Drawing.Color.White
        Me.btnAlumnosEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.btnAlumnosEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosEliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlumnosEliminar.Location = New System.Drawing.Point(78, 38)
        Me.btnAlumnosEliminar.Name = "btnAlumnosEliminar"
        Me.btnAlumnosEliminar.Size = New System.Drawing.Size(59, 57)
        Me.btnAlumnosEliminar.TabIndex = 24
        Me.btnAlumnosEliminar.UseVisualStyleBackColor = False
        '
        'btnAlumnosCrearNuevo
        '
        Me.btnAlumnosCrearNuevo.BackColor = System.Drawing.Color.White
        Me.btnAlumnosCrearNuevo.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.btnAlumnosCrearNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosCrearNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosCrearNuevo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosCrearNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosCrearNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlumnosCrearNuevo.Location = New System.Drawing.Point(12, 38)
        Me.btnAlumnosCrearNuevo.Name = "btnAlumnosCrearNuevo"
        Me.btnAlumnosCrearNuevo.Size = New System.Drawing.Size(59, 57)
        Me.btnAlumnosCrearNuevo.TabIndex = 23
        Me.btnAlumnosCrearNuevo.UseVisualStyleBackColor = False
        '
        'btnAlumnosImprimir
        '
        Me.btnAlumnosImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAlumnosImprimir.BackColor = System.Drawing.Color.White
        Me.btnAlumnosImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnAlumnosImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosImprimir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlumnosImprimir.Location = New System.Drawing.Point(12, 485)
        Me.btnAlumnosImprimir.Name = "btnAlumnosImprimir"
        Me.btnAlumnosImprimir.Size = New System.Drawing.Size(45, 35)
        Me.btnAlumnosImprimir.TabIndex = 21
        Me.btnAlumnosImprimir.UseVisualStyleBackColor = False
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
        'btnMateriasModificar
        '
        Me.btnMateriasModificar.BackColor = System.Drawing.Color.White
        Me.btnMateriasModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnMateriasModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMateriasModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriasModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriasModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMateriasModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMateriasModificar.Location = New System.Drawing.Point(141, 40)
        Me.btnMateriasModificar.Name = "btnMateriasModificar"
        Me.btnMateriasModificar.Size = New System.Drawing.Size(59, 57)
        Me.btnMateriasModificar.TabIndex = 31
        Me.btnMateriasModificar.UseVisualStyleBackColor = False
        '
        'btnMateriasEliminar
        '
        Me.btnMateriasEliminar.BackColor = System.Drawing.Color.White
        Me.btnMateriasEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.delete_book_trash_education_remove_30d96a3dea2d0c0a_512x512
        Me.btnMateriasEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMateriasEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriasEliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriasEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMateriasEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMateriasEliminar.Location = New System.Drawing.Point(75, 40)
        Me.btnMateriasEliminar.Name = "btnMateriasEliminar"
        Me.btnMateriasEliminar.Size = New System.Drawing.Size(59, 57)
        Me.btnMateriasEliminar.TabIndex = 30
        Me.btnMateriasEliminar.UseVisualStyleBackColor = False
        '
        'btnMateriasCrear
        '
        Me.btnMateriasCrear.BackColor = System.Drawing.Color.White
        Me.btnMateriasCrear.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_books_read_literature_512
        Me.btnMateriasCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMateriasCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriasCrear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriasCrear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMateriasCrear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMateriasCrear.Location = New System.Drawing.Point(9, 40)
        Me.btnMateriasCrear.Name = "btnMateriasCrear"
        Me.btnMateriasCrear.Size = New System.Drawing.Size(59, 57)
        Me.btnMateriasCrear.TabIndex = 29
        Me.btnMateriasCrear.UseVisualStyleBackColor = False
        '
        'btnMateriasFiltrar
        '
        Me.btnMateriasFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnMateriasFiltrar.BackColor = System.Drawing.Color.White
        Me.btnMateriasFiltrar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.search_filled
        Me.btnMateriasFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMateriasFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriasFiltrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriasFiltrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMateriasFiltrar.Location = New System.Drawing.Point(729, 25)
        Me.btnMateriasFiltrar.Name = "btnMateriasFiltrar"
        Me.btnMateriasFiltrar.Size = New System.Drawing.Size(55, 47)
        Me.btnMateriasFiltrar.TabIndex = 16
        Me.btnMateriasFiltrar.UseVisualStyleBackColor = False
        '
        'btnMateriasImprimir
        '
        Me.btnMateriasImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMateriasImprimir.BackColor = System.Drawing.Color.White
        Me.btnMateriasImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnMateriasImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMateriasImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriasImprimir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriasImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMateriasImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMateriasImprimir.Location = New System.Drawing.Point(9, 487)
        Me.btnMateriasImprimir.Name = "btnMateriasImprimir"
        Me.btnMateriasImprimir.Size = New System.Drawing.Size(45, 35)
        Me.btnMateriasImprimir.TabIndex = 27
        Me.btnMateriasImprimir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(144, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 57)
        Me.Button1.TabIndex = 38
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.delete_book_trash_education_remove_30d96a3dea2d0c0a_512x512
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(78, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 57)
        Me.Button2.TabIndex = 37
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_books_read_literature_512
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(12, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 57)
        Me.Button3.TabIndex = 36
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.search_filled
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(729, 25)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(55, 47)
        Me.Button5.TabIndex = 16
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnEvaluacionesImprimir
        '
        Me.btnEvaluacionesImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEvaluacionesImprimir.BackColor = System.Drawing.Color.White
        Me.btnEvaluacionesImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnEvaluacionesImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEvaluacionesImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEvaluacionesImprimir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluacionesImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEvaluacionesImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEvaluacionesImprimir.Location = New System.Drawing.Point(12, 487)
        Me.btnEvaluacionesImprimir.Name = "btnEvaluacionesImprimir"
        Me.btnEvaluacionesImprimir.Size = New System.Drawing.Size(45, 35)
        Me.btnEvaluacionesImprimir.TabIndex = 34
        Me.btnEvaluacionesImprimir.UseVisualStyleBackColor = False
        '
        'btnDocentesModificar
        '
        Me.btnDocentesModificar.BackColor = System.Drawing.Color.White
        Me.btnDocentesModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnDocentesModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesModificar.Location = New System.Drawing.Point(144, 39)
        Me.btnDocentesModificar.Name = "btnDocentesModificar"
        Me.btnDocentesModificar.Size = New System.Drawing.Size(59, 57)
        Me.btnDocentesModificar.TabIndex = 32
        Me.btnDocentesModificar.UseVisualStyleBackColor = False
        '
        'btnDocentesEliminar
        '
        Me.btnDocentesEliminar.BackColor = System.Drawing.Color.White
        Me.btnDocentesEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.btnDocentesEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesEliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesEliminar.Location = New System.Drawing.Point(78, 39)
        Me.btnDocentesEliminar.Name = "btnDocentesEliminar"
        Me.btnDocentesEliminar.Size = New System.Drawing.Size(59, 57)
        Me.btnDocentesEliminar.TabIndex = 31
        Me.btnDocentesEliminar.UseVisualStyleBackColor = False
        '
        'btnDocentesCrearNuevo
        '
        Me.btnDocentesCrearNuevo.BackColor = System.Drawing.Color.White
        Me.btnDocentesCrearNuevo.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.btnDocentesCrearNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesCrearNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesCrearNuevo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesCrearNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesCrearNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesCrearNuevo.Location = New System.Drawing.Point(12, 39)
        Me.btnDocentesCrearNuevo.Name = "btnDocentesCrearNuevo"
        Me.btnDocentesCrearNuevo.Size = New System.Drawing.Size(59, 57)
        Me.btnDocentesCrearNuevo.TabIndex = 30
        Me.btnDocentesCrearNuevo.UseVisualStyleBackColor = False
        '
        'btnDocentesFiltrarRUN
        '
        Me.btnDocentesFiltrarRUN.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDocentesFiltrarRUN.BackColor = System.Drawing.Color.White
        Me.btnDocentesFiltrarRUN.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.find_user_male
        Me.btnDocentesFiltrarRUN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesFiltrarRUN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesFiltrarRUN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesFiltrarRUN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesFiltrarRUN.Location = New System.Drawing.Point(729, 25)
        Me.btnDocentesFiltrarRUN.Name = "btnDocentesFiltrarRUN"
        Me.btnDocentesFiltrarRUN.Size = New System.Drawing.Size(55, 47)
        Me.btnDocentesFiltrarRUN.TabIndex = 16
        Me.btnDocentesFiltrarRUN.UseVisualStyleBackColor = False
        '
        'btnDocentesImprimir
        '
        Me.btnDocentesImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDocentesImprimir.BackColor = System.Drawing.Color.White
        Me.btnDocentesImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnDocentesImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesImprimir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesImprimir.Location = New System.Drawing.Point(12, 486)
        Me.btnDocentesImprimir.Name = "btnDocentesImprimir"
        Me.btnDocentesImprimir.Size = New System.Drawing.Size(45, 35)
        Me.btnDocentesImprimir.TabIndex = 28
        Me.btnDocentesImprimir.UseVisualStyleBackColor = False
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
        'pnlUsuariosModificar
        '
        Me.pnlUsuariosModificar.BackColor = System.Drawing.Color.White
        Me.pnlUsuariosModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.pnlUsuariosModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlUsuariosModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pnlUsuariosModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUsuariosModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlUsuariosModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.pnlUsuariosModificar.Location = New System.Drawing.Point(139, 49)
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
        Me.pnlUsuariosBotonEliminarUsuario.Location = New System.Drawing.Point(73, 49)
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
        Me.pnlUsuariosBotonCrearNuevo.Location = New System.Drawing.Point(7, 49)
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
        Me.lblTareas.Size = New System.Drawing.Size(193, 36)
        Me.lblTareas.TabIndex = 12
        Me.lblTareas.Text = "Evaluaciones"
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
        'btnVentanaPrincipalInstitutos
        '
        Me.btnVentanaPrincipalInstitutos.BackColor = System.Drawing.Color.White
        Me.btnVentanaPrincipalInstitutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVentanaPrincipalInstitutos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaPrincipalInstitutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaPrincipalInstitutos.Location = New System.Drawing.Point(12, 326)
        Me.btnVentanaPrincipalInstitutos.Name = "btnVentanaPrincipalInstitutos"
        Me.btnVentanaPrincipalInstitutos.Size = New System.Drawing.Size(211, 39)
        Me.btnVentanaPrincipalInstitutos.TabIndex = 22
        Me.btnVentanaPrincipalInstitutos.Text = "Institutos"
        Me.btnVentanaPrincipalInstitutos.UseVisualStyleBackColor = False
        '
        'tabpageInstitutos
        '
        Me.tabpageInstitutos.Controls.Add(Me.Panel4)
        Me.tabpageInstitutos.Controls.Add(Me.Button4)
        Me.tabpageInstitutos.Controls.Add(Me.Button6)
        Me.tabpageInstitutos.Controls.Add(Me.Button7)
        Me.tabpageInstitutos.Controls.Add(Me.Panel5)
        Me.tabpageInstitutos.Controls.Add(Me.BorderLabel1)
        Me.tabpageInstitutos.Location = New System.Drawing.Point(4, 22)
        Me.tabpageInstitutos.Name = "tabpageInstitutos"
        Me.tabpageInstitutos.Size = New System.Drawing.Size(836, 526)
        Me.tabpageInstitutos.TabIndex = 5
        Me.tabpageInstitutos.Text = "Institutos"
        Me.tabpageInstitutos.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(12, 241)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(818, 247)
        Me.Panel4.TabIndex = 32
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(144, 47)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 57)
        Me.Button4.TabIndex = 31
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button6.Location = New System.Drawing.Point(78, 47)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(59, 57)
        Me.Button6.TabIndex = 30
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button7.Location = New System.Drawing.Point(12, 47)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(59, 57)
        Me.Button7.TabIndex = 29
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Button8)
        Me.Panel5.Controls.Add(Me.TextBox4)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.TextBox5)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Location = New System.Drawing.Point(12, 110)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(818, 100)
        Me.Panel5.TabIndex = 28
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.find_user_male
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(729, 25)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(55, 47)
        Me.Button8.TabIndex = 16
        Me.Button8.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(385, 43)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(338, 20)
        Me.TextBox4.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(296, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 22)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Nombre"
        Me.Label9.UseMnemonic = False
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(106, 43)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(185, 20)
        Me.TextBox5.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(24, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 22)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Cedula"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(12, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 24)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Filtrar"
        '
        'BorderLabel1
        '
        Me.BorderLabel1.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorderLabel1.Location = New System.Drawing.Point(6, 13)
        Me.BorderLabel1.Name = "BorderLabel1"
        Me.BorderLabel1.Size = New System.Drawing.Size(136, 36)
        Me.BorderLabel1.TabIndex = 27
        Me.BorderLabel1.Text = "Alumnos"
        '
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(230, Byte), Integer))
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
        Me.pnlAlumnosFiltrar.ResumeLayout(False)
        Me.pnlAlumnosFiltrar.PerformLayout()
        Me.tabPrincipalMaterias.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabPrincipalTareas.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tabPrincipalDocentes.ResumeLayout(False)
        CType(Me.datagridDocentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDocentesFiltros.ResumeLayout(False)
        Me.pnlDocentesFiltros.PerformLayout()
        Me.tabPrincipalUsuarios.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tabpageInstitutos.ResumeLayout(False)
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
    Friend WithEvents pnlUsuariosBotonCrearNuevo As Button
    Friend WithEvents pnlUsuariosBotonEliminarUsuario As Button
    Friend WithEvents pnlUsuariosModificar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlUsuariosFiltroNombreUsuario As TextBox
    Friend WithEvents pnlUsuariolblNombreUsuario As Label
    Friend WithEvents pnlUsuarioslblFiltrar As Label
    Friend WithEvents pnlUsuariosBotonFiltrarNombre As Button
    Friend WithEvents pnlUsuariosBotonImprimir As Button
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblDocentesFiltrarNombre As Label
    Friend WithEvents txtDocentesFiltrarCedula As TextBox
    Friend WithEvents lblDocentesFiltrarCedula As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMateriasModificar As Button
    Friend WithEvents btnMateriasEliminar As Button
    Friend WithEvents btnMateriasCrear As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnMateriasImprimir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMateriasFiltrar As Button
    Friend WithEvents txtMateriasDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMateriasFiltrarNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents btnEvaluacionesImprimir As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lbxEvaluacionesTipoEvaluacion As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlAlumnosFichas As Panel
    Friend WithEvents tabpageInstitutos As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BorderLabel1 As BorderLabel
    Friend WithEvents btnVentanaPrincipalInstitutos As Button
End Class
