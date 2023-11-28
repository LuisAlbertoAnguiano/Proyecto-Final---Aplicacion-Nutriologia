<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FrecAlimentaria
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
        Me.DGV_Alimentos = New System.Windows.Forms.DataGridView()
        Me.DGV_Pacientes = New System.Windows.Forms.DataGridView()
        Me.DGV_FrecAlimentaria = New System.Windows.Forms.DataGridView()
        Me.lb_ID_Paciente = New System.Windows.Forms.Label()
        Me.tb_ID_Paciente = New System.Windows.Forms.TextBox()
        Me.lb_ID_Alimento = New System.Windows.Forms.Label()
        Me.tb_ID_Alimento = New System.Windows.Forms.TextBox()
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.tb_FrecDiaria = New System.Windows.Forms.TextBox()
        Me.lb_FrecDia = New System.Windows.Forms.Label()
        Me.tb_Especificacion = New System.Windows.Forms.TextBox()
        Me.lb_Especificacion = New System.Windows.Forms.Label()
        Me.tb_FrecSemanal = New System.Windows.Forms.TextBox()
        Me.lb_FrecuenciaSemanal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGV_Alimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_FrecAlimentaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Alimentos
        '
        Me.DGV_Alimentos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Alimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Alimentos.Location = New System.Drawing.Point(568, 261)
        Me.DGV_Alimentos.MultiSelect = False
        Me.DGV_Alimentos.Name = "DGV_Alimentos"
        Me.DGV_Alimentos.ReadOnly = True
        Me.DGV_Alimentos.Size = New System.Drawing.Size(264, 308)
        Me.DGV_Alimentos.TabIndex = 96
        '
        'DGV_Pacientes
        '
        Me.DGV_Pacientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pacientes.Location = New System.Drawing.Point(568, 39)
        Me.DGV_Pacientes.MultiSelect = False
        Me.DGV_Pacientes.Name = "DGV_Pacientes"
        Me.DGV_Pacientes.ReadOnly = True
        Me.DGV_Pacientes.Size = New System.Drawing.Size(264, 190)
        Me.DGV_Pacientes.TabIndex = 97
        '
        'DGV_FrecAlimentaria
        '
        Me.DGV_FrecAlimentaria.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_FrecAlimentaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_FrecAlimentaria.Location = New System.Drawing.Point(12, 379)
        Me.DGV_FrecAlimentaria.MultiSelect = False
        Me.DGV_FrecAlimentaria.Name = "DGV_FrecAlimentaria"
        Me.DGV_FrecAlimentaria.ReadOnly = True
        Me.DGV_FrecAlimentaria.Size = New System.Drawing.Size(550, 190)
        Me.DGV_FrecAlimentaria.TabIndex = 98
        '
        'lb_ID_Paciente
        '
        Me.lb_ID_Paciente.AutoSize = True
        Me.lb_ID_Paciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID_Paciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID_Paciente.Location = New System.Drawing.Point(88, 93)
        Me.lb_ID_Paciente.Name = "lb_ID_Paciente"
        Me.lb_ID_Paciente.Size = New System.Drawing.Size(92, 20)
        Me.lb_ID_Paciente.TabIndex = 100
        Me.lb_ID_Paciente.Text = "ID Paciente"
        '
        'tb_ID_Paciente
        '
        Me.tb_ID_Paciente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Paciente.Location = New System.Drawing.Point(186, 90)
        Me.tb_ID_Paciente.MaxLength = 3
        Me.tb_ID_Paciente.Name = "tb_ID_Paciente"
        Me.tb_ID_Paciente.ReadOnly = True
        Me.tb_ID_Paciente.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Paciente.TabIndex = 99
        Me.tb_ID_Paciente.TabStop = False
        Me.tb_ID_Paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Paciente.WordWrap = False
        '
        'lb_ID_Alimento
        '
        Me.lb_ID_Alimento.AutoSize = True
        Me.lb_ID_Alimento.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID_Alimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID_Alimento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID_Alimento.Location = New System.Drawing.Point(88, 125)
        Me.lb_ID_Alimento.Name = "lb_ID_Alimento"
        Me.lb_ID_Alimento.Size = New System.Drawing.Size(92, 20)
        Me.lb_ID_Alimento.TabIndex = 102
        Me.lb_ID_Alimento.Text = "ID Alimento"
        '
        'tb_ID_Alimento
        '
        Me.tb_ID_Alimento.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Alimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Alimento.Location = New System.Drawing.Point(186, 122)
        Me.tb_ID_Alimento.MaxLength = 3
        Me.tb_ID_Alimento.Name = "tb_ID_Alimento"
        Me.tb_ID_Alimento.ReadOnly = True
        Me.tb_ID_Alimento.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Alimento.TabIndex = 101
        Me.tb_ID_Alimento.TabStop = False
        Me.tb_ID_Alimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Alimento.WordWrap = False
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(12, 12)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(120, 45)
        Me.btRegresar.TabIndex = 103
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(408, 286)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(120, 45)
        Me.btCancelar.TabIndex = 107
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Enabled = False
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(304, 349)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(120, 45)
        Me.btEliminar.TabIndex = 106
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        Me.btEliminar.Visible = False
        '
        'btModificar
        '
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.Location = New System.Drawing.Point(241, 286)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(120, 45)
        Me.btModificar.TabIndex = 105
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(60, 286)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(120, 45)
        Me.btAgregar.TabIndex = 104
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'tb_FrecDiaria
        '
        Me.tb_FrecDiaria.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_FrecDiaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_FrecDiaria.Location = New System.Drawing.Point(186, 186)
        Me.tb_FrecDiaria.MaxLength = 50
        Me.tb_FrecDiaria.Name = "tb_FrecDiaria"
        Me.tb_FrecDiaria.Size = New System.Drawing.Size(175, 26)
        Me.tb_FrecDiaria.TabIndex = 110
        '
        'lb_FrecDia
        '
        Me.lb_FrecDia.AutoSize = True
        Me.lb_FrecDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_FrecDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_FrecDia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_FrecDia.Location = New System.Drawing.Point(47, 189)
        Me.lb_FrecDia.Name = "lb_FrecDia"
        Me.lb_FrecDia.Size = New System.Drawing.Size(133, 20)
        Me.lb_FrecDia.TabIndex = 111
        Me.lb_FrecDia.Text = "Frecuencia Diaria"
        '
        'tb_Especificacion
        '
        Me.tb_Especificacion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Especificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Especificacion.Location = New System.Drawing.Point(186, 219)
        Me.tb_Especificacion.MaxLength = 50
        Me.tb_Especificacion.Name = "tb_Especificacion"
        Me.tb_Especificacion.Size = New System.Drawing.Size(175, 26)
        Me.tb_Especificacion.TabIndex = 108
        '
        'lb_Especificacion
        '
        Me.lb_Especificacion.AutoSize = True
        Me.lb_Especificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Especificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Especificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Especificacion.Location = New System.Drawing.Point(69, 222)
        Me.lb_Especificacion.Name = "lb_Especificacion"
        Me.lb_Especificacion.Size = New System.Drawing.Size(111, 20)
        Me.lb_Especificacion.TabIndex = 109
        Me.lb_Especificacion.Text = "Especificacion"
        '
        'tb_FrecSemanal
        '
        Me.tb_FrecSemanal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_FrecSemanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_FrecSemanal.Location = New System.Drawing.Point(186, 154)
        Me.tb_FrecSemanal.MaxLength = 50
        Me.tb_FrecSemanal.Name = "tb_FrecSemanal"
        Me.tb_FrecSemanal.Size = New System.Drawing.Size(175, 26)
        Me.tb_FrecSemanal.TabIndex = 112
        '
        'lb_FrecuenciaSemanal
        '
        Me.lb_FrecuenciaSemanal.AutoSize = True
        Me.lb_FrecuenciaSemanal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_FrecuenciaSemanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_FrecuenciaSemanal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_FrecuenciaSemanal.Location = New System.Drawing.Point(25, 157)
        Me.lb_FrecuenciaSemanal.Name = "lb_FrecuenciaSemanal"
        Me.lb_FrecuenciaSemanal.Size = New System.Drawing.Size(155, 20)
        Me.lb_FrecuenciaSemanal.TabIndex = 113
        Me.lb_FrecuenciaSemanal.Text = "Frecuencia Semanal"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(568, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 29)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Pacientes"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(568, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 29)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Alimentos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(550, 29)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Frecuencia Alimentaria"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_FrecAlimentaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(844, 581)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_FrecSemanal)
        Me.Controls.Add(Me.lb_FrecuenciaSemanal)
        Me.Controls.Add(Me.tb_FrecDiaria)
        Me.Controls.Add(Me.lb_FrecDia)
        Me.Controls.Add(Me.tb_Especificacion)
        Me.Controls.Add(Me.lb_Especificacion)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.lb_ID_Alimento)
        Me.Controls.Add(Me.tb_ID_Alimento)
        Me.Controls.Add(Me.lb_ID_Paciente)
        Me.Controls.Add(Me.tb_ID_Paciente)
        Me.Controls.Add(Me.DGV_FrecAlimentaria)
        Me.Controls.Add(Me.DGV_Pacientes)
        Me.Controls.Add(Me.DGV_Alimentos)
        Me.Name = "frm_FrecAlimentaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frecuencia Alimentaria"
        CType(Me.DGV_Alimentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_FrecAlimentaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Alimentos As DataGridView
    Friend WithEvents DGV_Pacientes As DataGridView
    Friend WithEvents DGV_FrecAlimentaria As DataGridView
    Friend WithEvents lb_ID_Paciente As Label
    Friend WithEvents tb_ID_Paciente As TextBox
    Friend WithEvents lb_ID_Alimento As Label
    Friend WithEvents tb_ID_Alimento As TextBox
    Friend WithEvents btRegresar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btModificar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents tb_FrecDiaria As TextBox
    Friend WithEvents lb_FrecDia As Label
    Friend WithEvents tb_Especificacion As TextBox
    Friend WithEvents lb_Especificacion As Label
    Friend WithEvents tb_FrecSemanal As TextBox
    Friend WithEvents lb_FrecuenciaSemanal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
