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
        ErrorProvider errorProvider = new ErrorProvider();
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

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                errorProvider.SetError(textBoxNombre, "Este campo es obligatorio.");
                return;
            }
            else
            {
                usuario.nombre = textBoxNombre.Text;
                errorProvider.SetError(textBoxNombre, "");
            }

            if (string.IsNullOrWhiteSpace(textBoxCorreo.Text))
            {
                errorProvider.SetError(textBoxCorreo, "Este campo es obligatorio.");
                return;
            }
            else
            {
                usuario.correo = textBoxCorreo.Text;
                errorProvider.SetError(textBoxCorreo, "");
            }

            if (string.IsNullOrWhiteSpace(textBoxContra.Text))
            {
                errorProvider.SetError(textBoxContra, "Este campo es obligatorio.");
                return;
            }
            else
            {
                usuario.contra = textBoxContra.Text;
                errorProvider.SetError(textBoxContra, "");
            }
            if (string.IsNullOrWhiteSpace(comboBoxRol.Text))
            {
                errorProvider.SetError(comboBoxRol, "Este campo es obligatorio.");
                return;
            }
            else
            {
                usuario.rol = comboBoxRol.SelectedItem.ToString();
                errorProvider.SetError(comboBoxRol, "");
            }

            CRUDUsuarios.AgregarUsuario(usuario);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin ventana = new Admin();
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

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProductos ventana = new AgregarProductos();
            ventana.Show();

            this.Hide();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarIngredientes ventana = new AgregarIngredientes();
            ventana.Show();

            this.Hide();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta ventana = new Venta();
            ventana.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            VerUsuarios usuarios = new VerUsuarios();
            usuarios.Show();
            this.Hide();
        }

        private void ingredientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerIngredientes ventana = new VerIngredientes();
            ventana.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerProductocs usuarios = new VerProductocs();
            usuarios.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxCorreo.Text = "";
            textBoxContra.Text = "";
        }
    }
}
