using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LaboratorioEF.Data.DataAccess
{
    internal class Conection
    {
        private string connectionString = "Server=localhost;DataBase=db_universidad;Uid=root;Pwd=Franklin23030917@";
        public bool PruebaConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
