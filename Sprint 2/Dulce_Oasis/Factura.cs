using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulce_Oasis
{
    internal class Factura
    {
        public int cod_factura {  get; set; }
        public int id_cliente { get; set; }
        public int cod_prod {  get; set; }
        public string nombre_prod { get; set; }
        public DateTime fecha { get; set; }
        public int precio { get; set; }

        public Factura() { }

        public Factura (int cod_factura, int id_cliente, int cod_prod, string nombre_prod, DateTime fecha, int precio)
        { 
            this.cod_factura = cod_factura;
            this.id_cliente = id_cliente;
            this.cod_prod = cod_prod;
            this.nombre_prod = nombre_prod;
            this.fecha = fecha;
            this.precio = precio;
        }
    }
}
