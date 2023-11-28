<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarUsuario
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.txtrecontra = New System.Windows.Forms.TextBox()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Confirmar Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(56, 243)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(26, 36)
        Me.txt_Id.MaxLength = 8
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.ReadOnly = True
        Me.txt_Id.Size = New System.Drawing.Size(100, 20)
        Me.txt_Id.TabIndex = 12
        '
        'txtrecontra
        '
        Me.txtrecontra.Location = New System.Drawing.Point(26, 201)
        Me.txtrecontra.MaxLength = 30
        Me.txtrecontra.Name = "txtrecontra"
        Me.txtrecontra.Size = New System.Drawing.Size(145, 20)
        Me.txtrecontra.TabIndex = 11
        Me.txtrecontra.UseSystemPasswordChar = True
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(26, 151)
        Me.txtContrasenia.MaxLength = 30
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(145, 20)
        Me.txtContrasenia.TabIndex = 10
        Me.txtContrasenia.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(26, 106)
        Me.txtUsuario.MaxLength = 30
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(145, 20)
        Me.txtUsuario.TabIndex = 9
        '
        'AgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(197, 278)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.txtrecontra)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Name = "AgregarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents txtrecontra As TextBox
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents txtUsuario As TextBox
End Class
