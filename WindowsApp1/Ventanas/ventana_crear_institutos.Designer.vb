<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_crear_institutos
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
        Me.pnlCrearAsignatura = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cbo_Ciudades = New System.Windows.Forms.ComboBox()
        Me.txt_crear_institutos_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_institutos_telefonos = New System.Windows.Forms.CheckedListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_crear_instituto_telefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_crear_instituto_numero_calle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_crear_instituto_calles = New System.Windows.Forms.TextBox()
        Me.lblCrearAsignatura_Descripcion = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_crear_instituto_nombre = New System.Windows.Forms.TextBox()
        Me.lblCrearAsignaturaNombre = New System.Windows.Forms.Label()
        Me.btn_crear_instituto_aceptar = New System.Windows.Forms.Button()
        Me.btn_crear_instituto_cancelar = New System.Windows.Forms.Button()
        Me.lblCrear_Asignatura_Titulo = New WindowsApp1.BorderLabel()
        Me.pnlCrearAsignatura.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCrearAsignatura
        '
        Me.pnlCrearAsignatura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlCrearAsignatura.BackColor = System.Drawing.Color.Gray
        Me.pnlCrearAsignatura.Controls.Add(Me.Label4)
        Me.pnlCrearAsignatura.Controls.Add(Me.Cbo_Ciudades)
        Me.pnlCrearAsignatura.Controls.Add(Me.txt_crear_institutos_email)
        Me.pnlCrearAsignatura.Controls.Add(Me.Label3)
        Me.pnlCrearAsignatura.Controls.Add(Me.chk_institutos_telefonos)
        Me.pnlCrearAsignatura.Controls.Add(Me.Button2)
        Me.pnlCrearAsignatura.Controls.Add(Me.Button1)
        Me.pnlCrearAsignatura.Controls.Add(Me.txt_crear_instituto_telefono)
        Me.pnlCrearAsignatura.Controls.Add(Me.Label2)
        Me.pnlCrearAsignatura.Controls.Add(Me.txt_crear_instituto_numero_calle)
        Me.pnlCrearAsignatura.Controls.Add(Me.Label1)
        Me.pnlCrearAsignatura.Controls.Add(Me.txt_crear_instituto_calles)
        Me.pnlCrearAsignatura.Controls.Add(Me.lblCrearAsignatura_Descripcion)
        Me.pnlCrearAsignatura.Controls.Add(Me.Panel2)
        Me.pnlCrearAsignatura.Location = New System.Drawing.Point(12, 72)
        Me.pnlCrearAsignatura.Name = "pnlCrearAsignatura"
        Me.pnlCrearAsignatura.Size = New System.Drawing.Size(431, 359)
        Me.pnlCrearAsignatura.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(224, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 24)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Ciudad"
        '
        'Cbo_Ciudades
        '
        Me.Cbo_Ciudades.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cbo_Ciudades.FormattingEnabled = True
        Me.Cbo_Ciudades.Location = New System.Drawing.Point(228, 268)
        Me.Cbo_Ciudades.Name = "Cbo_Ciudades"
        Me.Cbo_Ciudades.Size = New System.Drawing.Size(169, 21)
        Me.Cbo_Ciudades.TabIndex = 43
        '
        'txt_crear_institutos_email
        '
        Me.txt_crear_institutos_email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_crear_institutos_email.Location = New System.Drawing.Point(228, 200)
        Me.txt_crear_institutos_email.MaxLength = 150
        Me.txt_crear_institutos_email.Name = "txt_crear_institutos_email"
        Me.txt_crear_institutos_email.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_crear_institutos_email.ShortcutsEnabled = False
        Me.txt_crear_institutos_email.Size = New System.Drawing.Size(169, 20)
        Me.txt_crear_institutos_email.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(224, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Email"
        '
        'chk_institutos_telefonos
        '
        Me.chk_institutos_telefonos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chk_institutos_telefonos.FormattingEnabled = True
        Me.chk_institutos_telefonos.Location = New System.Drawing.Point(32, 199)
        Me.chk_institutos_telefonos.Name = "chk_institutos_telefonos"
        Me.chk_institutos_telefonos.Size = New System.Drawing.Size(168, 109)
        Me.chk_institutos_telefonos.TabIndex = 40
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(123, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 33)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(32, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 33)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_crear_instituto_telefono
        '
        Me.txt_crear_instituto_telefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_crear_instituto_telefono.Location = New System.Drawing.Point(32, 173)
        Me.txt_crear_instituto_telefono.MaxLength = 8
        Me.txt_crear_instituto_telefono.Name = "txt_crear_instituto_telefono"
        Me.txt_crear_instituto_telefono.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_crear_instituto_telefono.ShortcutsEnabled = False
        Me.txt_crear_instituto_telefono.Size = New System.Drawing.Size(168, 20)
        Me.txt_crear_instituto_telefono.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(28, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Telefonos"
        '
        'txt_crear_instituto_numero_calle
        '
        Me.txt_crear_instituto_numero_calle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_crear_instituto_numero_calle.Location = New System.Drawing.Point(322, 109)
        Me.txt_crear_instituto_numero_calle.MaxLength = 6
        Me.txt_crear_instituto_numero_calle.Name = "txt_crear_instituto_numero_calle"
        Me.txt_crear_instituto_numero_calle.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_crear_instituto_numero_calle.ShortcutsEnabled = False
        Me.txt_crear_instituto_numero_calle.Size = New System.Drawing.Size(75, 20)
        Me.txt_crear_instituto_numero_calle.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(318, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Numero"
        '
        'txt_crear_instituto_calles
        '
        Me.txt_crear_instituto_calles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_crear_instituto_calles.Location = New System.Drawing.Point(32, 109)
        Me.txt_crear_instituto_calles.MaxLength = 50
        Me.txt_crear_instituto_calles.Name = "txt_crear_instituto_calles"
        Me.txt_crear_instituto_calles.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_crear_instituto_calles.ShortcutsEnabled = False
        Me.txt_crear_instituto_calles.Size = New System.Drawing.Size(284, 20)
        Me.txt_crear_instituto_calles.TabIndex = 33
        '
        'lblCrearAsignatura_Descripcion
        '
        Me.lblCrearAsignatura_Descripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrearAsignatura_Descripcion.AutoSize = True
        Me.lblCrearAsignatura_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAsignatura_Descripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAsignatura_Descripcion.Location = New System.Drawing.Point(28, 78)
        Me.lblCrearAsignatura_Descripcion.Name = "lblCrearAsignatura_Descripcion"
        Me.lblCrearAsignatura_Descripcion.Size = New System.Drawing.Size(61, 24)
        Me.lblCrearAsignatura_Descripcion.TabIndex = 32
        Me.lblCrearAsignatura_Descripcion.Text = "Calles"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_crear_instituto_nombre)
        Me.Panel2.Controls.Add(Me.lblCrearAsignaturaNombre)
        Me.Panel2.Location = New System.Drawing.Point(32, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 42)
        Me.Panel2.TabIndex = 30
        '
        'txt_crear_instituto_nombre
        '
        Me.txt_crear_instituto_nombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_crear_instituto_nombre.Location = New System.Drawing.Point(91, 13)
        Me.txt_crear_instituto_nombre.MaxLength = 50
        Me.txt_crear_instituto_nombre.Name = "txt_crear_instituto_nombre"
        Me.txt_crear_instituto_nombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_crear_instituto_nombre.ShortcutsEnabled = False
        Me.txt_crear_instituto_nombre.Size = New System.Drawing.Size(253, 20)
        Me.txt_crear_instituto_nombre.TabIndex = 31
        '
        'lblCrearAsignaturaNombre
        '
        Me.lblCrearAsignaturaNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrearAsignaturaNombre.AutoSize = True
        Me.lblCrearAsignaturaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearAsignaturaNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearAsignaturaNombre.Location = New System.Drawing.Point(4, 9)
        Me.lblCrearAsignaturaNombre.Name = "lblCrearAsignaturaNombre"
        Me.lblCrearAsignaturaNombre.Size = New System.Drawing.Size(79, 24)
        Me.lblCrearAsignaturaNombre.TabIndex = 19
        Me.lblCrearAsignaturaNombre.Text = "Nombre"
        '
        'btn_crear_instituto_aceptar
        '
        Me.btn_crear_instituto_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_crear_instituto_aceptar.BackColor = System.Drawing.Color.White
        Me.btn_crear_instituto_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_crear_instituto_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear_instituto_aceptar.ForeColor = System.Drawing.Color.Green
        Me.btn_crear_instituto_aceptar.Location = New System.Drawing.Point(260, 450)
        Me.btn_crear_instituto_aceptar.Name = "btn_crear_instituto_aceptar"
        Me.btn_crear_instituto_aceptar.Size = New System.Drawing.Size(183, 32)
        Me.btn_crear_instituto_aceptar.TabIndex = 49
        Me.btn_crear_instituto_aceptar.Text = "Aceptar"
        Me.btn_crear_instituto_aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_crear_instituto_aceptar.UseVisualStyleBackColor = False
        '
        'btn_crear_instituto_cancelar
        '
        Me.btn_crear_instituto_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_crear_instituto_cancelar.BackColor = System.Drawing.Color.White
        Me.btn_crear_instituto_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_crear_instituto_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear_instituto_cancelar.ForeColor = System.Drawing.Color.Red
        Me.btn_crear_instituto_cancelar.Location = New System.Drawing.Point(12, 450)
        Me.btn_crear_instituto_cancelar.Name = "btn_crear_instituto_cancelar"
        Me.btn_crear_instituto_cancelar.Size = New System.Drawing.Size(183, 32)
        Me.btn_crear_instituto_cancelar.TabIndex = 48
        Me.btn_crear_instituto_cancelar.Text = "Cancelar"
        Me.btn_crear_instituto_cancelar.UseVisualStyleBackColor = False
        '
        'lblCrear_Asignatura_Titulo
        '
        Me.lblCrear_Asignatura_Titulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrear_Asignatura_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrear_Asignatura_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrear_Asignatura_Titulo.Location = New System.Drawing.Point(12, 18)
        Me.lblCrear_Asignatura_Titulo.Name = "lblCrear_Asignatura_Titulo"
        Me.lblCrear_Asignatura_Titulo.Size = New System.Drawing.Size(412, 36)
        Me.lblCrear_Asignatura_Titulo.TabIndex = 26
        Me.lblCrear_Asignatura_Titulo.Text = "Cree un nuevo Instituto..."
        '
        'ventana_crear_institutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(467, 489)
        Me.Controls.Add(Me.btn_crear_instituto_aceptar)
        Me.Controls.Add(Me.btn_crear_instituto_cancelar)
        Me.Controls.Add(Me.pnlCrearAsignatura)
        Me.Controls.Add(Me.lblCrear_Asignatura_Titulo)
        Me.Name = "ventana_crear_institutos"
        Me.Text = "Crear nuevo instituto"
        Me.pnlCrearAsignatura.ResumeLayout(False)
        Me.pnlCrearAsignatura.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCrearAsignatura As Panel
    Friend WithEvents txt_crear_instituto_calles As TextBox
    Friend WithEvents lblCrearAsignatura_Descripcion As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_crear_instituto_nombre As TextBox
    Friend WithEvents lblCrearAsignaturaNombre As Label
    Friend WithEvents lblCrear_Asignatura_Titulo As BorderLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_crear_instituto_telefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_crear_instituto_numero_calle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_crear_institutos_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cbo_Ciudades As ComboBox
    Friend WithEvents btn_crear_instituto_aceptar As Button
    Friend WithEvents btn_crear_instituto_cancelar As Button
    Friend WithEvents chk_institutos_telefonos As CheckedListBox
End Class
