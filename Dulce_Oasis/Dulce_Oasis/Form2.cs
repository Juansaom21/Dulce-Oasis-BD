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
            // Obtenemos los datos del formulario
            string correo = txb1.Text;
            string contra = txb2.Text;

            // Verificar si las credenciales son válidas
            if (CRUDUsuarios.VerificarCredenciales(correo, contra))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                Admin ventana = new Admin();
                ventana.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas. Por favor, verifica tu usuario o contraseña.");
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
