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
                    string query = "Insert into producto (nombre_prod, cantidad_prod, descrip, precio) values ('" + producto.nombre_prod + "', '" + producto.cantidad_prod + "','" + producto.descrip + "', " + producto.precio + ")"; ;
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

        public static int borrarproducto(Producto producto)
        {
           
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                int retorna = 1;
                try
                {
                    string query = "Delete from producto where cod_prod = '" + producto.cod_prod + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    retorna = cmd.ExecuteNonQuery();

                    MessageBox.Show("Producto eliminado con éxito");
                    return retorna;
                }
                catch 
                {
                    MessageBox.Show("Error al eliminar producto");
                    return -1;
                }
            }
        }

        public static int Actualizarproducto(Producto producto)
        {
            int retorna = 0;
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                try
                {
                    string query = "Update producto set nombre_prod = @nombre_prod, cantidad_prod = @cantidad_prod, descrip = @descrip, precio = @precio where cod_prod = @cod_prod";
                    SqlCommand cmd = new SqlCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@cod_prod", producto.cod_prod);
                    cmd.Parameters.AddWithValue("@nombre_prod", producto.nombre_prod);
                    cmd.Parameters.AddWithValue("@cantidad_prod", producto.cantidad_prod);
                    cmd.Parameters.AddWithValue("@descrip", producto.descrip);
                    cmd.Parameters.AddWithValue("@precio", producto.precio);

                    retorna = cmd.ExecuteNonQuery();

                    MessageBox.Show("Producto actualizado con éxito");
                    return retorna;
                }
                catch 
                {
                    MessageBox.Show("Error al actualizar producto");
                    return -1;
                }
            }
        }

        public static List<Producto> Listarproducto(Producto producto)
        {
            List<Producto> lproducto = new List<Producto>();
            using (SqlConnection cnn = ConexionBD.conexion())
            {
                string query = "Select cod_prod, nombre_prod, cantidad_prod, descrip, precio From producto";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader productoB = cmd.ExecuteReader();
                while (productoB.Read())
                {
                    Producto producto1 = new Producto();
                    producto1.cod_prod = productoB.GetInt32(0);
                    producto1.nombre_prod = productoB.GetString(1);
                    producto1.cantidad_prod = productoB.GetInt32(2);
                    producto1.descrip = productoB.GetString(3);
                    producto1.precio = productoB.GetInt32(4);
                    lproducto.Add(producto1);
                }
                cnn.Close();
                return lproducto;
            }
        }
    }
}