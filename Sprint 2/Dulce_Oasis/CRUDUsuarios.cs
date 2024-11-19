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
                    string query = $"Insert into usuario (nombre, correo, contra, rol) values ('{usuario.nombre}', '{usuario.correo}', '{usuario.contra}', '{usuario.rol}');";
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
                    string query = "Select count(1) from usuario where nombre = @nombre and contra = @contra";
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


        public static int borrarusuario(Usuario usuario)
        {
            int retorna = 0;
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                string query = "Delete from usuario where id = '" + usuario.id + "'";
                SqlCommand cmd = new SqlCommand(query, cnn);
                retorna = cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario eliminado con éxito");
            }
            return retorna;
        }

        public static List<Usuario> Listarusuario(Usuario usuario)
        {
            List<Usuario> lusuario = new List<Usuario>();
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                string query = "Select id, nombre, correo, contra, rol From usuario";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader usuarioB = cmd.ExecuteReader();
                while (usuarioB.Read())
                {
                    Usuario usuario1 = new Usuario();
                    usuario1.id = usuarioB.GetInt32(0);
                    usuario1.nombre = usuarioB.GetString(1);
                    usuario1.correo = usuarioB.GetString(2);
                    usuario1.contra = usuarioB.GetString(3);
                    usuario1.rol = usuarioB.GetString(4);
                    lusuario.Add(usuario1);
                }
                cnn.Close();
                return lusuario;
            }
        }
    }
}
