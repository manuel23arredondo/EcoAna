namespace presentacion
{
    partial class frmPantallaP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaP));
            this.btnCierre = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.btnCuestionario = new System.Windows.Forms.Button();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.btnMiProgreso = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblEcoP = new System.Windows.Forms.Label();
            this.pcbLogoP = new System.Windows.Forms.PictureBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lnsHead = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lnsFoot = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lnsPie = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lnsDivision = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lblConsejo = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoP)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCierre
            // 
            this.btnCierre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCierre.Location = new System.Drawing.Point(592, 450);
            this.btnCierre.Margin = new System.Windows.Forms.Padding(2);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(56, 19);
            this.btnCierre.TabIndex = 0;
            this.btnCierre.Text = "Salir";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(242)))), ((int)(((byte)(107)))));
            this.pnlMenu.Controls.Add(this.lblConsejo);
            this.pnlMenu.Controls.Add(this.lblInfo2);
            this.pnlMenu.Controls.Add(this.lblInfo1);
            this.pnlMenu.Controls.Add(this.btnCuestionario);
            this.pnlMenu.Controls.Add(this.btnAcerca);
            this.pnlMenu.Controls.Add(this.btnMiProgreso);
            this.pnlMenu.Controls.Add(this.btnBitacora);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.lblEcoP);
            this.pnlMenu.Controls.Add(this.pcbLogoP);
            this.pnlMenu.Controls.Add(this.shapeContainer2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(160, 480);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.ForeColor = System.Drawing.Color.White;
            this.lblInfo2.Location = new System.Drawing.Point(9, 456);
            this.lblInfo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(138, 13);
            this.lblInfo2.TabIndex = 10;
            this.lblInfo2.Text = "de Aplicación General 2020";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.ForeColor = System.Drawing.Color.White;
            this.lblInfo1.Location = new System.Drawing.Point(9, 442);
            this.lblInfo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(101, 13);
            this.lblInfo1.TabIndex = 9;
            this.lblInfo1.Text = "Lenguajes Visuales ";
            // 
            // btnCuestionario
            // 
            this.btnCuestionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuestionario.FlatAppearance.BorderSize = 0;
            this.btnCuestionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCuestionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuestionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuestionario.ForeColor = System.Drawing.Color.White;
            this.btnCuestionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCuestionario.Image")));
            this.btnCuestionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuestionario.Location = new System.Drawing.Point(0, 300);
            this.btnCuestionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnCuestionario.Name = "btnCuestionario";
            this.btnCuestionario.Size = new System.Drawing.Size(160, 48);
            this.btnCuestionario.TabIndex = 7;
            this.btnCuestionario.Text = "Contribución";
            this.btnCuestionario.UseVisualStyleBackColor = true;
            this.btnCuestionario.Click += new System.EventHandler(this.btnCuestionario_Click);
            // 
            // btnAcerca
            // 
            this.btnAcerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcerca.FlatAppearance.BorderSize = 0;
            this.btnAcerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.ForeColor = System.Drawing.Color.White;
            this.btnAcerca.Image = ((System.Drawing.Image)(resources.GetObject("btnAcerca.Image")));
            this.btnAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcerca.Location = new System.Drawing.Point(0, 254);
            this.btnAcerca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(160, 50);
            this.btnAcerca.TabIndex = 6;
            this.btnAcerca.Text = "About Us";
            this.btnAcerca.UseVisualStyleBackColor = true;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // btnMiProgreso
            // 
            this.btnMiProgreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiProgreso.FlatAppearance.BorderSize = 0;
            this.btnMiProgreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMiProgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiProgreso.ForeColor = System.Drawing.Color.White;
            this.btnMiProgreso.Image = ((System.Drawing.Image)(resources.GetObject("btnMiProgreso.Image")));
            this.btnMiProgreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiProgreso.Location = new System.Drawing.Point(0, 210);
            this.btnMiProgreso.Margin = new System.Windows.Forms.Padding(2);
            this.btnMiProgreso.Name = "btnMiProgreso";
            this.btnMiProgreso.Size = new System.Drawing.Size(160, 48);
            this.btnMiProgreso.TabIndex = 5;
            this.btnMiProgreso.Text = "Mi Progreso";
            this.btnMiProgreso.UseVisualStyleBackColor = true;
            this.btnMiProgreso.Click += new System.EventHandler(this.btnMiProgreso_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBitacora.FlatAppearance.BorderSize = 0;
            this.btnBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBitacora.ForeColor = System.Drawing.Color.White;
            this.btnBitacora.Image = ((System.Drawing.Image)(resources.GetObject("btnBitacora.Image")));
            this.btnBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacora.Location = new System.Drawing.Point(0, 165);
            this.btnBitacora.Margin = new System.Windows.Forms.Padding(2);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(160, 48);
            this.btnBitacora.TabIndex = 4;
            this.btnBitacora.Text = "Bitacora";
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 119);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(160, 48);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblEcoP
            // 
            this.lblEcoP.AutoSize = true;
            this.lblEcoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(242)))), ((int)(((byte)(107)))));
            this.lblEcoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcoP.ForeColor = System.Drawing.Color.White;
            this.lblEcoP.Location = new System.Drawing.Point(21, 72);
            this.lblEcoP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEcoP.Name = "lblEcoP";
            this.lblEcoP.Size = new System.Drawing.Size(130, 24);
            this.lblEcoP.TabIndex = 2;
            this.lblEcoP.Text = "Eco-Analizer";
            // 
            // pcbLogoP
            // 
            this.pcbLogoP.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogoP.Image")));
            this.pcbLogoP.Location = new System.Drawing.Point(54, 9);
            this.pcbLogoP.Margin = new System.Windows.Forms.Padding(2);
            this.pcbLogoP.Name = "pcbLogoP";
            this.pcbLogoP.Size = new System.Drawing.Size(56, 54);
            this.pcbLogoP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogoP.TabIndex = 1;
            this.pcbLogoP.TabStop = false;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lnsHead,
            this.lnsFoot,
            this.lnsPie,
            this.lnsDivision});
            this.shapeContainer2.Size = new System.Drawing.Size(160, 480);
            this.shapeContainer2.TabIndex = 8;
            this.shapeContainer2.TabStop = false;
            // 
            // lnsHead
            // 
            this.lnsHead.BorderColor = System.Drawing.Color.White;
            this.lnsHead.BorderWidth = 3;
            this.lnsHead.Name = "lnsHead";
            this.lnsHead.X1 = 9;
            this.lnsHead.X2 = 152;
            this.lnsHead.Y1 = 102;
            this.lnsHead.Y2 = 102;
            // 
            // lnsFoot
            // 
            this.lnsFoot.BorderColor = System.Drawing.Color.White;
            this.lnsFoot.Name = "lnsFoot";
            this.lnsFoot.X1 = 9;
            this.lnsFoot.X2 = 152;
            this.lnsFoot.Y1 = 435;
            this.lnsFoot.Y2 = 435;
            // 
            // lnsPie
            // 
            this.lnsPie.BorderColor = System.Drawing.Color.White;
            this.lnsPie.Enabled = false;
            this.lnsPie.Name = "lnsPie";
            this.lnsPie.X1 = 6;
            this.lnsPie.X2 = 207;
            this.lnsPie.Y1 = 535;
            this.lnsPie.Y2 = 535;
            // 
            // lnsDivision
            // 
            this.lnsDivision.BorderColor = System.Drawing.Color.White;
            this.lnsDivision.BorderWidth = 2;
            this.lnsDivision.Enabled = false;
            this.lnsDivision.Name = "lnsDivision";
            this.lnsDivision.X1 = 5;
            this.lnsDivision.X2 = 206;
            this.lnsDivision.Y1 = 134;
            this.lnsDivision.Y2 = 134;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.btnCierre);
            this.pnlContenedor.Location = new System.Drawing.Point(160, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(659, 480);
            this.pnlContenedor.TabIndex = 2;
            // 
            // lblConsejo
            // 
            this.lblConsejo.AutoSize = true;
            this.lblConsejo.ForeColor = System.Drawing.Color.White;
            this.lblConsejo.Location = new System.Drawing.Point(5, 372);
            this.lblConsejo.Name = "lblConsejo";
            this.lblConsejo.Size = new System.Drawing.Size(152, 26);
            this.lblConsejo.TabIndex = 11;
            this.lblConsejo.Text = "Da un click aquí para generar \r\nun consejo aleatorio";
            this.lblConsejo.Click += new System.EventHandler(this.lblConsejo_Click);
            // 
            // frmPantallaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCierre;
            this.ClientSize = new System.Drawing.Size(819, 480);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPantallaP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPantallaP";
            this.Load += new System.EventHandler(this.frmPantallaP_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoP)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pcbLogoP;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnMiProgreso;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblEcoP;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnCuestionario;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnsDivision;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnsPie;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnsHead;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnsFoot;
        private System.Windows.Forms.Label lblConsejo;
    }
}