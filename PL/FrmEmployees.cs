using SistemaGestionEmpleados.BL;
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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            int FakeId = 0;

            string EmployeeNames = txtNames.Text;
            string EmployeeDept = cbDepartment.Text;
            string EmployeeFirstSurname = txtFirstSurname.Text;
            string EmployeeSecondSurname = txtSecSurname.Text;
            string EmployeeEmail = txtEmail.Text;
            long EmployeePhone = Int64.Parse(numPhone.Text);

            Employee newEmployee = new Employee(EmployeeNames, EmployeeDept, EmployeeFirstSurname,
                             EmployeeSecondSurname, FakeId, EmployeeEmail, EmployeePhone);


            if (newEmployee.Names != "" && newEmployee.Department != "" && newEmployee.FirstSurname != "" &&
                newEmployee.SecondSurname != "" && newEmployee.Email != "" && newEmployee.Phone != 0)
            {
                int n = dgvEmployeesList.Rows.Add();
                FakeId++;

                dgvEmployeesList.Rows[n].Cells[0].Value = newEmployee.Names;
                dgvEmployeesList.Rows[n].Cells[1].Value = newEmployee.Department;
                dgvEmployeesList.Rows[n].Cells[2].Value = newEmployee.FirstSurname;
                dgvEmployeesList.Rows[n].Cells[3].Value = newEmployee.SecondSurname;
                dgvEmployeesList.Rows[n].Cells[4].Value = newEmployee.Email;
                dgvEmployeesList.Rows[n].Cells[5].Value = newEmployee.Phone.ToString();

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
            numPhone.Value = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanInputs();
        }
    }
}
