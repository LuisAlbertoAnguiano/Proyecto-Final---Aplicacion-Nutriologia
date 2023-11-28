<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.PanelMainMenu = New System.Windows.Forms.Panel()
        Me.Panel_ConsultarSubMenu = New System.Windows.Forms.Panel()
        Me.bt_FrecAlimentaria = New System.Windows.Forms.Button()
        Me.bt_DietasPaciente = New System.Windows.Forms.Button()
        Me.bt_DiagClinico = New System.Windows.Forms.Button()
        Me.bt_Revision = New System.Windows.Forms.Button()
        Me.bt_Citas = New System.Windows.Forms.Button()
        Me.bt_ActFisica = New System.Windows.Forms.Button()
        Me.bt_Pacientes = New System.Windows.Forms.Button()
        Me.bt_Consultar = New System.Windows.Forms.Button()
        Me.Panel_Logo = New System.Windows.Forms.Panel()
        Me.PanelCatalogoMenu = New System.Windows.Forms.Panel()
        Me.PanelSubMenuCatalogo = New System.Windows.Forms.Panel()
        Me.bt_Alimentos = New System.Windows.Forms.Button()
        Me.bt_Sistemas = New System.Windows.Forms.Button()
        Me.bt_Dietas = New System.Windows.Forms.Button()
        Me.bt_CategoriasFisicas = New System.Windows.Forms.Button()
        Me.bt_Catalogos = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelMainMenu.SuspendLayout()
        Me.Panel_ConsultarSubMenu.SuspendLayout()
        Me.PanelCatalogoMenu.SuspendLayout()
        Me.PanelSubMenuCatalogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMainMenu
        '
        Me.PanelMainMenu.BackColor = System.Drawing.Color.PaleGreen
        Me.PanelMainMenu.Controls.Add(Me.Panel_ConsultarSubMenu)
        Me.PanelMainMenu.Controls.Add(Me.bt_Consultar)
        Me.PanelMainMenu.Controls.Add(Me.Panel_Logo)
        Me.PanelMainMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMainMenu.Name = "PanelMainMenu"
        Me.PanelMainMenu.Size = New System.Drawing.Size(300, 441)
        Me.PanelMainMenu.TabIndex = 0
        '
        'Panel_ConsultarSubMenu
        '
        Me.Panel_ConsultarSubMenu.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel_ConsultarSubMenu.Controls.Add(Me.bt_FrecAlimentaria)
        Me.Panel_ConsultarSubMenu.Controls.Add(Me.bt_DietasPaciente)
        Me.Panel_ConsultarSubMenu.Controls.Add(Me.bt_DiagClinico)
        Me.Panel_ConsultarSubMenu.Controls.Add(Me.bt_Revision)
        Me.Panel_ConsultarSubMenu.Controls.Add(Me.bt_Citas)
        Me.Panel_ConsultarSubMenu.Controls.Add(Me.bt_ActFisica)
        Me.Panel_ConsultarSubMenu.Controls.Add(Me.bt_Pacientes)
        Me.Panel_ConsultarSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_ConsultarSubMenu.Location = New System.Drawing.Point(0, 130)
        Me.Panel_ConsultarSubMenu.Name = "Panel_ConsultarSubMenu"
        Me.Panel_ConsultarSubMenu.Size = New System.Drawing.Size(300, 282)
        Me.Panel_ConsultarSubMenu.TabIndex = 2
        '
        'bt_FrecAlimentaria
        '
        Me.bt_FrecAlimentaria.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_FrecAlimentaria.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_FrecAlimentaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_FrecAlimentaria.Location = New System.Drawing.Point(0, 240)
        Me.bt_FrecAlimentaria.Name = "bt_FrecAlimentaria"
        Me.bt_FrecAlimentaria.Size = New System.Drawing.Size(300, 40)
        Me.bt_FrecAlimentaria.TabIndex = 8
        Me.bt_FrecAlimentaria.Text = "Frecuencia Alimentaria"
        Me.bt_FrecAlimentaria.UseVisualStyleBackColor = False
        '
        'bt_DietasPaciente
        '
        Me.bt_DietasPaciente.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_DietasPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_DietasPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_DietasPaciente.Location = New System.Drawing.Point(0, 200)
        Me.bt_DietasPaciente.Name = "bt_DietasPaciente"
        Me.bt_DietasPaciente.Size = New System.Drawing.Size(300, 40)
        Me.bt_DietasPaciente.TabIndex = 7
        Me.bt_DietasPaciente.Text = "Dieta del Paciente"
        Me.bt_DietasPaciente.UseVisualStyleBackColor = False
        '
        'bt_DiagClinico
        '
        Me.bt_DiagClinico.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_DiagClinico.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_DiagClinico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_DiagClinico.Location = New System.Drawing.Point(0, 160)
        Me.bt_DiagClinico.Name = "bt_DiagClinico"
        Me.bt_DiagClinico.Size = New System.Drawing.Size(300, 40)
        Me.bt_DiagClinico.TabIndex = 6
        Me.bt_DiagClinico.Text = "Diagnostico Clinico"
        Me.bt_DiagClinico.UseVisualStyleBackColor = False
        '
        'bt_Revision
        '
        Me.bt_Revision.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_Revision.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_Revision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Revision.Location = New System.Drawing.Point(0, 120)
        Me.bt_Revision.Name = "bt_Revision"
        Me.bt_Revision.Size = New System.Drawing.Size(300, 40)
        Me.bt_Revision.TabIndex = 5
        Me.bt_Revision.Text = "Revision"
        Me.bt_Revision.UseVisualStyleBackColor = False
        '
        'bt_Citas
        '
        Me.bt_Citas.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_Citas.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_Citas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Citas.Location = New System.Drawing.Point(0, 80)
        Me.bt_Citas.Name = "bt_Citas"
        Me.bt_Citas.Size = New System.Drawing.Size(300, 40)
        Me.bt_Citas.TabIndex = 4
        Me.bt_Citas.Text = "Citas"
        Me.bt_Citas.UseVisualStyleBackColor = False
        '
        'bt_ActFisica
        '
        Me.bt_ActFisica.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_ActFisica.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_ActFisica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ActFisica.Location = New System.Drawing.Point(0, 40)
        Me.bt_ActFisica.Name = "bt_ActFisica"
        Me.bt_ActFisica.Size = New System.Drawing.Size(300, 40)
        Me.bt_ActFisica.TabIndex = 3
        Me.bt_ActFisica.Text = "Actividad Fisica"
        Me.bt_ActFisica.UseVisualStyleBackColor = False
        '
        'bt_Pacientes
        '
        Me.bt_Pacientes.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_Pacientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_Pacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Pacientes.Location = New System.Drawing.Point(0, 0)
        Me.bt_Pacientes.Name = "bt_Pacientes"
        Me.bt_Pacientes.Size = New System.Drawing.Size(300, 40)
        Me.bt_Pacientes.TabIndex = 2
        Me.bt_Pacientes.Text = "Pacientes"
        Me.bt_Pacientes.UseVisualStyleBackColor = False
        '
        'bt_Consultar
        '
        Me.bt_Consultar.BackColor = System.Drawing.Color.DodgerBlue
        Me.bt_Consultar.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Consultar.Location = New System.Drawing.Point(0, 80)
        Me.bt_Consultar.Name = "bt_Consultar"
        Me.bt_Consultar.Size = New System.Drawing.Size(300, 50)
        Me.bt_Consultar.TabIndex = 1
        Me.bt_Consultar.Text = "Consultar"
        Me.bt_Consultar.UseVisualStyleBackColor = False
        '
        'Panel_Logo
        '
        Me.Panel_Logo.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Logo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Logo.Name = "Panel_Logo"
        Me.Panel_Logo.Size = New System.Drawing.Size(300, 80)
        Me.Panel_Logo.TabIndex = 0
        '
        'PanelCatalogoMenu
        '
        Me.PanelCatalogoMenu.BackColor = System.Drawing.Color.PaleGreen
        Me.PanelCatalogoMenu.Controls.Add(Me.PanelSubMenuCatalogo)
        Me.PanelCatalogoMenu.Controls.Add(Me.bt_Catalogos)
        Me.PanelCatalogoMenu.Controls.Add(Me.Panel1)
        Me.PanelCatalogoMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelCatalogoMenu.Location = New System.Drawing.Point(484, 0)
        Me.PanelCatalogoMenu.Name = "PanelCatalogoMenu"
        Me.PanelCatalogoMenu.Size = New System.Drawing.Size(300, 441)
        Me.PanelCatalogoMenu.TabIndex = 1
        '
        'PanelSubMenuCatalogo
        '
        Me.PanelSubMenuCatalogo.BackColor = System.Drawing.Color.SpringGreen
        Me.PanelSubMenuCatalogo.Controls.Add(Me.bt_Alimentos)
        Me.PanelSubMenuCatalogo.Controls.Add(Me.bt_Sistemas)
        Me.PanelSubMenuCatalogo.Controls.Add(Me.bt_Dietas)
        Me.PanelSubMenuCatalogo.Controls.Add(Me.bt_CategoriasFisicas)
        Me.PanelSubMenuCatalogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuCatalogo.Location = New System.Drawing.Point(0, 130)
        Me.PanelSubMenuCatalogo.Name = "PanelSubMenuCatalogo"
        Me.PanelSubMenuCatalogo.Size = New System.Drawing.Size(300, 162)
        Me.PanelSubMenuCatalogo.TabIndex = 5
        '
        'bt_Alimentos
        '
        Me.bt_Alimentos.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_Alimentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_Alimentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Alimentos.Location = New System.Drawing.Point(0, 120)
        Me.bt_Alimentos.Name = "bt_Alimentos"
        Me.bt_Alimentos.Size = New System.Drawing.Size(300, 40)
        Me.bt_Alimentos.TabIndex = 9
        Me.bt_Alimentos.Text = "Alimentos"
        Me.bt_Alimentos.UseVisualStyleBackColor = False
        '
        'bt_Sistemas
        '
        Me.bt_Sistemas.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_Sistemas.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_Sistemas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Sistemas.Location = New System.Drawing.Point(0, 80)
        Me.bt_Sistemas.Name = "bt_Sistemas"
        Me.bt_Sistemas.Size = New System.Drawing.Size(300, 40)
        Me.bt_Sistemas.TabIndex = 8
        Me.bt_Sistemas.Text = "Sistemas"
        Me.bt_Sistemas.UseVisualStyleBackColor = False
        '
        'bt_Dietas
        '
        Me.bt_Dietas.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_Dietas.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_Dietas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Dietas.Location = New System.Drawing.Point(0, 40)
        Me.bt_Dietas.Name = "bt_Dietas"
        Me.bt_Dietas.Size = New System.Drawing.Size(300, 40)
        Me.bt_Dietas.TabIndex = 7
        Me.bt_Dietas.Text = "Dietas"
        Me.bt_Dietas.UseVisualStyleBackColor = False
        '
        'bt_CategoriasFisicas
        '
        Me.bt_CategoriasFisicas.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_CategoriasFisicas.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_CategoriasFisicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_CategoriasFisicas.Location = New System.Drawing.Point(0, 0)
        Me.bt_CategoriasFisicas.Name = "bt_CategoriasFisicas"
        Me.bt_CategoriasFisicas.Size = New System.Drawing.Size(300, 40)
        Me.bt_CategoriasFisicas.TabIndex = 6
        Me.bt_CategoriasFisicas.Text = "Categorias Fisicas"
        Me.bt_CategoriasFisicas.UseVisualStyleBackColor = False
        '
        'bt_Catalogos
        '
        Me.bt_Catalogos.BackColor = System.Drawing.Color.DodgerBlue
        Me.bt_Catalogos.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_Catalogos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Catalogos.Location = New System.Drawing.Point(0, 80)
        Me.bt_Catalogos.Name = "bt_Catalogos"
        Me.bt_Catalogos.Size = New System.Drawing.Size(300, 50)
        Me.bt_Catalogos.TabIndex = 4
        Me.bt_Catalogos.Text = "Catalogos"
        Me.bt_Catalogos.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 80)
        Me.Panel1.TabIndex = 3
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.PanelCatalogoMenu)
        Me.Controls.Add(Me.PanelMainMenu)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "MainMenu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.PanelMainMenu.ResumeLayout(False)
        Me.Panel_ConsultarSubMenu.ResumeLayout(False)
        Me.PanelCatalogoMenu.ResumeLayout(False)
        Me.PanelSubMenuCatalogo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMainMenu As Panel
    Friend WithEvents Panel_ConsultarSubMenu As Panel
    Friend WithEvents bt_DiagClinico As Button
    Friend WithEvents bt_Revision As Button
    Friend WithEvents bt_Citas As Button
    Friend WithEvents bt_ActFisica As Button
    Friend WithEvents bt_Pacientes As Button
    Friend WithEvents bt_Consultar As Button
    Friend WithEvents Panel_Logo As Panel
    Friend WithEvents PanelCatalogoMenu As Panel
    Friend WithEvents PanelSubMenuCatalogo As Panel
    Friend WithEvents bt_CategoriasFisicas As Button
    Friend WithEvents bt_Catalogos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bt_Dietas As Button
    Friend WithEvents bt_Sistemas As Button
    Friend WithEvents bt_DietasPaciente As Button
    Friend WithEvents bt_Alimentos As Button
    Friend WithEvents bt_FrecAlimentaria As Button
End Class
