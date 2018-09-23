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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lst_Agregar_grupo = New System.Windows.Forms.ListBox()
        Me.btn_agregar_a_un_grupo = New System.Windows.Forms.Button()
        Me.btn_alumnos_Refrescar = New System.Windows.Forms.Button()
        Me.btnAlumnosModificar = New System.Windows.Forms.Button()
        Me.btnAlumnosEliminar = New System.Windows.Forms.Button()
        Me.btnAlumnosCrearNuevo = New System.Windows.Forms.Button()
        Me.btnAlumnosImprimir = New System.Windows.Forms.Button()
        Me.tabpage_Grupos = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_Grupos_Modificar = New System.Windows.Forms.Button()
        Me.btnGrupos_Eliminar = New System.Windows.Forms.Button()
        Me.btnGrupos_Agregar = New System.Windows.Forms.Button()
        Me.tabPrincipalMaterias = New System.Windows.Forms.TabPage()
        Me.btnMateriasModificar = New System.Windows.Forms.Button()
        Me.btnMateriasEliminar = New System.Windows.Forms.Button()
        Me.btnMateriasCrear = New System.Windows.Forms.Button()
        Me.btnMateriasImprimir = New System.Windows.Forms.Button()
        Me.tabPrincipalTareas = New System.Windows.Forms.TabPage()
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
        Me.pnlCalificaciones_Comboboxes = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.btnDocentesImprimir = New System.Windows.Forms.Button()
        Me.tabPrincipalUsuarios = New System.Windows.Forms.TabPage()
        Me.btnUsuariosImprimir = New System.Windows.Forms.Button()
        Me.btnUsuariosModificar = New System.Windows.Forms.Button()
        Me.btnUsuariosBotonEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnUsuariosBotonCrearNuevo = New System.Windows.Forms.Button()
        Me.tabpageInstitutos = New System.Windows.Forms.TabPage()
        Me.btnInstitutoImprimir = New System.Windows.Forms.Button()
        Me.btnInstitutoModificar = New System.Windows.Forms.Button()
        Me.btnInstitutoEliminar = New System.Windows.Forms.Button()
        Me.btnInstitutoCrear = New System.Windows.Forms.Button()
        Me.tabOrientaciones = New System.Windows.Forms.TabPage()
        Me.btnOrientacionesModificar = New System.Windows.Forms.Button()
        Me.btnOrientacionesEliminar = New System.Windows.Forms.Button()
        Me.btnOrientacionesCrear = New System.Windows.Forms.Button()
        Me.btnImprimirOrientaciones = New System.Windows.Forms.Button()
        Me.tabCiudades = New System.Windows.Forms.TabPage()
        Me.btnCiudadesModificar = New System.Windows.Forms.Button()
        Me.btnCiudadesEliminar = New System.Windows.Forms.Button()
        Me.btnCiudadesCrear = New System.Windows.Forms.Button()
        Me.btnCiudadesImprimir = New System.Windows.Forms.Button()
        Me.tabAdmins = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnAdmins_Modificar = New System.Windows.Forms.Button()
        Me.btnAdmins_Eliminar = New System.Windows.Forms.Button()
        Me.btnAdmins_Crear = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnTareas = New System.Windows.Forms.Button()
        Me.btnDocentes = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnVentanaPrincipalInstitutos = New System.Windows.Forms.Button()
        Me.btn_Grupos = New System.Windows.Forms.Button()
        Me.btnVentanaPrincipalOrientaciones = New System.Windows.Forms.Button()
        Me.btnCiudad = New System.Windows.Forms.Button()
        Me.btnVentanaPrincipalConfiguracion = New System.Windows.Forms.Button()
        Me.btnVentanaPrincipal_Admins_Administrativos = New System.Windows.Forms.Button()
        Me.btnDesvincular = New System.Windows.Forms.Button()
        Me.dgvP_Alumnos = New WindowsApp1.DGVPaginado()
        Me.lblAlumnos_Titulo = New WindowsApp1.BorderLabel()
        Me.dgvP_Grupos = New WindowsApp1.DGVPaginado()
        Me.lbl_Grupos_Titulo = New WindowsApp1.BorderLabel()
        Me.dgvP_Asignaturas = New WindowsApp1.DGVPaginado()
        Me.lblMaterias = New WindowsApp1.BorderLabel()
        Me.dgvP_Calificaciones = New WindowsApp1.DGVPaginado()
        Me.lblTareas = New WindowsApp1.BorderLabel()
        Me.dgvP_Docentes = New WindowsApp1.DGVPaginado()
        Me.lblDocentes = New WindowsApp1.BorderLabel()
        Me.dgvP_Usuarios = New WindowsApp1.DGVPaginado()
        Me.lblUsuarios = New WindowsApp1.BorderLabel()
        Me.dgvP_Institutos = New WindowsApp1.DGVPaginado()
        Me.BorderLabel1 = New WindowsApp1.BorderLabel()
        Me.BorderLabel2 = New WindowsApp1.BorderLabel()
        Me.dgvP_Orientaciones = New WindowsApp1.DGVPaginado()
        Me.lblCiudades = New WindowsApp1.BorderLabel()
        Me.dgvP_Ciudades = New WindowsApp1.DGVPaginado()
        Me.dgv_Admins_Administrativos = New WindowsApp1.DGVPaginado()
        Me.BorderLabel3 = New WindowsApp1.BorderLabel()
        Me.b_lblRol_Dinamico = New WindowsApp1.BorderLabel()
        Me.b_lblNombreUsuario_Dinamico = New WindowsApp1.BorderLabel()
        Me.b_lblusuarioLogueado_nombre = New WindowsApp1.BorderLabel()
        Me.btnDesvicularADocenteGrupo = New System.Windows.Forms.Button()
        Me.listDocenteAsignarGrupo = New System.Windows.Forms.ListBox()
        Me.listAsignaturas = New System.Windows.Forms.ListBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BorderLabel4 = New WindowsApp1.BorderLabel()
        Me.BorderLabel5 = New WindowsApp1.BorderLabel()
        Me.pnlUsuario_logueado.SuspendLayout()
        Me.tabPrincipal.SuspendLayout()
        Me.tabPrincipalAlumnos.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.tabpage_Grupos.SuspendLayout()
        Me.tabPrincipalMaterias.SuspendLayout()
        Me.tabPrincipalTareas.SuspendLayout()
        Me.tabCalificaciones_Vista.SuspendLayout()
        Me.tabCalificaciones_Vista_Por_Calificacion.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tabCalificaiones_Vista_Alumnos.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlCalificaciones_Comboboxes.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.tabPrincipalDocentes.SuspendLayout()
        Me.tabPrincipalUsuarios.SuspendLayout()
        Me.tabpageInstitutos.SuspendLayout()
        Me.tabOrientaciones.SuspendLayout()
        Me.tabCiudades.SuspendLayout()
        Me.tabAdmins.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.pnlUsuario_logueado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUsuario_logueado.BackColor = System.Drawing.Color.Silver
        Me.pnlUsuario_logueado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlUsuario_logueado.Controls.Add(Me.b_lblRol_Dinamico)
        Me.pnlUsuario_logueado.Controls.Add(Me.b_lblNombreUsuario_Dinamico)
        Me.pnlUsuario_logueado.Controls.Add(Me.b_lblusuarioLogueado_nombre)
        Me.pnlUsuario_logueado.Location = New System.Drawing.Point(12, 12)
        Me.pnlUsuario_logueado.Name = "pnlUsuario_logueado"
        Me.pnlUsuario_logueado.Size = New System.Drawing.Size(1061, 35)
        Me.pnlUsuario_logueado.TabIndex = 6
        '
        'btnAlumnos
        '
        Me.btnAlumnos.BackColor = System.Drawing.Color.White
        Me.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnos.Location = New System.Drawing.Point(12, 64)
        Me.btnAlumnos.Name = "btnAlumnos"
        Me.btnAlumnos.Size = New System.Drawing.Size(211, 29)
        Me.btnAlumnos.TabIndex = 7
        Me.btnAlumnos.Text = "Alumnos"
        Me.btnAlumnos.UseVisualStyleBackColor = False
        '
        'btnMaterias
        '
        Me.btnMaterias.BackColor = System.Drawing.Color.White
        Me.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMaterias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaterias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMaterias.Location = New System.Drawing.Point(12, 101)
        Me.btnMaterias.Name = "btnMaterias"
        Me.btnMaterias.Size = New System.Drawing.Size(211, 29)
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
        Me.tabPrincipal.Controls.Add(Me.tabpage_Grupos)
        Me.tabPrincipal.Controls.Add(Me.tabPrincipalMaterias)
        Me.tabPrincipal.Controls.Add(Me.tabPrincipalTareas)
        Me.tabPrincipal.Controls.Add(Me.tabPrincipalDocentes)
        Me.tabPrincipal.Controls.Add(Me.tabPrincipalUsuarios)
        Me.tabPrincipal.Controls.Add(Me.tabpageInstitutos)
        Me.tabPrincipal.Controls.Add(Me.tabOrientaciones)
        Me.tabPrincipal.Controls.Add(Me.tabCiudades)
        Me.tabPrincipal.Controls.Add(Me.tabAdmins)
        Me.tabPrincipal.Location = New System.Drawing.Point(229, 45)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedIndex = 0
        Me.tabPrincipal.Size = New System.Drawing.Size(844, 519)
        Me.tabPrincipal.TabIndex = 10
        '
        'tabPrincipalAlumnos
        '
        Me.tabPrincipalAlumnos.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalAlumnos.Controls.Add(Me.dgvP_Alumnos)
        Me.tabPrincipalAlumnos.Controls.Add(Me.Panel7)
        Me.tabPrincipalAlumnos.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalAlumnos.Name = "tabPrincipalAlumnos"
        Me.tabPrincipalAlumnos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalAlumnos.Size = New System.Drawing.Size(836, 493)
        Me.tabPrincipalAlumnos.TabIndex = 0
        Me.tabPrincipalAlumnos.Text = "Alumnos"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnDesvincular)
        Me.Panel7.Controls.Add(Me.lst_Agregar_grupo)
        Me.Panel7.Controls.Add(Me.btn_agregar_a_un_grupo)
        Me.Panel7.Controls.Add(Me.btn_alumnos_Refrescar)
        Me.Panel7.Controls.Add(Me.btnAlumnosModificar)
        Me.Panel7.Controls.Add(Me.btnAlumnosEliminar)
        Me.Panel7.Controls.Add(Me.btnAlumnosCrearNuevo)
        Me.Panel7.Controls.Add(Me.btnAlumnosImprimir)
        Me.Panel7.Controls.Add(Me.lblAlumnos_Titulo)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(830, 109)
        Me.Panel7.TabIndex = 27
        '
        'lst_Agregar_grupo
        '
        Me.lst_Agregar_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_Agregar_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Agregar_grupo.FormattingEnabled = True
        Me.lst_Agregar_grupo.ItemHeight = 16
        Me.lst_Agregar_grupo.Location = New System.Drawing.Point(293, 41)
        Me.lst_Agregar_grupo.Name = "lst_Agregar_grupo"
        Me.lst_Agregar_grupo.Size = New System.Drawing.Size(371, 68)
        Me.lst_Agregar_grupo.TabIndex = 33
        '
        'btn_agregar_a_un_grupo
        '
        Me.btn_agregar_a_un_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_a_un_grupo.BackColor = System.Drawing.Color.White
        Me.btn_agregar_a_un_grupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar_a_un_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_a_un_grupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_agregar_a_un_grupo.Location = New System.Drawing.Point(293, 10)
        Me.btn_agregar_a_un_grupo.Name = "btn_agregar_a_un_grupo"
        Me.btn_agregar_a_un_grupo.Size = New System.Drawing.Size(171, 28)
        Me.btn_agregar_a_un_grupo.TabIndex = 27
        Me.btn_agregar_a_un_grupo.Text = "Vincular a un grupo"
        Me.btn_agregar_a_un_grupo.UseVisualStyleBackColor = False
        '
        'btn_alumnos_Refrescar
        '
        Me.btn_alumnos_Refrescar.BackColor = System.Drawing.Color.White
        Me.btn_alumnos_Refrescar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.database_restore
        Me.btn_alumnos_Refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_alumnos_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_alumnos_Refrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alumnos_Refrescar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_alumnos_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_alumnos_Refrescar.Location = New System.Drawing.Point(173, 53)
        Me.btn_alumnos_Refrescar.Name = "btn_alumnos_Refrescar"
        Me.btn_alumnos_Refrescar.Size = New System.Drawing.Size(45, 50)
        Me.btn_alumnos_Refrescar.TabIndex = 32
        Me.btn_alumnos_Refrescar.UseVisualStyleBackColor = False
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
        Me.btnAlumnosModificar.Location = New System.Drawing.Point(117, 53)
        Me.btnAlumnosModificar.Name = "btnAlumnosModificar"
        Me.btnAlumnosModificar.Size = New System.Drawing.Size(50, 50)
        Me.btnAlumnosModificar.TabIndex = 31
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
        Me.btnAlumnosEliminar.Location = New System.Drawing.Point(61, 53)
        Me.btnAlumnosEliminar.Name = "btnAlumnosEliminar"
        Me.btnAlumnosEliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnAlumnosEliminar.TabIndex = 30
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
        Me.btnAlumnosCrearNuevo.Location = New System.Drawing.Point(5, 53)
        Me.btnAlumnosCrearNuevo.Name = "btnAlumnosCrearNuevo"
        Me.btnAlumnosCrearNuevo.Size = New System.Drawing.Size(50, 50)
        Me.btnAlumnosCrearNuevo.TabIndex = 29
        Me.btnAlumnosCrearNuevo.UseVisualStyleBackColor = False
        '
        'btnAlumnosImprimir
        '
        Me.btnAlumnosImprimir.BackColor = System.Drawing.Color.White
        Me.btnAlumnosImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnAlumnosImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlumnosImprimir.Location = New System.Drawing.Point(236, 53)
        Me.btnAlumnosImprimir.Name = "btnAlumnosImprimir"
        Me.btnAlumnosImprimir.Size = New System.Drawing.Size(51, 53)
        Me.btnAlumnosImprimir.TabIndex = 28
        Me.btnAlumnosImprimir.UseVisualStyleBackColor = False
        '
        'tabpage_Grupos
        '
        Me.tabpage_Grupos.BackColor = System.Drawing.Color.Silver
        Me.tabpage_Grupos.Controls.Add(Me.dgvP_Grupos)
        Me.tabpage_Grupos.Controls.Add(Me.Button3)
        Me.tabpage_Grupos.Controls.Add(Me.btn_Grupos_Modificar)
        Me.tabpage_Grupos.Controls.Add(Me.btnGrupos_Eliminar)
        Me.tabpage_Grupos.Controls.Add(Me.btnGrupos_Agregar)
        Me.tabpage_Grupos.Controls.Add(Me.lbl_Grupos_Titulo)
        Me.tabpage_Grupos.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_Grupos.Name = "tabpage_Grupos"
        Me.tabpage_Grupos.Size = New System.Drawing.Size(836, 493)
        Me.tabpage_Grupos.TabIndex = 6
        Me.tabpage_Grupos.Text = "Grupos"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(796, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 39
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btn_Grupos_Modificar
        '
        Me.btn_Grupos_Modificar.BackColor = System.Drawing.Color.White
        Me.btn_Grupos_Modificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btn_Grupos_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Grupos_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Grupos_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Grupos_Modificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Grupos_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Grupos_Modificar.Location = New System.Drawing.Point(125, 49)
        Me.btn_Grupos_Modificar.Name = "btn_Grupos_Modificar"
        Me.btn_Grupos_Modificar.Size = New System.Drawing.Size(50, 50)
        Me.btn_Grupos_Modificar.TabIndex = 38
        Me.btn_Grupos_Modificar.UseVisualStyleBackColor = False
        '
        'btnGrupos_Eliminar
        '
        Me.btnGrupos_Eliminar.BackColor = System.Drawing.Color.White
        Me.btnGrupos_Eliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.btnGrupos_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGrupos_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGrupos_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupos_Eliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGrupos_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnGrupos_Eliminar.Location = New System.Drawing.Point(69, 49)
        Me.btnGrupos_Eliminar.Name = "btnGrupos_Eliminar"
        Me.btnGrupos_Eliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnGrupos_Eliminar.TabIndex = 37
        Me.btnGrupos_Eliminar.UseVisualStyleBackColor = False
        '
        'btnGrupos_Agregar
        '
        Me.btnGrupos_Agregar.BackColor = System.Drawing.Color.White
        Me.btnGrupos_Agregar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.btnGrupos_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGrupos_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGrupos_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupos_Agregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGrupos_Agregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnGrupos_Agregar.Location = New System.Drawing.Point(13, 49)
        Me.btnGrupos_Agregar.Name = "btnGrupos_Agregar"
        Me.btnGrupos_Agregar.Size = New System.Drawing.Size(50, 50)
        Me.btnGrupos_Agregar.TabIndex = 35
        Me.btnGrupos_Agregar.UseVisualStyleBackColor = False
        '
        'tabPrincipalMaterias
        '
        Me.tabPrincipalMaterias.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalMaterias.Controls.Add(Me.dgvP_Asignaturas)
        Me.tabPrincipalMaterias.Controls.Add(Me.lblMaterias)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasModificar)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasEliminar)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasCrear)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasImprimir)
        Me.tabPrincipalMaterias.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalMaterias.Name = "tabPrincipalMaterias"
        Me.tabPrincipalMaterias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalMaterias.Size = New System.Drawing.Size(836, 493)
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
        Me.btnMateriasImprimir.Location = New System.Drawing.Point(792, 7)
        Me.btnMateriasImprimir.Name = "btnMateriasImprimir"
        Me.btnMateriasImprimir.Size = New System.Drawing.Size(35, 35)
        Me.btnMateriasImprimir.TabIndex = 27
        Me.btnMateriasImprimir.UseVisualStyleBackColor = False
        '
        'tabPrincipalTareas
        '
        Me.tabPrincipalTareas.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalTareas.Controls.Add(Me.dgvP_Calificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.tabCalificaciones_Vista)
        Me.tabPrincipalTareas.Controls.Add(Me.pnlCalificaciones_Comboboxes)
        Me.tabPrincipalTareas.Controls.Add(Me.btnModificarCalificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.btnEliminarCalificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.btnCrearCalificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.btnEvaluacionesImprimir)
        Me.tabPrincipalTareas.Controls.Add(Me.lblTareas)
        Me.tabPrincipalTareas.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalTareas.Name = "tabPrincipalTareas"
        Me.tabPrincipalTareas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalTareas.Size = New System.Drawing.Size(836, 493)
        Me.tabPrincipalTareas.TabIndex = 2
        Me.tabPrincipalTareas.Text = "Calificaciones"
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
        Me.TextBox1.Location = New System.Drawing.Point(332, 48)
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
        'pnlCalificaciones_Comboboxes
        '
        Me.pnlCalificaciones_Comboboxes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCalificaciones_Comboboxes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.Button2)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.Panel4)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.cboAsignatura)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.cboGrupo)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.cboInstituto)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.Label16)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.Label15)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.cbxInstituto)
        Me.pnlCalificaciones_Comboboxes.Location = New System.Drawing.Point(186, 47)
        Me.pnlCalificaciones_Comboboxes.Name = "pnlCalificaciones_Comboboxes"
        Me.pnlCalificaciones_Comboboxes.Size = New System.Drawing.Size(636, 86)
        Me.pnlCalificaciones_Comboboxes.TabIndex = 39
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.search_filled
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(448, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 26
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rdioCalificaciones_Ver_Por_Alumno)
        Me.Panel4.Controls.Add(Me.rdioCalificaciones_Ver_Por_Calificacion)
        Me.Panel4.Location = New System.Drawing.Point(492, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(130, 57)
        Me.Panel4.TabIndex = 25
        '
        'rdioCalificaciones_Ver_Por_Alumno
        '
        Me.rdioCalificaciones_Ver_Por_Alumno.AutoSize = True
        Me.rdioCalificaciones_Ver_Por_Alumno.BackColor = System.Drawing.Color.Transparent
        Me.rdioCalificaciones_Ver_Por_Alumno.ForeColor = System.Drawing.Color.White
        Me.rdioCalificaciones_Ver_Por_Alumno.Location = New System.Drawing.Point(11, 28)
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
        Me.rdioCalificaciones_Ver_Por_Calificacion.Location = New System.Drawing.Point(11, 4)
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
        Me.btnEvaluacionesImprimir.Location = New System.Drawing.Point(787, 7)
        Me.btnEvaluacionesImprimir.Name = "btnEvaluacionesImprimir"
        Me.btnEvaluacionesImprimir.Size = New System.Drawing.Size(35, 35)
        Me.btnEvaluacionesImprimir.TabIndex = 34
        Me.btnEvaluacionesImprimir.UseVisualStyleBackColor = False
        '
        'tabPrincipalDocentes
        '
        Me.tabPrincipalDocentes.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalDocentes.Controls.Add(Me.BorderLabel5)
        Me.tabPrincipalDocentes.Controls.Add(Me.BorderLabel4)
        Me.tabPrincipalDocentes.Controls.Add(Me.Button5)
        Me.tabPrincipalDocentes.Controls.Add(Me.listAsignaturas)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDesvicularADocenteGrupo)
        Me.tabPrincipalDocentes.Controls.Add(Me.listDocenteAsignarGrupo)
        Me.tabPrincipalDocentes.Controls.Add(Me.dgvP_Docentes)
        Me.tabPrincipalDocentes.Controls.Add(Me.lblDocentes)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesModificar)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesEliminar)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesCrearNuevo)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesImprimir)
        Me.tabPrincipalDocentes.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalDocentes.Name = "tabPrincipalDocentes"
        Me.tabPrincipalDocentes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalDocentes.Size = New System.Drawing.Size(836, 493)
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
        'btnDocentesImprimir
        '
        Me.btnDocentesImprimir.BackColor = System.Drawing.Color.White
        Me.btnDocentesImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnDocentesImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesImprimir.Location = New System.Drawing.Point(177, 47)
        Me.btnDocentesImprimir.Name = "btnDocentesImprimir"
        Me.btnDocentesImprimir.Size = New System.Drawing.Size(49, 50)
        Me.btnDocentesImprimir.TabIndex = 28
        Me.btnDocentesImprimir.UseVisualStyleBackColor = False
        '
        'tabPrincipalUsuarios
        '
        Me.tabPrincipalUsuarios.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tabPrincipalUsuarios.Controls.Add(Me.dgvP_Usuarios)
        Me.tabPrincipalUsuarios.Controls.Add(Me.lblUsuarios)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosImprimir)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosModificar)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosBotonEliminarUsuario)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosBotonCrearNuevo)
        Me.tabPrincipalUsuarios.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalUsuarios.Name = "tabPrincipalUsuarios"
        Me.tabPrincipalUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalUsuarios.Size = New System.Drawing.Size(836, 493)
        Me.tabPrincipalUsuarios.TabIndex = 4
        Me.tabPrincipalUsuarios.Text = "Usuarios"
        '
        'btnUsuariosImprimir
        '
        Me.btnUsuariosImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUsuariosImprimir.BackColor = System.Drawing.Color.White
        Me.btnUsuariosImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnUsuariosImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsuariosImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsuariosImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsuariosImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnUsuariosImprimir.Location = New System.Drawing.Point(792, 7)
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
        Me.tabpageInstitutos.Controls.Add(Me.dgvP_Institutos)
        Me.tabpageInstitutos.Controls.Add(Me.BorderLabel1)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoImprimir)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoModificar)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoEliminar)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoCrear)
        Me.tabpageInstitutos.Location = New System.Drawing.Point(4, 22)
        Me.tabpageInstitutos.Name = "tabpageInstitutos"
        Me.tabpageInstitutos.Size = New System.Drawing.Size(836, 493)
        Me.tabpageInstitutos.TabIndex = 5
        Me.tabpageInstitutos.Text = "Institutos"
        '
        'btnInstitutoImprimir
        '
        Me.btnInstitutoImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInstitutoImprimir.BackColor = System.Drawing.Color.White
        Me.btnInstitutoImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnInstitutoImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInstitutoImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInstitutoImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstitutoImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInstitutoImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnInstitutoImprimir.Location = New System.Drawing.Point(792, 14)
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
        'tabOrientaciones
        '
        Me.tabOrientaciones.BackColor = System.Drawing.Color.Silver
        Me.tabOrientaciones.Controls.Add(Me.btnOrientacionesModificar)
        Me.tabOrientaciones.Controls.Add(Me.btnOrientacionesEliminar)
        Me.tabOrientaciones.Controls.Add(Me.btnOrientacionesCrear)
        Me.tabOrientaciones.Controls.Add(Me.btnImprimirOrientaciones)
        Me.tabOrientaciones.Controls.Add(Me.BorderLabel2)
        Me.tabOrientaciones.Controls.Add(Me.dgvP_Orientaciones)
        Me.tabOrientaciones.Location = New System.Drawing.Point(4, 22)
        Me.tabOrientaciones.Name = "tabOrientaciones"
        Me.tabOrientaciones.Size = New System.Drawing.Size(836, 493)
        Me.tabOrientaciones.TabIndex = 7
        Me.tabOrientaciones.Text = "Orientaciones"
        '
        'btnOrientacionesModificar
        '
        Me.btnOrientacionesModificar.BackColor = System.Drawing.Color.White
        Me.btnOrientacionesModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnOrientacionesModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrientacionesModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrientacionesModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrientacionesModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOrientacionesModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnOrientacionesModificar.Location = New System.Drawing.Point(121, 48)
        Me.btnOrientacionesModificar.Name = "btnOrientacionesModificar"
        Me.btnOrientacionesModificar.Size = New System.Drawing.Size(50, 50)
        Me.btnOrientacionesModificar.TabIndex = 38
        Me.btnOrientacionesModificar.UseVisualStyleBackColor = False
        '
        'btnOrientacionesEliminar
        '
        Me.btnOrientacionesEliminar.BackColor = System.Drawing.Color.White
        Me.btnOrientacionesEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.btnOrientacionesEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrientacionesEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrientacionesEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrientacionesEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOrientacionesEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnOrientacionesEliminar.Location = New System.Drawing.Point(65, 48)
        Me.btnOrientacionesEliminar.Name = "btnOrientacionesEliminar"
        Me.btnOrientacionesEliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnOrientacionesEliminar.TabIndex = 37
        Me.btnOrientacionesEliminar.UseVisualStyleBackColor = False
        '
        'btnOrientacionesCrear
        '
        Me.btnOrientacionesCrear.BackColor = System.Drawing.Color.White
        Me.btnOrientacionesCrear.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.btnOrientacionesCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrientacionesCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrientacionesCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrientacionesCrear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOrientacionesCrear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnOrientacionesCrear.Location = New System.Drawing.Point(9, 48)
        Me.btnOrientacionesCrear.Name = "btnOrientacionesCrear"
        Me.btnOrientacionesCrear.Size = New System.Drawing.Size(50, 50)
        Me.btnOrientacionesCrear.TabIndex = 36
        Me.btnOrientacionesCrear.UseVisualStyleBackColor = False
        '
        'btnImprimirOrientaciones
        '
        Me.btnImprimirOrientaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirOrientaciones.BackColor = System.Drawing.Color.White
        Me.btnImprimirOrientaciones.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnImprimirOrientaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimirOrientaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimirOrientaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirOrientaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImprimirOrientaciones.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnImprimirOrientaciones.Location = New System.Drawing.Point(798, 14)
        Me.btnImprimirOrientaciones.Name = "btnImprimirOrientaciones"
        Me.btnImprimirOrientaciones.Size = New System.Drawing.Size(35, 35)
        Me.btnImprimirOrientaciones.TabIndex = 35
        Me.btnImprimirOrientaciones.UseVisualStyleBackColor = False
        '
        'tabCiudades
        '
        Me.tabCiudades.BackColor = System.Drawing.Color.Silver
        Me.tabCiudades.Controls.Add(Me.btnCiudadesModificar)
        Me.tabCiudades.Controls.Add(Me.btnCiudadesEliminar)
        Me.tabCiudades.Controls.Add(Me.btnCiudadesCrear)
        Me.tabCiudades.Controls.Add(Me.btnCiudadesImprimir)
        Me.tabCiudades.Controls.Add(Me.lblCiudades)
        Me.tabCiudades.Controls.Add(Me.dgvP_Ciudades)
        Me.tabCiudades.Location = New System.Drawing.Point(4, 22)
        Me.tabCiudades.Name = "tabCiudades"
        Me.tabCiudades.Size = New System.Drawing.Size(836, 493)
        Me.tabCiudades.TabIndex = 8
        Me.tabCiudades.Text = "Ciudades"
        '
        'btnCiudadesModificar
        '
        Me.btnCiudadesModificar.BackColor = System.Drawing.Color.White
        Me.btnCiudadesModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnCiudadesModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCiudadesModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCiudadesModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudadesModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCiudadesModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCiudadesModificar.Location = New System.Drawing.Point(119, 50)
        Me.btnCiudadesModificar.Name = "btnCiudadesModificar"
        Me.btnCiudadesModificar.Size = New System.Drawing.Size(50, 50)
        Me.btnCiudadesModificar.TabIndex = 38
        Me.btnCiudadesModificar.UseVisualStyleBackColor = False
        '
        'btnCiudadesEliminar
        '
        Me.btnCiudadesEliminar.BackColor = System.Drawing.Color.White
        Me.btnCiudadesEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.btnCiudadesEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCiudadesEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCiudadesEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudadesEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCiudadesEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCiudadesEliminar.Location = New System.Drawing.Point(63, 50)
        Me.btnCiudadesEliminar.Name = "btnCiudadesEliminar"
        Me.btnCiudadesEliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnCiudadesEliminar.TabIndex = 37
        Me.btnCiudadesEliminar.UseVisualStyleBackColor = False
        '
        'btnCiudadesCrear
        '
        Me.btnCiudadesCrear.BackColor = System.Drawing.Color.White
        Me.btnCiudadesCrear.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.btnCiudadesCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCiudadesCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCiudadesCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudadesCrear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCiudadesCrear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCiudadesCrear.Location = New System.Drawing.Point(7, 50)
        Me.btnCiudadesCrear.Name = "btnCiudadesCrear"
        Me.btnCiudadesCrear.Size = New System.Drawing.Size(50, 50)
        Me.btnCiudadesCrear.TabIndex = 36
        Me.btnCiudadesCrear.UseVisualStyleBackColor = False
        '
        'btnCiudadesImprimir
        '
        Me.btnCiudadesImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCiudadesImprimir.BackColor = System.Drawing.Color.White
        Me.btnCiudadesImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.btnCiudadesImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCiudadesImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCiudadesImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudadesImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCiudadesImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCiudadesImprimir.Location = New System.Drawing.Point(796, 16)
        Me.btnCiudadesImprimir.Name = "btnCiudadesImprimir"
        Me.btnCiudadesImprimir.Size = New System.Drawing.Size(35, 35)
        Me.btnCiudadesImprimir.TabIndex = 35
        Me.btnCiudadesImprimir.UseVisualStyleBackColor = False
        '
        'tabAdmins
        '
        Me.tabAdmins.BackColor = System.Drawing.Color.Silver
        Me.tabAdmins.Controls.Add(Me.dgv_Admins_Administrativos)
        Me.tabAdmins.Controls.Add(Me.Panel1)
        Me.tabAdmins.Location = New System.Drawing.Point(4, 22)
        Me.tabAdmins.Name = "tabAdmins"
        Me.tabAdmins.Size = New System.Drawing.Size(836, 493)
        Me.tabAdmins.TabIndex = 9
        Me.tabAdmins.Text = "Admins/Administrativos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnAdmins_Modificar)
        Me.Panel1.Controls.Add(Me.btnAdmins_Eliminar)
        Me.Panel1.Controls.Add(Me.btnAdmins_Crear)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.BorderLabel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 109)
        Me.Panel1.TabIndex = 29
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.database_restore
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(750, 11)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 32
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnAdmins_Modificar
        '
        Me.btnAdmins_Modificar.BackColor = System.Drawing.Color.White
        Me.btnAdmins_Modificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.multi_edit
        Me.btnAdmins_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdmins_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmins_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmins_Modificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdmins_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAdmins_Modificar.Location = New System.Drawing.Point(117, 53)
        Me.btnAdmins_Modificar.Name = "btnAdmins_Modificar"
        Me.btnAdmins_Modificar.Size = New System.Drawing.Size(50, 50)
        Me.btnAdmins_Modificar.TabIndex = 31
        Me.btnAdmins_Modificar.UseVisualStyleBackColor = False
        '
        'btnAdmins_Eliminar
        '
        Me.btnAdmins_Eliminar.BackColor = System.Drawing.Color.White
        Me.btnAdmins_Eliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_male
        Me.btnAdmins_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdmins_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmins_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmins_Eliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdmins_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAdmins_Eliminar.Location = New System.Drawing.Point(61, 53)
        Me.btnAdmins_Eliminar.Name = "btnAdmins_Eliminar"
        Me.btnAdmins_Eliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnAdmins_Eliminar.TabIndex = 30
        Me.btnAdmins_Eliminar.UseVisualStyleBackColor = False
        '
        'btnAdmins_Crear
        '
        Me.btnAdmins_Crear.BackColor = System.Drawing.Color.White
        Me.btnAdmins_Crear.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_man_man
        Me.btnAdmins_Crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdmins_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmins_Crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmins_Crear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdmins_Crear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAdmins_Crear.Location = New System.Drawing.Point(5, 53)
        Me.btnAdmins_Crear.Name = "btnAdmins_Crear"
        Me.btnAdmins_Crear.Size = New System.Drawing.Size(50, 50)
        Me.btnAdmins_Crear.TabIndex = 29
        Me.btnAdmins_Crear.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button8.Location = New System.Drawing.Point(797, 10)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(35, 35)
        Me.Button8.TabIndex = 28
        Me.Button8.UseVisualStyleBackColor = False
        '
        'btnTareas
        '
        Me.btnTareas.BackColor = System.Drawing.Color.White
        Me.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTareas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTareas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTareas.Location = New System.Drawing.Point(12, 311)
        Me.btnTareas.Name = "btnTareas"
        Me.btnTareas.Size = New System.Drawing.Size(211, 29)
        Me.btnTareas.TabIndex = 11
        Me.btnTareas.Text = "Calificaciones"
        Me.btnTareas.UseVisualStyleBackColor = False
        '
        'btnDocentes
        '
        Me.btnDocentes.BackColor = System.Drawing.Color.White
        Me.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentes.Location = New System.Drawing.Point(12, 171)
        Me.btnDocentes.Name = "btnDocentes"
        Me.btnDocentes.Size = New System.Drawing.Size(211, 29)
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
        Me.btnVentanaPrincipalInstitutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaPrincipalInstitutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaPrincipalInstitutos.Location = New System.Drawing.Point(12, 206)
        Me.btnVentanaPrincipalInstitutos.Name = "btnVentanaPrincipalInstitutos"
        Me.btnVentanaPrincipalInstitutos.Size = New System.Drawing.Size(211, 29)
        Me.btnVentanaPrincipalInstitutos.TabIndex = 22
        Me.btnVentanaPrincipalInstitutos.Text = "Institutos"
        Me.btnVentanaPrincipalInstitutos.UseVisualStyleBackColor = False
        '
        'btn_Grupos
        '
        Me.btn_Grupos.BackColor = System.Drawing.Color.White
        Me.btn_Grupos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Grupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Grupos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Grupos.Location = New System.Drawing.Point(12, 136)
        Me.btn_Grupos.Name = "btn_Grupos"
        Me.btn_Grupos.Size = New System.Drawing.Size(211, 29)
        Me.btn_Grupos.TabIndex = 23
        Me.btn_Grupos.Text = "Grupos"
        Me.btn_Grupos.UseVisualStyleBackColor = False
        '
        'btnVentanaPrincipalOrientaciones
        '
        Me.btnVentanaPrincipalOrientaciones.BackColor = System.Drawing.Color.White
        Me.btnVentanaPrincipalOrientaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVentanaPrincipalOrientaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaPrincipalOrientaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaPrincipalOrientaciones.Location = New System.Drawing.Point(12, 241)
        Me.btnVentanaPrincipalOrientaciones.Name = "btnVentanaPrincipalOrientaciones"
        Me.btnVentanaPrincipalOrientaciones.Size = New System.Drawing.Size(211, 29)
        Me.btnVentanaPrincipalOrientaciones.TabIndex = 24
        Me.btnVentanaPrincipalOrientaciones.Text = "Orientaciones"
        Me.btnVentanaPrincipalOrientaciones.UseVisualStyleBackColor = False
        '
        'btnCiudad
        '
        Me.btnCiudad.BackColor = System.Drawing.Color.White
        Me.btnCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCiudad.Location = New System.Drawing.Point(12, 276)
        Me.btnCiudad.Name = "btnCiudad"
        Me.btnCiudad.Size = New System.Drawing.Size(211, 29)
        Me.btnCiudad.TabIndex = 25
        Me.btnCiudad.Text = "Ciudades"
        Me.btnCiudad.UseVisualStyleBackColor = False
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
        'btnVentanaPrincipal_Admins_Administrativos
        '
        Me.btnVentanaPrincipal_Admins_Administrativos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVentanaPrincipal_Admins_Administrativos.BackColor = System.Drawing.Color.White
        Me.btnVentanaPrincipal_Admins_Administrativos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVentanaPrincipal_Admins_Administrativos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaPrincipal_Admins_Administrativos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaPrincipal_Admins_Administrativos.Location = New System.Drawing.Point(12, 434)
        Me.btnVentanaPrincipal_Admins_Administrativos.Name = "btnVentanaPrincipal_Admins_Administrativos"
        Me.btnVentanaPrincipal_Admins_Administrativos.Size = New System.Drawing.Size(211, 39)
        Me.btnVentanaPrincipal_Admins_Administrativos.TabIndex = 26
        Me.btnVentanaPrincipal_Admins_Administrativos.Text = "Admins/Administrativos"
        Me.btnVentanaPrincipal_Admins_Administrativos.UseVisualStyleBackColor = False
        '
        'btnDesvincular
        '
        Me.btnDesvincular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDesvincular.BackColor = System.Drawing.Color.White
        Me.btnDesvincular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDesvincular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesvincular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDesvincular.Location = New System.Drawing.Point(470, 10)
        Me.btnDesvincular.Name = "btnDesvincular"
        Me.btnDesvincular.Size = New System.Drawing.Size(194, 28)
        Me.btnDesvincular.TabIndex = 34
        Me.btnDesvincular.Text = "Desvincular del grupo"
        Me.btnDesvincular.UseVisualStyleBackColor = False
        '
        'dgvP_Alumnos
        '
        Me.dgvP_Alumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Alumnos.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Alumnos.Location = New System.Drawing.Point(0, 118)
        Me.dgvP_Alumnos.Name = "dgvP_Alumnos"
        Me.dgvP_Alumnos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvP_Alumnos.Size = New System.Drawing.Size(833, 372)
        Me.dgvP_Alumnos.TabIndex = 27
        '
        'lblAlumnos_Titulo
        '
        Me.lblAlumnos_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnos_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlumnos_Titulo.Location = New System.Drawing.Point(2, 10)
        Me.lblAlumnos_Titulo.Name = "lblAlumnos_Titulo"
        Me.lblAlumnos_Titulo.Size = New System.Drawing.Size(136, 36)
        Me.lblAlumnos_Titulo.TabIndex = 26
        Me.lblAlumnos_Titulo.Text = "Alumnos"
        '
        'dgvP_Grupos
        '
        Me.dgvP_Grupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Grupos.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Grupos.Location = New System.Drawing.Point(14, 110)
        Me.dgvP_Grupos.Name = "dgvP_Grupos"
        Me.dgvP_Grupos.Size = New System.Drawing.Size(817, 380)
        Me.dgvP_Grupos.TabIndex = 41
        '
        'lbl_Grupos_Titulo
        '
        Me.lbl_Grupos_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grupos_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Grupos_Titulo.Location = New System.Drawing.Point(6, 4)
        Me.lbl_Grupos_Titulo.Name = "lbl_Grupos_Titulo"
        Me.lbl_Grupos_Titulo.Size = New System.Drawing.Size(136, 36)
        Me.lbl_Grupos_Titulo.TabIndex = 36
        Me.lbl_Grupos_Titulo.Text = "Grupos"
        '
        'dgvP_Asignaturas
        '
        Me.dgvP_Asignaturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Asignaturas.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Asignaturas.Location = New System.Drawing.Point(9, 103)
        Me.dgvP_Asignaturas.Name = "dgvP_Asignaturas"
        Me.dgvP_Asignaturas.Size = New System.Drawing.Size(818, 387)
        Me.dgvP_Asignaturas.TabIndex = 32
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
        'dgvP_Calificaciones
        '
        Me.dgvP_Calificaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Calificaciones.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Calificaciones.Location = New System.Drawing.Point(9, 283)
        Me.dgvP_Calificaciones.Name = "dgvP_Calificaciones"
        Me.dgvP_Calificaciones.Size = New System.Drawing.Size(818, 204)
        Me.dgvP_Calificaciones.TabIndex = 41
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
        'dgvP_Docentes
        '
        Me.dgvP_Docentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Docentes.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Docentes.Location = New System.Drawing.Point(9, 193)
        Me.dgvP_Docentes.Name = "dgvP_Docentes"
        Me.dgvP_Docentes.Size = New System.Drawing.Size(816, 297)
        Me.dgvP_Docentes.TabIndex = 33
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
        'dgvP_Usuarios
        '
        Me.dgvP_Usuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Usuarios.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Usuarios.Location = New System.Drawing.Point(10, 108)
        Me.dgvP_Usuarios.Name = "dgvP_Usuarios"
        Me.dgvP_Usuarios.Size = New System.Drawing.Size(817, 379)
        Me.dgvP_Usuarios.TabIndex = 34
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
        'dgvP_Institutos
        '
        Me.dgvP_Institutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Institutos.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Institutos.Location = New System.Drawing.Point(9, 103)
        Me.dgvP_Institutos.Name = "dgvP_Institutos"
        Me.dgvP_Institutos.Size = New System.Drawing.Size(818, 387)
        Me.dgvP_Institutos.TabIndex = 35
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
        'BorderLabel2
        '
        Me.BorderLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorderLabel2.Location = New System.Drawing.Point(6, 5)
        Me.BorderLabel2.Name = "BorderLabel2"
        Me.BorderLabel2.Size = New System.Drawing.Size(201, 36)
        Me.BorderLabel2.TabIndex = 32
        Me.BorderLabel2.Text = "Orientaciones"
        '
        'dgvP_Orientaciones
        '
        Me.dgvP_Orientaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Orientaciones.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Orientaciones.Location = New System.Drawing.Point(9, 104)
        Me.dgvP_Orientaciones.Name = "dgvP_Orientaciones"
        Me.dgvP_Orientaciones.Size = New System.Drawing.Size(823, 386)
        Me.dgvP_Orientaciones.TabIndex = 34
        '
        'lblCiudades
        '
        Me.lblCiudades.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudades.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCiudades.Location = New System.Drawing.Point(4, 7)
        Me.lblCiudades.Name = "lblCiudades"
        Me.lblCiudades.Size = New System.Drawing.Size(136, 36)
        Me.lblCiudades.TabIndex = 32
        Me.lblCiudades.Text = "Ciudades"
        '
        'dgvP_Ciudades
        '
        Me.dgvP_Ciudades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Ciudades.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Ciudades.Location = New System.Drawing.Point(7, 106)
        Me.dgvP_Ciudades.Name = "dgvP_Ciudades"
        Me.dgvP_Ciudades.Size = New System.Drawing.Size(823, 391)
        Me.dgvP_Ciudades.TabIndex = 34
        '
        'dgv_Admins_Administrativos
        '
        Me.dgv_Admins_Administrativos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Admins_Administrativos.BackColor = System.Drawing.Color.AliceBlue
        Me.dgv_Admins_Administrativos.Location = New System.Drawing.Point(0, 119)
        Me.dgv_Admins_Administrativos.Name = "dgv_Admins_Administrativos"
        Me.dgv_Admins_Administrativos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_Admins_Administrativos.Size = New System.Drawing.Size(833, 372)
        Me.dgv_Admins_Administrativos.TabIndex = 28
        '
        'BorderLabel3
        '
        Me.BorderLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorderLabel3.Location = New System.Drawing.Point(2, 10)
        Me.BorderLabel3.Name = "BorderLabel3"
        Me.BorderLabel3.Size = New System.Drawing.Size(332, 36)
        Me.BorderLabel3.TabIndex = 26
        Me.BorderLabel3.Text = "Admins/Administrativos"
        '
        'b_lblRol_Dinamico
        '
        Me.b_lblRol_Dinamico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_lblRol_Dinamico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblRol_Dinamico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.b_lblRol_Dinamico.Location = New System.Drawing.Point(888, 4)
        Me.b_lblRol_Dinamico.Name = "b_lblRol_Dinamico"
        Me.b_lblRol_Dinamico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.b_lblRol_Dinamico.Size = New System.Drawing.Size(160, 24)
        Me.b_lblRol_Dinamico.TabIndex = 4
        Me.b_lblRol_Dinamico.Text = "rol"
        Me.b_lblRol_Dinamico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'b_lblNombreUsuario_Dinamico
        '
        Me.b_lblNombreUsuario_Dinamico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblNombreUsuario_Dinamico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.b_lblNombreUsuario_Dinamico.Location = New System.Drawing.Point(122, 4)
        Me.b_lblNombreUsuario_Dinamico.Name = "b_lblNombreUsuario_Dinamico"
        Me.b_lblNombreUsuario_Dinamico.Size = New System.Drawing.Size(200, 24)
        Me.b_lblNombreUsuario_Dinamico.TabIndex = 2
        Me.b_lblNombreUsuario_Dinamico.Text = "usuario"
        '
        'b_lblusuarioLogueado_nombre
        '
        Me.b_lblusuarioLogueado_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblusuarioLogueado_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.b_lblusuarioLogueado_nombre.Location = New System.Drawing.Point(4, 7)
        Me.b_lblusuarioLogueado_nombre.Name = "b_lblusuarioLogueado_nombre"
        Me.b_lblusuarioLogueado_nombre.Size = New System.Drawing.Size(112, 24)
        Me.b_lblusuarioLogueado_nombre.TabIndex = 1
        Me.b_lblusuarioLogueado_nombre.Text = "Bienvenido,"
        '
        'btnDesvicularADocenteGrupo
        '
        Me.btnDesvicularADocenteGrupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDesvicularADocenteGrupo.BackColor = System.Drawing.Color.White
        Me.btnDesvicularADocenteGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDesvicularADocenteGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesvicularADocenteGrupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDesvicularADocenteGrupo.Location = New System.Drawing.Point(639, 164)
        Me.btnDesvicularADocenteGrupo.Name = "btnDesvicularADocenteGrupo"
        Me.btnDesvicularADocenteGrupo.Size = New System.Drawing.Size(186, 28)
        Me.btnDesvicularADocenteGrupo.TabIndex = 37
        Me.btnDesvicularADocenteGrupo.Text = "Desvincular del grupo"
        Me.btnDesvicularADocenteGrupo.UseVisualStyleBackColor = False
        '
        'listDocenteAsignarGrupo
        '
        Me.listDocenteAsignarGrupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listDocenteAsignarGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listDocenteAsignarGrupo.FormattingEnabled = True
        Me.listDocenteAsignarGrupo.ItemHeight = 16
        Me.listDocenteAsignarGrupo.Location = New System.Drawing.Point(346, 124)
        Me.listDocenteAsignarGrupo.Name = "listDocenteAsignarGrupo"
        Me.listDocenteAsignarGrupo.Size = New System.Drawing.Size(291, 68)
        Me.listDocenteAsignarGrupo.TabIndex = 36
        '
        'listAsignaturas
        '
        Me.listAsignaturas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listAsignaturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listAsignaturas.FormattingEnabled = True
        Me.listAsignaturas.ItemHeight = 16
        Me.listAsignaturas.Location = New System.Drawing.Point(9, 124)
        Me.listAsignaturas.Name = "listAsignaturas"
        Me.listAsignaturas.Size = New System.Drawing.Size(331, 68)
        Me.listAsignaturas.TabIndex = 38
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(639, 124)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(186, 28)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Vincular a un grupo"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'BorderLabel4
        '
        Me.BorderLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorderLabel4.Location = New System.Drawing.Point(7, 100)
        Me.BorderLabel4.Name = "BorderLabel4"
        Me.BorderLabel4.Size = New System.Drawing.Size(136, 21)
        Me.BorderLabel4.TabIndex = 40
        Me.BorderLabel4.Text = "Asignatura"
        '
        'BorderLabel5
        '
        Me.BorderLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorderLabel5.Location = New System.Drawing.Point(342, 100)
        Me.BorderLabel5.Name = "BorderLabel5"
        Me.BorderLabel5.Size = New System.Drawing.Size(136, 21)
        Me.BorderLabel5.TabIndex = 41
        Me.BorderLabel5.Text = "Grupo"
        '
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1085, 576)
        Me.Controls.Add(Me.btnVentanaPrincipal_Admins_Administrativos)
        Me.Controls.Add(Me.btnCiudad)
        Me.Controls.Add(Me.btnVentanaPrincipalOrientaciones)
        Me.Controls.Add(Me.btn_Grupos)
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
        Me.Panel7.ResumeLayout(False)
        Me.tabpage_Grupos.ResumeLayout(False)
        Me.tabPrincipalMaterias.ResumeLayout(False)
        Me.tabPrincipalTareas.ResumeLayout(False)
        Me.tabCalificaciones_Vista.ResumeLayout(False)
        Me.tabCalificaciones_Vista_Por_Calificacion.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tabCalificaiones_Vista_Alumnos.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.pnlCalificaciones_Comboboxes.ResumeLayout(False)
        Me.pnlCalificaciones_Comboboxes.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.tabPrincipalDocentes.ResumeLayout(False)
        Me.tabPrincipalUsuarios.ResumeLayout(False)
        Me.tabpageInstitutos.ResumeLayout(False)
        Me.tabOrientaciones.ResumeLayout(False)
        Me.tabCiudades.ResumeLayout(False)
        Me.tabAdmins.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogoff As Button
    Friend WithEvents pnlUsuario_logueado As Panel
    Friend WithEvents b_lblRol_Dinamico As BorderLabel
    Friend WithEvents b_lblNombreUsuario_Dinamico As BorderLabel
    Friend WithEvents b_lblusuarioLogueado_nombre As BorderLabel
    Friend WithEvents btnAlumnos As Button
    Friend WithEvents btnMaterias As Button
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
    Friend WithEvents btnUsuariosBotonCrearNuevo As Button
    Friend WithEvents btnUsuariosBotonEliminarUsuario As Button
    Friend WithEvents btnUsuariosModificar As Button
    Friend WithEvents btnUsuariosImprimir As Button
    Friend WithEvents btnVentanaPrincipalConfiguracion As Button
    Friend WithEvents btnDocentesModificar As Button
    Friend WithEvents btnDocentesEliminar As Button
    Friend WithEvents btnDocentesCrearNuevo As Button
    Friend WithEvents btnDocentesImprimir As Button
    Friend WithEvents btnMateriasModificar As Button
    Friend WithEvents btnMateriasEliminar As Button
    Friend WithEvents btnMateriasCrear As Button
    Friend WithEvents btnMateriasImprimir As Button
    Friend WithEvents btnModificarCalificaciones As Button
    Friend WithEvents btnEliminarCalificaciones As Button
    Friend WithEvents btnCrearCalificaciones As Button
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
    Friend WithEvents BorderLabel1 As BorderLabel
    Friend WithEvents btnVentanaPrincipalInstitutos As Button
    Friend WithEvents btnInstitutoImprimir As Button
    Friend WithEvents pnlCalificaciones_Comboboxes As Panel
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
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnAlumnosModificar As Button
    Friend WithEvents btnAlumnosEliminar As Button
    Friend WithEvents btnAlumnosCrearNuevo As Button
    Friend WithEvents btnAlumnosImprimir As Button
    Friend WithEvents lblAlumnos_Titulo As BorderLabel
    Friend WithEvents dgvP_Asignaturas As DGVPaginado
    Friend WithEvents dgvP_Calificaciones As DGVPaginado
    Friend WithEvents dgvP_Docentes As DGVPaginado
    Friend WithEvents dgvP_Usuarios As DGVPaginado
    Friend WithEvents tabpage_Grupos As TabPage
    Friend WithEvents dgvP_Grupos As DGVPaginado
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_Grupos_Modificar As Button
    Friend WithEvents btnGrupos_Eliminar As Button
    Friend WithEvents btnGrupos_Agregar As Button
    Friend WithEvents lbl_Grupos_Titulo As BorderLabel
    Friend WithEvents btn_Grupos As Button
    Friend WithEvents dgvP_Institutos As DGVPaginado
    Friend WithEvents tabOrientaciones As TabPage
    Friend WithEvents btnOrientacionesModificar As Button
    Friend WithEvents btnOrientacionesEliminar As Button
    Friend WithEvents btnOrientacionesCrear As Button
    Friend WithEvents btnImprimirOrientaciones As Button
    Friend WithEvents BorderLabel2 As BorderLabel
    Friend WithEvents dgvP_Orientaciones As DGVPaginado
    Friend WithEvents btnVentanaPrincipalOrientaciones As Button
    Friend WithEvents btnCiudad As Button
    Friend WithEvents tabCiudades As TabPage
    Friend WithEvents btnCiudadesModificar As Button
    Friend WithEvents btnCiudadesEliminar As Button
    Friend WithEvents btnCiudadesCrear As Button
    Friend WithEvents btnCiudadesImprimir As Button
    Friend WithEvents lblCiudades As BorderLabel
    Friend WithEvents dgvP_Ciudades As DGVPaginado
    Friend WithEvents dgvP_Alumnos As DGVPaginado
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_alumnos_Refrescar As Button
    Friend WithEvents tabAdmins As TabPage
    Friend WithEvents dgv_Admins_Administrativos As DGVPaginado
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnAdmins_Modificar As Button
    Friend WithEvents btnAdmins_Eliminar As Button
    Friend WithEvents btnAdmins_Crear As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents BorderLabel3 As BorderLabel
    Friend WithEvents btnVentanaPrincipal_Admins_Administrativos As Button
    Friend WithEvents btn_agregar_a_un_grupo As Button
    Friend WithEvents lst_Agregar_grupo As ListBox
    Friend WithEvents btnDesvincular As Button
    Friend WithEvents btnDesvicularADocenteGrupo As Button
    Friend WithEvents listDocenteAsignarGrupo As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents listAsignaturas As ListBox
    Friend WithEvents BorderLabel5 As BorderLabel
    Friend WithEvents BorderLabel4 As BorderLabel
End Class
