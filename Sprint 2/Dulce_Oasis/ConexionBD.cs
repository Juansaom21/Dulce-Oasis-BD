using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulce_Oasis
{
    internal class ConexionBD
    {
        public static SqlConnection conexion()
        {
            SqlConnection cnx = new SqlConnection("Data Source=LAPTOP-6P97G00J\\SQLEXPRESS;Initial Catalog=Dulce_Oasis;Integrated Security=true; TrustServerCertificate=true;");
            cnx.Open();
            return cnx;
        }
    }
}