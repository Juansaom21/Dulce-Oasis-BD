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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txb1.Text == "mariam" && txb2.Text == "2110")
            {
                Admin ventana = new Admin();
                ventana.Show();

                this.Hide();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            txb2.PasswordChar = '\0';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
            txb2.PasswordChar = '*';
        }
    }
}
