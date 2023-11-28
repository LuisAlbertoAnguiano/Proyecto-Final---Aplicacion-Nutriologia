namespace C__Nutriologia
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Usuario = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Usuario
            // 
            this.dgv_Usuario.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuario.Location = new System.Drawing.Point(4, 6);
            this.dgv_Usuario.Name = "dgv_Usuario";
            this.dgv_Usuario.ReadOnly = true;
            this.dgv_Usuario.Size = new System.Drawing.Size(61, 23);
            this.dgv_Usuario.TabIndex = 20;
            this.dgv_Usuario.Visible = false;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(60, 248);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarUsuario.TabIndex = 19;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Location = new System.Drawing.Point(40, 219);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(168, 23);
            this.btnEntrar.TabIndex = 18;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(21, 119);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(95, 18);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Contraseña";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(21, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 18);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Usuario";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(24, 140);
            this.txtContrasenia.Multiline = true;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(197, 28);
            this.txtContrasenia.TabIndex = 15;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(24, 53);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 28);
            this.txtUsuario.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 279);
            this.Controls.Add(this.dgv_Usuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgv_Usuario;
        internal System.Windows.Forms.Button btnAgregarUsuario;
        internal System.Windows.Forms.Button btnEntrar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtContrasenia;
        internal System.Windows.Forms.TextBox txtUsuario;
    }
}

