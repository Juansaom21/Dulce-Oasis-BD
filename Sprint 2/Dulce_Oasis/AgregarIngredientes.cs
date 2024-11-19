using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dulce_Oasis
{
    public partial class AgregarIngredientes : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        Ingredientes ingredientes = new Ingredientes();

        public AgregarIngredientes()
        {
            InitializeComponent();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProductos ventana = new AgregarProductos();
            ventana.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin ventana = new Admin();
            ventana.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxnomrei.Text))
            {
                errorProvider.SetError(textBoxnomrei, "Este campo es obligatorio.");
                return;
            }
            else
            {
                ingredientes.nombre_ingr = textBoxnomrei.Text;
                errorProvider.SetError(textBoxnomrei, "");
            }
            if (string.IsNullOrWhiteSpace(textBoxcantidadi.Text))
            {
                MessageBox.Show("El campo no puede estar vacío.");
                return;
            }
            else if (!int.TryParse(textBoxcantidadi.Text, out _))
            {
                MessageBox.Show("El valor ingresado debe ser numérico.");
                return;
            }
            else
            {
                ingredientes.cantidad_ingr = int.Parse(textBoxcantidadi.Text.ToString());
                errorProvider.SetError(textBoxcantidadi, "");
            }

            CRUDingredientes.Agregaringredientes(ingredientes);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();

            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIusuario ventana = new UIusuario();
            ventana.Show();

            this.Hide();
        }

        private void ingredientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerIngredientes ventana = new VerIngredientes();
            ventana.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerProductocs ventana = new VerProductocs();
            ventana.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerUsuarios ventana = new VerUsuarios();
            ventana.Show();
            this.Hide();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta ventana = new Venta();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxnomrei.Text = "";
            textBoxcantidadi.Text = "";
        }
    }
}
