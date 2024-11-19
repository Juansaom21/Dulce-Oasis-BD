namespace Dulce_Oasis
{
    partial class UIusuario
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
            buttonRegistrar = new Button();
            textBoxNombre = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxContra = new TextBox();
            labelNombre = new Label();
            labelCorreo = new Label();
            labelContra = new Label();
            labelRol = new Label();
            comboBoxRol = new ComboBox();
            label1 = new Label();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            vERToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem1 = new ToolStripMenuItem();
            ingredientesToolStripMenuItem1 = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            button1 = new Button();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonRegistrar.Location = new Point(209, 516);
            buttonRegistrar.Margin = new Padding(3, 4, 3, 4);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(104, 47);
            buttonRegistrar.TabIndex = 0;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(209, 193);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(237, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(209, 281);
            textBoxCorreo.Margin = new Padding(3, 4, 3, 4);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(237, 27);
            textBoxCorreo.TabIndex = 2;
            // 
            // textBoxContra
            // 
            textBoxContra.Location = new Point(209, 376);
            textBoxContra.Margin = new Padding(3, 4, 3, 4);
            textBoxContra.Name = "textBoxContra";
            textBoxContra.Size = new Size(237, 27);
            textBoxContra.TabIndex = 3;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelNombre.Location = new Point(209, 159);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(80, 29);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Nombre";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCorreo.Location = new Point(209, 247);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(69, 29);
            labelCorreo.TabIndex = 6;
            labelCorreo.Text = "Correo";
            // 
            // labelContra
            // 
            labelContra.AutoSize = true;
            labelContra.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelContra.Location = new Point(209, 341);
            labelContra.Name = "labelContra";
            labelContra.Size = new Size(109, 29);
            labelContra.TabIndex = 7;
            labelContra.Text = "Contraseña";
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelRol.Location = new Point(209, 427);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(42, 29);
            labelRol.TabIndex = 8;
            labelRol.Text = "Rol";
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(209, 461);
            comboBoxRol.Margin = new Padding(3, 4, 3, 4);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(237, 28);
            comboBoxRol.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(264, 80);
            label1.Name = "label1";
            label1.Size = new Size(140, 39);
            label1.TabIndex = 10;
            label1.Text = "USUARIOS";
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.MistyRose;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem3, vERToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(7, 3, 0, 3);
            menuStrip2.Size = new Size(670, 30);
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
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4, ventaToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(99, 24);
            toolStripMenuItem3.Text = "AGREAGAR";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, ingredientesToolStripMenuItem });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(158, 26);
            toolStripMenuItem4.Text = "Inventario";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(174, 26);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.Size = new Size(174, 26);
            ingredientesToolStripMenuItem.Text = "Ingredientes";
            ingredientesToolStripMenuItem.Click += ingredientesToolStripMenuItem_Click;
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
            vERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem1, ingredientesToolStripMenuItem1, usuariosToolStripMenuItem });
            vERToolStripMenuItem.Name = "vERToolStripMenuItem";
            vERToolStripMenuItem.Size = new Size(49, 24);
            vERToolStripMenuItem.Text = "VER";
            // 
            // productosToolStripMenuItem1
            // 
            productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            productosToolStripMenuItem1.Size = new Size(174, 26);
            productosToolStripMenuItem1.Text = "Productos";
            productosToolStripMenuItem1.Click += productosToolStripMenuItem1_Click;
            // 
            // ingredientesToolStripMenuItem1
            // 
            ingredientesToolStripMenuItem1.Name = "ingredientesToolStripMenuItem1";
            ingredientesToolStripMenuItem1.Size = new Size(174, 26);
            ingredientesToolStripMenuItem1.Text = "Ingredientes";
            ingredientesToolStripMenuItem1.Click += ingredientesToolStripMenuItem1_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(174, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(0, 36);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 27;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(342, 516);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(104, 47);
            button1.TabIndex = 28;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UIusuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(670, 600);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(menuStrip2);
            Controls.Add(label1);
            Controls.Add(comboBoxRol);
            Controls.Add(labelRol);
            Controls.Add(labelContra);
            Controls.Add(labelCorreo);
            Controls.Add(labelNombre);
            Controls.Add(textBoxContra);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonRegistrar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UIusuario";
            Text = "UIusuario";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegistrar;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private TextBox textBoxContra;
        private Label labelNombre;
        private Label labelCorreo;
        private Label labelContra;
        private Label labelRol;
        private ComboBox comboBoxRol;
        private Label label1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private Button button3;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ToolStripMenuItem vERToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem ingredientesToolStripMenuItem1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private Button button1;
    }
}