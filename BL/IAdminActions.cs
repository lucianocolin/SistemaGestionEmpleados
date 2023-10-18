using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionEmpleados.BL
{
    public interface IAdminActions
    {
        string GetUser();
        string CreateUser();
        string UpdateUser();
        string DeleteUser();
    }
}
