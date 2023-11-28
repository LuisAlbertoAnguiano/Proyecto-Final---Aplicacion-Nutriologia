<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActFisica
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
        Me.DGV_CategoriasFisicas = New System.Windows.Forms.DataGridView()
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.tb_Descripcion = New System.Windows.Forms.TextBox()
        Me.lb_Descripcion = New System.Windows.Forms.Label()
        Me.lb_ID = New System.Windows.Forms.Label()
        Me.tb_ID_Categoria = New System.Windows.Forms.TextBox()
        Me.DGV_ActFisica = New System.Windows.Forms.DataGridView()
        Me.lb_ID_Paciente = New System.Windows.Forms.Label()
        Me.tb_ID_Paciente = New System.Windows.Forms.TextBox()
        Me.tb_Frecuencia = New System.Windows.Forms.TextBox()
        Me.lb_Frecuencia = New System.Windows.Forms.Label()
        Me.DGV_Pacientes = New System.Windows.Forms.DataGridView()
        Me.lbAlimentos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGV_CategoriasFisicas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ActFisica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_CategoriasFisicas
        '
        Me.DGV_CategoriasFisicas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_CategoriasFisicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CategoriasFisicas.Location = New System.Drawing.Point(412, 285)
        Me.DGV_CategoriasFisicas.MultiSelect = False
        Me.DGV_CategoriasFisicas.Name = "DGV_CategoriasFisicas"
        Me.DGV_CategoriasFisicas.ReadOnly = True
        Me.DGV_CategoriasFisicas.Size = New System.Drawing.Size(260, 190)
        Me.DGV_CategoriasFisicas.TabIndex = 44
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(13, 17)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(120, 45)
        Me.btRegresar.TabIndex = 87
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(480, 491)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(120, 45)
        Me.btCancelar.TabIndex = 86
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(354, 491)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(120, 45)
        Me.btEliminar.TabIndex = 85
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btModificar
        '
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.Location = New System.Drawing.Point(228, 491)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(120, 45)
        Me.btModificar.TabIndex = 84
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(101, 491)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(120, 45)
        Me.btAgregar.TabIndex = 83
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'tb_Descripcion
        '
        Me.tb_Descripcion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Descripcion.Location = New System.Drawing.Point(162, 163)
        Me.tb_Descripcion.MaxLength = 50
        Me.tb_Descripcion.Name = "tb_Descripcion"
        Me.tb_Descripcion.Size = New System.Drawing.Size(175, 26)
        Me.tb_Descripcion.TabIndex = 80
        '
        'lb_Descripcion
        '
        Me.lb_Descripcion.AutoSize = True
        Me.lb_Descripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Descripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Descripcion.Location = New System.Drawing.Point(64, 166)
        Me.lb_Descripcion.Name = "lb_Descripcion"
        Me.lb_Descripcion.Size = New System.Drawing.Size(92, 20)
        Me.lb_Descripcion.TabIndex = 82
        Me.lb_Descripcion.Text = "Descripcion"
        '
        'lb_ID
        '
        Me.lb_ID.AutoSize = True
        Me.lb_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID.Location = New System.Drawing.Point(12, 134)
        Me.lb_ID.Name = "lb_ID"
        Me.lb_ID.Size = New System.Drawing.Size(144, 20)
        Me.lb_ID.TabIndex = 81
        Me.lb_ID.Text = "ID Categoria Fisica"
        '
        'tb_ID_Categoria
        '
        Me.tb_ID_Categoria.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Categoria.Location = New System.Drawing.Point(162, 131)
        Me.tb_ID_Categoria.MaxLength = 3
        Me.tb_ID_Categoria.Name = "tb_ID_Categoria"
        Me.tb_ID_Categoria.ReadOnly = True
        Me.tb_ID_Categoria.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Categoria.TabIndex = 79
        Me.tb_ID_Categoria.TabStop = False
        Me.tb_ID_Categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Categoria.WordWrap = False
        '
        'DGV_ActFisica
        '
        Me.DGV_ActFisica.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_ActFisica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ActFisica.Location = New System.Drawing.Point(33, 285)
        Me.DGV_ActFisica.MultiSelect = False
        Me.DGV_ActFisica.Name = "DGV_ActFisica"
        Me.DGV_ActFisica.ReadOnly = True
        Me.DGV_ActFisica.Size = New System.Drawing.Size(358, 190)
        Me.DGV_ActFisica.TabIndex = 88
        '
        'lb_ID_Paciente
        '
        Me.lb_ID_Paciente.AutoSize = True
        Me.lb_ID_Paciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID_Paciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID_Paciente.Location = New System.Drawing.Point(64, 102)
        Me.lb_ID_Paciente.Name = "lb_ID_Paciente"
        Me.lb_ID_Paciente.Size = New System.Drawing.Size(92, 20)
        Me.lb_ID_Paciente.TabIndex = 90
        Me.lb_ID_Paciente.Text = "ID Paciente"
        '
        'tb_ID_Paciente
        '
        Me.tb_ID_Paciente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Paciente.Location = New System.Drawing.Point(162, 99)
        Me.tb_ID_Paciente.MaxLength = 3
        Me.tb_ID_Paciente.Name = "tb_ID_Paciente"
        Me.tb_ID_Paciente.ReadOnly = True
        Me.tb_ID_Paciente.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Paciente.TabIndex = 89
        Me.tb_ID_Paciente.TabStop = False
        Me.tb_ID_Paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Paciente.WordWrap = False
        '
        'tb_Frecuencia
        '
        Me.tb_Frecuencia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Frecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Frecuencia.Location = New System.Drawing.Point(162, 195)
        Me.tb_Frecuencia.MaxLength = 50
        Me.tb_Frecuencia.Name = "tb_Frecuencia"
        Me.tb_Frecuencia.Size = New System.Drawing.Size(175, 26)
        Me.tb_Frecuencia.TabIndex = 91
        '
        'lb_Frecuencia
        '
        Me.lb_Frecuencia.AutoSize = True
        Me.lb_Frecuencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Frecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Frecuencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Frecuencia.Location = New System.Drawing.Point(64, 198)
        Me.lb_Frecuencia.Name = "lb_Frecuencia"
        Me.lb_Frecuencia.Size = New System.Drawing.Size(88, 20)
        Me.lb_Frecuencia.TabIndex = 92
        Me.lb_Frecuencia.Text = "Frecuencia"
        '
        'DGV_Pacientes
        '
        Me.DGV_Pacientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pacientes.Location = New System.Drawing.Point(412, 46)
        Me.DGV_Pacientes.MultiSelect = False
        Me.DGV_Pacientes.Name = "DGV_Pacientes"
        Me.DGV_Pacientes.ReadOnly = True
        Me.DGV_Pacientes.Size = New System.Drawing.Size(260, 190)
        Me.DGV_Pacientes.TabIndex = 93
        '
        'lbAlimentos
        '
        Me.lbAlimentos.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbAlimentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlimentos.Location = New System.Drawing.Point(412, 17)
        Me.lbAlimentos.Name = "lbAlimentos"
        Me.lbAlimentos.Size = New System.Drawing.Size(260, 29)
        Me.lbAlimentos.TabIndex = 112
        Me.lbAlimentos.Text = "Pacientes"
        Me.lbAlimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(412, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 29)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Categorias Fisicas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 29)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Actividad Fisica"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_ActFisica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(684, 541)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbAlimentos)
        Me.Controls.Add(Me.DGV_Pacientes)
        Me.Controls.Add(Me.tb_Frecuencia)
        Me.Controls.Add(Me.lb_Frecuencia)
        Me.Controls.Add(Me.lb_ID_Paciente)
        Me.Controls.Add(Me.tb_ID_Paciente)
        Me.Controls.Add(Me.DGV_ActFisica)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.tb_Descripcion)
        Me.Controls.Add(Me.lb_Descripcion)
        Me.Controls.Add(Me.lb_ID)
        Me.Controls.Add(Me.tb_ID_Categoria)
        Me.Controls.Add(Me.DGV_CategoriasFisicas)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frm_ActFisica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actividad Fisica"
        CType(Me.DGV_CategoriasFisicas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ActFisica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_CategoriasFisicas As DataGridView
    Friend WithEvents btRegresar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btModificar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents tb_Descripcion As TextBox
    Friend WithEvents lb_Descripcion As Label
    Friend WithEvents lb_ID As Label
    Friend WithEvents tb_ID_Categoria As TextBox
    Friend WithEvents DGV_ActFisica As DataGridView
    Friend WithEvents lb_ID_Paciente As Label
    Friend WithEvents tb_ID_Paciente As TextBox
    Friend WithEvents tb_Frecuencia As TextBox
    Friend WithEvents lb_Frecuencia As Label
    Friend WithEvents DGV_Pacientes As DataGridView
    Friend WithEvents lbAlimentos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
