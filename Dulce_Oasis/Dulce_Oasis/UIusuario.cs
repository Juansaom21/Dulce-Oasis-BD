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

            string[] elementos = { "admin", "empleado" };
            comboBoxRol.Items.AddRange(elementos);

            comboBoxRol.SelectedIndex = 0;

            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            usuario.nombre = textBoxNombre.Text;
            usuario.correo = textBoxCorreo.Text;
            usuario.contra = textBoxContra.Text;
            usuario.rol = comboBoxRol.SelectedItem.ToString();

            CRUDUsuarios.AgregarUsuario(usuario);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin ventana = new Admin();
            ventana.Show();

            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Agregar ventana = new Agregar();
            ventana.Show();

            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIusuario ventana = new UIusuario();
            ventana.Show();

            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();

            this.Close();
        }
    }
}
