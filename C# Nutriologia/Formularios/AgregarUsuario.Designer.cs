namespace C__Nutriologia.Formularios
{
    partial class AgregarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txtrecontra = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 173);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(108, 13);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "Confirmar Contraseña";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 123);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(61, 13);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Contraseña";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 78);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 13);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Usuario";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(18, 13);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "ID";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(42, 231);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(12, 24);
            this.txt_Id.MaxLength = 8;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 21;
            // 
            // txtrecontra
            // 
            this.txtrecontra.Location = new System.Drawing.Point(12, 189);
            this.txtrecontra.MaxLength = 30;
            this.txtrecontra.Name = "txtrecontra";
            this.txtrecontra.Size = new System.Drawing.Size(145, 20);
            this.txtrecontra.TabIndex = 20;
            this.txtrecontra.UseSystemPasswordChar = true;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(12, 139);
            this.txtContrasenia.MaxLength = 30;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(145, 20);
            this.txtContrasenia.TabIndex = 19;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 94);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(145, 20);
            this.txtUsuario.TabIndex = 18;
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 273);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txtrecontra);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.TextBox txt_Id;
        internal System.Windows.Forms.TextBox txtrecontra;
        internal System.Windows.Forms.TextBox txtContrasenia;
        internal System.Windows.Forms.TextBox txtUsuario;
    }
}