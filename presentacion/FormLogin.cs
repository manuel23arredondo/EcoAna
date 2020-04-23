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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
                pcbUsuario.Visible = false;
                txtUsuario.Left -= 35;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
                pcbUsuario.Visible = true;
                txtUsuario.Left += 35;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;

                pcbContra.Visible = false;
                txtContra.Left -= 35;

                if (pcbContraEyeO.Visible == true)
                {
                    txtContra.UseSystemPasswordChar = false;
                }
                else if (pcbContraEyeC.Visible == true)
                {
                    txtContra.UseSystemPasswordChar = true;
                }
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if(txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.DimGray;
                txtContra.UseSystemPasswordChar = false;
                pcbContra.Visible = true;
                txtContra.Left += 35;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "admin" && txtContra.Text == "1234")
            {
                this.Hide();
                Form pantallaPrincipal = new frmPantallaP();
                pantallaPrincipal.Show();
                lblError.Visible = false;
            }
            else if (txtUsuario.Text != "Usuario" || txtContra.Text != "Contraseña")
            {
                lblError.Visible = true;
            }
        }

        private void pcbContraEyeC_Click(object sender, EventArgs e)
        {
            pcbContraEyeC.Visible = false;
            txtContra.UseSystemPasswordChar = false;
            pcbContraEyeO.Visible = true;
        }

        private void pcbContraEyeO_Click(object sender, EventArgs e)
        {
            pcbContraEyeC.Visible = true;
            pcbContraEyeO.Visible = false;

            if (txtContra.Text != "Contraseña") txtContra.UseSystemPasswordChar = true;
            
        }

        private void pcbUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.ForeColor = Color.Black;
            pcbUsuario.Visible = false;
            txtUsuario.Left -= 35;
            txtUsuario.Focus();
        }

        private void pcbContra_Click(object sender, EventArgs e)
        {
            txtContra.Text = "";
            txtContra.ForeColor = Color.Black;
            pcbContra.Visible = false;
            txtContra.Left -= 35;
            txtContra.Focus();

            if (pcbContraEyeO.Visible == true)
            {
                txtContra.UseSystemPasswordChar = false;
            }
            else txtContra.UseSystemPasswordChar = true;
        }

        private void frmLogin_Click(object sender, EventArgs e)
        {
            lblLogin.Focus();
        }

        private void pnlImagenLogo_Click(object sender, EventArgs e)
        {
            lblLogin.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblLogin.Focus();
            pcbContraEyeO.Visible = false;
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registro = new FormRegistro();
            registro.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
