<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Pacientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.cmbCorreos = New System.Windows.Forms.ComboBox()
        Me.lbArroba = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lb_fechaN = New System.Windows.Forms.Label()
        Me.lb_Sexo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_Nombre = New System.Windows.Forms.Label()
        Me.lb_ID = New System.Windows.Forms.Label()
        Me.tb_Correo = New System.Windows.Forms.TextBox()
        Me.tb_Telefono = New System.Windows.Forms.TextBox()
        Me.tb_ApeM = New System.Windows.Forms.TextBox()
        Me.tb_ApeP = New System.Windows.Forms.TextBox()
        Me.tb_ID_Paciente = New System.Windows.Forms.TextBox()
        Me.cmb_Sexo = New System.Windows.Forms.ComboBox()
        Me.tb_Dia = New System.Windows.Forms.TextBox()
        Me.tb_mes = New System.Windows.Forms.TextBox()
        Me.tb_año = New System.Windows.Forms.TextBox()
        Me.lb_Dia = New System.Windows.Forms.Label()
        Me.lb_mes = New System.Windows.Forms.Label()
        Me.lb_Año = New System.Windows.Forms.Label()
        Me.DGV_Pacientes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(12, 12)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(120, 45)
        Me.btRegresar.TabIndex = 57
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(596, 504)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(120, 45)
        Me.btCancelar.TabIndex = 56
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(418, 504)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(120, 45)
        Me.btEliminar.TabIndex = 55
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btModificar
        '
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.Location = New System.Drawing.Point(250, 504)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(120, 45)
        Me.btModificar.TabIndex = 54
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(68, 504)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(120, 45)
        Me.btAgregar.TabIndex = 53
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'tbNombre
        '
        Me.tbNombre.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(109, 111)
        Me.tbNombre.MaxLength = 30
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(124, 26)
        Me.tbNombre.TabIndex = 59
        '
        'cmbCorreos
        '
        Me.cmbCorreos.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbCorreos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCorreos.FormattingEnabled = True
        Me.cmbCorreos.IntegralHeight = False
        Me.cmbCorreos.Items.AddRange(New Object() {"hotmail.com", "outlook.com", "gmail.com"})
        Me.cmbCorreos.Location = New System.Drawing.Point(507, 200)
        Me.cmbCorreos.MaxDropDownItems = 5
        Me.cmbCorreos.Name = "cmbCorreos"
        Me.cmbCorreos.Size = New System.Drawing.Size(134, 28)
        Me.cmbCorreos.TabIndex = 79
        '
        'lbArroba
        '
        Me.lbArroba.AutoSize = True
        Me.lbArroba.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbArroba.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbArroba.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbArroba.Location = New System.Drawing.Point(476, 205)
        Me.lbArroba.Name = "lbArroba"
        Me.lbArroba.Size = New System.Drawing.Size(25, 20)
        Me.lbArroba.TabIndex = 78
        Me.lbArroba.Text = "@"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(246, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 20)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Correo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(31, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Telefono"
        '
        'lb_fechaN
        '
        Me.lb_fechaN.AutoSize = True
        Me.lb_fechaN.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_fechaN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_fechaN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_fechaN.Location = New System.Drawing.Point(263, 155)
        Me.lb_fechaN.Name = "lb_fechaN"
        Me.lb_fechaN.Size = New System.Drawing.Size(159, 20)
        Me.lb_fechaN.TabIndex = 74
        Me.lb_fechaN.Text = "Fecha de Nacimiento"
        '
        'lb_Sexo
        '
        Me.lb_Sexo.AutoSize = True
        Me.lb_Sexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Sexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Sexo.Location = New System.Drawing.Point(61, 155)
        Me.lb_Sexo.Name = "lb_Sexo"
        Me.lb_Sexo.Size = New System.Drawing.Size(45, 20)
        Me.lb_Sexo.TabIndex = 73
        Me.lb_Sexo.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(522, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Apellido Materno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(258, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Apellido Paterno"
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Nombre.Location = New System.Drawing.Point(38, 114)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(65, 20)
        Me.lb_Nombre.TabIndex = 69
        Me.lb_Nombre.Text = "Nombre"
        '
        'lb_ID
        '
        Me.lb_ID.AutoSize = True
        Me.lb_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ID.Location = New System.Drawing.Point(76, 75)
        Me.lb_ID.Name = "lb_ID"
        Me.lb_ID.Size = New System.Drawing.Size(26, 20)
        Me.lb_ID.TabIndex = 68
        Me.lb_ID.Text = "ID"
        '
        'tb_Correo
        '
        Me.tb_Correo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Correo.Location = New System.Drawing.Point(308, 202)
        Me.tb_Correo.MaxLength = 30
        Me.tb_Correo.Name = "tb_Correo"
        Me.tb_Correo.Size = New System.Drawing.Size(162, 26)
        Me.tb_Correo.TabIndex = 67
        '
        'tb_Telefono
        '
        Me.tb_Telefono.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Telefono.Location = New System.Drawing.Point(109, 199)
        Me.tb_Telefono.MaxLength = 10
        Me.tb_Telefono.Name = "tb_Telefono"
        Me.tb_Telefono.Size = New System.Drawing.Size(106, 26)
        Me.tb_Telefono.TabIndex = 66
        '
        'tb_ApeM
        '
        Me.tb_ApeM.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ApeM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ApeM.Location = New System.Drawing.Point(656, 111)
        Me.tb_ApeM.MaxLength = 20
        Me.tb_ApeM.Name = "tb_ApeM"
        Me.tb_ApeM.Size = New System.Drawing.Size(106, 26)
        Me.tb_ApeM.TabIndex = 61
        '
        'tb_ApeP
        '
        Me.tb_ApeP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ApeP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ApeP.Location = New System.Drawing.Point(389, 111)
        Me.tb_ApeP.MaxLength = 20
        Me.tb_ApeP.Name = "tb_ApeP"
        Me.tb_ApeP.Size = New System.Drawing.Size(106, 26)
        Me.tb_ApeP.TabIndex = 60
        '
        'tb_ID_Paciente
        '
        Me.tb_ID_Paciente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_ID_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID_Paciente.Location = New System.Drawing.Point(109, 72)
        Me.tb_ID_Paciente.MaxLength = 3
        Me.tb_ID_Paciente.Name = "tb_ID_Paciente"
        Me.tb_ID_Paciente.ReadOnly = True
        Me.tb_ID_Paciente.Size = New System.Drawing.Size(42, 26)
        Me.tb_ID_Paciente.TabIndex = 58
        Me.tb_ID_Paciente.TabStop = False
        Me.tb_ID_Paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_ID_Paciente.WordWrap = False
        '
        'cmb_Sexo
        '
        Me.cmb_Sexo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmb_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Sexo.FormattingEnabled = True
        Me.cmb_Sexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cmb_Sexo.Location = New System.Drawing.Point(112, 152)
        Me.cmb_Sexo.Name = "cmb_Sexo"
        Me.cmb_Sexo.Size = New System.Drawing.Size(120, 28)
        Me.cmb_Sexo.TabIndex = 80
        '
        'tb_Dia
        '
        Me.tb_Dia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Dia.Location = New System.Drawing.Point(446, 152)
        Me.tb_Dia.MaxLength = 2
        Me.tb_Dia.Name = "tb_Dia"
        Me.tb_Dia.Size = New System.Drawing.Size(49, 26)
        Me.tb_Dia.TabIndex = 81
        '
        'tb_mes
        '
        Me.tb_mes.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_mes.Location = New System.Drawing.Point(510, 152)
        Me.tb_mes.MaxLength = 2
        Me.tb_mes.Name = "tb_mes"
        Me.tb_mes.Size = New System.Drawing.Size(49, 26)
        Me.tb_mes.TabIndex = 82
        '
        'tb_año
        '
        Me.tb_año.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tb_año.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_año.Location = New System.Drawing.Point(577, 152)
        Me.tb_año.MaxLength = 4
        Me.tb_año.Name = "tb_año"
        Me.tb_año.Size = New System.Drawing.Size(49, 26)
        Me.tb_año.TabIndex = 83
        '
        'lb_Dia
        '
        Me.lb_Dia.AutoSize = True
        Me.lb_Dia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lb_Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Dia.Location = New System.Drawing.Point(456, 177)
        Me.lb_Dia.Name = "lb_Dia"
        Me.lb_Dia.Size = New System.Drawing.Size(28, 16)
        Me.lb_Dia.TabIndex = 84
        Me.lb_Dia.Text = "Dia"
        '
        'lb_mes
        '
        Me.lb_mes.AutoSize = True
        Me.lb_mes.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lb_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mes.Location = New System.Drawing.Point(517, 177)
        Me.lb_mes.Name = "lb_mes"
        Me.lb_mes.Size = New System.Drawing.Size(33, 16)
        Me.lb_mes.TabIndex = 85
        Me.lb_mes.Text = "Mes"
        '
        'lb_Año
        '
        Me.lb_Año.AutoSize = True
        Me.lb_Año.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lb_Año.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Año.Location = New System.Drawing.Point(586, 177)
        Me.lb_Año.Name = "lb_Año"
        Me.lb_Año.Size = New System.Drawing.Size(31, 16)
        Me.lb_Año.TabIndex = 86
        Me.lb_Año.Text = "Año"
        '
        'DGV_Pacientes
        '
        Me.DGV_Pacientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pacientes.Location = New System.Drawing.Point(25, 268)
        Me.DGV_Pacientes.MultiSelect = False
        Me.DGV_Pacientes.Name = "DGV_Pacientes"
        Me.DGV_Pacientes.ReadOnly = True
        Me.DGV_Pacientes.Size = New System.Drawing.Size(737, 230)
        Me.DGV_Pacientes.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(737, 29)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Pacientes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_Pacientes)
        Me.Controls.Add(Me.lb_Año)
        Me.Controls.Add(Me.lb_mes)
        Me.Controls.Add(Me.lb_Dia)
        Me.Controls.Add(Me.tb_año)
        Me.Controls.Add(Me.tb_mes)
        Me.Controls.Add(Me.tb_Dia)
        Me.Controls.Add(Me.cmb_Sexo)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.cmbCorreos)
        Me.Controls.Add(Me.lbArroba)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lb_fechaN)
        Me.Controls.Add(Me.lb_Sexo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lb_Nombre)
        Me.Controls.Add(Me.lb_ID)
        Me.Controls.Add(Me.tb_Correo)
        Me.Controls.Add(Me.tb_Telefono)
        Me.Controls.Add(Me.tb_ApeM)
        Me.Controls.Add(Me.tb_ApeP)
        Me.Controls.Add(Me.tb_ID_Paciente)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btAgregar)
        Me.Name = "frm_Pacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        CType(Me.DGV_Pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btRegresar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btModificar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents cmbCorreos As ComboBox
    Friend WithEvents lbArroba As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lb_fechaN As Label
    Friend WithEvents lb_Sexo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lb_Nombre As Label
    Friend WithEvents lb_ID As Label
    Friend WithEvents tb_Correo As TextBox
    Friend WithEvents tb_ApeM As TextBox
    Friend WithEvents tb_ApeP As TextBox
    Friend WithEvents tb_ID_Paciente As TextBox
    Friend WithEvents cmb_Sexo As ComboBox
    Friend WithEvents tb_Dia As TextBox
    Friend WithEvents tb_mes As TextBox
    Friend WithEvents tb_año As TextBox
    Friend WithEvents lb_Dia As Label
    Friend WithEvents lb_mes As Label
    Friend WithEvents lb_Año As Label
    Friend WithEvents tb_Telefono As TextBox
    Friend WithEvents DGV_Pacientes As DataGridView
    Friend WithEvents Label1 As Label
End Class
