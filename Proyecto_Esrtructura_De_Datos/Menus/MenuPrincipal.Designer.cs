namespace Proyecto_Esrtructura_De_Datos
{
    partial class MenuPrincipal
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
            Titulo = new Label();
            btnMenuArrays = new Button();
            btnMenuListas = new Button();
            btnMenuPilas = new Button();
            btnMenuColas = new Button();
            btnSalir = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.Transparent;
            Titulo.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(122, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(414, 54);
            Titulo.TabIndex = 0;
            Titulo.Text = "Estructura De Datos";
            // 
            // btnMenuArrays
            // 
            btnMenuArrays.BackColor = Color.Orange;
            btnMenuArrays.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMenuArrays.ForeColor = SystemColors.ControlLightLight;
            btnMenuArrays.Location = new Point(58, 21);
            btnMenuArrays.Name = "btnMenuArrays";
            btnMenuArrays.Size = new Size(103, 45);
            btnMenuArrays.TabIndex = 1;
            btnMenuArrays.Text = "Arreglos";
            btnMenuArrays.UseVisualStyleBackColor = false;
            btnMenuArrays.Click += btnMenuArrays_Click;
            // 
            // btnMenuListas
            // 
            btnMenuListas.BackColor = Color.OliveDrab;
            btnMenuListas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMenuListas.ForeColor = SystemColors.ControlLightLight;
            btnMenuListas.Location = new Point(58, 188);
            btnMenuListas.Name = "btnMenuListas";
            btnMenuListas.Size = new Size(103, 45);
            btnMenuListas.TabIndex = 2;
            btnMenuListas.Text = "Listas";
            btnMenuListas.UseVisualStyleBackColor = false;
            // 
            // btnMenuPilas
            // 
            btnMenuPilas.BackColor = Color.DarkSlateBlue;
            btnMenuPilas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMenuPilas.ForeColor = SystemColors.ControlLightLight;
            btnMenuPilas.Location = new Point(401, 21);
            btnMenuPilas.Name = "btnMenuPilas";
            btnMenuPilas.Size = new Size(103, 45);
            btnMenuPilas.TabIndex = 3;
            btnMenuPilas.Text = "Pilas";
            btnMenuPilas.UseVisualStyleBackColor = false;
            // 
            // btnMenuColas
            // 
            btnMenuColas.BackColor = Color.DarkBlue;
            btnMenuColas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMenuColas.ForeColor = SystemColors.ControlLightLight;
            btnMenuColas.Location = new Point(401, 188);
            btnMenuColas.Name = "btnMenuColas";
            btnMenuColas.Size = new Size(103, 45);
            btnMenuColas.TabIndex = 4;
            btnMenuColas.Text = "Colas";
            btnMenuColas.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(279, 303);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 45);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.foot;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnMenuPilas);
            panel1.Controls.Add(btnMenuListas);
            panel1.Controls.Add(btnMenuColas);
            panel1.Controls.Add(btnMenuArrays);
            panel1.Location = new Point(50, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 231);
            panel1.TabIndex = 6;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(659, 360);
            Controls.Add(btnSalir);
            Controls.Add(Titulo);
            Controls.Add(panel1);
            Name = "MenuPrincipal";
            Text = "Estructura de Datos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Titulo;
        private Button btnMenuArrays;
        private Button btnMenuListas;
        private Button btnMenuPilas;
        private Button btnMenuColas;
        private Button btnSalir;
        private Panel panel1;
    }
}