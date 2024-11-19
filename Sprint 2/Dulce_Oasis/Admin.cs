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
    public partial class Admin : Form
    {
        Factura factura = new Factura();

        public Admin()
        {
            InitializeComponent();
        }

        private void cERRARSESIÓNToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarProductos ventana = new AgregarProductos();
            ventana.Show();

            this.Hide();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta ventana = new Venta();
            ventana.Show();

            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CRUDfactura.Listarfactura(factura);
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarIngredientes ventana = new AgregarIngredientes();
            ventana.Show();

            this.Hide();
        }

        private void ingredientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerProductocs ventana = new VerProductocs();
            ventana.Show();

            this.Hide();
        }

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VerIngredientes ventana = new VerIngredientes();
            ventana.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerUsuarios ventana = new VerUsuarios();
            ventana.Show();

            this.Hide();
        }

        private void pERFILToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}