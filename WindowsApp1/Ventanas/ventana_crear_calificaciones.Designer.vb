<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_crear_calificaciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCrearCalificaciones_Nombre_Descriptivo = New System.Windows.Forms.TextBox()
        Me.lblNombreCalificacion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCrearCalificaciones_Nombre_Materia = New System.Windows.Forms.Label()
        Me.txtCrearCalificaciones_Nombre_Materia = New System.Windows.Forms.TextBox()
        Me.chkCrearCalificacion_Asignar_A = New System.Windows.Forms.CheckedListBox()
        Me.lblCrearCalificacion_Asignar_A = New System.Windows.Forms.Label()
        Me.rchCrearCalificacion_Comentario = New System.Windows.Forms.RichTextBox()
        Me.lblCrearCalificacion_Comentario = New System.Windows.Forms.Label()
        Me.lstCrearCalificacion_tipo = New System.Windows.Forms.ListBox()
        Me.lblCrearCalificacion_Tipo = New System.Windows.Forms.Label()
        Me.nudCrearCalificacion_Nota = New System.Windows.Forms.NumericUpDown()
        Me.lbl_CrearCalificacion_Nota = New System.Windows.Forms.Label()
        Me.btnCrearCalificacion_Cancelar = New System.Windows.Forms.Button()
        Me.btnCrearCalificacion_Aceptar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.nudCrearCalificacion_Nota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCrearCalificaciones_Nombre_Descriptivo
        '
        Me.txtCrearCalificaciones_Nombre_Descriptivo.Location = New System.Drawing.Point(25, 47)
        Me.txtCrearCalificaciones_Nombre_Descriptivo.Name = "txtCrearCalificaciones_Nombre_Descriptivo"
        Me.txtCrearCalificaciones_Nombre_Descriptivo.Size = New System.Drawing.Size(262, 20)
        Me.txtCrearCalificaciones_Nombre_Descriptivo.TabIndex = 11
        '
        'lblNombreCalificacion
        '
        Me.lblNombreCalificacion.AutoSize = True
        Me.lblNombreCalificacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCalificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombreCalificacion.Location = New System.Drawing.Point(21, 22)
        Me.lblNombreCalificacion.Name = "lblNombreCalificacion"
        Me.lblNombreCalificacion.Size = New System.Drawing.Size(192, 22)
        Me.lblNombreCalificacion.TabIndex = 10
        Me.lblNombreCalificacion.Text = "Nombre Descriptivo"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCrearCalificacion_Aceptar)
        Me.Panel1.Controls.Add(Me.btnCrearCalificacion_Cancelar)
        Me.Panel1.Controls.Add(Me.lbl_CrearCalificacion_Nota)
        Me.Panel1.Controls.Add(Me.nudCrearCalificacion_Nota)
        Me.Panel1.Controls.Add(Me.lblCrearCalificacion_Tipo)
        Me.Panel1.Controls.Add(Me.lstCrearCalificacion_tipo)
        Me.Panel1.Controls.Add(Me.lblCrearCalificacion_Comentario)
        Me.Panel1.Controls.Add(Me.rchCrearCalificacion_Comentario)
        Me.Panel1.Controls.Add(Me.lblCrearCalificacion_Asignar_A)
        Me.Panel1.Controls.Add(Me.chkCrearCalificacion_Asignar_A)
        Me.Panel1.Controls.Add(Me.lblCrearCalificaciones_Nombre_Materia)
        Me.Panel1.Controls.Add(Me.txtCrearCalificaciones_Nombre_Materia)
        Me.Panel1.Controls.Add(Me.lblNombreCalificacion)
        Me.Panel1.Controls.Add(Me.txtCrearCalificaciones_Nombre_Descriptivo)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 638)
        Me.Panel1.TabIndex = 12
        '
        'lblCrearCalificaciones_Nombre_Materia
        '
        Me.lblCrearCalificaciones_Nombre_Materia.AutoSize = True
        Me.lblCrearCalificaciones_Nombre_Materia.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearCalificaciones_Nombre_Materia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearCalificaciones_Nombre_Materia.Location = New System.Drawing.Point(21, 103)
        Me.lblCrearCalificaciones_Nombre_Materia.Name = "lblCrearCalificaciones_Nombre_Materia"
        Me.lblCrearCalificaciones_Nombre_Materia.Size = New System.Drawing.Size(79, 22)
        Me.lblCrearCalificaciones_Nombre_Materia.TabIndex = 12
        Me.lblCrearCalificaciones_Nombre_Materia.Text = "Materia"
        '
        'txtCrearCalificaciones_Nombre_Materia
        '
        Me.txtCrearCalificaciones_Nombre_Materia.Location = New System.Drawing.Point(25, 128)
        Me.txtCrearCalificaciones_Nombre_Materia.Name = "txtCrearCalificaciones_Nombre_Materia"
        Me.txtCrearCalificaciones_Nombre_Materia.Size = New System.Drawing.Size(262, 20)
        Me.txtCrearCalificaciones_Nombre_Materia.TabIndex = 13
        '
        'chkCrearCalificacion_Asignar_A
        '
        Me.chkCrearCalificacion_Asignar_A.FormattingEnabled = True
        Me.chkCrearCalificacion_Asignar_A.Location = New System.Drawing.Point(312, 47)
        Me.chkCrearCalificacion_Asignar_A.Name = "chkCrearCalificacion_Asignar_A"
        Me.chkCrearCalificacion_Asignar_A.Size = New System.Drawing.Size(358, 274)
        Me.chkCrearCalificacion_Asignar_A.TabIndex = 14
        '
        'lblCrearCalificacion_Asignar_A
        '
        Me.lblCrearCalificacion_Asignar_A.AutoSize = True
        Me.lblCrearCalificacion_Asignar_A.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearCalificacion_Asignar_A.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearCalificacion_Asignar_A.Location = New System.Drawing.Point(308, 16)
        Me.lblCrearCalificacion_Asignar_A.Name = "lblCrearCalificacion_Asignar_A"
        Me.lblCrearCalificacion_Asignar_A.Size = New System.Drawing.Size(120, 22)
        Me.lblCrearCalificacion_Asignar_A.TabIndex = 15
        Me.lblCrearCalificacion_Asignar_A.Text = "Asignar a ..."
        '
        'rchCrearCalificacion_Comentario
        '
        Me.rchCrearCalificacion_Comentario.Location = New System.Drawing.Point(25, 378)
        Me.rchCrearCalificacion_Comentario.Name = "rchCrearCalificacion_Comentario"
        Me.rchCrearCalificacion_Comentario.Size = New System.Drawing.Size(645, 152)
        Me.rchCrearCalificacion_Comentario.TabIndex = 16
        Me.rchCrearCalificacion_Comentario.Text = ""
        '
        'lblCrearCalificacion_Comentario
        '
        Me.lblCrearCalificacion_Comentario.AutoSize = True
        Me.lblCrearCalificacion_Comentario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearCalificacion_Comentario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearCalificacion_Comentario.Location = New System.Drawing.Point(21, 339)
        Me.lblCrearCalificacion_Comentario.Name = "lblCrearCalificacion_Comentario"
        Me.lblCrearCalificacion_Comentario.Size = New System.Drawing.Size(116, 22)
        Me.lblCrearCalificacion_Comentario.TabIndex = 17
        Me.lblCrearCalificacion_Comentario.Text = "Comentario"
        '
        'lstCrearCalificacion_tipo
        '
        Me.lstCrearCalificacion_tipo.FormattingEnabled = True
        Me.lstCrearCalificacion_tipo.Items.AddRange(New Object() {"Trabajo_Laboratorio", "Trabajo_domiciliario", "Trabajo_practico", "Trabajo_Investigacion", "Trabajo_escrito", "Oral", "Parcial", "Primera_entrega_proyecto", "Segunda_entrega_proyecto", "Entrega_final_proyecto", "Defensa_individual", "Defensa_grupal", "Es_proyecto"})
        Me.lstCrearCalificacion_tipo.Location = New System.Drawing.Point(25, 206)
        Me.lstCrearCalificacion_tipo.Name = "lstCrearCalificacion_tipo"
        Me.lstCrearCalificacion_tipo.Size = New System.Drawing.Size(262, 43)
        Me.lstCrearCalificacion_tipo.TabIndex = 18
        '
        'lblCrearCalificacion_Tipo
        '
        Me.lblCrearCalificacion_Tipo.AutoSize = True
        Me.lblCrearCalificacion_Tipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearCalificacion_Tipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearCalificacion_Tipo.Location = New System.Drawing.Point(21, 177)
        Me.lblCrearCalificacion_Tipo.Name = "lblCrearCalificacion_Tipo"
        Me.lblCrearCalificacion_Tipo.Size = New System.Drawing.Size(50, 22)
        Me.lblCrearCalificacion_Tipo.TabIndex = 19
        Me.lblCrearCalificacion_Tipo.Text = "Tipo"
        '
        'nudCrearCalificacion_Nota
        '
        Me.nudCrearCalificacion_Nota.Location = New System.Drawing.Point(25, 295)
        Me.nudCrearCalificacion_Nota.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudCrearCalificacion_Nota.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCrearCalificacion_Nota.Name = "nudCrearCalificacion_Nota"
        Me.nudCrearCalificacion_Nota.Size = New System.Drawing.Size(262, 20)
        Me.nudCrearCalificacion_Nota.TabIndex = 20
        Me.nudCrearCalificacion_Nota.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_CrearCalificacion_Nota
        '
        Me.lbl_CrearCalificacion_Nota.AutoSize = True
        Me.lbl_CrearCalificacion_Nota.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CrearCalificacion_Nota.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_CrearCalificacion_Nota.Location = New System.Drawing.Point(21, 266)
        Me.lbl_CrearCalificacion_Nota.Name = "lbl_CrearCalificacion_Nota"
        Me.lbl_CrearCalificacion_Nota.Size = New System.Drawing.Size(53, 22)
        Me.lbl_CrearCalificacion_Nota.TabIndex = 21
        Me.lbl_CrearCalificacion_Nota.Text = "Nota"
        '
        'btnCrearCalificacion_Cancelar
        '
        Me.btnCrearCalificacion_Cancelar.BackColor = System.Drawing.Color.White
        Me.btnCrearCalificacion_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearCalificacion_Cancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearCalificacion_Cancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCrearCalificacion_Cancelar.Location = New System.Drawing.Point(25, 582)
        Me.btnCrearCalificacion_Cancelar.Name = "btnCrearCalificacion_Cancelar"
        Me.btnCrearCalificacion_Cancelar.Size = New System.Drawing.Size(211, 39)
        Me.btnCrearCalificacion_Cancelar.TabIndex = 22
        Me.btnCrearCalificacion_Cancelar.Text = "Cancelar"
        Me.btnCrearCalificacion_Cancelar.UseVisualStyleBackColor = False
        '
        'btnCrearCalificacion_Aceptar
        '
        Me.btnCrearCalificacion_Aceptar.BackColor = System.Drawing.Color.White
        Me.btnCrearCalificacion_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrearCalificacion_Aceptar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearCalificacion_Aceptar.ForeColor = System.Drawing.Color.Green
        Me.btnCrearCalificacion_Aceptar.Location = New System.Drawing.Point(459, 582)
        Me.btnCrearCalificacion_Aceptar.Name = "btnCrearCalificacion_Aceptar"
        Me.btnCrearCalificacion_Aceptar.Size = New System.Drawing.Size(211, 39)
        Me.btnCrearCalificacion_Aceptar.TabIndex = 23
        Me.btnCrearCalificacion_Aceptar.Text = "Aceptar"
        Me.btnCrearCalificacion_Aceptar.UseVisualStyleBackColor = False
        '
        'ventana_crear_calificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(717, 662)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ventana_crear_calificaciones"
        Me.Text = "Nueva Calificacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudCrearCalificacion_Nota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCrearCalificaciones_Nombre_Descriptivo As TextBox
    Friend WithEvents lblNombreCalificacion As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCrearCalificaciones_Nombre_Materia As Label
    Friend WithEvents txtCrearCalificaciones_Nombre_Materia As TextBox
    Friend WithEvents lblCrearCalificacion_Comentario As Label
    Friend WithEvents rchCrearCalificacion_Comentario As RichTextBox
    Friend WithEvents lblCrearCalificacion_Asignar_A As Label
    Friend WithEvents chkCrearCalificacion_Asignar_A As CheckedListBox
    Friend WithEvents lbl_CrearCalificacion_Nota As Label
    Friend WithEvents nudCrearCalificacion_Nota As NumericUpDown
    Friend WithEvents lblCrearCalificacion_Tipo As Label
    Friend WithEvents lstCrearCalificacion_tipo As ListBox
    Friend WithEvents btnCrearCalificacion_Aceptar As Button
    Friend WithEvents btnCrearCalificacion_Cancelar As Button
End Class
