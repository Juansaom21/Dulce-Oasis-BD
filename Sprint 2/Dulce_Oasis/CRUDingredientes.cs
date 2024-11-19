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
                    string query = "Insert into ingrediente (nombre_ingr, cantidad_ingr) values ('" + ingredientes.nombre_ingr + "', " + ingredientes.cantidad_ingr + ")"; ;
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

        public static int borraringrediente(Ingredientes ingredientes)
        {
            int retorna = 0;
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                try
                {
                    string query = "Delete from ingrediente where cod_ingr = '" + ingredientes.cod_ingr + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    retorna = cmd.ExecuteNonQuery();

                    MessageBox.Show("Ingrediente eliminado con éxito");
                    return retorna;
                }
                catch 
                {
                    MessageBox.Show("Error al eliminar producto");
                    return -1;
                }

            }
        }


        public static int Actualizaringrediente(Ingredientes ingredientes)
        {
            int retorna = 0;
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                try 
                {
                    string query = "Update ingrediente set nombre_ingr = @nombre_ingr, cantidad_ingr = @cantidad_ingr WHERE cod_ingr = @cod_ingr";
                    SqlCommand cmd = new SqlCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@cod_ingr", ingredientes.cod_ingr);
                    cmd.Parameters.AddWithValue("@nombre_ingr", ingredientes.nombre_ingr);
                    cmd.Parameters.AddWithValue("@cantidad_ingr", ingredientes.cantidad_ingr);

                    retorna = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Ingrediente actualizado con éxito");
                    return retorna;


                }
                catch 
                {
                    MessageBox.Show("Error al actualizar Ingrediente");
                    return -1;
                }
            }
        }


        public static List<Ingredientes> Listaringredientes(Ingredientes ingredientes)
        {
            List<Ingredientes> lingredientes = new List<Ingredientes>();
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                string query = "Select cod_ingr, nombre_ingr, cantidad_ingr From ingrediente";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader ingredientesB = cmd.ExecuteReader();
                while (ingredientesB.Read())
                {
                    Ingredientes ingredientes1 = new Ingredientes();
                    ingredientes1.cod_ingr = ingredientesB.GetInt32(0);
                    ingredientes1.nombre_ingr = ingredientesB.GetString(1);
                    ingredientes1.cantidad_ingr = ingredientesB.GetInt32(2);
                    lingredientes.Add(ingredientes1);
                }
                cnn.Close();
                return lingredientes;
            }
        }
    }
}
