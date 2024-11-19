namespace Dulce_Oasis
{
    partial class Venta
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
            menuStrip1 = new MenuStrip();
            pERFILToolStripMenuItem = new ToolStripMenuItem();
            cERRARSESIÓNToolStripMenuItem = new ToolStripMenuItem();
            pRODUCTOSToolStripMenuItem = new ToolStripMenuItem();
            aGREGARToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem1 = new ToolStripMenuItem();
            ingredientesToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            usuariosToolStripMenuItem2 = new ToolStripMenuItem();
            textBox_cedula = new TextBox();
            comboBox1 = new ComboBox();
            button_vender = new Button();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label_precio = new Label();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MistyRose;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pERFILToolStripMenuItem, pRODUCTOSToolStripMenuItem, verToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(636, 30);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // pERFILToolStripMenuItem
            // 
            pERFILToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cERRARSESIÓNToolStripMenuItem });
            pERFILToolStripMenuItem.Name = "pERFILToolStripMenuItem";
            pERFILToolStripMenuItem.Size = new Size(66, 24);
            pERFILToolStripMenuItem.Text = "PERFIL";
            // 
            // cERRARSESIÓNToolStripMenuItem
            // 
            cERRARSESIÓNToolStripMenuItem.Name = "cERRARSESIÓNToolStripMenuItem";
            cERRARSESIÓNToolStripMenuItem.Size = new Size(200, 26);
            cERRARSESIÓNToolStripMenuItem.Text = "CERRAR SESIÓN";
            cERRARSESIÓNToolStripMenuItem.Click += cERRARSESIÓNToolStripMenuItem_Click;
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            pRODUCTOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aGREGARToolStripMenuItem, usuariosToolStripMenuItem });
            pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            pRODUCTOSToolStripMenuItem.Size = new Size(89, 24);
            pRODUCTOSToolStripMenuItem.Text = "AGREGAR";
            // 
            // aGREGARToolStripMenuItem
            // 
            aGREGARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem1, ingredientesToolStripMenuItem });
            aGREGARToolStripMenuItem.Name = "aGREGARToolStripMenuItem";
            aGREGARToolStripMenuItem.Size = new Size(158, 26);
            aGREGARToolStripMenuItem.Text = "Inventario";
            // 
            // productosToolStripMenuItem1
            // 
            productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            productosToolStripMenuItem1.Size = new Size(174, 26);
            productosToolStripMenuItem1.Text = "Productos";
            productosToolStripMenuItem1.Click += productosToolStripMenuItem1_Click;
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.Size = new Size(174, 26);
            ingredientesToolStripMenuItem.Text = "Ingredientes";
            ingredientesToolStripMenuItem.Click += ingredientesToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(158, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inventarioToolStripMenuItem, usuariosToolStripMenuItem1, usuariosToolStripMenuItem2 });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(49, 24);
            verToolStripMenuItem.Text = "VER";
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(174, 26);
            inventarioToolStripMenuItem.Text = "Productos";
            inventarioToolStripMenuItem.Click += inventarioToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(174, 26);
            usuariosToolStripMenuItem1.Text = "Ingredientes";
            usuariosToolStripMenuItem1.Click += usuariosToolStripMenuItem1_Click;
            // 
            // usuariosToolStripMenuItem2
            // 
            usuariosToolStripMenuItem2.Name = "usuariosToolStripMenuItem2";
            usuariosToolStripMenuItem2.Size = new Size(174, 26);
            usuariosToolStripMenuItem2.Text = "Usuarios";
            usuariosToolStripMenuItem2.Click += usuariosToolStripMenuItem2_Click;
            // 
            // textBox_cedula
            // 
            textBox_cedula.Location = new Point(230, 214);
            textBox_cedula.Name = "textBox_cedula";
            textBox_cedula.Size = new Size(151, 27);
            textBox_cedula.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(230, 305);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button_vender
            // 
            button_vender.Location = new Point(186, 441);
            button_vender.Name = "button_vender";
            button_vender.Size = new Size(94, 29);
            button_vender.TabIndex = 20;
            button_vender.Text = "Vender";
            button_vender.UseVisualStyleBackColor = true;
            button_vender.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(230, 116);
            label1.Name = "label1";
            label1.Size = new Size(82, 39);
            label1.TabIndex = 30;
            label1.Text = "Venta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(230, 274);
            label6.Name = "label6";
            label6.Size = new Size(83, 28);
            label6.TabIndex = 44;
            label6.Text = "Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(230, 183);
            label5.Name = "label5";
            label5.Size = new Size(124, 28);
            label5.TabIndex = 45;
            label5.Text = "Cedula Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(214, 369);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 46;
            label2.Text = "Precio:";
            // 
            // label_precio
            // 
            label_precio.AutoSize = true;
            label_precio.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_precio.Location = new Point(300, 369);
            label_precio.Name = "label_precio";
            label_precio.Size = new Size(0, 28);
            label_precio.TabIndex = 47;
            // 
            // button1
            // 
            button1.Location = new Point(0, 33);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 48;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            button2.Location = new Point(325, 441);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 49;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(636, 496);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label_precio);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(button_vender);
            Controls.Add(comboBox1);
            Controls.Add(textBox_cedula);
            Controls.Add(menuStrip1);
            Name = "Venta";
            Text = "Venta";
            Load += Venta_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pERFILToolStripMenuItem;
        private ToolStripMenuItem cERRARSESIÓNToolStripMenuItem;
        private ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private ToolStripMenuItem aGREGARToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem ingredientesToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
        private TextBox textBox_cedula;
        private ComboBox comboBox1;
        private Button button_vender;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label_precio;
        private Button button1;
        private ToolStripMenuItem usuariosToolStripMenuItem2;
        private ErrorProvider errorProvider1;
        private Button button2;
    }
}