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
        Me.b_lblRol_Dinamico = New WindowsApp1.BorderLabel()
        Me.b_lblNombreUsuario_Dinamico = New WindowsApp1.BorderLabel()
        Me.b_lblusuarioLogueado_nombre = New WindowsApp1.BorderLabel()
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.btnMaterias = New System.Windows.Forms.Button()
        Me.tabPrincipal = New System.Windows.Forms.TabControl()
        Me.tabPrincipalAlumnos = New System.Windows.Forms.TabPage()
        Me.dgvP_Alumnos = New WindowsApp1.DGVPaginado()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lst_Agregar_grupo = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnDesvincular = New System.Windows.Forms.Button()
        Me.btn_agregar_a_un_grupo = New System.Windows.Forms.Button()
        Me.btn_alumnos_Refrescar = New System.Windows.Forms.Button()
        Me.btnAlumnosModificar = New System.Windows.Forms.Button()
        Me.btnAlumnosEliminar = New System.Windows.Forms.Button()
        Me.btnAlumnosCrearNuevo = New System.Windows.Forms.Button()
        Me.btnAlumnosImprimir = New System.Windows.Forms.Button()
        Me.lblAlumnos_Titulo = New WindowsApp1.BorderLabel()
        Me.tabpage_Grupos = New System.Windows.Forms.TabPage()
        Me.lstGrupos_vinc_Orientaciones = New System.Windows.Forms.ComboBox()
        Me.btnVincular_a_Orientacion = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_Grupos_refrescar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_Grupos_Modificar = New System.Windows.Forms.Button()
        Me.btnGrupos_Eliminar = New System.Windows.Forms.Button()
        Me.btnGrupos_Agregar = New System.Windows.Forms.Button()
        Me.dgvP_Grupos = New WindowsApp1.DGVPaginado()
        Me.lbl_Grupos_Titulo = New WindowsApp1.BorderLabel()
        Me.tabPrincipalMaterias = New System.Windows.Forms.TabPage()
        Me.btn_Asignaturas_refrescar = New System.Windows.Forms.Button()
        Me.btnMateriasModificar = New System.Windows.Forms.Button()
        Me.btnMateriasEliminar = New System.Windows.Forms.Button()
        Me.btnMateriasCrear = New System.Windows.Forms.Button()
        Me.btnMateriasImprimir = New System.Windows.Forms.Button()
        Me.dgvP_Asignaturas = New WindowsApp1.DGVPaginado()
        Me.lblMaterias = New WindowsApp1.BorderLabel()
        Me.tabPrincipalTareas = New System.Windows.Forms.TabPage()
        Me.btn_refrescar_Calificaciones = New System.Windows.Forms.Button()
        Me.pnlCalificaciones_Comboboxes = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.dgvP_Calificaciones = New WindowsApp1.DGVPaginado()
        Me.lblTareas = New WindowsApp1.BorderLabel()
        Me.tabPrincipalDocentes = New System.Windows.Forms.TabPage()
        Me.ver_grupos = New System.Windows.Forms.Button()
        Me.listDocenteAsignarGrupo = New System.Windows.Forms.ComboBox()
        Me.listAsignaturasDocente = New System.Windows.Forms.ComboBox()
        Me.btn_ver_grupos_asignados_docente = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btn_Docentes_refrescar = New System.Windows.Forms.Button()
        Me.btnDocentesModificar = New System.Windows.Forms.Button()
        Me.btnDocentesEliminar = New System.Windows.Forms.Button()
        Me.btnDocentesCrearNuevo = New System.Windows.Forms.Button()
        Me.btnDocentesImprimir = New System.Windows.Forms.Button()
        Me.BorderLabel5 = New WindowsApp1.BorderLabel()
        Me.BorderLabel4 = New WindowsApp1.BorderLabel()
        Me.dgvP_Docentes = New WindowsApp1.DGVPaginado()
        Me.lblDocentes = New WindowsApp1.BorderLabel()
        Me.tabPrincipalUsuarios = New System.Windows.Forms.TabPage()
        Me.btn_usuarios_refrescar = New System.Windows.Forms.Button()
        Me.btnUsuariosImprimir = New System.Windows.Forms.Button()
        Me.btnUsuariosModificar = New System.Windows.Forms.Button()
        Me.btnUsuariosBotonEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnUsuariosBotonCrearNuevo = New System.Windows.Forms.Button()
        Me.dgvP_Usuarios = New WindowsApp1.DGVPaginado()
        Me.lblUsuarios = New WindowsApp1.BorderLabel()
        Me.tabpageInstitutos = New System.Windows.Forms.TabPage()
        Me.btn_Institutos_refrescar = New System.Windows.Forms.Button()
        Me.btnInstitutoImprimir = New System.Windows.Forms.Button()
        Me.btnInstitutoModificar = New System.Windows.Forms.Button()
        Me.btnInstitutoEliminar = New System.Windows.Forms.Button()
        Me.btnInstitutoCrear = New System.Windows.Forms.Button()
        Me.dgvP_Institutos = New WindowsApp1.DGVPaginado()
        Me.BorderLabel1 = New WindowsApp1.BorderLabel()
        Me.tabOrientaciones = New System.Windows.Forms.TabPage()
        Me.btn_orientacion_refrescar = New System.Windows.Forms.Button()
        Me.btnOrientacionesModificar = New System.Windows.Forms.Button()
        Me.btnOrientacionesEliminar = New System.Windows.Forms.Button()
        Me.btnOrientacionesCrear = New System.Windows.Forms.Button()
        Me.btnImprimirOrientaciones = New System.Windows.Forms.Button()
        Me.BorderLabel2 = New WindowsApp1.BorderLabel()
        Me.dgvP_Orientaciones = New WindowsApp1.DGVPaginado()
        Me.tabCiudades = New System.Windows.Forms.TabPage()
        Me.btnCiudades_Refrescar = New System.Windows.Forms.Button()
        Me.btnCiudadesModificar = New System.Windows.Forms.Button()
        Me.btnCiudadesEliminar = New System.Windows.Forms.Button()
        Me.btnCiudadesCrear = New System.Windows.Forms.Button()
        Me.btnCiudadesImprimir = New System.Windows.Forms.Button()
        Me.lblCiudades = New WindowsApp1.BorderLabel()
        Me.dgvP_Ciudades = New WindowsApp1.DGVPaginado()
        Me.tabAdmins = New System.Windows.Forms.TabPage()
        Me.dgv_Admins_Administrativos = New WindowsApp1.DGVPaginado()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_admins_Refrescar = New System.Windows.Forms.Button()
        Me.btnAdmins_Modificar = New System.Windows.Forms.Button()
        Me.btnAdmins_Eliminar = New System.Windows.Forms.Button()
        Me.btnAdmins_Crear = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.BorderLabel3 = New WindowsApp1.BorderLabel()
        Me.tabHistorial = New System.Windows.Forms.TabPage()
        Me.dgvP_Historial = New WindowsApp1.DGVPaginado()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Historial = New WindowsApp1.BorderLabel()
        Me.tabCarambula = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCarambula_1 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_1 = New System.Windows.Forms.Button()
        Me.dgvP_carambula_1 = New WindowsApp1.DGVPaginado()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BorderLabel6 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_2 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_2 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_2 = New WindowsApp1.DGVPaginado()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BorderLabel7 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_3 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_3 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_3 = New WindowsApp1.DGVPaginado()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BorderLabel8 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_4 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_4 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_4 = New WindowsApp1.DGVPaginado()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BorderLabel9 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_5 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_5 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_5 = New WindowsApp1.DGVPaginado()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.BorderLabel10 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_6 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_6 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_6 = New WindowsApp1.DGVPaginado()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.BorderLabel11 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_7 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_7 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_7 = New WindowsApp1.DGVPaginado()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.BorderLabel12 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_8 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_8 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_8 = New WindowsApp1.DGVPaginado()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.BorderLabel13 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_9 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_9 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_9 = New WindowsApp1.DGVPaginado()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.BorderLabel14 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_10 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_10 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_10 = New WindowsApp1.DGVPaginado()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.BorderLabel15 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_11 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_11 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_11 = New WindowsApp1.DGVPaginado()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.BorderLabel16 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_12 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_12 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_12 = New WindowsApp1.DGVPaginado()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.BorderLabel17 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_13 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_13 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_13 = New WindowsApp1.DGVPaginado()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.BorderLabel18 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_14 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_14 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_14 = New WindowsApp1.DGVPaginado()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.BorderLabel19 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_15 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_15 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_15 = New WindowsApp1.DGVPaginado()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.BorderLabel20 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_16 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_16 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_16 = New WindowsApp1.DGVPaginado()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.BorderLabel21 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_17 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_17 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_17 = New WindowsApp1.DGVPaginado()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.BorderLabel22 = New WindowsApp1.BorderLabel()
        Me.tabCarambula_18 = New System.Windows.Forms.TabPage()
        Me.btn_carambula_18 = New System.Windows.Forms.Button()
        Me.dgvp_carambula_18 = New WindowsApp1.DGVPaginado()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.BorderLabel23 = New WindowsApp1.BorderLabel()
        Me.btnTareas = New System.Windows.Forms.Button()
        Me.btnDocentes = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnVentanaPrincipalInstitutos = New System.Windows.Forms.Button()
        Me.btn_Grupos = New System.Windows.Forms.Button()
        Me.btnVentanaPrincipalOrientaciones = New System.Windows.Forms.Button()
        Me.btnCiudad = New System.Windows.Forms.Button()
        Me.btnVentanaPrincipal_Admins_Administrativos = New System.Windows.Forms.Button()
        Me.Control_impresion = New System.Drawing.Printing.PrintDocument()
        Me.btnTabHistorial = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.pnlUsuario_logueado.SuspendLayout()
        Me.tabPrincipal.SuspendLayout()
        Me.tabPrincipalAlumnos.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.tabpage_Grupos.SuspendLayout()
        Me.tabPrincipalMaterias.SuspendLayout()
        Me.tabPrincipalTareas.SuspendLayout()
        Me.pnlCalificaciones_Comboboxes.SuspendLayout()
        Me.tabPrincipalDocentes.SuspendLayout()
        Me.tabPrincipalUsuarios.SuspendLayout()
        Me.tabpageInstitutos.SuspendLayout()
        Me.tabOrientaciones.SuspendLayout()
        Me.tabCiudades.SuspendLayout()
        Me.tabAdmins.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabHistorial.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tabCarambula.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabCarambula_1.SuspendLayout()
        Me.tabCarambula_2.SuspendLayout()
        Me.tabCarambula_3.SuspendLayout()
        Me.tabCarambula_4.SuspendLayout()
        Me.tabCarambula_5.SuspendLayout()
        Me.tabCarambula_6.SuspendLayout()
        Me.tabCarambula_7.SuspendLayout()
        Me.tabCarambula_8.SuspendLayout()
        Me.tabCarambula_9.SuspendLayout()
        Me.tabCarambula_10.SuspendLayout()
        Me.tabCarambula_11.SuspendLayout()
        Me.tabCarambula_12.SuspendLayout()
        Me.tabCarambula_13.SuspendLayout()
        Me.tabCarambula_14.SuspendLayout()
        Me.tabCarambula_15.SuspendLayout()
        Me.tabCarambula_16.SuspendLayout()
        Me.tabCarambula_17.SuspendLayout()
        Me.tabCarambula_18.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogoff
        '
        Me.btnLogoff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogoff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogoff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogoff.Location = New System.Drawing.Point(12, 661)
        Me.btnLogoff.Name = "btnLogoff"
        Me.btnLogoff.Size = New System.Drawing.Size(211, 39)
        Me.btnLogoff.TabIndex = 5
        Me.btnLogoff.Text = "Log off!"
        Me.btnLogoff.UseVisualStyleBackColor = False
        '
        'pnlUsuario_logueado
        '
        Me.pnlUsuario_logueado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUsuario_logueado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlUsuario_logueado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlUsuario_logueado.Controls.Add(Me.b_lblRol_Dinamico)
        Me.pnlUsuario_logueado.Controls.Add(Me.b_lblNombreUsuario_Dinamico)
        Me.pnlUsuario_logueado.Controls.Add(Me.b_lblusuarioLogueado_nombre)
        Me.pnlUsuario_logueado.Location = New System.Drawing.Point(12, 12)
        Me.pnlUsuario_logueado.Name = "pnlUsuario_logueado"
        Me.pnlUsuario_logueado.Size = New System.Drawing.Size(1345, 35)
        Me.pnlUsuario_logueado.TabIndex = 6
        '
        'b_lblRol_Dinamico
        '
        Me.b_lblRol_Dinamico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_lblRol_Dinamico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_lblRol_Dinamico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.b_lblRol_Dinamico.Location = New System.Drawing.Point(1172, 4)
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
        Me.tabPrincipal.Controls.Add(Me.tabHistorial)
        Me.tabPrincipal.Controls.Add(Me.tabCarambula)
        Me.tabPrincipal.Location = New System.Drawing.Point(229, 45)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedIndex = 0
        Me.tabPrincipal.Size = New System.Drawing.Size(1128, 655)
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
        Me.tabPrincipalAlumnos.Size = New System.Drawing.Size(1120, 629)
        Me.tabPrincipalAlumnos.TabIndex = 0
        Me.tabPrincipalAlumnos.Text = "Alumnos"
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
        Me.dgvP_Alumnos.Size = New System.Drawing.Size(1117, 508)
        Me.dgvP_Alumnos.TabIndex = 27
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lst_Agregar_grupo)
        Me.Panel7.Controls.Add(Me.Button6)
        Me.Panel7.Controls.Add(Me.btnDesvincular)
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
        Me.Panel7.Size = New System.Drawing.Size(1114, 109)
        Me.Panel7.TabIndex = 27
        '
        'lst_Agregar_grupo
        '
        Me.lst_Agregar_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_Agregar_grupo.FormattingEnabled = True
        Me.lst_Agregar_grupo.Location = New System.Drawing.Point(739, 39)
        Me.lst_Agregar_grupo.Name = "lst_Agregar_grupo"
        Me.lst_Agregar_grupo.Size = New System.Drawing.Size(371, 21)
        Me.lst_Agregar_grupo.TabIndex = 36
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.calificaciones
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button6.Location = New System.Drawing.Point(236, 53)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 50)
        Me.Button6.TabIndex = 35
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnDesvincular
        '
        Me.btnDesvincular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDesvincular.BackColor = System.Drawing.Color.White
        Me.btnDesvincular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDesvincular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesvincular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDesvincular.Location = New System.Drawing.Point(916, 4)
        Me.btnDesvincular.Name = "btnDesvincular"
        Me.btnDesvincular.Size = New System.Drawing.Size(194, 28)
        Me.btnDesvincular.TabIndex = 34
        Me.btnDesvincular.Text = "Desvincular del grupo"
        Me.btnDesvincular.UseVisualStyleBackColor = False
        '
        'btn_agregar_a_un_grupo
        '
        Me.btn_agregar_a_un_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_a_un_grupo.BackColor = System.Drawing.Color.White
        Me.btn_agregar_a_un_grupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar_a_un_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_a_un_grupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_agregar_a_un_grupo.Location = New System.Drawing.Point(739, 4)
        Me.btn_agregar_a_un_grupo.Name = "btn_agregar_a_un_grupo"
        Me.btn_agregar_a_un_grupo.Size = New System.Drawing.Size(171, 28)
        Me.btn_agregar_a_un_grupo.TabIndex = 27
        Me.btn_agregar_a_un_grupo.Text = "Vincular a un grupo"
        Me.btn_agregar_a_un_grupo.UseVisualStyleBackColor = False
        '
        'btn_alumnos_Refrescar
        '
        Me.btn_alumnos_Refrescar.BackColor = System.Drawing.Color.White
        Me.btn_alumnos_Refrescar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_alumnos_Refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_alumnos_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_alumnos_Refrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alumnos_Refrescar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_alumnos_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_alumnos_Refrescar.Location = New System.Drawing.Point(173, 53)
        Me.btn_alumnos_Refrescar.Name = "btn_alumnos_Refrescar"
        Me.btn_alumnos_Refrescar.Size = New System.Drawing.Size(57, 50)
        Me.btn_alumnos_Refrescar.TabIndex = 32
        Me.btn_alumnos_Refrescar.UseVisualStyleBackColor = False
        '
        'btnAlumnosModificar
        '
        Me.btnAlumnosModificar.BackColor = System.Drawing.Color.White
        Me.btnAlumnosModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.application_icon
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
        Me.btnAlumnosEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_female
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
        Me.btnAlumnosCrearNuevo.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_woman_man
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
        Me.btnAlumnosImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.printer1
        Me.btnAlumnosImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlumnosImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlumnosImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnosImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlumnosImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlumnosImprimir.Location = New System.Drawing.Point(292, 53)
        Me.btnAlumnosImprimir.Name = "btnAlumnosImprimir"
        Me.btnAlumnosImprimir.Size = New System.Drawing.Size(51, 50)
        Me.btnAlumnosImprimir.TabIndex = 28
        Me.btnAlumnosImprimir.UseVisualStyleBackColor = False
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
        'tabpage_Grupos
        '
        Me.tabpage_Grupos.BackColor = System.Drawing.Color.Silver
        Me.tabpage_Grupos.Controls.Add(Me.lstGrupos_vinc_Orientaciones)
        Me.tabpage_Grupos.Controls.Add(Me.btnVincular_a_Orientacion)
        Me.tabpage_Grupos.Controls.Add(Me.Button4)
        Me.tabpage_Grupos.Controls.Add(Me.btn_Grupos_refrescar)
        Me.tabpage_Grupos.Controls.Add(Me.Button3)
        Me.tabpage_Grupos.Controls.Add(Me.btn_Grupos_Modificar)
        Me.tabpage_Grupos.Controls.Add(Me.btnGrupos_Eliminar)
        Me.tabpage_Grupos.Controls.Add(Me.btnGrupos_Agregar)
        Me.tabpage_Grupos.Controls.Add(Me.dgvP_Grupos)
        Me.tabpage_Grupos.Controls.Add(Me.lbl_Grupos_Titulo)
        Me.tabpage_Grupos.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_Grupos.Name = "tabpage_Grupos"
        Me.tabpage_Grupos.Size = New System.Drawing.Size(1120, 629)
        Me.tabpage_Grupos.TabIndex = 6
        Me.tabpage_Grupos.Text = "Grupos"
        '
        'lstGrupos_vinc_Orientaciones
        '
        Me.lstGrupos_vinc_Orientaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstGrupos_vinc_Orientaciones.FormattingEnabled = True
        Me.lstGrupos_vinc_Orientaciones.Location = New System.Drawing.Point(763, 7)
        Me.lstGrupos_vinc_Orientaciones.Name = "lstGrupos_vinc_Orientaciones"
        Me.lstGrupos_vinc_Orientaciones.Size = New System.Drawing.Size(350, 21)
        Me.lstGrupos_vinc_Orientaciones.TabIndex = 48
        '
        'btnVincular_a_Orientacion
        '
        Me.btnVincular_a_Orientacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVincular_a_Orientacion.BackColor = System.Drawing.Color.White
        Me.btnVincular_a_Orientacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVincular_a_Orientacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVincular_a_Orientacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVincular_a_Orientacion.Location = New System.Drawing.Point(576, 4)
        Me.btnVincular_a_Orientacion.Name = "btnVincular_a_Orientacion"
        Me.btnVincular_a_Orientacion.Size = New System.Drawing.Size(181, 24)
        Me.btnVincular_a_Orientacion.TabIndex = 44
        Me.btnVincular_a_Orientacion.Text = "Vincular a una orientacion"
        Me.btnVincular_a_Orientacion.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.group_members
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(240, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 50)
        Me.Button4.TabIndex = 47
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btn_Grupos_refrescar
        '
        Me.btn_Grupos_refrescar.BackColor = System.Drawing.Color.White
        Me.btn_Grupos_refrescar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_Grupos_refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Grupos_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Grupos_refrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Grupos_refrescar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Grupos_refrescar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Grupos_refrescar.Location = New System.Drawing.Point(181, 48)
        Me.btn_Grupos_refrescar.Name = "btn_Grupos_refrescar"
        Me.btn_Grupos_refrescar.Size = New System.Drawing.Size(53, 50)
        Me.btn_Grupos_refrescar.TabIndex = 46
        Me.btn_Grupos_refrescar.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.printer1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(296, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 50)
        Me.Button3.TabIndex = 39
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btn_Grupos_Modificar
        '
        Me.btn_Grupos_Modificar.BackColor = System.Drawing.Color.White
        Me.btn_Grupos_Modificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.application_icon
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
        Me.btnGrupos_Eliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_group_512
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
        Me.btnGrupos_Agregar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_user_group_woman_man
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
        'dgvP_Grupos
        '
        Me.dgvP_Grupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Grupos.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Grupos.Location = New System.Drawing.Point(14, 110)
        Me.dgvP_Grupos.Name = "dgvP_Grupos"
        Me.dgvP_Grupos.Size = New System.Drawing.Size(1101, 516)
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
        'tabPrincipalMaterias
        '
        Me.tabPrincipalMaterias.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalMaterias.Controls.Add(Me.btn_Asignaturas_refrescar)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasModificar)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasEliminar)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasCrear)
        Me.tabPrincipalMaterias.Controls.Add(Me.btnMateriasImprimir)
        Me.tabPrincipalMaterias.Controls.Add(Me.dgvP_Asignaturas)
        Me.tabPrincipalMaterias.Controls.Add(Me.lblMaterias)
        Me.tabPrincipalMaterias.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalMaterias.Name = "tabPrincipalMaterias"
        Me.tabPrincipalMaterias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalMaterias.Size = New System.Drawing.Size(1120, 629)
        Me.tabPrincipalMaterias.TabIndex = 1
        Me.tabPrincipalMaterias.Text = "Asignaturas"
        '
        'btn_Asignaturas_refrescar
        '
        Me.btn_Asignaturas_refrescar.BackColor = System.Drawing.Color.White
        Me.btn_Asignaturas_refrescar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_Asignaturas_refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Asignaturas_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Asignaturas_refrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Asignaturas_refrescar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Asignaturas_refrescar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Asignaturas_refrescar.Location = New System.Drawing.Point(177, 48)
        Me.btn_Asignaturas_refrescar.Name = "btn_Asignaturas_refrescar"
        Me.btn_Asignaturas_refrescar.Size = New System.Drawing.Size(53, 50)
        Me.btn_Asignaturas_refrescar.TabIndex = 33
        Me.btn_Asignaturas_refrescar.UseVisualStyleBackColor = False
        '
        'btnMateriasModificar
        '
        Me.btnMateriasModificar.BackColor = System.Drawing.Color.White
        Me.btnMateriasModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.application_icon
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
        Me.btnMateriasEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.delete_books
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
        Me.btnMateriasCrear.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_book
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
        Me.btnMateriasImprimir.BackColor = System.Drawing.Color.White
        Me.btnMateriasImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.printer1
        Me.btnMateriasImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMateriasImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriasImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriasImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMateriasImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMateriasImprimir.Location = New System.Drawing.Point(236, 48)
        Me.btnMateriasImprimir.Name = "btnMateriasImprimir"
        Me.btnMateriasImprimir.Size = New System.Drawing.Size(51, 50)
        Me.btnMateriasImprimir.TabIndex = 27
        Me.btnMateriasImprimir.UseVisualStyleBackColor = False
        '
        'dgvP_Asignaturas
        '
        Me.dgvP_Asignaturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Asignaturas.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Asignaturas.Location = New System.Drawing.Point(9, 103)
        Me.dgvP_Asignaturas.Name = "dgvP_Asignaturas"
        Me.dgvP_Asignaturas.Size = New System.Drawing.Size(1104, 520)
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
        'tabPrincipalTareas
        '
        Me.tabPrincipalTareas.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalTareas.Controls.Add(Me.btn_refrescar_Calificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.pnlCalificaciones_Comboboxes)
        Me.tabPrincipalTareas.Controls.Add(Me.btnModificarCalificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.btnEliminarCalificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.btnCrearCalificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.btnEvaluacionesImprimir)
        Me.tabPrincipalTareas.Controls.Add(Me.dgvP_Calificaciones)
        Me.tabPrincipalTareas.Controls.Add(Me.lblTareas)
        Me.tabPrincipalTareas.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalTareas.Name = "tabPrincipalTareas"
        Me.tabPrincipalTareas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalTareas.Size = New System.Drawing.Size(1120, 629)
        Me.tabPrincipalTareas.TabIndex = 2
        Me.tabPrincipalTareas.Text = "Calificaciones"
        '
        'btn_refrescar_Calificaciones
        '
        Me.btn_refrescar_Calificaciones.BackColor = System.Drawing.Color.White
        Me.btn_refrescar_Calificaciones.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_refrescar_Calificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_refrescar_Calificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_refrescar_Calificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refrescar_Calificaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_refrescar_Calificaciones.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_refrescar_Calificaciones.Location = New System.Drawing.Point(177, 47)
        Me.btn_refrescar_Calificaciones.Name = "btn_refrescar_Calificaciones"
        Me.btn_refrescar_Calificaciones.Size = New System.Drawing.Size(53, 50)
        Me.btn_refrescar_Calificaciones.TabIndex = 42
        Me.btn_refrescar_Calificaciones.UseVisualStyleBackColor = False
        '
        'pnlCalificaciones_Comboboxes
        '
        Me.pnlCalificaciones_Comboboxes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCalificaciones_Comboboxes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.Button2)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.cboAsignatura)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.cboGrupo)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.cboInstituto)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.Label16)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.Label15)
        Me.pnlCalificaciones_Comboboxes.Controls.Add(Me.cbxInstituto)
        Me.pnlCalificaciones_Comboboxes.Location = New System.Drawing.Point(481, 6)
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
        Me.Button2.Location = New System.Drawing.Point(592, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 26
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cboAsignatura
        '
        Me.cboAsignatura.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboAsignatura.FormattingEnabled = True
        Me.cboAsignatura.Location = New System.Drawing.Point(324, 41)
        Me.cboAsignatura.Name = "cboAsignatura"
        Me.cboAsignatura.Size = New System.Drawing.Size(230, 21)
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
        Me.Label16.Location = New System.Drawing.Point(320, 13)
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
        Me.btnModificarCalificaciones.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.application_icon
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
        Me.btnEliminarCalificaciones.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download2
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
        Me.btnCrearCalificaciones.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._748449
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
        Me.btnEvaluacionesImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.printer1
        Me.btnEvaluacionesImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEvaluacionesImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEvaluacionesImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluacionesImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEvaluacionesImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEvaluacionesImprimir.Location = New System.Drawing.Point(236, 47)
        Me.btnEvaluacionesImprimir.Name = "btnEvaluacionesImprimir"
        Me.btnEvaluacionesImprimir.Size = New System.Drawing.Size(46, 51)
        Me.btnEvaluacionesImprimir.TabIndex = 34
        Me.btnEvaluacionesImprimir.UseVisualStyleBackColor = False
        '
        'dgvP_Calificaciones
        '
        Me.dgvP_Calificaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Calificaciones.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Calificaciones.Location = New System.Drawing.Point(9, 104)
        Me.dgvP_Calificaciones.Name = "dgvP_Calificaciones"
        Me.dgvP_Calificaciones.Size = New System.Drawing.Size(1104, 522)
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
        'tabPrincipalDocentes
        '
        Me.tabPrincipalDocentes.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalDocentes.Controls.Add(Me.ver_grupos)
        Me.tabPrincipalDocentes.Controls.Add(Me.listDocenteAsignarGrupo)
        Me.tabPrincipalDocentes.Controls.Add(Me.listAsignaturasDocente)
        Me.tabPrincipalDocentes.Controls.Add(Me.btn_ver_grupos_asignados_docente)
        Me.tabPrincipalDocentes.Controls.Add(Me.Button5)
        Me.tabPrincipalDocentes.Controls.Add(Me.btn_Docentes_refrescar)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesModificar)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesEliminar)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesCrearNuevo)
        Me.tabPrincipalDocentes.Controls.Add(Me.btnDocentesImprimir)
        Me.tabPrincipalDocentes.Controls.Add(Me.BorderLabel5)
        Me.tabPrincipalDocentes.Controls.Add(Me.BorderLabel4)
        Me.tabPrincipalDocentes.Controls.Add(Me.dgvP_Docentes)
        Me.tabPrincipalDocentes.Controls.Add(Me.lblDocentes)
        Me.tabPrincipalDocentes.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalDocentes.Name = "tabPrincipalDocentes"
        Me.tabPrincipalDocentes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalDocentes.Size = New System.Drawing.Size(1120, 629)
        Me.tabPrincipalDocentes.TabIndex = 3
        Me.tabPrincipalDocentes.Text = "Docentes"
        '
        'ver_grupos
        '
        Me.ver_grupos.BackColor = System.Drawing.Color.White
        Me.ver_grupos.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.group_members
        Me.ver_grupos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ver_grupos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ver_grupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ver_grupos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ver_grupos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ver_grupos.Location = New System.Drawing.Point(177, 69)
        Me.ver_grupos.Name = "ver_grupos"
        Me.ver_grupos.Size = New System.Drawing.Size(53, 52)
        Me.ver_grupos.TabIndex = 46
        Me.ver_grupos.UseVisualStyleBackColor = False
        '
        'listDocenteAsignarGrupo
        '
        Me.listDocenteAsignarGrupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listDocenteAsignarGrupo.FormattingEnabled = True
        Me.listDocenteAsignarGrupo.Location = New System.Drawing.Point(551, 101)
        Me.listDocenteAsignarGrupo.Name = "listDocenteAsignarGrupo"
        Me.listDocenteAsignarGrupo.Size = New System.Drawing.Size(560, 21)
        Me.listDocenteAsignarGrupo.TabIndex = 45
        '
        'listAsignaturasDocente
        '
        Me.listAsignaturasDocente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listAsignaturasDocente.FormattingEnabled = True
        Me.listAsignaturasDocente.Location = New System.Drawing.Point(550, 27)
        Me.listAsignaturasDocente.Name = "listAsignaturasDocente"
        Me.listAsignaturasDocente.Size = New System.Drawing.Size(561, 21)
        Me.listAsignaturasDocente.TabIndex = 44
        '
        'btn_ver_grupos_asignados_docente
        '
        Me.btn_ver_grupos_asignados_docente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ver_grupos_asignados_docente.BackColor = System.Drawing.Color.White
        Me.btn_ver_grupos_asignados_docente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ver_grupos_asignados_docente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ver_grupos_asignados_docente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_ver_grupos_asignados_docente.Location = New System.Drawing.Point(353, 87)
        Me.btn_ver_grupos_asignados_docente.Name = "btn_ver_grupos_asignados_docente"
        Me.btn_ver_grupos_asignados_docente.Size = New System.Drawing.Size(191, 36)
        Me.btn_ver_grupos_asignados_docente.TabIndex = 42
        Me.btn_ver_grupos_asignados_docente.Text = "Ver Grupos asignados a docente"
        Me.btn_ver_grupos_asignados_docente.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(353, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(187, 36)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Vincular a Docente con asignatura"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btn_Docentes_refrescar
        '
        Me.btn_Docentes_refrescar.BackColor = System.Drawing.Color.White
        Me.btn_Docentes_refrescar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_Docentes_refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Docentes_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Docentes_refrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Docentes_refrescar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Docentes_refrescar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Docentes_refrescar.Location = New System.Drawing.Point(236, 69)
        Me.btn_Docentes_refrescar.Name = "btn_Docentes_refrescar"
        Me.btn_Docentes_refrescar.Size = New System.Drawing.Size(53, 54)
        Me.btn_Docentes_refrescar.TabIndex = 43
        Me.btn_Docentes_refrescar.UseVisualStyleBackColor = False
        '
        'btnDocentesModificar
        '
        Me.btnDocentesModificar.BackColor = System.Drawing.Color.White
        Me.btnDocentesModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.application_icon
        Me.btnDocentesModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesModificar.Location = New System.Drawing.Point(121, 71)
        Me.btnDocentesModificar.Name = "btnDocentesModificar"
        Me.btnDocentesModificar.Size = New System.Drawing.Size(50, 50)
        Me.btnDocentesModificar.TabIndex = 32
        Me.btnDocentesModificar.UseVisualStyleBackColor = False
        '
        'btnDocentesEliminar
        '
        Me.btnDocentesEliminar.BackColor = System.Drawing.Color.White
        Me.btnDocentesEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove_user_group_512
        Me.btnDocentesEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesEliminar.Location = New System.Drawing.Point(65, 71)
        Me.btnDocentesEliminar.Name = "btnDocentesEliminar"
        Me.btnDocentesEliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnDocentesEliminar.TabIndex = 31
        Me.btnDocentesEliminar.UseVisualStyleBackColor = False
        '
        'btnDocentesCrearNuevo
        '
        Me.btnDocentesCrearNuevo.BackColor = System.Drawing.Color.White
        Me.btnDocentesCrearNuevo.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.create_user_man_male_512
        Me.btnDocentesCrearNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesCrearNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesCrearNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesCrearNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesCrearNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesCrearNuevo.Location = New System.Drawing.Point(9, 71)
        Me.btnDocentesCrearNuevo.Name = "btnDocentesCrearNuevo"
        Me.btnDocentesCrearNuevo.Size = New System.Drawing.Size(50, 50)
        Me.btnDocentesCrearNuevo.TabIndex = 30
        Me.btnDocentesCrearNuevo.UseVisualStyleBackColor = False
        '
        'btnDocentesImprimir
        '
        Me.btnDocentesImprimir.BackColor = System.Drawing.Color.White
        Me.btnDocentesImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.printer1
        Me.btnDocentesImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocentesImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocentesImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentesImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDocentesImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDocentesImprimir.Location = New System.Drawing.Point(298, 72)
        Me.btnDocentesImprimir.Name = "btnDocentesImprimir"
        Me.btnDocentesImprimir.Size = New System.Drawing.Size(49, 50)
        Me.btnDocentesImprimir.TabIndex = 28
        Me.btnDocentesImprimir.UseVisualStyleBackColor = False
        '
        'BorderLabel5
        '
        Me.BorderLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BorderLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorderLabel5.Location = New System.Drawing.Point(548, 72)
        Me.BorderLabel5.Name = "BorderLabel5"
        Me.BorderLabel5.Size = New System.Drawing.Size(136, 21)
        Me.BorderLabel5.TabIndex = 41
        Me.BorderLabel5.Text = "Grupo"
        '
        'BorderLabel4
        '
        Me.BorderLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BorderLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorderLabel4.Location = New System.Drawing.Point(546, 3)
        Me.BorderLabel4.Name = "BorderLabel4"
        Me.BorderLabel4.Size = New System.Drawing.Size(136, 21)
        Me.BorderLabel4.TabIndex = 40
        Me.BorderLabel4.Text = "Asignatura"
        '
        'dgvP_Docentes
        '
        Me.dgvP_Docentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Docentes.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Docentes.Location = New System.Drawing.Point(7, 127)
        Me.dgvP_Docentes.Name = "dgvP_Docentes"
        Me.dgvP_Docentes.Size = New System.Drawing.Size(1104, 494)
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
        'tabPrincipalUsuarios
        '
        Me.tabPrincipalUsuarios.BackColor = System.Drawing.Color.Silver
        Me.tabPrincipalUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tabPrincipalUsuarios.Controls.Add(Me.btn_usuarios_refrescar)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosImprimir)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosModificar)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosBotonEliminarUsuario)
        Me.tabPrincipalUsuarios.Controls.Add(Me.btnUsuariosBotonCrearNuevo)
        Me.tabPrincipalUsuarios.Controls.Add(Me.dgvP_Usuarios)
        Me.tabPrincipalUsuarios.Controls.Add(Me.lblUsuarios)
        Me.tabPrincipalUsuarios.Location = New System.Drawing.Point(4, 22)
        Me.tabPrincipalUsuarios.Name = "tabPrincipalUsuarios"
        Me.tabPrincipalUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrincipalUsuarios.Size = New System.Drawing.Size(1120, 629)
        Me.tabPrincipalUsuarios.TabIndex = 4
        Me.tabPrincipalUsuarios.Text = "Usuarios"
        '
        'btn_usuarios_refrescar
        '
        Me.btn_usuarios_refrescar.BackColor = System.Drawing.Color.White
        Me.btn_usuarios_refrescar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_usuarios_refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_usuarios_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_usuarios_refrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_usuarios_refrescar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_usuarios_refrescar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_usuarios_refrescar.Location = New System.Drawing.Point(177, 48)
        Me.btn_usuarios_refrescar.Name = "btn_usuarios_refrescar"
        Me.btn_usuarios_refrescar.Size = New System.Drawing.Size(53, 50)
        Me.btn_usuarios_refrescar.TabIndex = 35
        Me.btn_usuarios_refrescar.UseVisualStyleBackColor = False
        '
        'btnUsuariosImprimir
        '
        Me.btnUsuariosImprimir.BackColor = System.Drawing.Color.White
        Me.btnUsuariosImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.printer1
        Me.btnUsuariosImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsuariosImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsuariosImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsuariosImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnUsuariosImprimir.Location = New System.Drawing.Point(236, 48)
        Me.btnUsuariosImprimir.Name = "btnUsuariosImprimir"
        Me.btnUsuariosImprimir.Size = New System.Drawing.Size(49, 50)
        Me.btnUsuariosImprimir.TabIndex = 20
        Me.btnUsuariosImprimir.UseVisualStyleBackColor = False
        '
        'btnUsuariosModificar
        '
        Me.btnUsuariosModificar.BackColor = System.Drawing.Color.White
        Me.btnUsuariosModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.application_icon
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
        Me.btnUsuariosBotonEliminarUsuario.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.images
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
        Me.btnUsuariosBotonCrearNuevo.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.create_user_group_512
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
        'dgvP_Usuarios
        '
        Me.dgvP_Usuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Usuarios.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Usuarios.Location = New System.Drawing.Point(10, 108)
        Me.dgvP_Usuarios.Name = "dgvP_Usuarios"
        Me.dgvP_Usuarios.Size = New System.Drawing.Size(1103, 515)
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
        'tabpageInstitutos
        '
        Me.tabpageInstitutos.BackColor = System.Drawing.Color.Silver
        Me.tabpageInstitutos.Controls.Add(Me.btn_Institutos_refrescar)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoImprimir)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoModificar)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoEliminar)
        Me.tabpageInstitutos.Controls.Add(Me.btnInstitutoCrear)
        Me.tabpageInstitutos.Controls.Add(Me.dgvP_Institutos)
        Me.tabpageInstitutos.Controls.Add(Me.BorderLabel1)
        Me.tabpageInstitutos.Location = New System.Drawing.Point(4, 22)
        Me.tabpageInstitutos.Name = "tabpageInstitutos"
        Me.tabpageInstitutos.Size = New System.Drawing.Size(1120, 629)
        Me.tabpageInstitutos.TabIndex = 5
        Me.tabpageInstitutos.Text = "Institutos"
        '
        'btn_Institutos_refrescar
        '
        Me.btn_Institutos_refrescar.BackColor = System.Drawing.Color.White
        Me.btn_Institutos_refrescar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_Institutos_refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Institutos_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Institutos_refrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Institutos_refrescar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Institutos_refrescar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Institutos_refrescar.Location = New System.Drawing.Point(177, 47)
        Me.btn_Institutos_refrescar.Name = "btn_Institutos_refrescar"
        Me.btn_Institutos_refrescar.Size = New System.Drawing.Size(53, 50)
        Me.btn_Institutos_refrescar.TabIndex = 36
        Me.btn_Institutos_refrescar.UseVisualStyleBackColor = False
        '
        'btnInstitutoImprimir
        '
        Me.btnInstitutoImprimir.BackColor = System.Drawing.Color.White
        Me.btnInstitutoImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.printer1
        Me.btnInstitutoImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInstitutoImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInstitutoImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstitutoImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInstitutoImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnInstitutoImprimir.Location = New System.Drawing.Point(236, 48)
        Me.btnInstitutoImprimir.Name = "btnInstitutoImprimir"
        Me.btnInstitutoImprimir.Size = New System.Drawing.Size(54, 50)
        Me.btnInstitutoImprimir.TabIndex = 33
        Me.btnInstitutoImprimir.UseVisualStyleBackColor = False
        '
        'btnInstitutoModificar
        '
        Me.btnInstitutoModificar.BackColor = System.Drawing.Color.White
        Me.btnInstitutoModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.application_icon
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
        Me.btnInstitutoEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.delete_school
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
        Me.btnInstitutoCrear.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_school
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
        'dgvP_Institutos
        '
        Me.dgvP_Institutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Institutos.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Institutos.Location = New System.Drawing.Point(9, 103)
        Me.dgvP_Institutos.Name = "dgvP_Institutos"
        Me.dgvP_Institutos.Size = New System.Drawing.Size(1104, 523)
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
        'tabOrientaciones
        '
        Me.tabOrientaciones.BackColor = System.Drawing.Color.Silver
        Me.tabOrientaciones.Controls.Add(Me.btn_orientacion_refrescar)
        Me.tabOrientaciones.Controls.Add(Me.btnOrientacionesModificar)
        Me.tabOrientaciones.Controls.Add(Me.btnOrientacionesEliminar)
        Me.tabOrientaciones.Controls.Add(Me.btnOrientacionesCrear)
        Me.tabOrientaciones.Controls.Add(Me.btnImprimirOrientaciones)
        Me.tabOrientaciones.Controls.Add(Me.BorderLabel2)
        Me.tabOrientaciones.Controls.Add(Me.dgvP_Orientaciones)
        Me.tabOrientaciones.Location = New System.Drawing.Point(4, 22)
        Me.tabOrientaciones.Name = "tabOrientaciones"
        Me.tabOrientaciones.Size = New System.Drawing.Size(1120, 629)
        Me.tabOrientaciones.TabIndex = 7
        Me.tabOrientaciones.Text = "Orientaciones"
        '
        'btn_orientacion_refrescar
        '
        Me.btn_orientacion_refrescar.BackColor = System.Drawing.Color.White
        Me.btn_orientacion_refrescar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_orientacion_refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_orientacion_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_orientacion_refrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orientacion_refrescar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_orientacion_refrescar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_orientacion_refrescar.Location = New System.Drawing.Point(177, 49)
        Me.btn_orientacion_refrescar.Name = "btn_orientacion_refrescar"
        Me.btn_orientacion_refrescar.Size = New System.Drawing.Size(53, 50)
        Me.btn_orientacion_refrescar.TabIndex = 39
        Me.btn_orientacion_refrescar.UseVisualStyleBackColor = False
        '
        'btnOrientacionesModificar
        '
        Me.btnOrientacionesModificar.BackColor = System.Drawing.Color.White
        Me.btnOrientacionesModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.application_icon
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
        Me.btnOrientacionesEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.borrar_orientacion
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
        Me.btnOrientacionesCrear.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.agregar_orientacion
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
        Me.btnImprimirOrientaciones.BackColor = System.Drawing.Color.White
        Me.btnImprimirOrientaciones.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.printer1
        Me.btnImprimirOrientaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimirOrientaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimirOrientaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirOrientaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImprimirOrientaciones.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnImprimirOrientaciones.Location = New System.Drawing.Point(236, 47)
        Me.btnImprimirOrientaciones.Name = "btnImprimirOrientaciones"
        Me.btnImprimirOrientaciones.Size = New System.Drawing.Size(50, 51)
        Me.btnImprimirOrientaciones.TabIndex = 35
        Me.btnImprimirOrientaciones.UseVisualStyleBackColor = False
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
        Me.dgvP_Orientaciones.Size = New System.Drawing.Size(1104, 522)
        Me.dgvP_Orientaciones.TabIndex = 34
        '
        'tabCiudades
        '
        Me.tabCiudades.BackColor = System.Drawing.Color.Silver
        Me.tabCiudades.Controls.Add(Me.btnCiudades_Refrescar)
        Me.tabCiudades.Controls.Add(Me.btnCiudadesModificar)
        Me.tabCiudades.Controls.Add(Me.btnCiudadesEliminar)
        Me.tabCiudades.Controls.Add(Me.btnCiudadesCrear)
        Me.tabCiudades.Controls.Add(Me.btnCiudadesImprimir)
        Me.tabCiudades.Controls.Add(Me.lblCiudades)
        Me.tabCiudades.Controls.Add(Me.dgvP_Ciudades)
        Me.tabCiudades.Location = New System.Drawing.Point(4, 22)
        Me.tabCiudades.Name = "tabCiudades"
        Me.tabCiudades.Size = New System.Drawing.Size(1120, 629)
        Me.tabCiudades.TabIndex = 8
        Me.tabCiudades.Text = "Ciudades"
        '
        'btnCiudades_Refrescar
        '
        Me.btnCiudades_Refrescar.BackColor = System.Drawing.Color.White
        Me.btnCiudades_Refrescar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btnCiudades_Refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCiudades_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCiudades_Refrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudades_Refrescar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCiudades_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCiudades_Refrescar.Location = New System.Drawing.Point(175, 50)
        Me.btnCiudades_Refrescar.Name = "btnCiudades_Refrescar"
        Me.btnCiudades_Refrescar.Size = New System.Drawing.Size(53, 50)
        Me.btnCiudades_Refrescar.TabIndex = 39
        Me.btnCiudades_Refrescar.UseVisualStyleBackColor = False
        '
        'btnCiudadesModificar
        '
        Me.btnCiudadesModificar.BackColor = System.Drawing.Color.White
        Me.btnCiudadesModificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.application_icon
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
        Me.btnCiudadesEliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.close_red
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
        Me.btnCiudadesCrear.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.add_1_icon
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
        Me.btnCiudadesImprimir.BackColor = System.Drawing.Color.White
        Me.btnCiudadesImprimir.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.printer1
        Me.btnCiudadesImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCiudadesImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCiudadesImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudadesImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCiudadesImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCiudadesImprimir.Location = New System.Drawing.Point(234, 50)
        Me.btnCiudadesImprimir.Name = "btnCiudadesImprimir"
        Me.btnCiudadesImprimir.Size = New System.Drawing.Size(52, 50)
        Me.btnCiudadesImprimir.TabIndex = 35
        Me.btnCiudadesImprimir.UseVisualStyleBackColor = False
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
        Me.dgvP_Ciudades.Size = New System.Drawing.Size(1106, 520)
        Me.dgvP_Ciudades.TabIndex = 34
        '
        'tabAdmins
        '
        Me.tabAdmins.BackColor = System.Drawing.Color.Silver
        Me.tabAdmins.Controls.Add(Me.dgv_Admins_Administrativos)
        Me.tabAdmins.Controls.Add(Me.Panel1)
        Me.tabAdmins.Location = New System.Drawing.Point(4, 22)
        Me.tabAdmins.Name = "tabAdmins"
        Me.tabAdmins.Size = New System.Drawing.Size(1120, 629)
        Me.tabAdmins.TabIndex = 9
        Me.tabAdmins.Text = "Admins/Administrativos"
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
        Me.dgv_Admins_Administrativos.Size = New System.Drawing.Size(1117, 507)
        Me.dgv_Admins_Administrativos.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_admins_Refrescar)
        Me.Panel1.Controls.Add(Me.btnAdmins_Modificar)
        Me.Panel1.Controls.Add(Me.btnAdmins_Eliminar)
        Me.Panel1.Controls.Add(Me.btnAdmins_Crear)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.BorderLabel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1120, 109)
        Me.Panel1.TabIndex = 29
        '
        'btn_admins_Refrescar
        '
        Me.btn_admins_Refrescar.BackColor = System.Drawing.Color.White
        Me.btn_admins_Refrescar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_admins_Refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_admins_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_admins_Refrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_admins_Refrescar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_admins_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_admins_Refrescar.Location = New System.Drawing.Point(173, 53)
        Me.btn_admins_Refrescar.Name = "btn_admins_Refrescar"
        Me.btn_admins_Refrescar.Size = New System.Drawing.Size(53, 50)
        Me.btn_admins_Refrescar.TabIndex = 32
        Me.btn_admins_Refrescar.UseVisualStyleBackColor = False
        '
        'btnAdmins_Modificar
        '
        Me.btnAdmins_Modificar.BackColor = System.Drawing.Color.White
        Me.btnAdmins_Modificar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.application_icon
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
        Me.btnAdmins_Eliminar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.images
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
        Me.btnAdmins_Crear.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.create_user_group_512
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
        Me.Button8.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.printer1
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button8.Location = New System.Drawing.Point(232, 53)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(54, 50)
        Me.Button8.TabIndex = 28
        Me.Button8.UseVisualStyleBackColor = False
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
        'tabHistorial
        '
        Me.tabHistorial.BackColor = System.Drawing.Color.Silver
        Me.tabHistorial.Controls.Add(Me.dgvP_Historial)
        Me.tabHistorial.Controls.Add(Me.Panel2)
        Me.tabHistorial.Location = New System.Drawing.Point(4, 22)
        Me.tabHistorial.Name = "tabHistorial"
        Me.tabHistorial.Size = New System.Drawing.Size(1120, 629)
        Me.tabHistorial.TabIndex = 10
        Me.tabHistorial.Text = "Historial"
        '
        'dgvP_Historial
        '
        Me.dgvP_Historial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_Historial.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_Historial.Location = New System.Drawing.Point(0, 119)
        Me.dgvP_Historial.Name = "dgvP_Historial"
        Me.dgvP_Historial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvP_Historial.Size = New System.Drawing.Size(1117, 508)
        Me.dgvP_Historial.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button11)
        Me.Panel2.Controls.Add(Me.Button15)
        Me.Panel2.Controls.Add(Me.Historial)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1120, 109)
        Me.Panel2.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.images2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(3, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 50)
        Me.Button1.TabIndex = 33
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button11.Location = New System.Drawing.Point(66, 56)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(57, 50)
        Me.Button11.TabIndex = 32
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.printer1
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button15.Location = New System.Drawing.Point(129, 56)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(51, 50)
        Me.Button15.TabIndex = 28
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Historial
        '
        Me.Historial.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Historial.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Historial.Location = New System.Drawing.Point(2, 10)
        Me.Historial.Name = "Historial"
        Me.Historial.Size = New System.Drawing.Size(136, 36)
        Me.Historial.TabIndex = 26
        Me.Historial.Text = "Historial"
        '
        'tabCarambula
        '
        Me.tabCarambula.Controls.Add(Me.TabControl1)
        Me.tabCarambula.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula.Name = "tabCarambula"
        Me.tabCarambula.Size = New System.Drawing.Size(1120, 629)
        Me.tabCarambula.TabIndex = 11
        Me.tabCarambula.Text = "Consultas Carambula 2018"
        Me.tabCarambula.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCarambula_1)
        Me.TabControl1.Controls.Add(Me.tabCarambula_2)
        Me.TabControl1.Controls.Add(Me.tabCarambula_3)
        Me.TabControl1.Controls.Add(Me.tabCarambula_4)
        Me.TabControl1.Controls.Add(Me.tabCarambula_5)
        Me.TabControl1.Controls.Add(Me.tabCarambula_6)
        Me.TabControl1.Controls.Add(Me.tabCarambula_7)
        Me.TabControl1.Controls.Add(Me.tabCarambula_8)
        Me.TabControl1.Controls.Add(Me.tabCarambula_9)
        Me.TabControl1.Controls.Add(Me.tabCarambula_10)
        Me.TabControl1.Controls.Add(Me.tabCarambula_11)
        Me.TabControl1.Controls.Add(Me.tabCarambula_12)
        Me.TabControl1.Controls.Add(Me.tabCarambula_13)
        Me.TabControl1.Controls.Add(Me.tabCarambula_14)
        Me.TabControl1.Controls.Add(Me.tabCarambula_15)
        Me.TabControl1.Controls.Add(Me.tabCarambula_16)
        Me.TabControl1.Controls.Add(Me.tabCarambula_17)
        Me.TabControl1.Controls.Add(Me.tabCarambula_18)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1120, 629)
        Me.TabControl1.TabIndex = 0
        '
        'tabCarambula_1
        '
        Me.tabCarambula_1.Controls.Add(Me.btn_carambula_1)
        Me.tabCarambula_1.Controls.Add(Me.dgvP_carambula_1)
        Me.tabCarambula_1.Controls.Add(Me.TextBox1)
        Me.tabCarambula_1.Controls.Add(Me.BorderLabel6)
        Me.tabCarambula_1.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_1.Name = "tabCarambula_1"
        Me.tabCarambula_1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCarambula_1.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_1.TabIndex = 0
        Me.tabCarambula_1.Text = "Consulta 1"
        Me.tabCarambula_1.UseVisualStyleBackColor = True
        '
        'btn_carambula_1
        '
        Me.btn_carambula_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_1.BackColor = System.Drawing.Color.White
        Me.btn_carambula_1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_1.Location = New System.Drawing.Point(1047, 9)
        Me.btn_carambula_1.Name = "btn_carambula_1"
        Me.btn_carambula_1.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_1.TabIndex = 47
        Me.btn_carambula_1.UseVisualStyleBackColor = False
        '
        'dgvP_carambula_1
        '
        Me.dgvP_carambula_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvP_carambula_1.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvP_carambula_1.Location = New System.Drawing.Point(22, 169)
        Me.dgvP_carambula_1.Name = "dgvP_carambula_1"
        Me.dgvP_carambula_1.Size = New System.Drawing.Size(1072, 422)
        Me.dgvP_carambula_1.TabIndex = 29
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox1.Location = New System.Drawing.Point(22, 65)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox1.TabIndex = 28
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'BorderLabel6
        '
        Me.BorderLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel6.Location = New System.Drawing.Point(16, 9)
        Me.BorderLabel6.Name = "BorderLabel6"
        Me.BorderLabel6.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel6.TabIndex = 27
        Me.BorderLabel6.Text = "Consulta 1"
        '
        'tabCarambula_2
        '
        Me.tabCarambula_2.Controls.Add(Me.btn_carambula_2)
        Me.tabCarambula_2.Controls.Add(Me.dgvp_carambula_2)
        Me.tabCarambula_2.Controls.Add(Me.TextBox2)
        Me.tabCarambula_2.Controls.Add(Me.BorderLabel7)
        Me.tabCarambula_2.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_2.Name = "tabCarambula_2"
        Me.tabCarambula_2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCarambula_2.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_2.TabIndex = 1
        Me.tabCarambula_2.Text = "Consulta 2"
        Me.tabCarambula_2.UseVisualStyleBackColor = True
        '
        'btn_carambula_2
        '
        Me.btn_carambula_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_2.BackColor = System.Drawing.Color.White
        Me.btn_carambula_2.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_2.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_2.Name = "btn_carambula_2"
        Me.btn_carambula_2.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_2.TabIndex = 51
        Me.btn_carambula_2.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_2
        '
        Me.dgvp_carambula_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_2.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_2.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_2.Name = "dgvp_carambula_2"
        Me.dgvp_carambula_2.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_2.TabIndex = 50
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox2.Location = New System.Drawing.Point(20, 66)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox2.TabIndex = 49
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'BorderLabel7
        '
        Me.BorderLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel7.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel7.Name = "BorderLabel7"
        Me.BorderLabel7.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel7.TabIndex = 48
        Me.BorderLabel7.Text = "Consulta 2"
        '
        'tabCarambula_3
        '
        Me.tabCarambula_3.Controls.Add(Me.btn_carambula_3)
        Me.tabCarambula_3.Controls.Add(Me.dgvp_carambula_3)
        Me.tabCarambula_3.Controls.Add(Me.TextBox3)
        Me.tabCarambula_3.Controls.Add(Me.BorderLabel8)
        Me.tabCarambula_3.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_3.Name = "tabCarambula_3"
        Me.tabCarambula_3.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_3.TabIndex = 2
        Me.tabCarambula_3.Text = "Consulta 3"
        Me.tabCarambula_3.UseVisualStyleBackColor = True
        '
        'btn_carambula_3
        '
        Me.btn_carambula_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_3.BackColor = System.Drawing.Color.White
        Me.btn_carambula_3.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_3.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_3.Name = "btn_carambula_3"
        Me.btn_carambula_3.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_3.TabIndex = 55
        Me.btn_carambula_3.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_3
        '
        Me.dgvp_carambula_3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_3.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_3.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_3.Name = "dgvp_carambula_3"
        Me.dgvp_carambula_3.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_3.TabIndex = 54
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox3.Location = New System.Drawing.Point(20, 66)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox3.TabIndex = 53
        Me.TextBox3.Text = resources.GetString("TextBox3.Text")
        '
        'BorderLabel8
        '
        Me.BorderLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel8.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel8.Name = "BorderLabel8"
        Me.BorderLabel8.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel8.TabIndex = 52
        Me.BorderLabel8.Text = "Consulta 3"
        '
        'tabCarambula_4
        '
        Me.tabCarambula_4.Controls.Add(Me.btn_carambula_4)
        Me.tabCarambula_4.Controls.Add(Me.dgvp_carambula_4)
        Me.tabCarambula_4.Controls.Add(Me.TextBox4)
        Me.tabCarambula_4.Controls.Add(Me.BorderLabel9)
        Me.tabCarambula_4.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_4.Name = "tabCarambula_4"
        Me.tabCarambula_4.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_4.TabIndex = 3
        Me.tabCarambula_4.Text = "Consulta 4"
        Me.tabCarambula_4.UseVisualStyleBackColor = True
        '
        'btn_carambula_4
        '
        Me.btn_carambula_4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_4.BackColor = System.Drawing.Color.White
        Me.btn_carambula_4.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_4.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_4.Name = "btn_carambula_4"
        Me.btn_carambula_4.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_4.TabIndex = 59
        Me.btn_carambula_4.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_4
        '
        Me.dgvp_carambula_4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_4.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_4.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_4.Name = "dgvp_carambula_4"
        Me.dgvp_carambula_4.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_4.TabIndex = 58
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Enabled = False
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox4.Location = New System.Drawing.Point(20, 66)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox4.TabIndex = 57
        Me.TextBox4.Text = resources.GetString("TextBox4.Text")
        '
        'BorderLabel9
        '
        Me.BorderLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel9.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel9.Name = "BorderLabel9"
        Me.BorderLabel9.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel9.TabIndex = 56
        Me.BorderLabel9.Text = "Consulta 4"
        '
        'tabCarambula_5
        '
        Me.tabCarambula_5.Controls.Add(Me.btn_carambula_5)
        Me.tabCarambula_5.Controls.Add(Me.dgvp_carambula_5)
        Me.tabCarambula_5.Controls.Add(Me.TextBox5)
        Me.tabCarambula_5.Controls.Add(Me.BorderLabel10)
        Me.tabCarambula_5.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_5.Name = "tabCarambula_5"
        Me.tabCarambula_5.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_5.TabIndex = 4
        Me.tabCarambula_5.Text = "Consulta 5"
        Me.tabCarambula_5.UseVisualStyleBackColor = True
        '
        'btn_carambula_5
        '
        Me.btn_carambula_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_5.BackColor = System.Drawing.Color.White
        Me.btn_carambula_5.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_5.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_5.Name = "btn_carambula_5"
        Me.btn_carambula_5.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_5.TabIndex = 63
        Me.btn_carambula_5.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_5
        '
        Me.dgvp_carambula_5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_5.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_5.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_5.Name = "dgvp_carambula_5"
        Me.dgvp_carambula_5.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_5.TabIndex = 62
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Enabled = False
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox5.Location = New System.Drawing.Point(20, 66)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox5.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox5.TabIndex = 61
        Me.TextBox5.Text = resources.GetString("TextBox5.Text")
        '
        'BorderLabel10
        '
        Me.BorderLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel10.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel10.Name = "BorderLabel10"
        Me.BorderLabel10.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel10.TabIndex = 60
        Me.BorderLabel10.Text = "Consulta 5"
        '
        'tabCarambula_6
        '
        Me.tabCarambula_6.Controls.Add(Me.btn_carambula_6)
        Me.tabCarambula_6.Controls.Add(Me.dgvp_carambula_6)
        Me.tabCarambula_6.Controls.Add(Me.TextBox6)
        Me.tabCarambula_6.Controls.Add(Me.BorderLabel11)
        Me.tabCarambula_6.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_6.Name = "tabCarambula_6"
        Me.tabCarambula_6.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_6.TabIndex = 5
        Me.tabCarambula_6.Text = "Consulta 6"
        Me.tabCarambula_6.UseVisualStyleBackColor = True
        '
        'btn_carambula_6
        '
        Me.btn_carambula_6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_6.BackColor = System.Drawing.Color.White
        Me.btn_carambula_6.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_6.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_6.Name = "btn_carambula_6"
        Me.btn_carambula_6.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_6.TabIndex = 67
        Me.btn_carambula_6.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_6
        '
        Me.dgvp_carambula_6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_6.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_6.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_6.Name = "dgvp_carambula_6"
        Me.dgvp_carambula_6.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_6.TabIndex = 66
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Enabled = False
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox6.Location = New System.Drawing.Point(20, 66)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox6.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox6.TabIndex = 65
        Me.TextBox6.Text = resources.GetString("TextBox6.Text")
        '
        'BorderLabel11
        '
        Me.BorderLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel11.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel11.Name = "BorderLabel11"
        Me.BorderLabel11.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel11.TabIndex = 64
        Me.BorderLabel11.Text = "Consulta 6"
        '
        'tabCarambula_7
        '
        Me.tabCarambula_7.Controls.Add(Me.btn_carambula_7)
        Me.tabCarambula_7.Controls.Add(Me.dgvp_carambula_7)
        Me.tabCarambula_7.Controls.Add(Me.TextBox7)
        Me.tabCarambula_7.Controls.Add(Me.BorderLabel12)
        Me.tabCarambula_7.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_7.Name = "tabCarambula_7"
        Me.tabCarambula_7.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_7.TabIndex = 6
        Me.tabCarambula_7.Text = "Consulta 7"
        Me.tabCarambula_7.UseVisualStyleBackColor = True
        '
        'btn_carambula_7
        '
        Me.btn_carambula_7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_7.BackColor = System.Drawing.Color.White
        Me.btn_carambula_7.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_7.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_7.Name = "btn_carambula_7"
        Me.btn_carambula_7.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_7.TabIndex = 71
        Me.btn_carambula_7.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_7
        '
        Me.dgvp_carambula_7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_7.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_7.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_7.Name = "dgvp_carambula_7"
        Me.dgvp_carambula_7.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_7.TabIndex = 70
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Enabled = False
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox7.Location = New System.Drawing.Point(20, 66)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox7.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox7.TabIndex = 69
        Me.TextBox7.Text = resources.GetString("TextBox7.Text")
        '
        'BorderLabel12
        '
        Me.BorderLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel12.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel12.Name = "BorderLabel12"
        Me.BorderLabel12.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel12.TabIndex = 68
        Me.BorderLabel12.Text = "Consulta 7"
        '
        'tabCarambula_8
        '
        Me.tabCarambula_8.Controls.Add(Me.btn_carambula_8)
        Me.tabCarambula_8.Controls.Add(Me.dgvp_carambula_8)
        Me.tabCarambula_8.Controls.Add(Me.TextBox8)
        Me.tabCarambula_8.Controls.Add(Me.BorderLabel13)
        Me.tabCarambula_8.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_8.Name = "tabCarambula_8"
        Me.tabCarambula_8.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_8.TabIndex = 7
        Me.tabCarambula_8.Text = "Consulta 8"
        Me.tabCarambula_8.UseVisualStyleBackColor = True
        '
        'btn_carambula_8
        '
        Me.btn_carambula_8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_8.BackColor = System.Drawing.Color.White
        Me.btn_carambula_8.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_8.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_8.Name = "btn_carambula_8"
        Me.btn_carambula_8.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_8.TabIndex = 75
        Me.btn_carambula_8.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_8
        '
        Me.dgvp_carambula_8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_8.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_8.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_8.Name = "dgvp_carambula_8"
        Me.dgvp_carambula_8.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_8.TabIndex = 74
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Enabled = False
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox8.Location = New System.Drawing.Point(20, 66)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox8.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox8.TabIndex = 73
        Me.TextBox8.Text = resources.GetString("TextBox8.Text")
        '
        'BorderLabel13
        '
        Me.BorderLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel13.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel13.Name = "BorderLabel13"
        Me.BorderLabel13.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel13.TabIndex = 72
        Me.BorderLabel13.Text = "Consulta 8"
        '
        'tabCarambula_9
        '
        Me.tabCarambula_9.Controls.Add(Me.btn_carambula_9)
        Me.tabCarambula_9.Controls.Add(Me.dgvp_carambula_9)
        Me.tabCarambula_9.Controls.Add(Me.TextBox9)
        Me.tabCarambula_9.Controls.Add(Me.BorderLabel14)
        Me.tabCarambula_9.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_9.Name = "tabCarambula_9"
        Me.tabCarambula_9.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_9.TabIndex = 8
        Me.tabCarambula_9.Text = "Consulta 9"
        Me.tabCarambula_9.UseVisualStyleBackColor = True
        '
        'btn_carambula_9
        '
        Me.btn_carambula_9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_9.BackColor = System.Drawing.Color.White
        Me.btn_carambula_9.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_9.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_9.Name = "btn_carambula_9"
        Me.btn_carambula_9.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_9.TabIndex = 79
        Me.btn_carambula_9.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_9
        '
        Me.dgvp_carambula_9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_9.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_9.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_9.Name = "dgvp_carambula_9"
        Me.dgvp_carambula_9.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_9.TabIndex = 78
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Enabled = False
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox9.Location = New System.Drawing.Point(20, 66)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox9.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox9.TabIndex = 77
        Me.TextBox9.Text = resources.GetString("TextBox9.Text")
        '
        'BorderLabel14
        '
        Me.BorderLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel14.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel14.Name = "BorderLabel14"
        Me.BorderLabel14.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel14.TabIndex = 76
        Me.BorderLabel14.Text = "Consulta 9"
        '
        'tabCarambula_10
        '
        Me.tabCarambula_10.Controls.Add(Me.btn_carambula_10)
        Me.tabCarambula_10.Controls.Add(Me.dgvp_carambula_10)
        Me.tabCarambula_10.Controls.Add(Me.TextBox10)
        Me.tabCarambula_10.Controls.Add(Me.BorderLabel15)
        Me.tabCarambula_10.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_10.Name = "tabCarambula_10"
        Me.tabCarambula_10.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_10.TabIndex = 9
        Me.tabCarambula_10.Text = "Consulta 10"
        Me.tabCarambula_10.UseVisualStyleBackColor = True
        '
        'btn_carambula_10
        '
        Me.btn_carambula_10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_10.BackColor = System.Drawing.Color.White
        Me.btn_carambula_10.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_10.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_10.Name = "btn_carambula_10"
        Me.btn_carambula_10.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_10.TabIndex = 83
        Me.btn_carambula_10.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_10
        '
        Me.dgvp_carambula_10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_10.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_10.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_10.Name = "dgvp_carambula_10"
        Me.dgvp_carambula_10.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_10.TabIndex = 82
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Enabled = False
        Me.TextBox10.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox10.Location = New System.Drawing.Point(20, 66)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox10.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox10.TabIndex = 81
        Me.TextBox10.Text = resources.GetString("TextBox10.Text")
        '
        'BorderLabel15
        '
        Me.BorderLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel15.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel15.Name = "BorderLabel15"
        Me.BorderLabel15.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel15.TabIndex = 80
        Me.BorderLabel15.Text = "Consulta 10"
        '
        'tabCarambula_11
        '
        Me.tabCarambula_11.Controls.Add(Me.btn_carambula_11)
        Me.tabCarambula_11.Controls.Add(Me.dgvp_carambula_11)
        Me.tabCarambula_11.Controls.Add(Me.TextBox11)
        Me.tabCarambula_11.Controls.Add(Me.BorderLabel16)
        Me.tabCarambula_11.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_11.Name = "tabCarambula_11"
        Me.tabCarambula_11.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_11.TabIndex = 10
        Me.tabCarambula_11.Text = "Consulta 11"
        Me.tabCarambula_11.UseVisualStyleBackColor = True
        '
        'btn_carambula_11
        '
        Me.btn_carambula_11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_11.BackColor = System.Drawing.Color.White
        Me.btn_carambula_11.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_11.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_11.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_11.Name = "btn_carambula_11"
        Me.btn_carambula_11.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_11.TabIndex = 87
        Me.btn_carambula_11.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_11
        '
        Me.dgvp_carambula_11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_11.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_11.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_11.Name = "dgvp_carambula_11"
        Me.dgvp_carambula_11.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_11.TabIndex = 86
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Enabled = False
        Me.TextBox11.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox11.Location = New System.Drawing.Point(20, 66)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox11.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox11.TabIndex = 85
        Me.TextBox11.Text = resources.GetString("TextBox11.Text")
        '
        'BorderLabel16
        '
        Me.BorderLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel16.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel16.Name = "BorderLabel16"
        Me.BorderLabel16.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel16.TabIndex = 84
        Me.BorderLabel16.Text = "Consulta 11"
        '
        'tabCarambula_12
        '
        Me.tabCarambula_12.Controls.Add(Me.btn_carambula_12)
        Me.tabCarambula_12.Controls.Add(Me.dgvp_carambula_12)
        Me.tabCarambula_12.Controls.Add(Me.TextBox12)
        Me.tabCarambula_12.Controls.Add(Me.BorderLabel17)
        Me.tabCarambula_12.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_12.Name = "tabCarambula_12"
        Me.tabCarambula_12.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_12.TabIndex = 11
        Me.tabCarambula_12.Text = "Consulta 12"
        Me.tabCarambula_12.UseVisualStyleBackColor = True
        '
        'btn_carambula_12
        '
        Me.btn_carambula_12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_12.BackColor = System.Drawing.Color.White
        Me.btn_carambula_12.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_12.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_12.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_12.Name = "btn_carambula_12"
        Me.btn_carambula_12.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_12.TabIndex = 91
        Me.btn_carambula_12.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_12
        '
        Me.dgvp_carambula_12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_12.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_12.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_12.Name = "dgvp_carambula_12"
        Me.dgvp_carambula_12.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_12.TabIndex = 90
        '
        'TextBox12
        '
        Me.TextBox12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.Enabled = False
        Me.TextBox12.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox12.Location = New System.Drawing.Point(20, 66)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox12.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox12.TabIndex = 89
        Me.TextBox12.Text = resources.GetString("TextBox12.Text")
        '
        'BorderLabel17
        '
        Me.BorderLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel17.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel17.Name = "BorderLabel17"
        Me.BorderLabel17.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel17.TabIndex = 88
        Me.BorderLabel17.Text = "Consulta 12"
        '
        'tabCarambula_13
        '
        Me.tabCarambula_13.Controls.Add(Me.btn_carambula_13)
        Me.tabCarambula_13.Controls.Add(Me.dgvp_carambula_13)
        Me.tabCarambula_13.Controls.Add(Me.TextBox13)
        Me.tabCarambula_13.Controls.Add(Me.BorderLabel18)
        Me.tabCarambula_13.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_13.Name = "tabCarambula_13"
        Me.tabCarambula_13.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_13.TabIndex = 12
        Me.tabCarambula_13.Text = "Consulta 13"
        Me.tabCarambula_13.UseVisualStyleBackColor = True
        '
        'btn_carambula_13
        '
        Me.btn_carambula_13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_13.BackColor = System.Drawing.Color.White
        Me.btn_carambula_13.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_13.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_13.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_13.Name = "btn_carambula_13"
        Me.btn_carambula_13.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_13.TabIndex = 95
        Me.btn_carambula_13.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_13
        '
        Me.dgvp_carambula_13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_13.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_13.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_13.Name = "dgvp_carambula_13"
        Me.dgvp_carambula_13.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_13.TabIndex = 94
        '
        'TextBox13
        '
        Me.TextBox13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox13.Enabled = False
        Me.TextBox13.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox13.Location = New System.Drawing.Point(20, 66)
        Me.TextBox13.Multiline = True
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox13.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox13.TabIndex = 93
        Me.TextBox13.Text = resources.GetString("TextBox13.Text")
        '
        'BorderLabel18
        '
        Me.BorderLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel18.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel18.Name = "BorderLabel18"
        Me.BorderLabel18.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel18.TabIndex = 92
        Me.BorderLabel18.Text = "Consulta 13"
        '
        'tabCarambula_14
        '
        Me.tabCarambula_14.Controls.Add(Me.btn_carambula_14)
        Me.tabCarambula_14.Controls.Add(Me.dgvp_carambula_14)
        Me.tabCarambula_14.Controls.Add(Me.TextBox14)
        Me.tabCarambula_14.Controls.Add(Me.BorderLabel19)
        Me.tabCarambula_14.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_14.Name = "tabCarambula_14"
        Me.tabCarambula_14.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_14.TabIndex = 13
        Me.tabCarambula_14.Text = "Consulta 14"
        Me.tabCarambula_14.UseVisualStyleBackColor = True
        '
        'btn_carambula_14
        '
        Me.btn_carambula_14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_14.BackColor = System.Drawing.Color.White
        Me.btn_carambula_14.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_14.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_14.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_14.Name = "btn_carambula_14"
        Me.btn_carambula_14.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_14.TabIndex = 99
        Me.btn_carambula_14.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_14
        '
        Me.dgvp_carambula_14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_14.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_14.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_14.Name = "dgvp_carambula_14"
        Me.dgvp_carambula_14.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_14.TabIndex = 98
        '
        'TextBox14
        '
        Me.TextBox14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox14.Enabled = False
        Me.TextBox14.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox14.Location = New System.Drawing.Point(20, 66)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox14.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox14.TabIndex = 97
        Me.TextBox14.Text = resources.GetString("TextBox14.Text")
        '
        'BorderLabel19
        '
        Me.BorderLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel19.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel19.Name = "BorderLabel19"
        Me.BorderLabel19.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel19.TabIndex = 96
        Me.BorderLabel19.Text = "Consulta 14"
        '
        'tabCarambula_15
        '
        Me.tabCarambula_15.Controls.Add(Me.btn_carambula_15)
        Me.tabCarambula_15.Controls.Add(Me.dgvp_carambula_15)
        Me.tabCarambula_15.Controls.Add(Me.TextBox15)
        Me.tabCarambula_15.Controls.Add(Me.BorderLabel20)
        Me.tabCarambula_15.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_15.Name = "tabCarambula_15"
        Me.tabCarambula_15.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_15.TabIndex = 14
        Me.tabCarambula_15.Text = "Consulta 15"
        Me.tabCarambula_15.UseVisualStyleBackColor = True
        '
        'btn_carambula_15
        '
        Me.btn_carambula_15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_15.BackColor = System.Drawing.Color.White
        Me.btn_carambula_15.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_15.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_15.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_15.Name = "btn_carambula_15"
        Me.btn_carambula_15.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_15.TabIndex = 103
        Me.btn_carambula_15.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_15
        '
        Me.dgvp_carambula_15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_15.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_15.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_15.Name = "dgvp_carambula_15"
        Me.dgvp_carambula_15.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_15.TabIndex = 102
        '
        'TextBox15
        '
        Me.TextBox15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox15.Enabled = False
        Me.TextBox15.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox15.Location = New System.Drawing.Point(20, 66)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox15.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox15.TabIndex = 101
        Me.TextBox15.Text = resources.GetString("TextBox15.Text")
        '
        'BorderLabel20
        '
        Me.BorderLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel20.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel20.Name = "BorderLabel20"
        Me.BorderLabel20.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel20.TabIndex = 100
        Me.BorderLabel20.Text = "Consulta 15"
        '
        'tabCarambula_16
        '
        Me.tabCarambula_16.Controls.Add(Me.btn_carambula_16)
        Me.tabCarambula_16.Controls.Add(Me.dgvp_carambula_16)
        Me.tabCarambula_16.Controls.Add(Me.TextBox16)
        Me.tabCarambula_16.Controls.Add(Me.BorderLabel21)
        Me.tabCarambula_16.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_16.Name = "tabCarambula_16"
        Me.tabCarambula_16.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_16.TabIndex = 15
        Me.tabCarambula_16.Text = "Consulta 16"
        Me.tabCarambula_16.UseVisualStyleBackColor = True
        '
        'btn_carambula_16
        '
        Me.btn_carambula_16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_16.BackColor = System.Drawing.Color.White
        Me.btn_carambula_16.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_16.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_16.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_16.Name = "btn_carambula_16"
        Me.btn_carambula_16.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_16.TabIndex = 107
        Me.btn_carambula_16.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_16
        '
        Me.dgvp_carambula_16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_16.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_16.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_16.Name = "dgvp_carambula_16"
        Me.dgvp_carambula_16.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_16.TabIndex = 106
        '
        'TextBox16
        '
        Me.TextBox16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox16.Enabled = False
        Me.TextBox16.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox16.Location = New System.Drawing.Point(20, 66)
        Me.TextBox16.Multiline = True
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox16.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox16.TabIndex = 105
        Me.TextBox16.Text = resources.GetString("TextBox16.Text")
        '
        'BorderLabel21
        '
        Me.BorderLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel21.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel21.Name = "BorderLabel21"
        Me.BorderLabel21.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel21.TabIndex = 104
        Me.BorderLabel21.Text = "Consulta 16"
        '
        'tabCarambula_17
        '
        Me.tabCarambula_17.Controls.Add(Me.btn_carambula_17)
        Me.tabCarambula_17.Controls.Add(Me.dgvp_carambula_17)
        Me.tabCarambula_17.Controls.Add(Me.TextBox17)
        Me.tabCarambula_17.Controls.Add(Me.BorderLabel22)
        Me.tabCarambula_17.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_17.Name = "tabCarambula_17"
        Me.tabCarambula_17.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_17.TabIndex = 16
        Me.tabCarambula_17.Text = "Consulta 17"
        Me.tabCarambula_17.UseVisualStyleBackColor = True
        '
        'btn_carambula_17
        '
        Me.btn_carambula_17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_17.BackColor = System.Drawing.Color.White
        Me.btn_carambula_17.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_17.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_17.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_17.Name = "btn_carambula_17"
        Me.btn_carambula_17.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_17.TabIndex = 110
        Me.btn_carambula_17.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_17
        '
        Me.dgvp_carambula_17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_17.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_17.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_17.Name = "dgvp_carambula_17"
        Me.dgvp_carambula_17.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_17.TabIndex = 109
        '
        'TextBox17
        '
        Me.TextBox17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox17.Enabled = False
        Me.TextBox17.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox17.Location = New System.Drawing.Point(20, 66)
        Me.TextBox17.Multiline = True
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox17.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox17.TabIndex = 108
        Me.TextBox17.Text = resources.GetString("TextBox17.Text")
        '
        'BorderLabel22
        '
        Me.BorderLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel22.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel22.Name = "BorderLabel22"
        Me.BorderLabel22.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel22.TabIndex = 107
        Me.BorderLabel22.Text = "Consulta 17"
        '
        'tabCarambula_18
        '
        Me.tabCarambula_18.Controls.Add(Me.btn_carambula_18)
        Me.tabCarambula_18.Controls.Add(Me.dgvp_carambula_18)
        Me.tabCarambula_18.Controls.Add(Me.TextBox18)
        Me.tabCarambula_18.Controls.Add(Me.BorderLabel23)
        Me.tabCarambula_18.Location = New System.Drawing.Point(4, 22)
        Me.tabCarambula_18.Name = "tabCarambula_18"
        Me.tabCarambula_18.Size = New System.Drawing.Size(1112, 603)
        Me.tabCarambula_18.TabIndex = 17
        Me.tabCarambula_18.Text = "Consulta 18"
        Me.tabCarambula_18.UseVisualStyleBackColor = True
        '
        'btn_carambula_18
        '
        Me.btn_carambula_18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_carambula_18.BackColor = System.Drawing.Color.White
        Me.btn_carambula_18.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.download1
        Me.btn_carambula_18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_carambula_18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_carambula_18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carambula_18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_carambula_18.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_carambula_18.Location = New System.Drawing.Point(1045, 10)
        Me.btn_carambula_18.Name = "btn_carambula_18"
        Me.btn_carambula_18.Size = New System.Drawing.Size(53, 50)
        Me.btn_carambula_18.TabIndex = 114
        Me.btn_carambula_18.UseVisualStyleBackColor = False
        '
        'dgvp_carambula_18
        '
        Me.dgvp_carambula_18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvp_carambula_18.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvp_carambula_18.Location = New System.Drawing.Point(20, 170)
        Me.dgvp_carambula_18.Name = "dgvp_carambula_18"
        Me.dgvp_carambula_18.Size = New System.Drawing.Size(1072, 422)
        Me.dgvp_carambula_18.TabIndex = 113
        '
        'TextBox18
        '
        Me.TextBox18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox18.Enabled = False
        Me.TextBox18.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox18.Location = New System.Drawing.Point(20, 66)
        Me.TextBox18.Multiline = True
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox18.Size = New System.Drawing.Size(1078, 98)
        Me.TextBox18.TabIndex = 112
        Me.TextBox18.Text = resources.GetString("TextBox18.Text")
        '
        'BorderLabel23
        '
        Me.BorderLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorderLabel23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderLabel23.Location = New System.Drawing.Point(14, 10)
        Me.BorderLabel23.Name = "BorderLabel23"
        Me.BorderLabel23.Size = New System.Drawing.Size(215, 36)
        Me.BorderLabel23.TabIndex = 111
        Me.BorderLabel23.Text = "Consulta 18"
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
        Me.btnUsuarios.Location = New System.Drawing.Point(12, 615)
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
        'btnVentanaPrincipal_Admins_Administrativos
        '
        Me.btnVentanaPrincipal_Admins_Administrativos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVentanaPrincipal_Admins_Administrativos.BackColor = System.Drawing.Color.White
        Me.btnVentanaPrincipal_Admins_Administrativos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVentanaPrincipal_Admins_Administrativos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaPrincipal_Admins_Administrativos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentanaPrincipal_Admins_Administrativos.Location = New System.Drawing.Point(12, 570)
        Me.btnVentanaPrincipal_Admins_Administrativos.Name = "btnVentanaPrincipal_Admins_Administrativos"
        Me.btnVentanaPrincipal_Admins_Administrativos.Size = New System.Drawing.Size(211, 39)
        Me.btnVentanaPrincipal_Admins_Administrativos.TabIndex = 26
        Me.btnVentanaPrincipal_Admins_Administrativos.Text = "Admins/Administrativos"
        Me.btnVentanaPrincipal_Admins_Administrativos.UseVisualStyleBackColor = False
        '
        'btnTabHistorial
        '
        Me.btnTabHistorial.BackColor = System.Drawing.Color.White
        Me.btnTabHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTabHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTabHistorial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTabHistorial.Location = New System.Drawing.Point(12, 346)
        Me.btnTabHistorial.Name = "btnTabHistorial"
        Me.btnTabHistorial.Size = New System.Drawing.Size(211, 29)
        Me.btnTabHistorial.TabIndex = 27
        Me.btnTabHistorial.Text = "Historial"
        Me.btnTabHistorial.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(12, 535)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(211, 29)
        Me.Button7.TabIndex = 28
        Me.Button7.Text = "Consultas Carambula 2018"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1369, 712)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnTabHistorial)
        Me.Controls.Add(Me.btnVentanaPrincipal_Admins_Administrativos)
        Me.Controls.Add(Me.btnCiudad)
        Me.Controls.Add(Me.btnVentanaPrincipalOrientaciones)
        Me.Controls.Add(Me.btn_Grupos)
        Me.Controls.Add(Me.btnVentanaPrincipalInstitutos)
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
        Me.pnlCalificaciones_Comboboxes.ResumeLayout(False)
        Me.pnlCalificaciones_Comboboxes.PerformLayout()
        Me.tabPrincipalDocentes.ResumeLayout(False)
        Me.tabPrincipalUsuarios.ResumeLayout(False)
        Me.tabpageInstitutos.ResumeLayout(False)
        Me.tabOrientaciones.ResumeLayout(False)
        Me.tabCiudades.ResumeLayout(False)
        Me.tabAdmins.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.tabHistorial.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.tabCarambula.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabCarambula_1.ResumeLayout(False)
        Me.tabCarambula_1.PerformLayout()
        Me.tabCarambula_2.ResumeLayout(False)
        Me.tabCarambula_2.PerformLayout()
        Me.tabCarambula_3.ResumeLayout(False)
        Me.tabCarambula_3.PerformLayout()
        Me.tabCarambula_4.ResumeLayout(False)
        Me.tabCarambula_4.PerformLayout()
        Me.tabCarambula_5.ResumeLayout(False)
        Me.tabCarambula_5.PerformLayout()
        Me.tabCarambula_6.ResumeLayout(False)
        Me.tabCarambula_6.PerformLayout()
        Me.tabCarambula_7.ResumeLayout(False)
        Me.tabCarambula_7.PerformLayout()
        Me.tabCarambula_8.ResumeLayout(False)
        Me.tabCarambula_8.PerformLayout()
        Me.tabCarambula_9.ResumeLayout(False)
        Me.tabCarambula_9.PerformLayout()
        Me.tabCarambula_10.ResumeLayout(False)
        Me.tabCarambula_10.PerformLayout()
        Me.tabCarambula_11.ResumeLayout(False)
        Me.tabCarambula_11.PerformLayout()
        Me.tabCarambula_12.ResumeLayout(False)
        Me.tabCarambula_12.PerformLayout()
        Me.tabCarambula_13.ResumeLayout(False)
        Me.tabCarambula_13.PerformLayout()
        Me.tabCarambula_14.ResumeLayout(False)
        Me.tabCarambula_14.PerformLayout()
        Me.tabCarambula_15.ResumeLayout(False)
        Me.tabCarambula_15.PerformLayout()
        Me.tabCarambula_16.ResumeLayout(False)
        Me.tabCarambula_16.PerformLayout()
        Me.tabCarambula_17.ResumeLayout(False)
        Me.tabCarambula_17.PerformLayout()
        Me.tabCarambula_18.ResumeLayout(False)
        Me.tabCarambula_18.PerformLayout()
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
    Friend WithEvents btn_admins_Refrescar As Button
    Friend WithEvents btnAdmins_Modificar As Button
    Friend WithEvents btnAdmins_Eliminar As Button
    Friend WithEvents btnAdmins_Crear As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents BorderLabel3 As BorderLabel
    Friend WithEvents btnVentanaPrincipal_Admins_Administrativos As Button
    Friend WithEvents btn_agregar_a_un_grupo As Button
    Friend WithEvents btnDesvincular As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BorderLabel5 As BorderLabel
    Friend WithEvents BorderLabel4 As BorderLabel
    Friend WithEvents btn_ver_grupos_asignados_docente As Button
    Friend WithEvents btnVincular_a_Orientacion As Button
    Friend WithEvents btn_Grupos_refrescar As Button
    Friend WithEvents btn_Asignaturas_refrescar As Button
    Friend WithEvents btn_refrescar_Calificaciones As Button
    Friend WithEvents btn_Docentes_refrescar As Button
    Friend WithEvents btn_usuarios_refrescar As Button
    Friend WithEvents btn_Institutos_refrescar As Button
    Friend WithEvents btn_orientacion_refrescar As Button
    Friend WithEvents btnCiudades_Refrescar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Control_impresion As Printing.PrintDocument
    Friend WithEvents tabHistorial As TabPage
    Friend WithEvents dgvP_Historial As DGVPaginado
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button11 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Historial As BorderLabel
    Friend WithEvents btnTabHistorial As Button
    Friend WithEvents lst_Agregar_grupo As ComboBox
    Friend WithEvents lstGrupos_vinc_Orientaciones As ComboBox
    Friend WithEvents listDocenteAsignarGrupo As ComboBox
    Friend WithEvents listAsignaturasDocente As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ver_grupos As Button
    Friend WithEvents tabCarambula As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabCarambula_1 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BorderLabel6 As BorderLabel
    Friend WithEvents tabCarambula_2 As TabPage
    Friend WithEvents tabCarambula_3 As TabPage
    Friend WithEvents tabCarambula_4 As TabPage
    Friend WithEvents tabCarambula_5 As TabPage
    Friend WithEvents tabCarambula_6 As TabPage
    Friend WithEvents tabCarambula_7 As TabPage
    Friend WithEvents tabCarambula_8 As TabPage
    Friend WithEvents tabCarambula_9 As TabPage
    Friend WithEvents tabCarambula_10 As TabPage
    Friend WithEvents tabCarambula_11 As TabPage
    Friend WithEvents tabCarambula_12 As TabPage
    Friend WithEvents tabCarambula_13 As TabPage
    Friend WithEvents tabCarambula_14 As TabPage
    Friend WithEvents tabCarambula_15 As TabPage
    Friend WithEvents tabCarambula_16 As TabPage
    Friend WithEvents tabCarambula_17 As TabPage
    Friend WithEvents tabCarambula_18 As TabPage
    Friend WithEvents Button7 As Button
    Friend WithEvents dgvP_carambula_1 As DGVPaginado
    Friend WithEvents btn_carambula_1 As Button
    Friend WithEvents btn_carambula_2 As Button
    Friend WithEvents dgvp_carambula_2 As DGVPaginado
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BorderLabel7 As BorderLabel
    Friend WithEvents btn_carambula_3 As Button
    Friend WithEvents dgvp_carambula_3 As DGVPaginado
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BorderLabel8 As BorderLabel
    Friend WithEvents btn_carambula_4 As Button
    Friend WithEvents dgvp_carambula_4 As DGVPaginado
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents BorderLabel9 As BorderLabel
    Friend WithEvents btn_carambula_5 As Button
    Friend WithEvents dgvp_carambula_5 As DGVPaginado
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents BorderLabel10 As BorderLabel
    Friend WithEvents btn_carambula_6 As Button
    Friend WithEvents dgvp_carambula_6 As DGVPaginado
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents BorderLabel11 As BorderLabel
    Friend WithEvents btn_carambula_7 As Button
    Friend WithEvents dgvp_carambula_7 As DGVPaginado
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents BorderLabel12 As BorderLabel
    Friend WithEvents btn_carambula_8 As Button
    Friend WithEvents dgvp_carambula_8 As DGVPaginado
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents BorderLabel13 As BorderLabel
    Friend WithEvents btn_carambula_9 As Button
    Friend WithEvents dgvp_carambula_9 As DGVPaginado
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents BorderLabel14 As BorderLabel
    Friend WithEvents btn_carambula_10 As Button
    Friend WithEvents dgvp_carambula_10 As DGVPaginado
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents BorderLabel15 As BorderLabel
    Friend WithEvents btn_carambula_11 As Button
    Friend WithEvents dgvp_carambula_11 As DGVPaginado
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents BorderLabel16 As BorderLabel
    Friend WithEvents btn_carambula_12 As Button
    Friend WithEvents dgvp_carambula_12 As DGVPaginado
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents BorderLabel17 As BorderLabel
    Friend WithEvents btn_carambula_13 As Button
    Friend WithEvents dgvp_carambula_13 As DGVPaginado
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents BorderLabel18 As BorderLabel
    Friend WithEvents btn_carambula_14 As Button
    Friend WithEvents dgvp_carambula_14 As DGVPaginado
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents BorderLabel19 As BorderLabel
    Friend WithEvents btn_carambula_15 As Button
    Friend WithEvents dgvp_carambula_15 As DGVPaginado
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents BorderLabel20 As BorderLabel
    Friend WithEvents btn_carambula_16 As Button
    Friend WithEvents dgvp_carambula_16 As DGVPaginado
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents BorderLabel21 As BorderLabel
    Friend WithEvents btn_carambula_17 As Button
    Friend WithEvents dgvp_carambula_17 As DGVPaginado
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents BorderLabel22 As BorderLabel
    Friend WithEvents btn_carambula_18 As Button
    Friend WithEvents dgvp_carambula_18 As DGVPaginado
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents BorderLabel23 As BorderLabel
End Class
