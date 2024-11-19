using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulce_Oasis
{
    internal class Producto
    {
        public int cod_prod {  get; set; }
        public string nombre_prod { get; set; }
        public int cantidad_prod { get; set; }
        public string descrip { get; set; }
        public int precio { get; set; }

        public Producto() { }

        public Producto(int cod_prod,string nombre_prod, int cantidad_prod, string descrip, int precio)
        {
            this.cod_prod = cod_prod;
            this.nombre_prod = nombre_prod;
            this.cantidad_prod = cantidad_prod;
            this.descrip = descrip;
            this.precio = precio;
        }
    }
}