namespace presentacion
{
    partial class frmMiProgreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiProgreso));
            this.btnCierre = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblCNombre = new System.Windows.Forms.Label();
            this.lblCEdad = new System.Windows.Forms.Label();
            this.lblCCiudad = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.pnlPorcentaje = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMetricas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCierre
            // 
            this.btnCierre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCierre.FlatAppearance.BorderSize = 2;
            this.btnCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierre.Font = new System.Drawing.Font("Roboto Lt", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierre.ForeColor = System.Drawing.Color.White;
            this.btnCierre.Location = new System.Drawing.Point(362, 543);
            this.btnCierre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(111, 37);
            this.btnCierre.TabIndex = 1;
            this.btnCierre.Text = "Salir";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(830, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(852, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(15, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Keep Calm Med", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 108);
            this.label2.TabIndex = 17;
            this.label2.Text = "79%";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(51, 446);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(160, 30);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Alexander F.";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(265, 446);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(39, 30);
            this.lblEdad.TabIndex = 19;
            this.lblEdad.Text = "23";
            // 
            // lblCNombre
            // 
            this.lblCNombre.AutoSize = true;
            this.lblCNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblCNombre.Location = new System.Drawing.Point(52, 425);
            this.lblCNombre.Name = "lblCNombre";
            this.lblCNombre.Size = new System.Drawing.Size(82, 21);
            this.lblCNombre.TabIndex = 20;
            this.lblCNombre.Text = "Nombre:";
            // 
            // lblCEdad
            // 
            this.lblCEdad.AutoSize = true;
            this.lblCEdad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEdad.ForeColor = System.Drawing.Color.DimGray;
            this.lblCEdad.Location = new System.Drawing.Point(266, 425);
            this.lblCEdad.Name = "lblCEdad";
            this.lblCEdad.Size = new System.Drawing.Size(60, 21);
            this.lblCEdad.TabIndex = 21;
            this.lblCEdad.Text = "Edad:";
            // 
            // lblCCiudad
            // 
            this.lblCCiudad.AutoSize = true;
            this.lblCCiudad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCiudad.ForeColor = System.Drawing.Color.DimGray;
            this.lblCCiudad.Location = new System.Drawing.Point(56, 486);
            this.lblCCiudad.Name = "lblCCiudad";
            this.lblCCiudad.Size = new System.Drawing.Size(78, 21);
            this.lblCCiudad.TabIndex = 22;
            this.lblCCiudad.Text = "Ciudad:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(56, 507);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(80, 23);
            this.lblCiudad.TabIndex = 23;
            this.lblCiudad.Text = "Puebla";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Green;
            this.lblUsuario.Location = new System.Drawing.Point(87, 372);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(200, 34);
            this.lblUsuario.TabIndex = 24;
            this.lblUsuario.Text = "AlexanderF23";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(219)))), ((int)(((byte)(104)))));
            this.pnlDatos.Controls.Add(this.lblMetricas);
            this.pnlDatos.Controls.Add(this.panel4);
            this.pnlDatos.Controls.Add(this.panel3);
            this.pnlDatos.Controls.Add(this.panel2);
            this.pnlDatos.Controls.Add(this.panel1);
            this.pnlDatos.Controls.Add(this.pnlPorcentaje);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.btnCierre);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDatos.Location = new System.Drawing.Point(394, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(485, 591);
            this.pnlDatos.TabIndex = 25;
            // 
            // pnlPorcentaje
            // 
            this.pnlPorcentaje.BackColor = System.Drawing.Color.White;
            this.pnlPorcentaje.Location = new System.Drawing.Point(20, 110);
            this.pnlPorcentaje.Name = "pnlPorcentaje";
            this.pnlPorcentaje.Size = new System.Drawing.Size(375, 46);
            this.pnlPorcentaje.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Location = new System.Drawing.Point(104, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 155);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Location = new System.Drawing.Point(167, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 202);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Location = new System.Drawing.Point(230, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 185);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel4.Location = new System.Drawing.Point(293, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(57, 218);
            this.panel4.TabIndex = 20;
            // 
            // lblMetricas
            // 
            this.lblMetricas.AutoSize = true;
            this.lblMetricas.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricas.ForeColor = System.Drawing.Color.White;
            this.lblMetricas.Location = new System.Drawing.Point(149, 446);
            this.lblMetricas.Name = "lblMetricas";
            this.lblMetricas.Size = new System.Drawing.Size(158, 40);
            this.lblMetricas.TabIndex = 26;
            this.lblMetricas.Text = "Metricas";
            // 
            // frmMiProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 591);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblCCiudad);
            this.Controls.Add(this.lblCEdad);
            this.Controls.Add(this.lblCNombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMiProgreso";
            this.Text = "FormMiProgreso";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblCNombre;
        private System.Windows.Forms.Label lblCEdad;
        private System.Windows.Forms.Label lblCCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel pnlPorcentaje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMetricas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}