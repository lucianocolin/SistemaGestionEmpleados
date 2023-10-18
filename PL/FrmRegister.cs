using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestionEmpleados.PL
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            cboNewUserRole.Items.Add("Administrador");
            cboNewUserRole.Items.Add("Editor");
        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewUsername_Leave(object sender, EventArgs e)
        {
            if (txtNewUsername.Text == "")
            {
                lblEmptyNewUsername.Text = "Debe ingresar un nombre de usuario";
            }
            else
            {
                lblEmptyNewUsername.Text = "";
            }

            if (txtNewUsername.Text != "" && cboNewUserRole.Text != "" && 
                txtNewPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                btnCreateUser.Enabled = true;
            }
            else
            {
                btnCreateUser.Enabled = false;
            }
        }

        private void cboNewUserRole_Leave(object sender, EventArgs e)
        {
            if (cboNewUserRole.Text == "")
            {
                lblEmptyRole.Text = "Debe elegir un rol";
            }
            else
            {
                lblEmptyRole.Text = "";
            }

            if (txtNewUsername.Text != "" && cboNewUserRole.Text != "" &&
                txtNewPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                btnCreateUser.Enabled = true;
            }
            else
            {
                btnCreateUser.Enabled = false;
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                lblEmptyNewPassword.Text = "Debe ingresar una contraseña";
            }
            else
            {
                lblEmptyNewPassword.Text = "";
            }

            if (txtNewUsername.Text != "" && cboNewUserRole.Text != "" &&
                txtNewPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                btnCreateUser.Enabled = true;
            }
            else
            {
                btnCreateUser.Enabled = false;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                lblConfirmPassword.Text = "Debe repetir la contraseña creada";
            }
            else
            {
                lblConfirmPassword.Text = "";
            }

            if (txtNewUsername.Text != "" && cboNewUserRole.Text != "" &&
                txtNewPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                btnCreateUser.Enabled = true;
            }
            else
            {
                btnCreateUser.Enabled = false;
            }
        }
    }
}
