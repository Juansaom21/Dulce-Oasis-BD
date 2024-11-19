namespace Dulce_Oasis
{
    partial class VerUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            ingredientesToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem2 = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            vERToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem1 = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            errorProvider1 = new ErrorProvider(components);
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.MistyRose;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem3, vERToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(7, 3, 0, 3);
            menuStrip2.Size = new Size(800, 30);
            menuStrip2.TabIndex = 40;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(66, 24);
            toolStripMenuItem1.Text = "PERFIL";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(200, 26);
            toolStripMenuItem2.Text = "CERRAR SESIÓN";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4, usuariosToolStripMenuItem, ventaToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(89, 24);
            toolStripMenuItem3.Text = "AGREGAR";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { ingredientesToolStripMenuItem, ingredientesToolStripMenuItem2 });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(158, 26);
            toolStripMenuItem4.Text = "Inventario";
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.Size = new Size(174, 26);
            ingredientesToolStripMenuItem.Text = "Productos";
            ingredientesToolStripMenuItem.Click += ingredientesToolStripMenuItem_Click;
            // 
            // ingredientesToolStripMenuItem2
            // 
            ingredientesToolStripMenuItem2.Name = "ingredientesToolStripMenuItem2";
            ingredientesToolStripMenuItem2.Size = new Size(174, 26);
            ingredientesToolStripMenuItem2.Text = "Ingredientes";
            ingredientesToolStripMenuItem2.Click += ingredientesToolStripMenuItem2_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(158, 26);
            usuariosToolStripMenuItem.Text = "Usuario";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(158, 26);
            ventaToolStripMenuItem.Text = "Venta";
            ventaToolStripMenuItem.Click += ventaToolStripMenuItem_Click;
            // 
            // vERToolStripMenuItem
            // 
            vERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingredientesToolStripMenuItem1, usuariosToolStripMenuItem1 });
            vERToolStripMenuItem.Name = "vERToolStripMenuItem";
            vERToolStripMenuItem.Size = new Size(49, 24);
            vERToolStripMenuItem.Text = "VER";
            // 
            // ingredientesToolStripMenuItem1
            // 
            ingredientesToolStripMenuItem1.Name = "ingredientesToolStripMenuItem1";
            ingredientesToolStripMenuItem1.Size = new Size(174, 26);
            ingredientesToolStripMenuItem1.Text = "Productos";
            ingredientesToolStripMenuItem1.Click += ingredientesToolStripMenuItem1_Click;
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(174, 26);
            usuariosToolStripMenuItem1.Text = "Ingredientes";
            usuariosToolStripMenuItem1.Click += usuariosToolStripMenuItem1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(283, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(484, 300);
            dataGridView1.TabIndex = 41;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 186);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(12, 155);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 44;
            label6.Text = "ID Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(140, 39);
            label1.TabIndex = 45;
            label1.Text = "USUARIOS";
            // 
            // button1
            // 
            button1.Location = new Point(0, 33);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 46;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 337);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 47;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(128, 337);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 48;
            button3.Text = "Cargar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // VerUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip2);
            Name = "VerUsuarios";
            Text = "VerUsuarios";
            Load += VerUsuarios_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem ingredientesToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem2;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem vERToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem1;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label6;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ErrorProvider errorProvider1;
    }
}