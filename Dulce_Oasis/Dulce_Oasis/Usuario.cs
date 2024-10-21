using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulce_Oasis
{
    internal class Usuario
    {
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contra { get; set; }
        public string rol {  get; set; }

        public Usuario() { }

        public Usuario(string nombre, string correo, string contra, string rol )
        {
            this.nombre = nombre;
            this.correo = correo;
            this.contra = contra;
            this.rol = rol;
        }
    }

}
