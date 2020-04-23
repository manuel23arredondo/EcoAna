namespace presentacion
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlImagenLogo = new System.Windows.Forms.Panel();
            this.lblEco = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lnsContra = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lnsUsuario = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblRegistrarse = new System.Windows.Forms.LinkLabel();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.pcbContra = new System.Windows.Forms.PictureBox();
            this.pcbContraEyeC = new System.Windows.Forms.PictureBox();
            this.pcbContraEyeO = new System.Windows.Forms.PictureBox();
            this.pnlImagenLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContraEyeC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContraEyeO)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImagenLogo
            // 
            this.pnlImagenLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(242)))), ((int)(((byte)(107)))));
            this.pnlImagenLogo.Controls.Add(this.lblEco);
            this.pnlImagenLogo.Controls.Add(this.pcbLogo);
            this.pnlImagenLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImagenLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlImagenLogo.Name = "pnlImagenLogo";
            this.pnlImagenLogo.Size = new System.Drawing.Size(248, 307);
            this.pnlImagenLogo.TabIndex = 4;
            this.pnlImagenLogo.Click += new System.EventHandler(this.pnlImagenLogo_Click);
            // 
            // lblEco
            // 
            this.lblEco.AutoSize = true;
            this.lblEco.Font = new System.Drawing.Font("Keep Calm Med", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEco.ForeColor = System.Drawing.Color.White;
            this.lblEco.Location = new System.Drawing.Point(51, 175);
            this.lblEco.Name = "lblEco";
            this.lblEco.Size = new System.Drawing.Size(151, 25);
            this.lblEco.TabIndex = 1;
            this.lblEco.Text = "Eco-Analizer";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(86, 105);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(75, 67);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lnsContra,
            this.lnsUsuario});
            this.shapeContainer1.Size = new System.Drawing.Size(750, 307);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lnsContra
            // 
            this.lnsContra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnsContra.BorderColor = System.Drawing.Color.DimGray;
            this.lnsContra.Enabled = false;
            this.lnsContra.Name = "lnsContra";
            this.lnsContra.X1 = 311;
            this.lnsContra.X2 = 674;
            this.lnsContra.Y1 = 175;
            this.lnsContra.Y2 = 175;
            // 
            // lnsUsuario
            // 
            this.lnsUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnsUsuario.BorderColor = System.Drawing.Color.DimGray;
            this.lnsUsuario.Enabled = false;
            this.lnsUsuario.Name = "lnsUsuario";
            this.lnsUsuario.X1 = 312;
            this.lnsUsuario.X2 = 675;
            this.lnsUsuario.Y1 = 104;
            this.lnsUsuario.Y2 = 104;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(352, 76);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(311, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContra
            // 
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.Color.DimGray;
            this.txtContra.Location = new System.Drawing.Point(352, 147);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(311, 20);
            this.txtContra.TabIndex = 1;
            this.txtContra.Text = "Contraseña";
            this.txtContra.Enter += new System.EventHandler(this.txtContra_Enter);
            this.txtContra.Leave += new System.EventHandler(this.txtContra_Leave);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Keep Calm Med", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(434, 19);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(97, 30);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "LOGIN";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(219)))), ((int)(((byte)(104)))));
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(110)))), ((int)(((byte)(45)))));
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(159)))), ((int)(((byte)(61)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Roboto Lt", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(375, 223);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(239, 42);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(723, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(15, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(701, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(311, 191);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(180, 13);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Error: Usuario o contraseña inválidos";
            this.lblError.Visible = false;
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrarse.LinkColor = System.Drawing.Color.ForestGreen;
            this.lblRegistrarse.Location = new System.Drawing.Point(411, 285);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(174, 13);
            this.lblRegistrarse.TabIndex = 2;
            this.lblRegistrarse.TabStop = true;
            this.lblRegistrarse.Text = "¿No tienes una cuenta? Regístrate";
            this.lblRegistrarse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblRegistrarse.Click += new System.EventHandler(this.lblRegistrarse_Click);
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pcbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pcbUsuario.Image")));
            this.pcbUsuario.Location = new System.Drawing.Point(314, 65);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(34, 36);
            this.pcbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUsuario.TabIndex = 14;
            this.pcbUsuario.TabStop = false;
            this.pcbUsuario.Click += new System.EventHandler(this.pcbUsuario_Click);
            // 
            // pcbContra
            // 
            this.pcbContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pcbContra.Image = ((System.Drawing.Image)(resources.GetObject("pcbContra.Image")));
            this.pcbContra.Location = new System.Drawing.Point(314, 141);
            this.pcbContra.Name = "pcbContra";
            this.pcbContra.Size = new System.Drawing.Size(34, 31);
            this.pcbContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbContra.TabIndex = 15;
            this.pcbContra.TabStop = false;
            this.pcbContra.Click += new System.EventHandler(this.pcbContra_Click);
            // 
            // pcbContraEyeC
            // 
            this.pcbContraEyeC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbContraEyeC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbContraEyeC.Image = ((System.Drawing.Image)(resources.GetObject("pcbContraEyeC.Image")));
            this.pcbContraEyeC.Location = new System.Drawing.Point(641, 141);
            this.pcbContraEyeC.Name = "pcbContraEyeC";
            this.pcbContraEyeC.Size = new System.Drawing.Size(34, 31);
            this.pcbContraEyeC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbContraEyeC.TabIndex = 16;
            this.pcbContraEyeC.TabStop = false;
            this.pcbContraEyeC.Click += new System.EventHandler(this.pcbContraEyeC_Click);
            // 
            // pcbContraEyeO
            // 
            this.pcbContraEyeO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbContraEyeO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbContraEyeO.Image = ((System.Drawing.Image)(resources.GetObject("pcbContraEyeO.Image")));
            this.pcbContraEyeO.Location = new System.Drawing.Point(638, 137);
            this.pcbContraEyeO.Name = "pcbContraEyeO";
            this.pcbContraEyeO.Size = new System.Drawing.Size(40, 38);
            this.pcbContraEyeO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbContraEyeO.TabIndex = 17;
            this.pcbContraEyeO.TabStop = false;
            this.pcbContraEyeO.Click += new System.EventHandler(this.pcbContraEyeO_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIniciar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(750, 307);
            this.Controls.Add(this.pcbContraEyeO);
            this.Controls.Add(this.pcbContraEyeC);
            this.Controls.Add(this.pcbContra);
            this.Controls.Add(this.pcbUsuario);
            this.Controls.Add(this.lblRegistrarse);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.pnlImagenLogo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Click += new System.EventHandler(this.frmLogin_Click);
            this.pnlImagenLogo.ResumeLayout(false);
            this.pnlImagenLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContraEyeC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContraEyeO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImagenLogo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnsUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label lblEco;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.LinkLabel lblRegistrarse;
        private System.Windows.Forms.PictureBox pcbUsuario;
        private System.Windows.Forms.PictureBox pcbContra;
        private System.Windows.Forms.PictureBox pcbContraEyeC;
        private System.Windows.Forms.PictureBox pcbContraEyeO;
        protected Microsoft.VisualBasic.PowerPacks.LineShape lnsContra;
    }
}

