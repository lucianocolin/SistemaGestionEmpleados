using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionEmpleados.BL
{
    public class AdminUser : User
    {
        public AdminUser(string username, string password, string role) : base(username, password, role)
        {

        }
    }
}
