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
            SuspendLayout();
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonRegistrar.Location = new Point(240, 384);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(91, 35);
            buttonRegistrar.TabIndex = 0;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(183, 145);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(208, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(183, 211);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(208, 23);
            textBoxCorreo.TabIndex = 2;
            // 
            // textBoxContra
            // 
            textBoxContra.Location = new Point(183, 282);
            textBoxContra.Name = "textBoxContra";
            textBoxContra.Size = new Size(208, 23);
            textBoxContra.TabIndex = 3;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelNombre.Location = new Point(183, 119);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 23);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Nombre";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCorreo.Location = new Point(183, 185);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(56, 23);
            labelCorreo.TabIndex = 6;
            labelCorreo.Text = "Correo";
            // 
            // labelContra
            // 
            labelContra.AutoSize = true;
            labelContra.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelContra.Location = new Point(183, 256);
            labelContra.Name = "labelContra";
            labelContra.Size = new Size(88, 23);
            labelContra.TabIndex = 7;
            labelContra.Text = "Contraseña";
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelRol.Location = new Point(183, 320);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(33, 23);
            labelRol.TabIndex = 8;
            labelRol.Text = "Rol";
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(183, 346);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(208, 23);
            comboBoxRol.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(231, 60);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 10;
            label1.Text = "USUARIOS";
            // 
            // UIusuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(586, 450);
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
            Name = "UIusuario";
            Text = "UIusuario";
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
    }
}