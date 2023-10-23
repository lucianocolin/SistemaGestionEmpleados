using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaGestionEmpleados.DAL;

namespace SistemaGestionEmpleados.PL
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Connect();
        }
    }
}
