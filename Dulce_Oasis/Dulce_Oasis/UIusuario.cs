using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dulce_Oasis
{
    public partial class UIusuario : Form
    {
        Usuario usuario = new Usuario();

        public UIusuario()
        {
            InitializeComponent();

            string[] elementos = { "Administrador", "Empleado"};
            comboBoxRol.Items.AddRange(elementos);
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            usuario.nombre = textBoxNombre.Text;
            usuario.correo = textBoxCorreo.Text;
            usuario.contra = textBoxContra.Text;
            usuario.rol = comboBoxRol.ValueMember;

            CRUDUsuarios.AgregarUsuario(usuario);

        }
    }
}
