namespace C__Nutriologia.Formularios.Consultas
{
    partial class Citas
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
            this.Label1 = new System.Windows.Forms.Label();
            this.lbAlimentos = new System.Windows.Forms.Label();
            this.lb_Año = new System.Windows.Forms.Label();
            this.lb_mes = new System.Windows.Forms.Label();
            this.lb_Dia = new System.Windows.Forms.Label();
            this.tb_año = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_Dia = new System.Windows.Forms.TextBox();
            this.DGV_Citas = new System.Windows.Forms.DataGridView();
            this.lb_ID_Paciente = new System.Windows.Forms.Label();
            this.tb_ID_Paciente = new System.Windows.Forms.TextBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.tb_Cita = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.DGV_Pacientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Citas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(306, 213);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(260, 29);
            this.Label1.TabIndex = 133;
            this.Label1.Text = "Citas";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAlimentos
            // 
            this.lbAlimentos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlimentos.Location = new System.Drawing.Point(306, 18);
            this.lbAlimentos.Name = "lbAlimentos";
            this.lbAlimentos.Size = new System.Drawing.Size(260, 29);
            this.lbAlimentos.TabIndex = 132;
            this.lbAlimentos.Text = "Pacientes";
            this.lbAlimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Año
            // 
            this.lb_Año.AutoSize = true;
            this.lb_Año.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Año.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Año.Location = new System.Drawing.Point(200, 161);
            this.lb_Año.Name = "lb_Año";
            this.lb_Año.Size = new System.Drawing.Size(38, 20);
            this.lb_Año.TabIndex = 131;
            this.lb_Año.Text = "Año";
            // 
            // lb_mes
            // 
            this.lb_mes.AutoSize = true;
            this.lb_mes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mes.Location = new System.Drawing.Point(95, 161);
            this.lb_mes.Name = "lb_mes";
            this.lb_mes.Size = new System.Drawing.Size(39, 20);
            this.lb_mes.TabIndex = 130;
            this.lb_mes.Text = "Mes";
            // 
            // lb_Dia
            // 
            this.lb_Dia.AutoSize = true;
            this.lb_Dia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dia.Location = new System.Drawing.Point(0, 161);
            this.lb_Dia.Name = "lb_Dia";
            this.lb_Dia.Size = new System.Drawing.Size(33, 20);
            this.lb_Dia.TabIndex = 129;
            this.lb_Dia.Text = "Dia";
            // 
            // tb_año
            // 
            this.tb_año.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_año.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_año.Location = new System.Drawing.Point(244, 158);
            this.tb_año.MaxLength = 4;
            this.tb_año.Name = "tb_año";
            this.tb_año.Size = new System.Drawing.Size(42, 26);
            this.tb_año.TabIndex = 128;
            // 
            // tb_mes
            // 
            this.tb_mes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mes.Location = new System.Drawing.Point(140, 158);
            this.tb_mes.MaxLength = 2;
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(42, 26);
            this.tb_mes.TabIndex = 127;
            // 
            // tb_Dia
            // 
            this.tb_Dia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Dia.Location = new System.Drawing.Point(39, 158);
            this.tb_Dia.MaxLength = 2;
            this.tb_Dia.Name = "tb_Dia";
            this.tb_Dia.Size = new System.Drawing.Size(42, 26);
            this.tb_Dia.TabIndex = 126;
            // 
            // DGV_Citas
            // 
            this.DGV_Citas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Citas.Location = new System.Drawing.Point(306, 235);
            this.DGV_Citas.MultiSelect = false;
            this.DGV_Citas.Name = "DGV_Citas";
            this.DGV_Citas.ReadOnly = true;
            this.DGV_Citas.Size = new System.Drawing.Size(260, 153);
            this.DGV_Citas.TabIndex = 125;
            // 
            // lb_ID_Paciente
            // 
            this.lb_ID_Paciente.AutoSize = true;
            this.lb_ID_Paciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_ID_Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID_Paciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_ID_Paciente.Location = new System.Drawing.Point(19, 91);
            this.lb_ID_Paciente.Name = "lb_ID_Paciente";
            this.lb_ID_Paciente.Size = new System.Drawing.Size(92, 20);
            this.lb_ID_Paciente.TabIndex = 124;
            this.lb_ID_Paciente.Text = "ID Paciente";
            // 
            // tb_ID_Paciente
            // 
            this.tb_ID_Paciente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_ID_Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID_Paciente.Location = new System.Drawing.Point(117, 88);
            this.tb_ID_Paciente.MaxLength = 3;
            this.tb_ID_Paciente.Name = "tb_ID_Paciente";
            this.tb_ID_Paciente.ReadOnly = true;
            this.tb_ID_Paciente.Size = new System.Drawing.Size(42, 26);
            this.tb_ID_Paciente.TabIndex = 123;
            this.tb_ID_Paciente.TabStop = false;
            this.tb_ID_Paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_ID_Paciente.WordWrap = false;
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_ID.Location = new System.Drawing.Point(65, 123);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(46, 20);
            this.lb_ID.TabIndex = 122;
            this.lb_ID.Text = "#Cita";
            // 
            // tb_Cita
            // 
            this.tb_Cita.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_Cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cita.Location = new System.Drawing.Point(117, 120);
            this.tb_Cita.MaxLength = 3;
            this.tb_Cita.Name = "tb_Cita";
            this.tb_Cita.Size = new System.Drawing.Size(42, 26);
            this.tb_Cita.TabIndex = 121;
            this.tb_Cita.TabStop = false;
            this.tb_Cita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Cita.WordWrap = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(150, 331);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(120, 45);
            this.btCancelar.TabIndex = 120;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            this.btEliminar.Enabled = false;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(4, 331);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(120, 45);
            this.btEliminar.TabIndex = 119;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Visible = false;
            // 
            // btModificar
            // 
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(150, 270);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(120, 45);
            this.btModificar.TabIndex = 118;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(4, 270);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(120, 45);
            this.btAgregar.TabIndex = 117;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(6, 11);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(120, 45);
            this.btRegresar.TabIndex = 116;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // DGV_Pacientes
            // 
            this.DGV_Pacientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Pacientes.Location = new System.Drawing.Point(306, 46);
            this.DGV_Pacientes.MultiSelect = false;
            this.DGV_Pacientes.Name = "DGV_Pacientes";
            this.DGV_Pacientes.ReadOnly = true;
            this.DGV_Pacientes.Size = new System.Drawing.Size(260, 153);
            this.DGV_Pacientes.TabIndex = 115;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 414);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lbAlimentos);
            this.Controls.Add(this.lb_Año);
            this.Controls.Add(this.lb_mes);
            this.Controls.Add(this.lb_Dia);
            this.Controls.Add(this.tb_año);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_Dia);
            this.Controls.Add(this.DGV_Citas);
            this.Controls.Add(this.lb_ID_Paciente);
            this.Controls.Add(this.tb_ID_Paciente);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.tb_Cita);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.DGV_Pacientes);
            this.Name = "Citas";
            this.Text = "Citas";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Citas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lbAlimentos;
        internal System.Windows.Forms.Label lb_Año;
        internal System.Windows.Forms.Label lb_mes;
        internal System.Windows.Forms.Label lb_Dia;
        internal System.Windows.Forms.TextBox tb_año;
        internal System.Windows.Forms.TextBox tb_mes;
        internal System.Windows.Forms.TextBox tb_Dia;
        internal System.Windows.Forms.DataGridView DGV_Citas;
        internal System.Windows.Forms.Label lb_ID_Paciente;
        internal System.Windows.Forms.TextBox tb_ID_Paciente;
        internal System.Windows.Forms.Label lb_ID;
        internal System.Windows.Forms.TextBox tb_Cita;
        internal System.Windows.Forms.Button btCancelar;
        internal System.Windows.Forms.Button btEliminar;
        internal System.Windows.Forms.Button btModificar;
        internal System.Windows.Forms.Button btAgregar;
        internal System.Windows.Forms.Button btRegresar;
        internal System.Windows.Forms.DataGridView DGV_Pacientes;
    }
}