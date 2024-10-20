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

        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar ventana = new Agregar();
            ventana.Show();

            this.Hide();
        }
    }
}
