namespace Dulce_Oasis
{
    partial class VerIngredientes
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
            ventasToolStripMenuItem = new ToolStripMenuItem();
            vERToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem1 = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBoxcantidadi = new TextBox();
            textBoxnomrei = new TextBox();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            button5 = new Button();
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
            menuStrip2.Size = new Size(938, 30);
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
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4, usuariosToolStripMenuItem, ventasToolStripMenuItem });
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
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(158, 26);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
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
            ingredientesToolStripMenuItem1.Size = new Size(158, 26);
            ingredientesToolStripMenuItem1.Text = "Productos";
            ingredientesToolStripMenuItem1.Click += ingredientesToolStripMenuItem1_Click;
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(158, 26);
            usuariosToolStripMenuItem1.Text = "Usuarios";
            usuariosToolStripMenuItem1.Click += usuariosToolStripMenuItem1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 33);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 41;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(81, 346);
            label8.Name = "label8";
            label8.Size = new Size(99, 28);
            label8.TabIndex = 46;
            label8.Text = "CANTIDAD";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(81, 247);
            label9.Name = "label9";
            label9.Size = new Size(87, 28);
            label9.TabIndex = 45;
            label9.Text = "NOMBRE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(81, 97);
            label10.Name = "label10";
            label10.Size = new Size(202, 39);
            label10.TabIndex = 44;
            label10.Text = "INGREDIENTES";
            // 
            // textBoxcantidadi
            // 
            textBoxcantidadi.Location = new Point(81, 381);
            textBoxcantidadi.Margin = new Padding(3, 4, 3, 4);
            textBoxcantidadi.Name = "textBoxcantidadi";
            textBoxcantidadi.Size = new Size(140, 27);
            textBoxcantidadi.TabIndex = 43;
            // 
            // textBoxnomrei
            // 
            textBoxnomrei.Location = new Point(81, 282);
            textBoxnomrei.Margin = new Padding(3, 4, 3, 4);
            textBoxnomrei.Name = "textBoxnomrei";
            textBoxnomrei.Size = new Size(140, 27);
            textBoxnomrei.TabIndex = 42;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(354, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(538, 273);
            dataGridView1.TabIndex = 48;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 28);
            comboBox1.TabIndex = 49;
            // 
            // button2
            // 
            button2.Location = new Point(44, 459);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 50;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(167, 459);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 51;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(44, 521);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 52;
            button4.Text = "Cargar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(81, 157);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 53;
            label1.Text = "Código Ingrediente";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button5
            // 
            button5.Location = new Point(167, 521);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 54;
            button5.Text = "Limpiar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // VerIngredientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(938, 587);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(textBoxcantidadi);
            Controls.Add(textBoxnomrei);
            Controls.Add(button1);
            Controls.Add(menuStrip2);
            Name = "VerIngredientes";
            Text = "VerIngredientes";
            Load += VerIngredientes_Load;
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
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem vERToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem1;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBoxcantidadi;
        private TextBox textBoxnomrei;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private ErrorProvider errorProvider1;
        private Button button5;
    }
}