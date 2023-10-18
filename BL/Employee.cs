using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionEmpleados.BL
{
    public class Employee
    {
        public string Names { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

        public Employee(string names, string fSurname, string sSurname, int id, string email, long phone)
        {
            Names = names;
            FirstSurname = fSurname;
            SecondSurname = sSurname;
            Id = id;
            Email = email;
            Phone = phone;
        }
    }
}
