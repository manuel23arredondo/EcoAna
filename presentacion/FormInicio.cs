﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
