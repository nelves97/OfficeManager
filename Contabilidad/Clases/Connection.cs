using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Contabilidad
{
    class Connection
    {
        public static SqlConnection conn;
        public static int rol = -1;

        public static void Autenticar(String RetUsers, String RetPass)
        {
                SqlCommand searchUser = new SqlCommand(string.Format("Select * From Empleados Where NombreUsuario = '{0}' and Contrasena = '{1}'", RetUsers, RetPass), conn);
                SqlDataReader readUser = searchUser.ExecuteReader();
                while (readUser.Read())
                {
                    rol = 0;
                }
            readUser.Close();
           

                SqlCommand searchAdmin = new SqlCommand(string.Format("Select * From Administrador Where NombreUsuario = '{0}' and Contrasena = '{1}'", RetUsers, RetPass), conn);
                SqlDataReader readAdmin = searchAdmin.ExecuteReader();
                while (readAdmin.Read())
                {
                    rol = 1;
                }
            readAdmin.Close();
        }
    }
}
