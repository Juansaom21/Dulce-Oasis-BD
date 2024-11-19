using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulce_Oasis
{
    internal class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contra { get; set; }
        public string rol {  get; set; }

        public Usuario() { }

        public Usuario(int id, string nombre, string correo, string contra, string rol )
        {
            this.id = id;
            this.nombre = nombre;
            this.correo = correo;
            this.contra = contra;
            this.rol = rol;
        }
    }

}
