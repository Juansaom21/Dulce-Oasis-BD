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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dulce_Oasis
{
    public partial class VerIngredientes : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        Ingredientes ingrediente = new Ingredientes();
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP-6P97G00J\\SQLEXPRESS;Initial Catalog=Dulce_Oasis;Integrated Security=true; TrustServerCertificate=true;");
        public VerIngredientes()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();
            this.Close();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProductos ventana = new AgregarProductos();
            ventana.Show();
            this.Hide();
        }

        private void ingredientesToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta ventana = new Venta();
            ventana.Show();
            this.Hide();
        }

        private void ingredientesToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Admin ventana = new Admin();
            ventana.Show();
            this.Hide();
        }

        private void VerIngredientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CRUDingredientes.Listaringredientes(ingrediente);

            cnx.Open();
            string consulta = "select *from ingrediente";
            SqlCommand comando = new SqlCommand(consulta, cnx);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                comboBox1.Items.Add(lector.GetInt32(0));
            }
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                errorProvider.SetError(comboBox1, "Este campo es obligatorio.");
            }
            else
            {
                ingrediente.cod_ingr = int.Parse(comboBox1.SelectedItem.ToString());
                errorProvider.SetError(comboBox1, "");
            }
            if (string.IsNullOrWhiteSpace(textBoxnomrei.Text))
            {
                errorProvider.SetError(textBoxnomrei, "Este campo es obligatorio.");
                return;
            }
            else
            {
                ingrediente.nombre_ingr = textBoxnomrei.Text;
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
                ingrediente.cantidad_ingr = int.Parse(textBoxcantidadi.Text.ToString());
                errorProvider.SetError(textBoxcantidadi, "");
            }


            CRUDingredientes.Actualizaringrediente(ingrediente);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CRUDingredientes.Listaringredientes(ingrediente);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                errorProvider.SetError(comboBox1, "Este campo es obligatorio.");
                return;
            }
            else
            {
                ingrediente.cod_ingr = int.Parse(comboBox1.SelectedItem.ToString());
                errorProvider.SetError(comboBox1, "");
                comboBox1.Text = "";
            }

            CRUDingredientes.borraringrediente(ingrediente);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxnomrei.Text = "";
            textBoxcantidadi.Text = "";
        }
    }
}
