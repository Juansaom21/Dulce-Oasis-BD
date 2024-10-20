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
    public partial class Agregar : Form
    {
        Producto producto = new Producto();
        Ingredientes ingredientes = new Ingredientes();

        public Agregar()
        {
            InitializeComponent();
        }

        private void cERRARSESIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin ventana = new Admin();
            ventana.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto.nombre_prod = textBoxnomp.Text;
            producto.cantidad_prod = int.Parse(textBoxcatidadp.Text);
            producto.descrip = textBoxdescripp.Text;
            producto.precio = int.Parse(textBoxpreciop.Text);

            CRUDproducto.Agregarproducto(producto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingredientes.nombre_ingr = textBoxnomrei.Text;
            ingredientes.cantidad_ingr = int.Parse(textBoxcantidadi.Text);

            CRUDingredientes.Agregaringredientes(ingredientes);
        }
    }
}
