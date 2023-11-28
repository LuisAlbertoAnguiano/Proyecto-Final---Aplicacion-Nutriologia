<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DiagClinico
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
        Me.DGV_Pacientes = New System.Windows.Forms.DataGridView()
        Me.DGV_DiagClinico = New System.Windows.Forms.DataGridView()
        Me.lb_ID = New System.Windows.Forms.Label()
        Me.tb_ID_Paciente = New System.Windows.Forms.TextBox()
        Me.tb_AtdFamiliar = New System.Windows.Forms.TextBox()
        Me.lb_AtdFamiliar = New System.Windows.Forms.Label()
        Me.tb_Enfermedad = New System.Windows.Forms.TextBox()
        Me.lb_Enfermedad = New System.Windows.Forms.Label()
        Me.tb_Sintomas = New System.Windows.Forms.TextBox()
        Me.tb_Alergia = New System.Windows.Forms.TextBox()
        Me.lb_Alergia = New System.Windows.Forms.Label()
        Me.tb_MedSup = New System.Windows.Forms.TextBox()
        Me.tb_Signos = New System.Windows.Forms.TextBox()
        Me.lb_Signos = New System.Windows.Forms.Label()
        Me.lb_NumDiag = New System.Windows.Forms.Label()
        Me.tb_NumDiag = New System.Windows.Forms.TextBox()
        Me.lb_Sintomas = New System.Windows.Forms.Label()
        Me.lb_MedSup = New System.Windows.Forms.Label()
        Me.lbAlimentos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_DiagClinico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(12, 12)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(120, 45)
        Me.btRegresar.TabIndex = 89
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(495, 529)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(120, 45)
        Me.btCancelar.TabIndex = 93
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Enabled = False
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(621, 491)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(120, 45)
        Me.btEliminar.TabIndex = 92
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        Me.btEliminar.Visible = False
        '
        'btModificar
        '
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.Location = New System.Drawing.Point(322, 529)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(120, 45)
        Me.btModificar.TabIndex = 91
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(140, 529)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(120, 45)
        Me.btAgregar.TabIndex = 90
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'DGV_Pacientes
        '
        Me.DGV_Pacientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pacientes.Location = New System.Drawing.Point(418, 53)
        Me.DGV_Pacientes.MultiSelect = False
        Me.DGV_Pacientes.Name = "DGV_Pacientes"
        Me.DGV_Pacientes.ReadOnly = True
        Me.DGV_Pacientes.Size = New System.Drawing.Size(354, 320)
        Me.DGV_Pacientes.TabIndex = 94
        '
        'DGV_DiagClinico
        '
        Me.DGV_DiagClinico.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_DiagClinico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DiagClinico.Location = New System.Drawing.Point(31, 430)
        Me.DGV_DiagClinico.MultiSelect = False
        Me.DGV_DiagClinico.Name = "DGV_DiagClinico"
        Me.DGV_DiagClinico.ReadOnly = True
        Me.DGV_DiagClinico.Size = New System.Drawing.Size(741, 93)
        Me.DGV_DiagClinico.TabIndex = 95
        '
        'lb_ID
        '
        Me.lb_ID.AutoSize = True
        Me.lb_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID.Location = New System.Drawing.Point(95, 66)
        Me.lb_ID.Name = "lb_ID"
        Me.lb_ID.Size = New System.Drawing.Size(26, 20)
        Me.lb_ID.TabIndex = 97
        Me.lb_ID.Text = "ID"
        '
        'tb_ID_Paciente
        '
        Me.tb_ID_Paciente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Paciente.Location = New System.Drawing.Point(128, 63)
        Me.tb_ID_Paciente.MaxLength = 3
        Me.tb_ID_Paciente.Name = "tb_ID_Paciente"
        Me.tb_ID_Paciente.ReadOnly = True
        Me.tb_ID_Paciente.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Paciente.TabIndex = 96
        Me.tb_ID_Paciente.TabStop = False
        Me.tb_ID_Paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Paciente.WordWrap = False
        '
        'tb_AtdFamiliar
        '
        Me.tb_AtdFamiliar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_AtdFamiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_AtdFamiliar.Location = New System.Drawing.Point(128, 164)
        Me.tb_AtdFamiliar.MaxLength = 50
        Me.tb_AtdFamiliar.Name = "tb_AtdFamiliar"
        Me.tb_AtdFamiliar.Size = New System.Drawing.Size(175, 26)
        Me.tb_AtdFamiliar.TabIndex = 100
        '
        'lb_AtdFamiliar
        '
        Me.lb_AtdFamiliar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_AtdFamiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_AtdFamiliar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_AtdFamiliar.Location = New System.Drawing.Point(21, 156)
        Me.lb_AtdFamiliar.Name = "lb_AtdFamiliar"
        Me.lb_AtdFamiliar.Size = New System.Drawing.Size(103, 42)
        Me.lb_AtdFamiliar.TabIndex = 101
        Me.lb_AtdFamiliar.Text = "Antecedente Familiar"
        Me.lb_AtdFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_Enfermedad
        '
        Me.tb_Enfermedad.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Enfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Enfermedad.Location = New System.Drawing.Point(128, 127)
        Me.tb_Enfermedad.MaxLength = 50
        Me.tb_Enfermedad.Name = "tb_Enfermedad"
        Me.tb_Enfermedad.Size = New System.Drawing.Size(175, 26)
        Me.tb_Enfermedad.TabIndex = 98
        '
        'lb_Enfermedad
        '
        Me.lb_Enfermedad.AutoSize = True
        Me.lb_Enfermedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Enfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Enfermedad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Enfermedad.Location = New System.Drawing.Point(27, 127)
        Me.lb_Enfermedad.Name = "lb_Enfermedad"
        Me.lb_Enfermedad.Size = New System.Drawing.Size(97, 20)
        Me.lb_Enfermedad.TabIndex = 99
        Me.lb_Enfermedad.Text = "Enfermedad"
        '
        'tb_Sintomas
        '
        Me.tb_Sintomas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Sintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Sintomas.Location = New System.Drawing.Point(128, 241)
        Me.tb_Sintomas.MaxLength = 50
        Me.tb_Sintomas.Name = "tb_Sintomas"
        Me.tb_Sintomas.Size = New System.Drawing.Size(175, 26)
        Me.tb_Sintomas.TabIndex = 104
        '
        'tb_Alergia
        '
        Me.tb_Alergia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Alergia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Alergia.Location = New System.Drawing.Point(128, 204)
        Me.tb_Alergia.MaxLength = 50
        Me.tb_Alergia.Name = "tb_Alergia"
        Me.tb_Alergia.Size = New System.Drawing.Size(175, 26)
        Me.tb_Alergia.TabIndex = 102
        '
        'lb_Alergia
        '
        Me.lb_Alergia.AutoSize = True
        Me.lb_Alergia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Alergia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Alergia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Alergia.Location = New System.Drawing.Point(60, 207)
        Me.lb_Alergia.Name = "lb_Alergia"
        Me.lb_Alergia.Size = New System.Drawing.Size(58, 20)
        Me.lb_Alergia.TabIndex = 103
        Me.lb_Alergia.Text = "Alergia"
        '
        'tb_MedSup
        '
        Me.tb_MedSup.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_MedSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_MedSup.Location = New System.Drawing.Point(144, 321)
        Me.tb_MedSup.MaxLength = 50
        Me.tb_MedSup.Name = "tb_MedSup"
        Me.tb_MedSup.Size = New System.Drawing.Size(175, 26)
        Me.tb_MedSup.TabIndex = 108
        '
        'tb_Signos
        '
        Me.tb_Signos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Signos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Signos.Location = New System.Drawing.Point(128, 281)
        Me.tb_Signos.MaxLength = 50
        Me.tb_Signos.Name = "tb_Signos"
        Me.tb_Signos.Size = New System.Drawing.Size(175, 26)
        Me.tb_Signos.TabIndex = 106
        '
        'lb_Signos
        '
        Me.lb_Signos.AutoSize = True
        Me.lb_Signos.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Signos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Signos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Signos.Location = New System.Drawing.Point(65, 284)
        Me.lb_Signos.Name = "lb_Signos"
        Me.lb_Signos.Size = New System.Drawing.Size(58, 20)
        Me.lb_Signos.TabIndex = 107
        Me.lb_Signos.Text = "Signos"
        '
        'lb_NumDiag
        '
        Me.lb_NumDiag.AutoSize = True
        Me.lb_NumDiag.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_NumDiag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_NumDiag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_NumDiag.Location = New System.Drawing.Point(21, 98)
        Me.lb_NumDiag.Name = "lb_NumDiag"
        Me.lb_NumDiag.Size = New System.Drawing.Size(102, 20)
        Me.lb_NumDiag.TabIndex = 111
        Me.lb_NumDiag.Text = "#Diagnostico"
        '
        'tb_NumDiag
        '
        Me.tb_NumDiag.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_NumDiag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_NumDiag.Location = New System.Drawing.Point(128, 95)
        Me.tb_NumDiag.MaxLength = 3
        Me.tb_NumDiag.Name = "tb_NumDiag"
        Me.tb_NumDiag.Size = New System.Drawing.Size(42, 26)
        Me.tb_NumDiag.TabIndex = 110
        Me.tb_NumDiag.TabStop = False
        Me.tb_NumDiag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_NumDiag.WordWrap = False
        '
        'lb_Sintomas
        '
        Me.lb_Sintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Sintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Sintomas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Sintomas.Location = New System.Drawing.Point(21, 233)
        Me.lb_Sintomas.Name = "lb_Sintomas"
        Me.lb_Sintomas.Size = New System.Drawing.Size(103, 42)
        Me.lb_Sintomas.TabIndex = 112
        Me.lb_Sintomas.Text = "Sintomas Digestivos"
        Me.lb_Sintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_MedSup
        '
        Me.lb_MedSup.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_MedSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_MedSup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_MedSup.Location = New System.Drawing.Point(13, 313)
        Me.lb_MedSup.Name = "lb_MedSup"
        Me.lb_MedSup.Size = New System.Drawing.Size(125, 42)
        Me.lb_MedSup.TabIndex = 113
        Me.lb_MedSup.Text = "Medicamentos y Suplementos"
        Me.lb_MedSup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbAlimentos
        '
        Me.lbAlimentos.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbAlimentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlimentos.Location = New System.Drawing.Point(418, 28)
        Me.lbAlimentos.Name = "lbAlimentos"
        Me.lbAlimentos.Size = New System.Drawing.Size(354, 29)
        Me.lbAlimentos.TabIndex = 114
        Me.lbAlimentos.Text = "Pacientes"
        Me.lbAlimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 407)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(741, 29)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Diagnostico Clinico"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_DiagClinico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(784, 581)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbAlimentos)
        Me.Controls.Add(Me.lb_MedSup)
        Me.Controls.Add(Me.lb_Sintomas)
        Me.Controls.Add(Me.lb_NumDiag)
        Me.Controls.Add(Me.tb_NumDiag)
        Me.Controls.Add(Me.tb_MedSup)
        Me.Controls.Add(Me.tb_Signos)
        Me.Controls.Add(Me.lb_Signos)
        Me.Controls.Add(Me.tb_Sintomas)
        Me.Controls.Add(Me.tb_Alergia)
        Me.Controls.Add(Me.lb_Alergia)
        Me.Controls.Add(Me.tb_AtdFamiliar)
        Me.Controls.Add(Me.lb_AtdFamiliar)
        Me.Controls.Add(Me.tb_Enfermedad)
        Me.Controls.Add(Me.lb_Enfermedad)
        Me.Controls.Add(Me.lb_ID)
        Me.Controls.Add(Me.tb_ID_Paciente)
        Me.Controls.Add(Me.DGV_DiagClinico)
        Me.Controls.Add(Me.DGV_Pacientes)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.btRegresar)
        Me.Name = "frm_DiagClinico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diagnostico Clinico"
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_DiagClinico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btRegresar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btModificar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents DGV_Pacientes As DataGridView
    Friend WithEvents DGV_DiagClinico As DataGridView
    Friend WithEvents lb_ID As Label
    Friend WithEvents tb_ID_Paciente As TextBox
    Friend WithEvents tb_AtdFamiliar As TextBox
    Friend WithEvents lb_AtdFamiliar As Label
    Friend WithEvents tb_Enfermedad As TextBox
    Friend WithEvents lb_Enfermedad As Label
    Friend WithEvents tb_Sintomas As TextBox
    Friend WithEvents tb_Alergia As TextBox
    Friend WithEvents lb_Alergia As Label
    Friend WithEvents tb_MedSup As TextBox
    Friend WithEvents tb_Signos As TextBox
    Friend WithEvents lb_Signos As Label
    Friend WithEvents lb_NumDiag As Label
    Friend WithEvents tb_NumDiag As TextBox
    Friend WithEvents lb_Sintomas As Label
    Friend WithEvents lb_MedSup As Label
    Friend WithEvents lbAlimentos As Label
    Friend WithEvents Label1 As Label
End Class
