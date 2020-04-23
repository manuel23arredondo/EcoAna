using System;
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
    public partial class FormBitacora : Form
    {
        public FormBitacora()
        {
            InitializeComponent();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos guardados correctamente", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
