using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulce_Oasis
{
    internal class CRUDUsuarios
    {
        public static int AgregarUsuario(Usuario usuario)
        {
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                int retorna = 1;
                try
                {
                    string query = "Insert Into usuario (nombre, correo, contra, rol) values ('" + usuario.nombre + "', '" + usuario.correo + "','" + usuario.contra + "', " + usuario.rol + ")"; ;
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    retorna = cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario reistrado con éxito");

                    return retorna;
                }
                catch
                {
                    MessageBox.Show("Error al registrar al usuario");
                    return -1;
                }
            }
        }
    }
}
