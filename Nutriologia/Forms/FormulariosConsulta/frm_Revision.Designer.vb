<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Revision
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
        Me.DGV_Revision = New System.Windows.Forms.DataGridView()
        Me.DGV_Pacientes = New System.Windows.Forms.DataGridView()
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.lb_ID_Paciente = New System.Windows.Forms.Label()
        Me.tb_ID_Paciente = New System.Windows.Forms.TextBox()
        Me.lb_ID = New System.Windows.Forms.Label()
        Me.tb_ID_Revision = New System.Windows.Forms.TextBox()
        Me.tb_Peso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_Estatura = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tb_Cintura = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tb_Cadera = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tb_IMC = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tb_ICC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        CType(Me.DGV_Revision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Revision
        '
        Me.DGV_Revision.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Revision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Revision.Location = New System.Drawing.Point(12, 420)
        Me.DGV_Revision.MultiSelect = False
        Me.DGV_Revision.Name = "DGV_Revision"
        Me.DGV_Revision.ReadOnly = True
        Me.DGV_Revision.Size = New System.Drawing.Size(599, 129)
        Me.DGV_Revision.TabIndex = 88
        '
        'DGV_Pacientes
        '
        Me.DGV_Pacientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pacientes.Location = New System.Drawing.Point(374, 45)
        Me.DGV_Pacientes.MultiSelect = False
        Me.DGV_Pacientes.Name = "DGV_Pacientes"
        Me.DGV_Pacientes.ReadOnly = True
        Me.DGV_Pacientes.Size = New System.Drawing.Size(237, 333)
        Me.DGV_Pacientes.TabIndex = 89
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(12, 12)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(120, 45)
        Me.btRegresar.TabIndex = 90
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(174, 343)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(120, 45)
        Me.btCancelar.TabIndex = 105
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Enabled = False
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(12, 343)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(120, 45)
        Me.btEliminar.TabIndex = 104
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        Me.btEliminar.Visible = False
        '
        'btModificar
        '
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.Location = New System.Drawing.Point(174, 272)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(120, 45)
        Me.btModificar.TabIndex = 103
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(12, 272)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(120, 45)
        Me.btAgregar.TabIndex = 102
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'lb_ID_Paciente
        '
        Me.lb_ID_Paciente.AutoSize = True
        Me.lb_ID_Paciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID_Paciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID_Paciente.Location = New System.Drawing.Point(15, 76)
        Me.lb_ID_Paciente.Name = "lb_ID_Paciente"
        Me.lb_ID_Paciente.Size = New System.Drawing.Size(92, 20)
        Me.lb_ID_Paciente.TabIndex = 124
        Me.lb_ID_Paciente.Text = "ID Paciente"
        '
        'tb_ID_Paciente
        '
        Me.tb_ID_Paciente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Paciente.Location = New System.Drawing.Point(113, 73)
        Me.tb_ID_Paciente.MaxLength = 3
        Me.tb_ID_Paciente.Name = "tb_ID_Paciente"
        Me.tb_ID_Paciente.ReadOnly = True
        Me.tb_ID_Paciente.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Paciente.TabIndex = 123
        Me.tb_ID_Paciente.TabStop = False
        Me.tb_ID_Paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Paciente.WordWrap = False
        '
        'lb_ID
        '
        Me.lb_ID.AutoSize = True
        Me.lb_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID.Location = New System.Drawing.Point(181, 76)
        Me.lb_ID.Name = "lb_ID"
        Me.lb_ID.Size = New System.Drawing.Size(90, 20)
        Me.lb_ID.TabIndex = 121
        Me.lb_ID.Text = "ID Revision"
        '
        'tb_ID_Revision
        '
        Me.tb_ID_Revision.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Revision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Revision.Location = New System.Drawing.Point(277, 73)
        Me.tb_ID_Revision.MaxLength = 3
        Me.tb_ID_Revision.Name = "tb_ID_Revision"
        Me.tb_ID_Revision.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Revision.TabIndex = 119
        Me.tb_ID_Revision.TabStop = False
        Me.tb_ID_Revision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Revision.WordWrap = False
        '
        'tb_Peso
        '
        Me.tb_Peso.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Peso.Location = New System.Drawing.Point(60, 120)
        Me.tb_Peso.MaxLength = 6
        Me.tb_Peso.Name = "tb_Peso"
        Me.tb_Peso.Size = New System.Drawing.Size(53, 26)
        Me.tb_Peso.TabIndex = 137
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(9, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Peso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(123, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 20)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "kg"
        '
        'tb_Estatura
        '
        Me.tb_Estatura.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Estatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Estatura.Location = New System.Drawing.Point(246, 123)
        Me.tb_Estatura.MaxLength = 6
        Me.tb_Estatura.Name = "tb_Estatura"
        Me.tb_Estatura.Size = New System.Drawing.Size(54, 26)
        Me.tb_Estatura.TabIndex = 143
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(170, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "Estatura"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(306, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 20)
        Me.Label11.TabIndex = 145
        Me.Label11.Text = "m"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(138, 169)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 20)
        Me.Label14.TabIndex = 151
        Me.Label14.Text = "cm"
        '
        'tb_Cintura
        '
        Me.tb_Cintura.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Cintura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Cintura.Location = New System.Drawing.Point(78, 163)
        Me.tb_Cintura.MaxLength = 6
        Me.tb_Cintura.Name = "tb_Cintura"
        Me.tb_Cintura.Size = New System.Drawing.Size(54, 26)
        Me.tb_Cintura.TabIndex = 149
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(14, 166)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 20)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "Cintura"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(306, 175)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 20)
        Me.Label18.TabIndex = 157
        Me.Label18.Text = "cm"
        '
        'tb_Cadera
        '
        Me.tb_Cadera.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Cadera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Cadera.Location = New System.Drawing.Point(246, 169)
        Me.tb_Cadera.MaxLength = 6
        Me.tb_Cadera.Name = "tb_Cadera"
        Me.tb_Cadera.Size = New System.Drawing.Size(54, 26)
        Me.tb_Cadera.TabIndex = 155
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(182, 172)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 20)
        Me.Label19.TabIndex = 156
        Me.Label19.Text = "Cadera"
        '
        'tb_IMC
        '
        Me.tb_IMC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_IMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_IMC.Location = New System.Drawing.Point(53, 208)
        Me.tb_IMC.MaxLength = 6
        Me.tb_IMC.Name = "tb_IMC"
        Me.tb_IMC.Size = New System.Drawing.Size(54, 26)
        Me.tb_IMC.TabIndex = 158
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(9, 211)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 20)
        Me.Label20.TabIndex = 159
        Me.Label20.Text = "IMC"
        '
        'tb_ICC
        '
        Me.tb_ICC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ICC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ICC.Location = New System.Drawing.Point(174, 211)
        Me.tb_ICC.MaxLength = 6
        Me.tb_ICC.Name = "tb_ICC"
        Me.tb_ICC.Size = New System.Drawing.Size(54, 26)
        Me.tb_ICC.TabIndex = 162
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(130, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 20)
        Me.Label13.TabIndex = 163
        Me.Label13.Text = "ICC"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(374, 19)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(237, 29)
        Me.Label28.TabIndex = 175
        Me.Label28.Text = "Pacientes"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(12, 400)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(599, 29)
        Me.Label29.TabIndex = 176
        Me.Label29.Text = "Revisión"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Revision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(644, 621)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.tb_ICC)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tb_IMC)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tb_Cadera)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tb_Cintura)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tb_Estatura)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_Peso)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lb_ID_Paciente)
        Me.Controls.Add(Me.tb_ID_Paciente)
        Me.Controls.Add(Me.lb_ID)
        Me.Controls.Add(Me.tb_ID_Revision)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.DGV_Pacientes)
        Me.Controls.Add(Me.DGV_Revision)
        Me.Name = "frm_Revision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Revision"
        CType(Me.DGV_Revision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Revision As DataGridView
    Friend WithEvents DGV_Pacientes As DataGridView
    Friend WithEvents btRegresar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btModificar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents lb_ID_Paciente As Label
    Friend WithEvents tb_ID_Paciente As TextBox
    Friend WithEvents lb_ID As Label
    Friend WithEvents tb_ID_Revision As TextBox
    Friend WithEvents tb_Peso As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_Estatura As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tb_Cintura As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tb_Cadera As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tb_IMC As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tb_ICC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
End Class
