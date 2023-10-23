using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGestionEmpleados.DAL
{
    public class ConnectionDB
    {
        private string _connectionString = "Data Source=localhost; Initial Catalog=db.SistemaGestion; Integrated Security=True";
        SqlConnection connection;

        public SqlConnection Connect()
        {
            this.connection = new SqlConnection(this._connectionString);
            return this.connection;
        }

        public bool TryConnection(string strCommand)
        {
            try 
            {
                SqlCommand command = new SqlCommand();

                command.CommandText = strCommand;
                command.Connection = this.Connect();
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }

            catch 
            {
                return false; 
            }
        }
    }
}
