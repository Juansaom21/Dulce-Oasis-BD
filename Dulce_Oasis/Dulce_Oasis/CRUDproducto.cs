using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dulce_Oasis.Producto;
using static Dulce_Oasis.ConexionBD;

namespace Dulce_Oasis
{
    internal class CRUDproducto
    {
        public static int Agregarproducto(Producto producto)
        {
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                int retorna = 1;
                try
                {
                    string query = "Insert Into producto (nombre_prod, cantidad_prod, descrip, precio) values ('" + producto.nombre_prod + "', '" + producto.cantidad_prod + "','" + producto.descrip + "', " + producto.precio + ")"; ;
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    retorna = cmd.ExecuteNonQuery();

                    MessageBox.Show("Producto agregado con éxito");

                    return retorna;
                }
                catch
                {
                    MessageBox.Show("Error al agregar producto");
                    return -1;
                }
            }
        }
    }
}