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
            panelLogo = new Panel();
            Titulo = new Label();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = Properties.Resources.foot;
            panelLogo.Controls.Add(Titulo);
            panelLogo.Location = new Point(140, 12);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(512, 456);
            panelLogo.TabIndex = 6;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.Transparent;
            Titulo.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(188, -3);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(138, 54);
            Titulo.TabIndex = 0;
            Titulo.Text = "label1";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(800, 450);
            Controls.Add(panelLogo);
            Name = "MenuPrincipal";
            Text = "Estructura de Datos";
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Label Titulo;
    }
}