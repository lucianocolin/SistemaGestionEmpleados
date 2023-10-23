using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionEmpleados.BL
{
    public class Employee
    {
        public string Names { get; set; }
        public string Department { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }

        public Employee(string names, string dept, string fSurname, string sSurname, int id, string email)
        {
            Names = names;
            Department = dept;
            FirstSurname = fSurname;
            SecondSurname = sSurname;
            Id = id;
            Email = email;
        }
    }
}
