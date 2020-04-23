namespace presentacion
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.btnCierre = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblPaBitacora = new System.Windows.Forms.Label();
            this.lblBitacora = new System.Windows.Forms.Label();
            this.lblMiProgreso = new System.Windows.Forms.Label();
            this.lblPaMiProgreso = new System.Windows.Forms.Label();
            this.lblAcerca = new System.Windows.Forms.Label();
            this.lblPaAcerca = new System.Windows.Forms.Label();
            this.lblHuella = new System.Windows.Forms.Label();
            this.lblPaHuella = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCierre
            // 
            this.btnCierre.BackColor = System.Drawing.Color.IndianRed;
            this.btnCierre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCierre.FlatAppearance.BorderSize = 0;
            this.btnCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierre.Font = new System.Drawing.Font("Roboto Lt", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierre.ForeColor = System.Drawing.Color.White;
            this.btnCierre.Location = new System.Drawing.Point(755, 547);
            this.btnCierre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(112, 33);
            this.btnCierre.TabIndex = 2;
            this.btnCierre.Text = "Salir";
            this.btnCierre.UseVisualStyleBackColor = false;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitulo.Font = new System.Drawing.Font("Keep Calm Med", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(450, 81);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Bienvenido a";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblTitulo2);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 199);
            this.panel1.TabIndex = 14;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitulo2.Font = new System.Drawing.Font("Keep Calm Med", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(12, 99);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(489, 81);
            this.lblTitulo2.TabIndex = 4;
            this.lblTitulo2.Text = "Eco - Analizer";
            // 
            // lblPaBitacora
            // 
            this.lblPaBitacora.AutoSize = true;
            this.lblPaBitacora.BackColor = System.Drawing.SystemColors.Window;
            this.lblPaBitacora.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaBitacora.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPaBitacora.Location = new System.Drawing.Point(218, 246);
            this.lblPaBitacora.Name = "lblPaBitacora";
            this.lblPaBitacora.Size = new System.Drawing.Size(415, 22);
            this.lblPaBitacora.TabIndex = 15;
            this.lblPaBitacora.Text = "Visita la bitácora para registrar tus progresos";
            // 
            // lblBitacora
            // 
            this.lblBitacora.AutoSize = true;
            this.lblBitacora.BackColor = System.Drawing.SystemColors.Window;
            this.lblBitacora.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitacora.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblBitacora.Location = new System.Drawing.Point(366, 218);
            this.lblBitacora.Name = "lblBitacora";
            this.lblBitacora.Size = new System.Drawing.Size(109, 28);
            this.lblBitacora.TabIndex = 16;
            this.lblBitacora.Text = "Bitácora";
            // 
            // lblMiProgreso
            // 
            this.lblMiProgreso.AutoSize = true;
            this.lblMiProgreso.BackColor = System.Drawing.SystemColors.Window;
            this.lblMiProgreso.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiProgreso.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMiProgreso.Location = new System.Drawing.Point(355, 301);
            this.lblMiProgreso.Name = "lblMiProgreso";
            this.lblMiProgreso.Size = new System.Drawing.Size(148, 28);
            this.lblMiProgreso.TabIndex = 17;
            this.lblMiProgreso.Text = "Mi Progreso";
            // 
            // lblPaMiProgreso
            // 
            this.lblPaMiProgreso.AutoSize = true;
            this.lblPaMiProgreso.BackColor = System.Drawing.SystemColors.Window;
            this.lblPaMiProgreso.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaMiProgreso.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPaMiProgreso.Location = new System.Drawing.Point(166, 329);
            this.lblPaMiProgreso.Name = "lblPaMiProgreso";
            this.lblPaMiProgreso.Size = new System.Drawing.Size(531, 22);
            this.lblPaMiProgreso.TabIndex = 18;
            this.lblPaMiProgreso.Text = "Aquí encontrarás tu avance semanal de tu contribución";
            // 
            // lblAcerca
            // 
            this.lblAcerca.AutoSize = true;
            this.lblAcerca.BackColor = System.Drawing.SystemColors.Window;
            this.lblAcerca.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcerca.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAcerca.Location = new System.Drawing.Point(366, 389);
            this.lblAcerca.Name = "lblAcerca";
            this.lblAcerca.Size = new System.Drawing.Size(137, 28);
            this.lblAcerca.TabIndex = 19;
            this.lblAcerca.Text = "Acerca de";
            // 
            // lblPaAcerca
            // 
            this.lblPaAcerca.AutoSize = true;
            this.lblPaAcerca.BackColor = System.Drawing.SystemColors.Window;
            this.lblPaAcerca.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaAcerca.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPaAcerca.Location = new System.Drawing.Point(107, 417);
            this.lblPaAcerca.Name = "lblPaAcerca";
            this.lblPaAcerca.Size = new System.Drawing.Size(639, 22);
            this.lblPaAcerca.TabIndex = 20;
            this.lblPaAcerca.Text = "Aquí encontrarás información sobre el proyecto y los desarrolladores ";
            // 
            // lblHuella
            // 
            this.lblHuella.AutoSize = true;
            this.lblHuella.BackColor = System.Drawing.SystemColors.Window;
            this.lblHuella.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuella.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblHuella.Location = new System.Drawing.Point(335, 475);
            this.lblHuella.Name = "lblHuella";
            this.lblHuella.Size = new System.Drawing.Size(208, 28);
            this.lblHuella.TabIndex = 21;
            this.lblHuella.Text = "Huella Ecológica";
            // 
            // lblPaHuella
            // 
            this.lblPaHuella.AutoSize = true;
            this.lblPaHuella.BackColor = System.Drawing.SystemColors.Window;
            this.lblPaHuella.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaHuella.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPaHuella.Location = new System.Drawing.Point(182, 503);
            this.lblPaHuella.Name = "lblPaHuella";
            this.lblPaHuella.Size = new System.Drawing.Size(493, 22);
            this.lblPaHuella.TabIndex = 22;
            this.lblPaHuella.Text = "Visita nuestro cuestionario para iniciar tu seguimiento";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 591);
            this.Controls.Add(this.lblPaHuella);
            this.Controls.Add(this.lblHuella);
            this.Controls.Add(this.lblPaAcerca);
            this.Controls.Add(this.lblAcerca);
            this.Controls.Add(this.lblPaMiProgreso);
            this.Controls.Add(this.lblMiProgreso);
            this.Controls.Add(this.lblBitacora);
            this.Controls.Add(this.lblPaBitacora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCierre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblPaBitacora;
        private System.Windows.Forms.Label lblBitacora;
        private System.Windows.Forms.Label lblMiProgreso;
        private System.Windows.Forms.Label lblPaMiProgreso;
        private System.Windows.Forms.Label lblAcerca;
        private System.Windows.Forms.Label lblPaAcerca;
        private System.Windows.Forms.Label lblHuella;
        private System.Windows.Forms.Label lblPaHuella;
    }
}