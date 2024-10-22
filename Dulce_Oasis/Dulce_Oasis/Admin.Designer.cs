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
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 36);
            label3.Name = "label3";
            label3.Size = new Size(406, 50);
            label3.TabIndex = 10;
            label3.Text = "HISTORIAL DE COMPRAS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(575, 219);
            dataGridView1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MistyRose;
            menuStrip1.Items.AddRange(new ToolStripItem[] { pERFILToolStripMenuItem, pRODUCTOSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(603, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // pERFILToolStripMenuItem
            // 
            pERFILToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cERRARSESIÓNToolStripMenuItem });
            pERFILToolStripMenuItem.Name = "pERFILToolStripMenuItem";
            pERFILToolStripMenuItem.Size = new Size(54, 20);
            pERFILToolStripMenuItem.Text = "PERFIL";
            // 
            // cERRARSESIÓNToolStripMenuItem
            // 
            cERRARSESIÓNToolStripMenuItem.Name = "cERRARSESIÓNToolStripMenuItem";
            cERRARSESIÓNToolStripMenuItem.Size = new Size(159, 22);
            cERRARSESIÓNToolStripMenuItem.Text = "CERRAR SESIÓN";
            cERRARSESIÓNToolStripMenuItem.Click += cERRARSESIÓNToolStripMenuItem_Click;
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            pRODUCTOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aGREGARToolStripMenuItem, usuariosToolStripMenuItem });
            pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            pRODUCTOSToolStripMenuItem.Size = new Size(61, 20);
            pRODUCTOSToolStripMenuItem.Text = "Agregar";
            // 
            // aGREGARToolStripMenuItem
            // 
            aGREGARToolStripMenuItem.Name = "aGREGARToolStripMenuItem";
            aGREGARToolStripMenuItem.Size = new Size(180, 22);
            aGREGARToolStripMenuItem.Text = "Productos";
            aGREGARToolStripMenuItem.Click += aGREGARToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(180, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(603, 450);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Name = "Admin";
            Text = "Admin";
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
    }
}