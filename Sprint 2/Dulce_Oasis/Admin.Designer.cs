namespace Dulce_Oasis
{
    partial class Admin
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
            label3 = new Label();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            pERFILToolStripMenuItem = new ToolStripMenuItem();
            cERRARSESIÓNToolStripMenuItem = new ToolStripMenuItem();
            pRODUCTOSToolStripMenuItem = new ToolStripMenuItem();
            aGREGARToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem1 = new ToolStripMenuItem();
            ingredientesToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            vERToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem1 = new ToolStripMenuItem();
            productosToolStripMenuItem2 = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(14, 48);
            label3.Name = "label3";
            label3.Size = new Size(510, 63);
            label3.TabIndex = 10;
            label3.Text = "HISTORIAL DE COMPRAS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 119);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(657, 292);
            dataGridView1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MistyRose;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pERFILToolStripMenuItem, pRODUCTOSToolStripMenuItem, vERToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(689, 30);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // pERFILToolStripMenuItem
            // 
            pERFILToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cERRARSESIÓNToolStripMenuItem });
            pERFILToolStripMenuItem.Name = "pERFILToolStripMenuItem";
            pERFILToolStripMenuItem.Size = new Size(66, 24);
            pERFILToolStripMenuItem.Text = "PERFIL";
            pERFILToolStripMenuItem.Click += pERFILToolStripMenuItem_Click;
            // 
            // cERRARSESIÓNToolStripMenuItem
            // 
            cERRARSESIÓNToolStripMenuItem.Name = "cERRARSESIÓNToolStripMenuItem";
            cERRARSESIÓNToolStripMenuItem.Size = new Size(224, 26);
            cERRARSESIÓNToolStripMenuItem.Text = "CERRAR SESIÓN";
            cERRARSESIÓNToolStripMenuItem.Click += cERRARSESIÓNToolStripMenuItem_Click;
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            pRODUCTOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aGREGARToolStripMenuItem, usuariosToolStripMenuItem, ventaToolStripMenuItem });
            pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            pRODUCTOSToolStripMenuItem.Size = new Size(89, 24);
            pRODUCTOSToolStripMenuItem.Text = "AGREGAR";
            // 
            // aGREGARToolStripMenuItem
            // 
            aGREGARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem1, ingredientesToolStripMenuItem });
            aGREGARToolStripMenuItem.Name = "aGREGARToolStripMenuItem";
            aGREGARToolStripMenuItem.Size = new Size(224, 26);
            aGREGARToolStripMenuItem.Text = "Inventario";
            // 
            // productosToolStripMenuItem1
            // 
            productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            productosToolStripMenuItem1.Size = new Size(224, 26);
            productosToolStripMenuItem1.Text = "Productos";
            productosToolStripMenuItem1.Click += productosToolStripMenuItem1_Click;
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.Size = new Size(224, 26);
            ingredientesToolStripMenuItem.Text = "Ingredientes";
            ingredientesToolStripMenuItem.Click += ingredientesToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(224, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(224, 26);
            ventaToolStripMenuItem.Text = "Venta";
            ventaToolStripMenuItem.Click += ventaToolStripMenuItem_Click;
            // 
            // vERToolStripMenuItem
            // 
            vERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingredientesToolStripMenuItem1, productosToolStripMenuItem2, usuariosToolStripMenuItem1 });
            vERToolStripMenuItem.Name = "vERToolStripMenuItem";
            vERToolStripMenuItem.Size = new Size(49, 24);
            vERToolStripMenuItem.Text = "VER";
            // 
            // ingredientesToolStripMenuItem1
            // 
            ingredientesToolStripMenuItem1.Name = "ingredientesToolStripMenuItem1";
            ingredientesToolStripMenuItem1.Size = new Size(224, 26);
            ingredientesToolStripMenuItem1.Text = "Productos";
            ingredientesToolStripMenuItem1.Click += ingredientesToolStripMenuItem1_Click;
            // 
            // productosToolStripMenuItem2
            // 
            productosToolStripMenuItem2.Name = "productosToolStripMenuItem2";
            productosToolStripMenuItem2.Size = new Size(224, 26);
            productosToolStripMenuItem2.Text = "Ingredientes";
            productosToolStripMenuItem2.Click += productosToolStripMenuItem2_Click;
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(224, 26);
            usuariosToolStripMenuItem1.Text = "Usuarios";
            usuariosToolStripMenuItem1.Click += usuariosToolStripMenuItem1_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(689, 441);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pERFILToolStripMenuItem;
        private ToolStripMenuItem cERRARSESIÓNToolStripMenuItem;
        private ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private ToolStripMenuItem aGREGARToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem ingredientesToolStripMenuItem;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ToolStripMenuItem vERToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem1;
        private ToolStripMenuItem productosToolStripMenuItem2;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
    }
}