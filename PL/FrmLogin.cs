using SistemaGestionEmpleados.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionEmpleados
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblEmptyUsername.Text = "Debes ingresar tu nombre de usuario";
                lblEmptyUsername.ForeColor = Color.Red;
            }
            else
            {
                lblEmptyUsername.Text = "";
            }

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                lblEmptyPassword.Text = "Debes ingresar tu contraseña";
                lblEmptyPassword.ForeColor = Color.Red;
            }
            else
            {
                lblEmptyPassword.Text = "";
            }

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmployees prueba = new FrmEmployees();
            prueba.Show();
        }
    }
}
