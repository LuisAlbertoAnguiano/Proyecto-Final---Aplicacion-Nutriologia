<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.dgv_Usuario = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Location = New System.Drawing.Point(48, 217)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(168, 23)
        Me.btnEntrar.TabIndex = 11
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Usuario"
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenia.Location = New System.Drawing.Point(32, 138)
        Me.txtContrasenia.Multiline = True
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenia.Size = New System.Drawing.Size(197, 28)
        Me.txtContrasenia.TabIndex = 8
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(32, 51)
        Me.txtUsuario.Multiline = True
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(197, 28)
        Me.txtUsuario.TabIndex = 7
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(68, 246)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(123, 23)
        Me.btnAgregarUsuario.TabIndex = 12
        Me.btnAgregarUsuario.Text = "Agregar Usuario"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = False
        '
        'dgv_Usuario
        '
        Me.dgv_Usuario.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Usuario.Location = New System.Drawing.Point(12, 4)
        Me.dgv_Usuario.Name = "dgv_Usuario"
        Me.dgv_Usuario.ReadOnly = True
        Me.dgv_Usuario.Size = New System.Drawing.Size(61, 23)
        Me.dgv_Usuario.TabIndex = 13
        Me.dgv_Usuario.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(276, 299)
        Me.Controls.Add(Me.dgv_Usuario)
        Me.Controls.Add(Me.btnAgregarUsuario)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgv_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEntrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents dgv_Usuario As DataGridView
End Class
