<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Dietas
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
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lb_Nombre = New System.Windows.Forms.Label()
        Me.lb_ID = New System.Windows.Forms.Label()
        Me.tb_ID_Dieta = New System.Windows.Forms.TextBox()
        Me.DGV_Dietas = New System.Windows.Forms.DataGridView()
        Me.lbAlimentos = New System.Windows.Forms.Label()
        CType(Me.DGV_Dietas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(13, 14)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(120, 45)
        Me.btRegresar.TabIndex = 88
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(146, 251)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(120, 45)
        Me.btCancelar.TabIndex = 87
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Enabled = False
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(20, 251)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(120, 45)
        Me.btEliminar.TabIndex = 86
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        Me.btEliminar.Visible = False
        '
        'btModificar
        '
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.Location = New System.Drawing.Point(146, 196)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(120, 45)
        Me.btModificar.TabIndex = 85
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(19, 196)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(120, 45)
        Me.btAgregar.TabIndex = 84
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'tbNombre
        '
        Me.tbNombre.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(91, 138)
        Me.tbNombre.MaxLength = 50
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(175, 26)
        Me.tbNombre.TabIndex = 81
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Nombre.Location = New System.Drawing.Point(20, 141)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(65, 20)
        Me.lb_Nombre.TabIndex = 83
        Me.lb_Nombre.Text = "Nombre"
        '
        'lb_ID
        '
        Me.lb_ID.AutoSize = True
        Me.lb_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID.Location = New System.Drawing.Point(58, 97)
        Me.lb_ID.Name = "lb_ID"
        Me.lb_ID.Size = New System.Drawing.Size(26, 20)
        Me.lb_ID.TabIndex = 82
        Me.lb_ID.Text = "ID"
        '
        'tb_ID_Dieta
        '
        Me.tb_ID_Dieta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Dieta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Dieta.Location = New System.Drawing.Point(91, 94)
        Me.tb_ID_Dieta.MaxLength = 3
        Me.tb_ID_Dieta.Name = "tb_ID_Dieta"
        Me.tb_ID_Dieta.ReadOnly = True
        Me.tb_ID_Dieta.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Dieta.TabIndex = 80
        Me.tb_ID_Dieta.TabStop = False
        Me.tb_ID_Dieta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Dieta.WordWrap = False
        '
        'DGV_Dietas
        '
        Me.DGV_Dietas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Dietas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Dietas.Location = New System.Drawing.Point(302, 66)
        Me.DGV_Dietas.MultiSelect = False
        Me.DGV_Dietas.Name = "DGV_Dietas"
        Me.DGV_Dietas.ReadOnly = True
        Me.DGV_Dietas.Size = New System.Drawing.Size(260, 230)
        Me.DGV_Dietas.TabIndex = 79
        '
        'lbAlimentos
        '
        Me.lbAlimentos.BackColor = System.Drawing.Color.LimeGreen
        Me.lbAlimentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlimentos.Location = New System.Drawing.Point(303, 43)
        Me.lbAlimentos.Name = "lbAlimentos"
        Me.lbAlimentos.Size = New System.Drawing.Size(259, 29)
        Me.lbAlimentos.TabIndex = 112
        Me.lbAlimentos.Text = "Dietas"
        Me.lbAlimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Dietas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(574, 311)
        Me.Controls.Add(Me.lbAlimentos)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lb_Nombre)
        Me.Controls.Add(Me.lb_ID)
        Me.Controls.Add(Me.tb_ID_Dieta)
        Me.Controls.Add(Me.DGV_Dietas)
        Me.Name = "frm_Dietas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dietas"
        CType(Me.DGV_Dietas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btRegresar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btModificar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lb_Nombre As Label
    Friend WithEvents lb_ID As Label
    Friend WithEvents tb_ID_Dieta As TextBox
    Friend WithEvents DGV_Dietas As DataGridView
    Friend WithEvents lbAlimentos As Label
End Class
