using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulce_Oasis
{
    internal class Ingredientes
    {
        public int cod_ingr {  get; set; }
        public string nombre_ingr { get; set; }
        public int cantidad_ingr { get; set; }
      
        public Ingredientes() { }

        public Ingredientes(int cod_ingr, string nombre_ingr, int cantidad_ingr)
        {
            this.cod_ingr = cod_ingr;
            this.nombre_ingr = nombre_ingr;
            this.cantidad_ingr = cantidad_ingr;
        }
    }
}