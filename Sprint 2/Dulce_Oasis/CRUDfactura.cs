using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulce_Oasis
{
    internal class CRUDfactura
    {
        public static int Agregarfactura(Factura factura)
        {
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                int retorna = 1;

                string query = "INSERT INTO factura (id_cliente, nombre_prod, precio) VALUES (@id_cliente,  @nombre_prod, @precio)";

                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@id_cliente", factura.id_cliente);
                cmd.Parameters.AddWithValue("@nombre_prod", factura.nombre_prod);
                cmd.Parameters.AddWithValue("@precio", factura.precio);
                retorna = cmd.ExecuteNonQuery();


                MessageBox.Show(" venta hecha con éxito");

                return retorna;

            }
        }

        public static List<Factura> Listarfactura(Factura factura)
        {
            List<Factura> lfactura = new List<Factura>();
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                string query = "Select cod_factura, id_cliente, nombre_prod, fecha, precio From factura";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader facturaB = cmd.ExecuteReader();
                while (facturaB.Read())
                {
                    Factura factura1 = new Factura();
                    factura1.cod_factura = facturaB.GetInt32(0);
                    factura1.id_cliente = facturaB.GetInt32(1);
                    factura1.nombre_prod = facturaB.GetString(2);
                    factura1.fecha = facturaB.GetDateTime(3);
                    factura1.precio = facturaB.GetInt32(4);
                    lfactura.Add(factura1);
                }
                cnn.Close();
                return lfactura;
            }
        }
    }
}
