namespace Proyecto_Esrtructura_De_Datos
{
    partial class wdwArrays
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnOrdenAscendente = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ventanaDatos = new ListBox();
            panelFondo = new Panel();
            btnOrdenDescendete = new Button();
            panel1 = new Panel();
            btnVolverMenu = new Button();
            panel2 = new Panel();
            btnSalir = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(46, 204, 113);
            btnAgregar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(113, 46);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(163, 63);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // btnOrdenAscendente
            // 
            btnOrdenAscendente.BackColor = Color.Gold;
            btnOrdenAscendente.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOrdenAscendente.ForeColor = SystemColors.ControlLightLight;
            btnOrdenAscendente.Location = new Point(213, 127);
            btnOrdenAscendente.Name = "btnOrdenAscendente";
            btnOrdenAscendente.Size = new Size(163, 63);
            btnOrdenAscendente.TabIndex = 1;
            btnOrdenAscendente.Text = "Ordenar Ascendente";
            btnOrdenAscendente.UseVisualStyleBackColor = false;
            btnOrdenAscendente.Click += button2_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(52, 152, 219);
            btnModificar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(12, 125);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(163, 63);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(217, 83, 79);
            btnEliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(12, 209);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(163, 63);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button4_Click;
            // 
            // ventanaDatos
            // 
            ventanaDatos.FormattingEnabled = true;
            ventanaDatos.ItemHeight = 15;
            ventanaDatos.Location = new Point(412, 46);
            ventanaDatos.Name = "ventanaDatos";
            ventanaDatos.Size = new Size(352, 244);
            ventanaDatos.TabIndex = 4;
            ventanaDatos.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panelFondo
            // 
            panelFondo.BackgroundImage = Properties.Resources.foot;
            panelFondo.BackgroundImageLayout = ImageLayout.Zoom;
            panelFondo.Location = new Point(268, 296);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(240, 153);
            panelFondo.TabIndex = 5;
            // 
            // btnOrdenDescendete
            // 
            btnOrdenDescendete.BackColor = Color.Gold;
            btnOrdenDescendete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOrdenDescendete.ForeColor = SystemColors.ControlLightLight;
            btnOrdenDescendete.Location = new Point(213, 211);
            btnOrdenDescendete.Name = "btnOrdenDescendete";
            btnOrdenDescendete.Size = new Size(163, 63);
            btnOrdenDescendete.TabIndex = 6;
            btnOrdenDescendete.Text = "Ordenar Descendente";
            btnOrdenDescendete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.foot;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnVolverMenu);
            panel1.Location = new Point(12, 296);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 153);
            panel1.TabIndex = 6;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.BackColor = Color.FromArgb(52, 73, 94);
            btnVolverMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnVolverMenu.ForeColor = SystemColors.Window;
            btnVolverMenu.Location = new Point(68, 79);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(95, 63);
            btnVolverMenu.TabIndex = 9;
            btnVolverMenu.Text = "Menú Pricipal";
            btnVolverMenu.UseVisualStyleBackColor = false;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.foot;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(btnSalir);
            panel2.Location = new Point(524, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 153);
            panel2.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.Window;
            btnSalir.Location = new Point(70, 79);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 63);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Cerrar App";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(314, -4);
            label1.Name = "label1";
            label1.Size = new Size(168, 47);
            label1.TabIndex = 8;
            label1.Text = "Arreglos";
            // 
            // wdwArrays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(776, 450);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnOrdenDescendete);
            Controls.Add(btnOrdenAscendente);
            Controls.Add(ventanaDatos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(panelFondo);
            Name = "wdwArrays";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnOrdenAscendente;
        private Button btnModificar;
        private Button btnEliminar;
        private ListBox ventanaDatos;
        private Panel panelFondo;
        private Button btnOrdenDescendete;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnVolverMenu;
        private Button btnSalir;
    }
}