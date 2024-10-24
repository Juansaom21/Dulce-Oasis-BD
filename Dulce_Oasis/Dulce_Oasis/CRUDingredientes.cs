using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dulce_Oasis.Ingredientes;
using static Dulce_Oasis.ConexionBD;

namespace Dulce_Oasis
{
    internal class CRUDingredientes
    {
        public static int Agregaringredientes(Ingredientes ingredientes)
        {
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                int retorna = 1;
                try
                {
                    string query = "Insert Into ingrediente (nombre_ingr, cantidad_ingr) values ('" + ingredientes.nombre_ingr + "', " + ingredientes.cantidad_ingr + ")"; ;
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    retorna = cmd.ExecuteNonQuery();

                    MessageBox.Show("Ingrediente agregado con éxito");

                    return retorna;
                }
                catch
                {
                    MessageBox.Show("Error al agregar ingrediente");
                    return -1;
                }
            }
        }
    }
}
