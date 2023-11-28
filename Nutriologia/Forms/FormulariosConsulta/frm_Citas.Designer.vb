<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Citas
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
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.lb_ID_Paciente = New System.Windows.Forms.Label()
        Me.tb_ID_Paciente = New System.Windows.Forms.TextBox()
        Me.lb_ID = New System.Windows.Forms.Label()
        Me.tb_Cita = New System.Windows.Forms.TextBox()
        Me.DGV_Citas = New System.Windows.Forms.DataGridView()
        Me.lb_Año = New System.Windows.Forms.Label()
        Me.lb_mes = New System.Windows.Forms.Label()
        Me.lb_Dia = New System.Windows.Forms.Label()
        Me.tb_año = New System.Windows.Forms.TextBox()
        Me.tb_mes = New System.Windows.Forms.TextBox()
        Me.tb_Dia = New System.Windows.Forms.TextBox()
        Me.lbAlimentos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Citas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Pacientes
        '
        Me.DGV_Pacientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pacientes.Location = New System.Drawing.Point(312, 47)
        Me.DGV_Pacientes.MultiSelect = False
        Me.DGV_Pacientes.Name = "DGV_Pacientes"
        Me.DGV_Pacientes.ReadOnly = True
        Me.DGV_Pacientes.Size = New System.Drawing.Size(260, 153)
        Me.DGV_Pacientes.TabIndex = 94
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(12, 12)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(120, 45)
        Me.btRegresar.TabIndex = 95
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(156, 332)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(120, 45)
        Me.btCancelar.TabIndex = 99
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Enabled = False
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(10, 332)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(120, 45)
        Me.btEliminar.TabIndex = 98
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        Me.btEliminar.Visible = False
        '
        'btModificar
        '
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.Location = New System.Drawing.Point(156, 271)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(120, 45)
        Me.btModificar.TabIndex = 97
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(10, 271)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(120, 45)
        Me.btAgregar.TabIndex = 96
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'lb_ID_Paciente
        '
        Me.lb_ID_Paciente.AutoSize = True
        Me.lb_ID_Paciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID_Paciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID_Paciente.Location = New System.Drawing.Point(25, 92)
        Me.lb_ID_Paciente.Name = "lb_ID_Paciente"
        Me.lb_ID_Paciente.Size = New System.Drawing.Size(92, 20)
        Me.lb_ID_Paciente.TabIndex = 103
        Me.lb_ID_Paciente.Text = "ID Paciente"
        '
        'tb_ID_Paciente
        '
        Me.tb_ID_Paciente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Paciente.Location = New System.Drawing.Point(123, 89)
        Me.tb_ID_Paciente.MaxLength = 3
        Me.tb_ID_Paciente.Name = "tb_ID_Paciente"
        Me.tb_ID_Paciente.ReadOnly = True
        Me.tb_ID_Paciente.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Paciente.TabIndex = 102
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
        Me.lb_ID.Location = New System.Drawing.Point(71, 124)
        Me.lb_ID.Name = "lb_ID"
        Me.lb_ID.Size = New System.Drawing.Size(46, 20)
        Me.lb_ID.TabIndex = 101
        Me.lb_ID.Text = "#Cita"
        '
        'tb_Cita
        '
        Me.tb_Cita.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Cita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Cita.Location = New System.Drawing.Point(123, 121)
        Me.tb_Cita.MaxLength = 3
        Me.tb_Cita.Name = "tb_Cita"
        Me.tb_Cita.Size = New System.Drawing.Size(42, 26)
        Me.tb_Cita.TabIndex = 100
        Me.tb_Cita.TabStop = False
        Me.tb_Cita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_Cita.WordWrap = False
        '
        'DGV_Citas
        '
        Me.DGV_Citas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Citas.Location = New System.Drawing.Point(312, 236)
        Me.DGV_Citas.MultiSelect = False
        Me.DGV_Citas.Name = "DGV_Citas"
        Me.DGV_Citas.ReadOnly = True
        Me.DGV_Citas.Size = New System.Drawing.Size(260, 153)
        Me.DGV_Citas.TabIndex = 104
        '
        'lb_Año
        '
        Me.lb_Año.AutoSize = True
        Me.lb_Año.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lb_Año.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Año.Location = New System.Drawing.Point(206, 162)
        Me.lb_Año.Name = "lb_Año"
        Me.lb_Año.Size = New System.Drawing.Size(38, 20)
        Me.lb_Año.TabIndex = 110
        Me.lb_Año.Text = "Año"
        '
        'lb_mes
        '
        Me.lb_mes.AutoSize = True
        Me.lb_mes.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lb_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mes.Location = New System.Drawing.Point(101, 162)
        Me.lb_mes.Name = "lb_mes"
        Me.lb_mes.Size = New System.Drawing.Size(39, 20)
        Me.lb_mes.TabIndex = 109
        Me.lb_mes.Text = "Mes"
        '
        'lb_Dia
        '
        Me.lb_Dia.AutoSize = True
        Me.lb_Dia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lb_Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Dia.Location = New System.Drawing.Point(6, 162)
        Me.lb_Dia.Name = "lb_Dia"
        Me.lb_Dia.Size = New System.Drawing.Size(33, 20)
        Me.lb_Dia.TabIndex = 108
        Me.lb_Dia.Text = "Dia"
        '
        'tb_año
        '
        Me.tb_año.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_año.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_año.Location = New System.Drawing.Point(250, 159)
        Me.tb_año.MaxLength = 4
        Me.tb_año.Name = "tb_año"
        Me.tb_año.Size = New System.Drawing.Size(42, 26)
        Me.tb_año.TabIndex = 107
        '
        'tb_mes
        '
        Me.tb_mes.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_mes.Location = New System.Drawing.Point(146, 159)
        Me.tb_mes.MaxLength = 2
        Me.tb_mes.Name = "tb_mes"
        Me.tb_mes.Size = New System.Drawing.Size(42, 26)
        Me.tb_mes.TabIndex = 106
        '
        'tb_Dia
        '
        Me.tb_Dia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Dia.Location = New System.Drawing.Point(45, 159)
        Me.tb_Dia.MaxLength = 2
        Me.tb_Dia.Name = "tb_Dia"
        Me.tb_Dia.Size = New System.Drawing.Size(42, 26)
        Me.tb_Dia.TabIndex = 105
        '
        'lbAlimentos
        '
        Me.lbAlimentos.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbAlimentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlimentos.Location = New System.Drawing.Point(312, 19)
        Me.lbAlimentos.Name = "lbAlimentos"
        Me.lbAlimentos.Size = New System.Drawing.Size(260, 29)
        Me.lbAlimentos.TabIndex = 113
        Me.lbAlimentos.Text = "Pacientes"
        Me.lbAlimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 29)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Citas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(584, 401)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbAlimentos)
        Me.Controls.Add(Me.lb_Año)
        Me.Controls.Add(Me.lb_mes)
        Me.Controls.Add(Me.lb_Dia)
        Me.Controls.Add(Me.tb_año)
        Me.Controls.Add(Me.tb_mes)
        Me.Controls.Add(Me.tb_Dia)
        Me.Controls.Add(Me.DGV_Citas)
        Me.Controls.Add(Me.lb_ID_Paciente)
        Me.Controls.Add(Me.tb_ID_Paciente)
        Me.Controls.Add(Me.lb_ID)
        Me.Controls.Add(Me.tb_Cita)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.DGV_Pacientes)
        Me.Name = "frm_Citas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Citas"
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Citas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Pacientes As DataGridView
    Friend WithEvents btRegresar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btModificar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents lb_ID_Paciente As Label
    Friend WithEvents tb_ID_Paciente As TextBox
    Friend WithEvents lb_ID As Label
    Friend WithEvents tb_Cita As TextBox
    Friend WithEvents DGV_Citas As DataGridView
    Friend WithEvents lb_Año As Label
    Friend WithEvents lb_mes As Label
    Friend WithEvents lb_Dia As Label
    Friend WithEvents tb_año As TextBox
    Friend WithEvents tb_mes As TextBox
    Friend WithEvents tb_Dia As TextBox
    Friend WithEvents lbAlimentos As Label
    Friend WithEvents Label1 As Label
End Class
