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
    public partial class VerUsuarios : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        Usuario usuario = new Usuario();
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP-6P97G00J\\SQLEXPRESS;Initial Catalog=Dulce_Oasis;Integrated Security=true; TrustServerCertificate=true;");
        public VerUsuarios()
        {
            InitializeComponent();
        }

        private void ingredientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerProductocs ventana = new VerProductocs();
            ventana.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerIngredientes ventana = new VerIngredientes();
            ventana.Show();
            this.Hide();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ingredientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AgregarIngredientes ventana = new AgregarIngredientes();
            ventana.Show();
            this.Hide();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta ventana = new Venta();
            ventana.Show();
            this.Hide();
        }

        private void VerUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CRUDUsuarios.Listarusuario(usuario);

            cnx.Open();
            string consulta = "select *from usuario";
            SqlCommand comando = new SqlCommand(consulta, cnx);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                comboBox1.Items.Add(lector.GetInt32(0));
            }
            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin ventana = new Admin();
            ventana.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CRUDUsuarios.Listarusuario(usuario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                errorProvider.SetError(comboBox1, "Este campo es obligatorio.");
                return;
            }
            else
            {
                usuario.id = int.Parse(comboBox1.SelectedItem.ToString());
                errorProvider.SetError(comboBox1, "");
                comboBox1.Text = "";
            }

            CRUDUsuarios.borrarusuario(usuario);
        }
    }
}
