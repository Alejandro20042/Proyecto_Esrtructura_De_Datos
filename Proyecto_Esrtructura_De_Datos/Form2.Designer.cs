﻿namespace Proyecto_Esrtructura_De_Datos
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnRegresar = new Button();
            panelLogo = new Panel();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            resources.ApplyResources(btnRegresar, "btnRegresar");
            btnRegresar.Name = "btnRegresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = Properties.Resources.foot;
            resources.ApplyResources(panelLogo, "panelLogo");
            panelLogo.Name = "panelLogo";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 73, 94);
            Controls.Add(panelLogo);
            Controls.Add(btnRegresar);
            Name = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegresar;
        private Panel panelLogo;
    }
}