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
    public partial class AgregarProductos : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        Producto producto = new Producto();

        public AgregarProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxnomp.Text))
            {
                errorProvider.SetError(textBoxnomp, "Este campo es obligatorio.");
                return;
            }
            else
            {
                producto.nombre_prod = textBoxnomp.Text;
                errorProvider.SetError(textBoxnomp, "");
            }
            if (string.IsNullOrWhiteSpace(textBoxcatidadp.Text))
            {
                MessageBox.Show("El campo no puede estar vacío.");
                return;
            }
            else if (!int.TryParse(textBoxcatidadp.Text, out _))
            {
                MessageBox.Show("El valor ingresado debe ser un numérico.");
                return;
            }
            else
            {
                producto.cantidad_prod = int.Parse(textBoxcatidadp.Text.ToString());
                errorProvider.SetError(textBoxcatidadp, "");
            }
            if (string.IsNullOrWhiteSpace(textBoxdescripp.Text))
            {
                errorProvider.SetError(textBoxdescripp, "Este campo es obligatorio.");
                return;
            }
            else
            {
                producto.descrip = textBoxdescripp.Text;
                errorProvider.SetError(textBoxdescripp, "");
            }
            if (string.IsNullOrWhiteSpace(textBoxpreciop.Text))
            {
                MessageBox.Show("El campo no puede estar vacío.");
                return;
            }
            else if (!int.TryParse(textBoxpreciop.Text, out _))
            {
                MessageBox.Show("El valor ingresado debe ser numérico.");
                return;
            }
            else
            {
                producto.precio = int.Parse(textBoxpreciop.Text.ToString());
                errorProvider.SetError(textBoxpreciop, "");
            }

            CRUDproducto.Agregarproducto(producto);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin ventana = new Admin();
            ventana.Show();

            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AgregarProductos ventana = new AgregarProductos();
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

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarIngredientes ventana = new AgregarIngredientes();
            ventana.Show();

            this.Hide();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void ingredientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerProductocs ventana = new VerProductocs();
            ventana.Show();

            this.Hide();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta ventana = new Venta();
            ventana.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VerUsuarios ventana = new VerUsuarios();
            ventana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxnomp.Text = "";
            textBoxcatidadp.Text = "";
            textBoxdescripp.Text = "";
            textBoxpreciop.Text = "";
        }
    }
}
