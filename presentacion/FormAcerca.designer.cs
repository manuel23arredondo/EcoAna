namespace presentacion
{
    partial class FormAcerca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcerca));
            this.btnCierre = new System.Windows.Forms.Button();
            this.pctFondo = new System.Windows.Forms.PictureBox();
            this.lblAcerca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCierre
            // 
            this.btnCierre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCierre.Location = new System.Drawing.Point(592, 450);
            this.btnCierre.Margin = new System.Windows.Forms.Padding(2);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(56, 19);
            this.btnCierre.TabIndex = 2;
            this.btnCierre.Text = "Salir";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // pctFondo
            // 
            this.pctFondo.Image = ((System.Drawing.Image)(resources.GetObject("pctFondo.Image")));
            this.pctFondo.Location = new System.Drawing.Point(-1, 0);
            this.pctFondo.Name = "pctFondo";
            this.pctFondo.Size = new System.Drawing.Size(659, 480);
            this.pctFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFondo.TabIndex = 3;
            this.pctFondo.TabStop = false;
            // 
            // lblAcerca
            // 
            this.lblAcerca.AutoSize = true;
            this.lblAcerca.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAcerca.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcerca.ForeColor = System.Drawing.Color.White;
            this.lblAcerca.Location = new System.Drawing.Point(22, 52);
            this.lblAcerca.Name = "lblAcerca";
            this.lblAcerca.Size = new System.Drawing.Size(316, 342);
            this.lblAcerca.TabIndex = 4;
            this.lblAcerca.Text = resources.GetString("lblAcerca.Text");
            // 
            // FormAcerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 480);
            this.Controls.Add(this.lblAcerca);
            this.Controls.Add(this.btnCierre);
            this.Controls.Add(this.pctFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAcerca";
            this.Text = "FormAcerca";
            ((System.ComponentModel.ISupportInitialize)(this.pctFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.PictureBox pctFondo;
        private System.Windows.Forms.Label lblAcerca;
    }
}