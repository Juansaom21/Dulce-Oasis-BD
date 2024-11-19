using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dulce_Oasis
{
    public partial class Venta : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        Factura factura = new Factura();

        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP-6P97G00J\\SQLEXPRESS;Initial Catalog=Dulce_Oasis;Integrated Security=true; TrustServerCertificate=true;");
        public Venta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_cedula.Text))
            {
                MessageBox.Show("El campo no puede estar vacío.");
                return;
            }
            else if (!int.TryParse(textBox_cedula.Text, out _))
            {
                MessageBox.Show("El valor ingresado debe ser numérico.");
                return;
            }
            else
            {
                factura.id_cliente = int.Parse(textBox_cedula.Text.ToString());
                errorProvider.SetError(textBox_cedula, "");
            }
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                errorProvider.SetError(comboBox1, "Este campo es obligatorio.");
                return;
            }
            else
            {
                factura.nombre_prod = comboBox1.SelectedItem.ToString();
                errorProvider.SetError(comboBox1, "");
            }

            factura.precio = int.Parse(label_precio.Text);
            CRUDfactura.Agregarfactura(factura);

        }

        private void Venta_Load(object sender, EventArgs e)
        {
            cnx.Open();
            string consulta = "select *from producto";
            SqlCommand comando = new SqlCommand(consulta, cnx);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                comboBox1.Items.Add(lector.GetString(1));
            }
            cnx.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            string consulta = "select *from producto";
            SqlCommand comando = new SqlCommand(consulta, cnx);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                label_precio.Text = lector.GetInt32(4).ToString();
            }
            cnx.Close();
        }

        private void cERRARSESIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin ventana = new Admin();
            ventana.Show();
            this.Close();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIusuario ventana = new UIusuario();
            ventana.Show();
            this.Hide();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerProductocs ventana = new VerProductocs();
            ventana.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerIngredientes ventana = new VerIngredientes();
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
            textBox_cedula.Text = "";
            comboBox1.Text = "";
        }
    }
}
