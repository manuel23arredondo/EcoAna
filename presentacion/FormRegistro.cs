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
    public partial class FormRegistro : Form
    {
        static int len;
        
        public FormRegistro()
        {
            InitializeComponent();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DimGray;
            }
        }


        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                txtApellidos.Text = "Apellidos";
                txtApellidos.ForeColor = Color.DimGray;
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                txtEdad.Text = "Edad";
                txtEdad.ForeColor = Color.DimGray;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
            
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "Apellidos")
            {
                txtApellidos.Text = "";
                txtApellidos.ForeColor = Color.Black;
            }
            
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if (txtEdad.Text == "Edad")
            {
                txtEdad.Text = "";
                txtEdad.ForeColor = Color.Black;
            }
            
        }

        private void txtCiudad_Enter(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "Ciudad")
            {
                txtCiudad.Text = "";
                txtCiudad.ForeColor = Color.Black;
            }
            
        }

        private void txtCiudad_Leave(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "")
            {
                txtCiudad.Text = "Ciudad";
                txtCiudad.ForeColor = Color.DimGray;

            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
            
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;
                txtContra.UseSystemPasswordChar = true;
            }
            
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.DimGray;
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmContra_Enter(object sender, EventArgs e)
        {
            if (txtConfirmContra.Text == "Confirmar contraseña")
            {
                txtConfirmContra.Text = "";
                txtConfirmContra.ForeColor = Color.Black;
                txtConfirmContra.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmContra_Leave(object sender, EventArgs e)
        {
            if (txtConfirmContra.Text =="")
            {
                txtConfirmContra.Text = "Confirmar contraseña";
                txtConfirmContra.ForeColor = Color.DimGray;
                txtConfirmContra.UseSystemPasswordChar = false;
            }
        }

        private void txtContra_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormRegistro_Click(object sender, EventArgs e)
        {
            lblEco.Focus();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text != "Nombre" && 
                txtApellidos.Text != "Apellidos" && txtEdad.Text != "Edad" 
                && txtCiudad.Text != "Ciudad" && txtUsuario.Text != "Usuario" 
                && txtConfirmContra.Text != "Confirmar contraseña" 
                && txtContra.Text != "Contraseña")
            {


                if (txtEdad.Text != "" && txtEdad.Text != "Edad")
                {
                    int edad = int.Parse(txtEdad.Text);
                    if (edad >= 5 && edad <= 120)
                    {
                        txtEdad.ForeColor = Color.Black;
                        carac(txtNombre.Text);
                        if (txtNombre.Text != "" && txtNombre.Text != "Nombre" && len < 20)
                        {
                            txtNombre.ForeColor = Color.Black;
                            carac(txtApellidos.Text);
                            if (txtApellidos.Text != "" && txtApellidos.Text != "Apellidos" && len < 35)
                            {
                                txtApellidos.ForeColor = Color.Black;
                                carac(txtCiudad.Text);
                                if (txtCiudad.Text != "" && txtCiudad.Text != "Ciudad" && len < 20)
                                {
                                    txtCiudad.ForeColor = Color.Black;
                                    carac(txtUsuario.Text);
                                    if (txtUsuario.Text != "" && txtUsuario.Text != "Usuario" && len < 30)
                                    {
                                        txtUsuario.ForeColor = Color.Black;
                                        carac(txtContra.Text);
                                        if (txtContra.Text != "" && txtContra.Text != "Contraseña" && len < 30)
                                        {
                                            txtContra.ForeColor = Color.Black;
                                            if (txtConfirmContra.Text != "" && txtConfirmContra.Text != "Confirmar contraseña" && txtConfirmContra.Text == txtContra.Text)
                                            {
                                                txtConfirmContra.ForeColor = Color.Black;
                                                lblRegistroE.Visible = true;
                                                btnRegistrarse.Visible = false;
                                                lblError.Visible = false;
                                                btnIniciar.Visible = true;
                                            }
                                            else
                                            {
                                                lblError.Text = "La contraseña no concuerda";
                                                lblError.Visible = true;
                                                txtConfirmContra.ForeColor = Color.Red;
                                            }
                                        }
                                        else
                                        {
                                            lblError.Text = "Contraseña inválida";
                                            lblError.Visible = true;
                                            txtContra.ForeColor = Color.Red;
                                        }
                                    }
                                    else
                                    {
                                        lblError.Text = "Usuario inválido";
                                        lblError.Visible = true;
                                        txtUsuario.ForeColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    lblError.Text = "Ciudad inválida";
                                    lblError.Visible = true;
                                    txtCiudad.ForeColor = Color.Red;
                                }
                            }
                            else
                            {
                                lblError.Text = "Apellido inválido";
                                lblError.Visible = true;
                                txtApellidos.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            lblError.Text = "Nombre inválido";
                            lblError.Visible = true;
                            txtNombre.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lblError.Text = "Edad inválida";
                        lblError.Visible = true;
                        txtEdad.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblError.Text = "Edad inválida";
                    lblError.Visible = true;
                    txtEdad.ForeColor = Color.Red;
                }
            }
            else
            {
                lblError.Text = "Debes completar la información para continuar";
                lblError.Visible = true;
            }
        }
        
        private static int carac(string ca)
        {
            len = ca.Length;
            return len;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new frmLogin();
            login.Show();
        }

        private void pcbRegreso_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new frmLogin();
            login.Show();
        }
    }
}
