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
    public partial class VerProductocs : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        Producto producto = new Producto();
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP-6P97G00J\\SQLEXPRESS;Initial Catalog=Dulce_Oasis;Integrated Security=true; TrustServerCertificate=true;");

        public VerProductocs()
        {
            InitializeComponent();
        }

        private void VerProductocs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CRUDproducto.Listarproducto(producto);

            cnx.Open();
            string consulta = "select *from producto";
            SqlCommand comando = new SqlCommand(consulta, cnx);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                comboBox1.Items.Add(lector.GetInt32(0));
            }
            cnx.Close();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                errorProvider.SetError(comboBox1, "Este campo es obligatorio.");
            }
            else
            {
                producto.cod_prod = int.Parse(comboBox1.SelectedItem.ToString());
                errorProvider.SetError(comboBox1, "");
            }
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

            CRUDproducto.Actualizarproducto(producto);
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                errorProvider.SetError(comboBox1, "Este campo es obligatorio.");
                return;
            }
            else
            {
                producto.cod_prod = int.Parse(comboBox1.SelectedItem.ToString());
                errorProvider.SetError(comboBox1, "");
                comboBox1.Text = "";
            }

            CRUDproducto.borrarproducto(producto);
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CRUDproducto.Listarproducto(producto);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Admin ventana = new Admin();
            ventana.Show();

            this.Close();
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

            this.Hide();
        }

        private void ingredientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerIngredientes Ver = new VerIngredientes();
            Ver.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerUsuarios Ver = new VerUsuarios();
            Ver.Show();
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