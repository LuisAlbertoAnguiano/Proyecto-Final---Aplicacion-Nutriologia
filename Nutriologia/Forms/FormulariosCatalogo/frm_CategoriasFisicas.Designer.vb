<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CategoriasFisicas
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
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lb_Nombre = New System.Windows.Forms.Label()
        Me.lb_ID = New System.Windows.Forms.Label()
        Me.tb_ID_Categoria = New System.Windows.Forms.TextBox()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.lb = New System.Windows.Forms.Label()
        CType(Me.DGV_CategoriasFisicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_CategoriasFisicas
        '
        Me.DGV_CategoriasFisicas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_CategoriasFisicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CategoriasFisicas.Location = New System.Drawing.Point(301, 54)
        Me.DGV_CategoriasFisicas.MultiSelect = False
        Me.DGV_CategoriasFisicas.Name = "DGV_CategoriasFisicas"
        Me.DGV_CategoriasFisicas.ReadOnly = True
        Me.DGV_CategoriasFisicas.Size = New System.Drawing.Size(260, 240)
        Me.DGV_CategoriasFisicas.TabIndex = 43
        '
        'tbNombre
        '
        Me.tbNombre.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(90, 136)
        Me.tbNombre.MaxLength = 50
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(175, 26)
        Me.tbNombre.TabIndex = 71
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Nombre.Location = New System.Drawing.Point(19, 139)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(65, 20)
        Me.lb_Nombre.TabIndex = 73
        Me.lb_Nombre.Text = "Nombre"
        '
        'lb_ID
        '
        Me.lb_ID.AutoSize = True
        Me.lb_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID.Location = New System.Drawing.Point(57, 95)
        Me.lb_ID.Name = "lb_ID"
        Me.lb_ID.Size = New System.Drawing.Size(26, 20)
        Me.lb_ID.TabIndex = 72
        Me.lb_ID.Text = "ID"
        '
        'tb_ID_Categoria
        '
        Me.tb_ID_Categoria.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Categoria.Location = New System.Drawing.Point(90, 92)
        Me.tb_ID_Categoria.MaxLength = 3
        Me.tb_ID_Categoria.Name = "tb_ID_Categoria"
        Me.tb_ID_Categoria.ReadOnly = True
        Me.tb_ID_Categoria.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Categoria.TabIndex = 70
        Me.tb_ID_Categoria.TabStop = False
        Me.tb_ID_Categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Categoria.WordWrap = False
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(145, 249)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(120, 45)
        Me.btCancelar.TabIndex = 77
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Enabled = False
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(19, 249)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(120, 45)
        Me.btEliminar.TabIndex = 76
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        Me.btEliminar.Visible = False
        '
        'btModificar
        '
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.Location = New System.Drawing.Point(145, 194)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(120, 45)
        Me.btModificar.TabIndex = 75
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(18, 194)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(120, 45)
        Me.btAgregar.TabIndex = 74
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(12, 12)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(120, 45)
        Me.btRegresar.TabIndex = 78
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'lb
        '
        Me.lb.BackColor = System.Drawing.Color.LimeGreen
        Me.lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb.Location = New System.Drawing.Point(301, 28)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(261, 29)
        Me.lb.TabIndex = 112
        Me.lb.Text = "Categorias Fisicas"
        Me.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_CategoriasFisicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(574, 311)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lb_Nombre)
        Me.Controls.Add(Me.lb_ID)
        Me.Controls.Add(Me.tb_ID_Categoria)
        Me.Controls.Add(Me.DGV_CategoriasFisicas)
        Me.Name = "frm_CategoriasFisicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorias Fisicas"
        CType(Me.DGV_CategoriasFisicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_CategoriasFisicas As DataGridView
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lb_Nombre As Label
    Friend WithEvents lb_ID As Label
    Friend WithEvents tb_ID_Categoria As TextBox
    Friend WithEvents btCancelar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btModificar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents btRegresar As Button
    Friend WithEvents lb As Label
End Class
