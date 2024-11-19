namespace Dulce_Oasis
{
    partial class AgregarIngredientes
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
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            vERToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem1 = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBoxcantidadi = new TextBox();
            textBoxnomrei = new TextBox();
            button3 = new Button();
            errorProvider1 = new ErrorProvider(components);
            button1 = new Button();
            menuStrip2.SuspendLayout();
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
            menuStrip2.Size = new Size(599, 30);
            menuStrip2.TabIndex = 26;
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
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { ingredientesToolStripMenuItem });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(158, 26);
            toolStripMenuItem4.Text = "Inventario";
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.Size = new Size(158, 26);
            ingredientesToolStripMenuItem.Text = "Productos";
            ingredientesToolStripMenuItem.Click += ingredientesToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(158, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
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
            vERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, ingredientesToolStripMenuItem1, usuariosToolStripMenuItem1 });
            vERToolStripMenuItem.Name = "vERToolStripMenuItem";
            vERToolStripMenuItem.Size = new Size(49, 24);
            vERToolStripMenuItem.Text = "VER";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(174, 26);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // ingredientesToolStripMenuItem1
            // 
            ingredientesToolStripMenuItem1.Name = "ingredientesToolStripMenuItem1";
            ingredientesToolStripMenuItem1.Size = new Size(174, 26);
            ingredientesToolStripMenuItem1.Text = "Ingredientes";
            ingredientesToolStripMenuItem1.Click += ingredientesToolStripMenuItem1_Click;
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(174, 26);
            usuariosToolStripMenuItem1.Text = "Usuarios";
            usuariosToolStripMenuItem1.Click += usuariosToolStripMenuItem1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(187, 402);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 32;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(187, 305);
            label8.Name = "label8";
            label8.Size = new Size(99, 28);
            label8.TabIndex = 31;
            label8.Text = "CANTIDAD";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(187, 183);
            label9.Name = "label9";
            label9.Size = new Size(87, 28);
            label9.TabIndex = 30;
            label9.Text = "NOMBRE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(187, 101);
            label10.Name = "label10";
            label10.Size = new Size(202, 39);
            label10.TabIndex = 29;
            label10.Text = "INGREDIENTES";
            // 
            // textBoxcantidadi
            // 
            textBoxcantidadi.Location = new Point(187, 340);
            textBoxcantidadi.Margin = new Padding(3, 4, 3, 4);
            textBoxcantidadi.Name = "textBoxcantidadi";
            textBoxcantidadi.Size = new Size(202, 27);
            textBoxcantidadi.TabIndex = 28;
            // 
            // textBoxnomrei
            // 
            textBoxnomrei.Location = new Point(187, 218);
            textBoxnomrei.Margin = new Padding(3, 4, 3, 4);
            textBoxnomrei.Name = "textBoxnomrei";
            textBoxnomrei.Size = new Size(202, 27);
            textBoxnomrei.TabIndex = 27;
            // 
            // button3
            // 
            button3.Location = new Point(0, 34);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 33;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.Location = new Point(303, 402);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 34;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AgregarIngredientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(599, 525);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(textBoxcantidadi);
            Controls.Add(textBoxnomrei);
            Controls.Add(menuStrip2);
            Name = "AgregarIngredientes";
            Text = "Ingredientes";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
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
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private Button button2;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBoxcantidadi;
        private TextBox textBoxnomrei;
        private Button button3;
        private ToolStripMenuItem vERToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem1;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ErrorProvider errorProvider1;
        private Button button1;
    }
}