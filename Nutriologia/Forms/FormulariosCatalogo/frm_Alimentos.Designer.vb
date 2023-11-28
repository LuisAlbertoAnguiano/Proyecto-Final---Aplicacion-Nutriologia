<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Alimentos
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
        Me.lb_ID = New System.Windows.Forms.Label()
        Me.tb_ID_Alimento = New System.Windows.Forms.TextBox()
        Me.tb_Nombre = New System.Windows.Forms.TextBox()
        Me.lb_Nombre = New System.Windows.Forms.Label()
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.lbAlimentos = New System.Windows.Forms.Label()
        CType(Me.DGV_Alimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Alimentos
        '
        Me.DGV_Alimentos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Alimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Alimentos.Location = New System.Drawing.Point(358, 35)
        Me.DGV_Alimentos.MultiSelect = False
        Me.DGV_Alimentos.Name = "DGV_Alimentos"
        Me.DGV_Alimentos.ReadOnly = True
        Me.DGV_Alimentos.Size = New System.Drawing.Size(264, 318)
        Me.DGV_Alimentos.TabIndex = 95
        '
        'lb_ID
        '
        Me.lb_ID.AutoSize = True
        Me.lb_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID.Location = New System.Drawing.Point(92, 98)
        Me.lb_ID.Name = "lb_ID"
        Me.lb_ID.Size = New System.Drawing.Size(26, 20)
        Me.lb_ID.TabIndex = 99
        Me.lb_ID.Text = "ID"
        '
        'tb_ID_Alimento
        '
        Me.tb_ID_Alimento.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Alimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Alimento.Location = New System.Drawing.Point(125, 95)
        Me.tb_ID_Alimento.MaxLength = 3
        Me.tb_ID_Alimento.Name = "tb_ID_Alimento"
        Me.tb_ID_Alimento.ReadOnly = True
        Me.tb_ID_Alimento.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Alimento.TabIndex = 98
        Me.tb_ID_Alimento.TabStop = False
        Me.tb_ID_Alimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Alimento.WordWrap = False
        '
        'tb_Nombre
        '
        Me.tb_Nombre.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Nombre.Location = New System.Drawing.Point(125, 127)
        Me.tb_Nombre.MaxLength = 50
        Me.tb_Nombre.Name = "tb_Nombre"
        Me.tb_Nombre.Size = New System.Drawing.Size(175, 26)
        Me.tb_Nombre.TabIndex = 104
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Nombre.Location = New System.Drawing.Point(57, 130)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(65, 20)
        Me.lb_Nombre.TabIndex = 105
        Me.lb_Nombre.Text = "Nombre"
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(12, 12)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(120, 45)
        Me.btRegresar.TabIndex = 106
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(163, 292)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(120, 45)
        Me.btCancelar.TabIndex = 110
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Enabled = False
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(12, 292)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(120, 45)
        Me.btEliminar.TabIndex = 109
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = False
        Me.btEliminar.Visible = False
        '
        'btModificar
        '
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.Location = New System.Drawing.Point(163, 227)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(120, 45)
        Me.btModificar.TabIndex = 108
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(12, 227)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(120, 45)
        Me.btAgregar.TabIndex = 107
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'lbAlimentos
        '
        Me.lbAlimentos.BackColor = System.Drawing.Color.LimeGreen
        Me.lbAlimentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlimentos.Location = New System.Drawing.Point(358, 9)
        Me.lbAlimentos.Name = "lbAlimentos"
        Me.lbAlimentos.Size = New System.Drawing.Size(264, 29)
        Me.lbAlimentos.TabIndex = 111
        Me.lbAlimentos.Text = "Alimentos"
        Me.lbAlimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Alimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(634, 361)
        Me.Controls.Add(Me.lbAlimentos)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.tb_Nombre)
        Me.Controls.Add(Me.lb_Nombre)
        Me.Controls.Add(Me.lb_ID)
        Me.Controls.Add(Me.tb_ID_Alimento)
        Me.Controls.Add(Me.DGV_Alimentos)
        Me.Name = "frm_Alimentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Alimentos"
        CType(Me.DGV_Alimentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Alimentos As DataGridView
    Friend WithEvents lb_ID As Label
    Friend WithEvents tb_ID_Alimento As TextBox
    Friend WithEvents tb_Nombre As TextBox
    Friend WithEvents lb_Nombre As Label
    Friend WithEvents btRegresar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btModificar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents lbAlimentos As Label
End Class
