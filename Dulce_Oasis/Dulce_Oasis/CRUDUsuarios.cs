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
                    string query = $"Insert Into usuario (nombre, correo, contra, rol) values ('{usuario.nombre}', '{usuario.correo}', '{usuario.contra}', '{usuario.rol}');";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    retorna = cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario reistrado con éxito");

                    return retorna;
                }
                catch
                {
                    MessageBox.Show($"Error al registrar al usuario {usuario.nombre}");
                    return -1;
                }
            }
        }

        public static bool VerificarCredenciales(string nombre, string contra)
        {
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                try
                {
                    string query = "SELECT COUNT(1) FROM usuario WHERE nombre = @nombre AND contra = @contra";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contra", contra);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar credenciales: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
