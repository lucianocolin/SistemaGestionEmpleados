using SistemaGestionEmpleados.BL;
using SistemaGestionEmpleados.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestionEmpleados.PL
{
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            cbDepartment.Items.Add("Vendedores");
            cbDepartment.Items.Add("Administrativos");
            cbDepartment.Items.Add("Mecánicos");
        }

        int FakeId = 0;

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

            string EmployeeNames = txtNames.Text;
            string EmployeeDept = cbDepartment.Text;
            string EmployeeFirstSurname = txtFirstSurname.Text;
            string EmployeeSecondSurname = txtSecSurname.Text;
            string EmployeeEmail = txtEmail.Text;

            Employee newEmployee = new Employee(EmployeeNames, EmployeeDept, EmployeeFirstSurname,
                             EmployeeSecondSurname, FakeId, EmployeeEmail);


            if (newEmployee.Names != "" && newEmployee.Department != "" && newEmployee.FirstSurname != "" &&
                newEmployee.SecondSurname != "" && newEmployee.Email != "")
            {
                int n = dgvEmployeesList.Rows.Add();
                FakeId++;

                dgvEmployeesList.Rows[n].Cells[0].Value = newEmployee.Id;
                dgvEmployeesList.Rows[n].Cells[1].Value = newEmployee.Names;
                dgvEmployeesList.Rows[n].Cells[2].Value = newEmployee.FirstSurname;
                dgvEmployeesList.Rows[n].Cells[3].Value = newEmployee.SecondSurname;
                dgvEmployeesList.Rows[n].Cells[4].Value = newEmployee.Department;
                dgvEmployeesList.Rows[n].Cells[5].Value = newEmployee.Email;

                CleanInputs();
            }
            else
            {
                MessageBox.Show("Hay campos que todavía deben ser completados");
            }


        }

        public void CleanInputs()
        {
            txtNames.Text = "";
            cbDepartment.Text = "";
            txtFirstSurname.Text = "";
            txtSecSurname.Text = "";
            txtEmail.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanInputs();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            ConnectionDB db = new ConnectionDB();
            MessageBox.Show("Conectado..." + db.TryConnection("INSERT INTO Departamentos(Departamentos) VALUES('Mecánicos')"));
        }
    }
}
