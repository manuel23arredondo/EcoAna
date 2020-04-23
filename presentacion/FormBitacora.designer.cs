namespace presentacion
{
    partial class FormBitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBitacora));
            this.btnCierre = new System.Windows.Forms.Button();
            this.lblBitacora = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ptrFondo = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDividir = new System.Windows.Forms.Panel();
            this.rdbCamino = new System.Windows.Forms.RadioButton();
            this.rdbCamion = new System.Windows.Forms.RadioButton();
            this.rdbCarro = new System.Windows.Forms.RadioButton();
            this.lbl = new System.Windows.Forms.Label();
            this.lblBolsas = new System.Windows.Forms.Label();
            this.pnlBolsas = new System.Windows.Forms.Panel();
            this.rdbNegacion = new System.Windows.Forms.RadioButton();
            this.rdbNegar = new System.Windows.Forms.RadioButton();
            this.rdbAfirmar = new System.Windows.Forms.RadioButton();
            this.lblArbol = new System.Windows.Forms.Label();
            this.pnlArbol = new System.Windows.Forms.Panel();
            this.rdbNoo = new System.Windows.Forms.RadioButton();
            this.rdbJa = new System.Windows.Forms.RadioButton();
            this.lblReciclar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbNada = new System.Windows.Forms.RadioButton();
            this.rdbPoco = new System.Windows.Forms.RadioButton();
            this.rdbParcial = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFondo)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDividir.SuspendLayout();
            this.pnlBolsas.SuspendLayout();
            this.pnlArbol.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCierre
            // 
            this.btnCierre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCierre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierre.Location = new System.Drawing.Point(579, 414);
            this.btnCierre.Margin = new System.Windows.Forms.Padding(2);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(65, 27);
            this.btnCierre.TabIndex = 1;
            this.btnCierre.Text = "Salir";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // lblBitacora
            // 
            this.lblBitacora.AutoSize = true;
            this.lblBitacora.BackColor = System.Drawing.Color.Transparent;
            this.lblBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitacora.Location = new System.Drawing.Point(278, 36);
            this.lblBitacora.Name = "lblBitacora";
            this.lblBitacora.Size = new System.Drawing.Size(122, 33);
            this.lblBitacora.TabIndex = 3;
            this.lblBitacora.Text = "Bitacora";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(472, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ptrFondo
            // 
            this.ptrFondo.Image = ((System.Drawing.Image)(resources.GetObject("ptrFondo.Image")));
            this.ptrFondo.Location = new System.Drawing.Point(0, -1);
            this.ptrFondo.Name = "ptrFondo";
            this.ptrFondo.Size = new System.Drawing.Size(659, 480);
            this.ptrFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrFondo.TabIndex = 9;
            this.ptrFondo.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(14, 103);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(452, 15);
            this.lblBienvenido.TabIndex = 10;
            this.lblBienvenido.Text = "Bienvenido de nuevo, veamos tus avances, contesta las siguientes preguntas:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.radioButton1.Location = new System.Drawing.Point(10, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 22);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "No";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(10, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 22);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Si";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "1. El día de hoy al sacar la basura, ¿la clasificaste según tipo?";
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.BackColor = System.Drawing.Color.Transparent;
            this.lblTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransporte.Location = new System.Drawing.Point(36, 224);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(243, 15);
            this.lblTransporte.TabIndex = 13;
            this.lblTransporte.Text = "2. ¿Qué medio de transporte utilizaste hoy?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Font = new System.Drawing.Font("Roboto Bk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(56, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 47);
            this.panel1.TabIndex = 14;
            // 
            // pnlDividir
            // 
            this.pnlDividir.Controls.Add(this.rdbCamino);
            this.pnlDividir.Controls.Add(this.rdbCamion);
            this.pnlDividir.Controls.Add(this.rdbCarro);
            this.pnlDividir.Location = new System.Drawing.Point(56, 260);
            this.pnlDividir.Name = "pnlDividir";
            this.pnlDividir.Size = new System.Drawing.Size(82, 85);
            this.pnlDividir.TabIndex = 16;
            // 
            // rdbCamino
            // 
            this.rdbCamino.AutoSize = true;
            this.rdbCamino.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdbCamino.Location = new System.Drawing.Point(10, 57);
            this.rdbCamino.Name = "rdbCamino";
            this.rdbCamino.Size = new System.Drawing.Size(53, 19);
            this.rdbCamino.TabIndex = 2;
            this.rdbCamino.TabStop = true;
            this.rdbCamino.Text = "A pie";
            this.rdbCamino.UseVisualStyleBackColor = true;
            // 
            // rdbCamion
            // 
            this.rdbCamion.AutoSize = true;
            this.rdbCamion.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdbCamion.Location = new System.Drawing.Point(10, 30);
            this.rdbCamion.Name = "rdbCamion";
            this.rdbCamion.Size = new System.Drawing.Size(68, 19);
            this.rdbCamion.TabIndex = 1;
            this.rdbCamion.TabStop = true;
            this.rdbCamion.Text = "Camión";
            this.rdbCamion.UseVisualStyleBackColor = true;
            // 
            // rdbCarro
            // 
            this.rdbCarro.AutoSize = true;
            this.rdbCarro.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdbCarro.Location = new System.Drawing.Point(10, 3);
            this.rdbCarro.Name = "rdbCarro";
            this.rdbCarro.Size = new System.Drawing.Size(57, 19);
            this.rdbCarro.TabIndex = 0;
            this.rdbCarro.TabStop = true;
            this.rdbCarro.Text = "Carro";
            this.rdbCarro.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(51, 132);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(362, 16);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "El día de hoy al sacar la basura, ¿la clasificaste según tipo?";
            // 
            // lblBolsas
            // 
            this.lblBolsas.AutoSize = true;
            this.lblBolsas.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblBolsas.Location = new System.Drawing.Point(428, 133);
            this.lblBolsas.Name = "lblBolsas";
            this.lblBolsas.Size = new System.Drawing.Size(216, 15);
            this.lblBolsas.TabIndex = 17;
            this.lblBolsas.Text = "3. ¿Utilizaste bolsas de plástico hoy?";
            // 
            // pnlBolsas
            // 
            this.pnlBolsas.Controls.Add(this.rdbNegacion);
            this.pnlBolsas.Controls.Add(this.rdbNegar);
            this.pnlBolsas.Controls.Add(this.rdbAfirmar);
            this.pnlBolsas.Location = new System.Drawing.Point(444, 169);
            this.pnlBolsas.Name = "pnlBolsas";
            this.pnlBolsas.Size = new System.Drawing.Size(49, 55);
            this.pnlBolsas.TabIndex = 18;
            // 
            // rdbNegacion
            // 
            this.rdbNegacion.AutoSize = true;
            this.rdbNegacion.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdbNegacion.Location = new System.Drawing.Point(3, 32);
            this.rdbNegacion.Name = "rdbNegacion";
            this.rdbNegacion.Size = new System.Drawing.Size(41, 19);
            this.rdbNegacion.TabIndex = 2;
            this.rdbNegacion.TabStop = true;
            this.rdbNegacion.Text = "No";
            this.rdbNegacion.UseVisualStyleBackColor = true;
            // 
            // rdbNegar
            // 
            this.rdbNegar.AutoSize = true;
            this.rdbNegar.Location = new System.Drawing.Point(-64, 30);
            this.rdbNegar.Name = "rdbNegar";
            this.rdbNegar.Size = new System.Drawing.Size(41, 19);
            this.rdbNegar.TabIndex = 1;
            this.rdbNegar.TabStop = true;
            this.rdbNegar.Text = "No";
            this.rdbNegar.UseVisualStyleBackColor = true;
            // 
            // rdbAfirmar
            // 
            this.rdbAfirmar.AutoSize = true;
            this.rdbAfirmar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdbAfirmar.Location = new System.Drawing.Point(3, 6);
            this.rdbAfirmar.Name = "rdbAfirmar";
            this.rdbAfirmar.Size = new System.Drawing.Size(36, 19);
            this.rdbAfirmar.TabIndex = 0;
            this.rdbAfirmar.TabStop = true;
            this.rdbAfirmar.Text = "Si";
            this.rdbAfirmar.UseVisualStyleBackColor = true;
            // 
            // lblArbol
            // 
            this.lblArbol.AutoSize = true;
            this.lblArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbol.Location = new System.Drawing.Point(36, 362);
            this.lblArbol.Name = "lblArbol";
            this.lblArbol.Size = new System.Drawing.Size(156, 15);
            this.lblArbol.TabIndex = 19;
            this.lblArbol.Text = "4. ¿Hoy plantaste un árbol?";
            // 
            // pnlArbol
            // 
            this.pnlArbol.Controls.Add(this.rdbNoo);
            this.pnlArbol.Controls.Add(this.rdbJa);
            this.pnlArbol.Location = new System.Drawing.Point(61, 390);
            this.pnlArbol.Name = "pnlArbol";
            this.pnlArbol.Size = new System.Drawing.Size(57, 51);
            this.pnlArbol.TabIndex = 20;
            // 
            // rdbNoo
            // 
            this.rdbNoo.AutoSize = true;
            this.rdbNoo.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdbNoo.Location = new System.Drawing.Point(6, 28);
            this.rdbNoo.Name = "rdbNoo";
            this.rdbNoo.Size = new System.Drawing.Size(41, 19);
            this.rdbNoo.TabIndex = 1;
            this.rdbNoo.TabStop = true;
            this.rdbNoo.Text = "No";
            this.rdbNoo.UseVisualStyleBackColor = true;
            // 
            // rdbJa
            // 
            this.rdbJa.AutoSize = true;
            this.rdbJa.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdbJa.Location = new System.Drawing.Point(6, 5);
            this.rdbJa.Name = "rdbJa";
            this.rdbJa.Size = new System.Drawing.Size(36, 19);
            this.rdbJa.TabIndex = 0;
            this.rdbJa.TabStop = true;
            this.rdbJa.Text = "Si";
            this.rdbJa.UseVisualStyleBackColor = true;
            // 
            // lblReciclar
            // 
            this.lblReciclar.AutoSize = true;
            this.lblReciclar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblReciclar.Location = new System.Drawing.Point(428, 271);
            this.lblReciclar.Name = "lblReciclar";
            this.lblReciclar.Size = new System.Drawing.Size(226, 15);
            this.lblReciclar.TabIndex = 21;
            this.lblReciclar.Text = "5. ¿Qué tanto reciclaste en la semana?";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbNada);
            this.panel2.Controls.Add(this.rdbPoco);
            this.panel2.Controls.Add(this.rdbParcial);
            this.panel2.Controls.Add(this.rdbTodos);
            this.panel2.Location = new System.Drawing.Point(448, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 99);
            this.panel2.TabIndex = 22;
            // 
            // rdbNada
            // 
            this.rdbNada.AutoSize = true;
            this.rdbNada.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdbNada.Location = new System.Drawing.Point(5, 76);
            this.rdbNada.Name = "rdbNada";
            this.rdbNada.Size = new System.Drawing.Size(55, 19);
            this.rdbNada.TabIndex = 3;
            this.rdbNada.TabStop = true;
            this.rdbNada.Text = "Nada";
            this.rdbNada.UseVisualStyleBackColor = true;
            // 
            // rdbPoco
            // 
            this.rdbPoco.AutoSize = true;
            this.rdbPoco.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdbPoco.Location = new System.Drawing.Point(3, 54);
            this.rdbPoco.Name = "rdbPoco";
            this.rdbPoco.Size = new System.Drawing.Size(72, 19);
            this.rdbPoco.TabIndex = 2;
            this.rdbPoco.TabStop = true;
            this.rdbPoco.Text = "1-3 días";
            this.rdbPoco.UseVisualStyleBackColor = true;
            // 
            // rdbParcial
            // 
            this.rdbParcial.AutoSize = true;
            this.rdbParcial.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdbParcial.Location = new System.Drawing.Point(3, 28);
            this.rdbParcial.Name = "rdbParcial";
            this.rdbParcial.Size = new System.Drawing.Size(72, 19);
            this.rdbParcial.TabIndex = 1;
            this.rdbParcial.TabStop = true;
            this.rdbParcial.Text = "3-5 días";
            this.rdbParcial.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdbTodos.Location = new System.Drawing.Point(3, 5);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(108, 19);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos los días";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // FormBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblReciclar);
            this.Controls.Add(this.pnlArbol);
            this.Controls.Add(this.lblArbol);
            this.Controls.Add(this.pnlBolsas);
            this.Controls.Add(this.lblBolsas);
            this.Controls.Add(this.pnlDividir);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTransporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnCierre);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBitacora);
            this.Controls.Add(this.ptrFondo);
            this.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBitacora";
            this.Text = "Bitacora";
            ((System.ComponentModel.ISupportInitialize)(this.ptrFondo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDividir.ResumeLayout(false);
            this.pnlDividir.PerformLayout();
            this.pnlBolsas.ResumeLayout(false);
            this.pnlBolsas.PerformLayout();
            this.pnlArbol.ResumeLayout(false);
            this.pnlArbol.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Label lblBitacora;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox ptrFondo;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDividir;
        private System.Windows.Forms.RadioButton rdbCamino;
        private System.Windows.Forms.RadioButton rdbCamion;
        private System.Windows.Forms.RadioButton rdbCarro;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblBolsas;
        private System.Windows.Forms.Panel pnlBolsas;
        private System.Windows.Forms.RadioButton rdbNegar;
        private System.Windows.Forms.RadioButton rdbAfirmar;
        private System.Windows.Forms.RadioButton rdbNegacion;
        private System.Windows.Forms.Label lblArbol;
        private System.Windows.Forms.Panel pnlArbol;
        private System.Windows.Forms.RadioButton rdbNoo;
        private System.Windows.Forms.RadioButton rdbJa;
        private System.Windows.Forms.Label lblReciclar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbNada;
        private System.Windows.Forms.RadioButton rdbPoco;
        private System.Windows.Forms.RadioButton rdbParcial;
        private System.Windows.Forms.RadioButton rdbTodos;
    }
}