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
        Me.lblCrearAsignatura_Descripcion = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCrearAsignaturaNombre = New System.Windows.Forms.TextBox()
        Me.lblCrearAsignaturaNombre = New System.Windows.Forms.Label()
        Me.btnCrearAsignaturaCancelar = New System.Windows.Forms.Button()
        Me.btnCrearAsignaturaAceptar = New System.Windows.Forms.Button()
        Me.lblCrear_Asignatura_Titulo = New WindowsApp1.BorderLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlCrearAsignatura.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCrearAsignatura
        '
        Me.pnlCrearAsignatura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlCrearAsignatura.BackColor = System.Drawing.Color.Gray
        Me.pnlCrearAsignatura.Controls.Add(Me.Label4)
        Me.pnlCrearAsignatura.Controls.Add(Me.ComboBox1)
        Me.pnlCrearAsignatura.Controls.Add(Me.TextBox4)
        Me.pnlCrearAsignatura.Controls.Add(Me.Label3)
        Me.pnlCrearAsignatura.Controls.Add(Me.CheckedListBox1)
        Me.pnlCrearAsignatura.Controls.Add(Me.Button2)
        Me.pnlCrearAsignatura.Controls.Add(Me.Button1)
        Me.pnlCrearAsignatura.Controls.Add(Me.TextBox3)
        Me.pnlCrearAsignatura.Controls.Add(Me.Label2)
        Me.pnlCrearAsignatura.Controls.Add(Me.TextBox2)
        Me.pnlCrearAsignatura.Controls.Add(Me.Label1)
        Me.pnlCrearAsignatura.Controls.Add(Me.TextBox1)
        Me.pnlCrearAsignatura.Controls.Add(Me.lblCrearAsignatura_Descripcion)
        Me.pnlCrearAsignatura.Controls.Add(Me.Panel2)
        Me.pnlCrearAsignatura.Location = New System.Drawing.Point(12, 72)
        Me.pnlCrearAsignatura.Name = "pnlCrearAsignatura"
        Me.pnlCrearAsignatura.Size = New System.Drawing.Size(431, 359)
        Me.pnlCrearAsignatura.TabIndex = 29
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
        Me.Panel2.Controls.Add(Me.txtCrearAsignaturaNombre)
        Me.Panel2.Controls.Add(Me.lblCrearAsignaturaNombre)
        Me.Panel2.Location = New System.Drawing.Point(32, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 42)
        Me.Panel2.TabIndex = 30
        '
        'txtCrearAsignaturaNombre
        '
        Me.txtCrearAsignaturaNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCrearAsignaturaNombre.Location = New System.Drawing.Point(154, 13)
        Me.txtCrearAsignaturaNombre.MaxLength = 10
        Me.txtCrearAsignaturaNombre.Name = "txtCrearAsignaturaNombre"
        Me.txtCrearAsignaturaNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCrearAsignaturaNombre.ShortcutsEnabled = False
        Me.txtCrearAsignaturaNombre.Size = New System.Drawing.Size(190, 20)
        Me.txtCrearAsignaturaNombre.TabIndex = 31
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
        'btnCrearAsignaturaCancelar
        '
        Me.btnCrearAsignaturaCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearAsignaturaCancelar.BackColor = System.Drawing.Color.White
        Me.btnCrearAsignaturaCancelar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.cancel
        Me.btnCrearAsignaturaCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrearAsignaturaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearAsignaturaCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearAsignaturaCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearAsignaturaCancelar.Location = New System.Drawing.Point(12, 437)
        Me.btnCrearAsignaturaCancelar.Name = "btnCrearAsignaturaCancelar"
        Me.btnCrearAsignaturaCancelar.Size = New System.Drawing.Size(45, 45)
        Me.btnCrearAsignaturaCancelar.TabIndex = 28
        Me.btnCrearAsignaturaCancelar.UseVisualStyleBackColor = False
        '
        'btnCrearAsignaturaAceptar
        '
        Me.btnCrearAsignaturaAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearAsignaturaAceptar.BackColor = System.Drawing.Color.White
        Me.btnCrearAsignaturaAceptar.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.checkmark_filled
        Me.btnCrearAsignaturaAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrearAsignaturaAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearAsignaturaAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearAsignaturaAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearAsignaturaAceptar.Location = New System.Drawing.Point(398, 437)
        Me.btnCrearAsignaturaAceptar.Name = "btnCrearAsignaturaAceptar"
        Me.btnCrearAsignaturaAceptar.Size = New System.Drawing.Size(45, 45)
        Me.btnCrearAsignaturaAceptar.TabIndex = 27
        Me.btnCrearAsignaturaAceptar.UseVisualStyleBackColor = False
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
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Location = New System.Drawing.Point(32, 109)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(284, 20)
        Me.TextBox1.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Location = New System.Drawing.Point(322, 109)
        Me.TextBox2.MaxLength = 8
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox2.ShortcutsEnabled = False
        Me.TextBox2.Size = New System.Drawing.Size(75, 20)
        Me.TextBox2.TabIndex = 35
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
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.Location = New System.Drawing.Point(32, 173)
        Me.TextBox3.MaxLength = 8
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox3.ShortcutsEnabled = False
        Me.TextBox3.Size = New System.Drawing.Size(168, 20)
        Me.TextBox3.TabIndex = 38
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
        'CheckedListBox1
        '
        Me.CheckedListBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(32, 199)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(168, 109)
        Me.CheckedListBox1.TabIndex = 40
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
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.Location = New System.Drawing.Point(228, 200)
        Me.TextBox4.MaxLength = 8
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox4.ShortcutsEnabled = False
        Me.TextBox4.Size = New System.Drawing.Size(169, 20)
        Me.TextBox4.TabIndex = 42
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(228, 268)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox1.TabIndex = 43
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
        'ventana_crear_institutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(467, 489)
        Me.Controls.Add(Me.pnlCrearAsignatura)
        Me.Controls.Add(Me.btnCrearAsignaturaCancelar)
        Me.Controls.Add(Me.btnCrearAsignaturaAceptar)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCrearAsignatura_Descripcion As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCrearAsignaturaNombre As TextBox
    Friend WithEvents lblCrearAsignaturaNombre As Label
    Friend WithEvents btnCrearAsignaturaCancelar As Button
    Friend WithEvents btnCrearAsignaturaAceptar As Button
    Friend WithEvents lblCrear_Asignatura_Titulo As BorderLabel
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
