<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DietasPaciente
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
        Me.DGV_Pacientes = New System.Windows.Forms.DataGridView()
        Me.DGV_DietasPaciente = New System.Windows.Forms.DataGridView()
        Me.DGV_Dietas = New System.Windows.Forms.DataGridView()
        Me.DGV_Sistemas = New System.Windows.Forms.DataGridView()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.tb_HC = New System.Windows.Forms.TextBox()
        Me.lb_Frecuencia = New System.Windows.Forms.Label()
        Me.lb_ID_Paciente = New System.Windows.Forms.Label()
        Me.tb_ID_Paciente = New System.Windows.Forms.TextBox()
        Me.tb_Calorias = New System.Windows.Forms.TextBox()
        Me.lb_Descripcion = New System.Windows.Forms.Label()
        Me.lb_ID = New System.Windows.Forms.Label()
        Me.tb_ID_Dieta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_ID_Sistema = New System.Windows.Forms.TextBox()
        Me.tb_Lipidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Notas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Proteinas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbAlimentos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_DietasPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Dietas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Sistemas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Pacientes
        '
        Me.DGV_Pacientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pacientes.Location = New System.Drawing.Point(512, 45)
        Me.DGV_Pacientes.MultiSelect = False
        Me.DGV_Pacientes.Name = "DGV_Pacientes"
        Me.DGV_Pacientes.ReadOnly = True
        Me.DGV_Pacientes.Size = New System.Drawing.Size(260, 190)
        Me.DGV_Pacientes.TabIndex = 96
        '
        'DGV_DietasPaciente
        '
        Me.DGV_DietasPaciente.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_DietasPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DietasPaciente.Location = New System.Drawing.Point(12, 499)
        Me.DGV_DietasPaciente.MultiSelect = False
        Me.DGV_DietasPaciente.Name = "DGV_DietasPaciente"
        Me.DGV_DietasPaciente.ReadOnly = True
        Me.DGV_DietasPaciente.Size = New System.Drawing.Size(464, 190)
        Me.DGV_DietasPaciente.TabIndex = 95
        '
        'DGV_Dietas
        '
        Me.DGV_Dietas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Dietas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Dietas.Location = New System.Drawing.Point(512, 276)
        Me.DGV_Dietas.MultiSelect = False
        Me.DGV_Dietas.Name = "DGV_Dietas"
        Me.DGV_Dietas.ReadOnly = True
        Me.DGV_Dietas.Size = New System.Drawing.Size(260, 190)
        Me.DGV_Dietas.TabIndex = 94
        '
        'DGV_Sistemas
        '
        Me.DGV_Sistemas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Sistemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Sistemas.Location = New System.Drawing.Point(512, 499)
        Me.DGV_Sistemas.MultiSelect = False
        Me.DGV_Sistemas.Name = "DGV_Sistemas"
        Me.DGV_Sistemas.ReadOnly = True
        Me.DGV_Sistemas.Size = New System.Drawing.Size(260, 190)
        Me.DGV_Sistemas.TabIndex = 97
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(279, 420)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(120, 45)
        Me.btCancelar.TabIndex = 101
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Enabled = False
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(97, 420)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(120, 45)
        Me.btEliminar.TabIndex = 100
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        Me.btEliminar.Visible = False
        '
        'btModificar
        '
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.Location = New System.Drawing.Point(279, 369)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(120, 45)
        Me.btModificar.TabIndex = 99
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(97, 369)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(120, 45)
        Me.btAgregar.TabIndex = 98
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(12, 12)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(120, 45)
        Me.btRegresar.TabIndex = 102
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'tb_HC
        '
        Me.tb_HC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_HC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_HC.Location = New System.Drawing.Point(175, 209)
        Me.tb_HC.MaxLength = 5
        Me.tb_HC.Name = "tb_HC"
        Me.tb_HC.Size = New System.Drawing.Size(66, 26)
        Me.tb_HC.TabIndex = 109
        '
        'lb_Frecuencia
        '
        Me.lb_Frecuencia.AutoSize = True
        Me.lb_Frecuencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Frecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Frecuencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Frecuencia.Location = New System.Drawing.Point(13, 212)
        Me.lb_Frecuencia.Name = "lb_Frecuencia"
        Me.lb_Frecuencia.Size = New System.Drawing.Size(156, 20)
        Me.lb_Frecuencia.TabIndex = 110
        Me.lb_Frecuencia.Text = "Hidratos de Carbono"
        '
        'lb_ID_Paciente
        '
        Me.lb_ID_Paciente.AutoSize = True
        Me.lb_ID_Paciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID_Paciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID_Paciente.Location = New System.Drawing.Point(77, 84)
        Me.lb_ID_Paciente.Name = "lb_ID_Paciente"
        Me.lb_ID_Paciente.Size = New System.Drawing.Size(92, 20)
        Me.lb_ID_Paciente.TabIndex = 108
        Me.lb_ID_Paciente.Text = "ID Paciente"
        '
        'tb_ID_Paciente
        '
        Me.tb_ID_Paciente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Paciente.Location = New System.Drawing.Point(175, 81)
        Me.tb_ID_Paciente.MaxLength = 3
        Me.tb_ID_Paciente.Name = "tb_ID_Paciente"
        Me.tb_ID_Paciente.ReadOnly = True
        Me.tb_ID_Paciente.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Paciente.TabIndex = 107
        Me.tb_ID_Paciente.TabStop = False
        Me.tb_ID_Paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Paciente.WordWrap = False
        '
        'tb_Calorias
        '
        Me.tb_Calorias.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Calorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Calorias.Location = New System.Drawing.Point(175, 177)
        Me.tb_Calorias.MaxLength = 6
        Me.tb_Calorias.Name = "tb_Calorias"
        Me.tb_Calorias.Size = New System.Drawing.Size(66, 26)
        Me.tb_Calorias.TabIndex = 104
        '
        'lb_Descripcion
        '
        Me.lb_Descripcion.AutoSize = True
        Me.lb_Descripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Descripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Descripcion.Location = New System.Drawing.Point(89, 180)
        Me.lb_Descripcion.Name = "lb_Descripcion"
        Me.lb_Descripcion.Size = New System.Drawing.Size(80, 20)
        Me.lb_Descripcion.TabIndex = 106
        Me.lb_Descripcion.Text = "K Calorias"
        '
        'lb_ID
        '
        Me.lb_ID.AutoSize = True
        Me.lb_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID.Location = New System.Drawing.Point(101, 116)
        Me.lb_ID.Name = "lb_ID"
        Me.lb_ID.Size = New System.Drawing.Size(68, 20)
        Me.lb_ID.TabIndex = 105
        Me.lb_ID.Text = "ID Dieta"
        '
        'tb_ID_Dieta
        '
        Me.tb_ID_Dieta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Dieta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Dieta.Location = New System.Drawing.Point(175, 113)
        Me.tb_ID_Dieta.MaxLength = 3
        Me.tb_ID_Dieta.Name = "tb_ID_Dieta"
        Me.tb_ID_Dieta.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Dieta.TabIndex = 103
        Me.tb_ID_Dieta.TabStop = False
        Me.tb_ID_Dieta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Dieta.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(81, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "ID Sistema"
        '
        'tb_ID_Sistema
        '
        Me.tb_ID_Sistema.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Sistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Sistema.Location = New System.Drawing.Point(175, 145)
        Me.tb_ID_Sistema.MaxLength = 3
        Me.tb_ID_Sistema.Name = "tb_ID_Sistema"
        Me.tb_ID_Sistema.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Sistema.TabIndex = 111
        Me.tb_ID_Sistema.TabStop = False
        Me.tb_ID_Sistema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Sistema.WordWrap = False
        '
        'tb_Lipidos
        '
        Me.tb_Lipidos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Lipidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Lipidos.Location = New System.Drawing.Point(175, 273)
        Me.tb_Lipidos.MaxLength = 5
        Me.tb_Lipidos.Name = "tb_Lipidos"
        Me.tb_Lipidos.Size = New System.Drawing.Size(66, 26)
        Me.tb_Lipidos.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(110, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Lipidos"
        '
        'tb_Notas
        '
        Me.tb_Notas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Notas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Notas.Location = New System.Drawing.Point(175, 305)
        Me.tb_Notas.MaxLength = 50
        Me.tb_Notas.Name = "tb_Notas"
        Me.tb_Notas.Size = New System.Drawing.Size(224, 26)
        Me.tb_Notas.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(118, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Notas"
        '
        'tb_Proteinas
        '
        Me.tb_Proteinas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Proteinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Proteinas.Location = New System.Drawing.Point(175, 241)
        Me.tb_Proteinas.MaxLength = 5
        Me.tb_Proteinas.Name = "tb_Proteinas"
        Me.tb_Proteinas.Size = New System.Drawing.Size(66, 26)
        Me.tb_Proteinas.TabIndex = 117
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(93, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Proteinas"
        '
        'lbAlimentos
        '
        Me.lbAlimentos.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbAlimentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlimentos.Location = New System.Drawing.Point(512, 19)
        Me.lbAlimentos.Name = "lbAlimentos"
        Me.lbAlimentos.Size = New System.Drawing.Size(260, 29)
        Me.lbAlimentos.TabIndex = 119
        Me.lbAlimentos.Text = "Pacientes"
        Me.lbAlimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(512, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(260, 29)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Dietas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(512, 479)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 29)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Sistemas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 479)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(464, 29)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Dieta del Paciente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_DietasPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(784, 701)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbAlimentos)
        Me.Controls.Add(Me.tb_Proteinas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_Notas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_Lipidos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_ID_Sistema)
        Me.Controls.Add(Me.tb_HC)
        Me.Controls.Add(Me.lb_Frecuencia)
        Me.Controls.Add(Me.lb_ID_Paciente)
        Me.Controls.Add(Me.tb_ID_Paciente)
        Me.Controls.Add(Me.tb_Calorias)
        Me.Controls.Add(Me.lb_Descripcion)
        Me.Controls.Add(Me.lb_ID)
        Me.Controls.Add(Me.tb_ID_Dieta)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.DGV_Sistemas)
        Me.Controls.Add(Me.DGV_Pacientes)
        Me.Controls.Add(Me.DGV_DietasPaciente)
        Me.Controls.Add(Me.DGV_Dietas)
        Me.Name = "frm_DietasPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_DietasPaciente"
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_DietasPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Dietas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Sistemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Pacientes As DataGridView
    Friend WithEvents DGV_DietasPaciente As DataGridView
    Friend WithEvents DGV_Dietas As DataGridView
    Friend WithEvents DGV_Sistemas As DataGridView
    Friend WithEvents btCancelar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btModificar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents btRegresar As Button
    Friend WithEvents tb_HC As TextBox
    Friend WithEvents lb_Frecuencia As Label
    Friend WithEvents lb_ID_Paciente As Label
    Friend WithEvents tb_ID_Paciente As TextBox
    Friend WithEvents tb_Calorias As TextBox
    Friend WithEvents lb_Descripcion As Label
    Friend WithEvents lb_ID As Label
    Friend WithEvents tb_ID_Dieta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_ID_Sistema As TextBox
    Friend WithEvents tb_Lipidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_Notas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_Proteinas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbAlimentos As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
