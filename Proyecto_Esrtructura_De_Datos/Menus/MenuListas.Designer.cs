namespace Proyecto_Esrtructura_De_Datos.Menus
{
    partial class MenuListas
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
            label1 = new Label();
            btnOrdenDescendete = new Button();
            btnOrdenAscendente = new Button();
            ventanaDatos = new ListBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnVolverMenu = new Button();
            panel2 = new Panel();
            btnSalir = new Button();
            panel1 = new Panel();
            panelFondo = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 47);
            label1.TabIndex = 18;
            label1.Text = "Listas";
            // 
            // btnOrdenDescendete
            // 
            btnOrdenDescendete.BackColor = Color.Gold;
            btnOrdenDescendete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOrdenDescendete.ForeColor = SystemColors.ControlLightLight;
            btnOrdenDescendete.Location = new Point(214, 206);
            btnOrdenDescendete.Name = "btnOrdenDescendete";
            btnOrdenDescendete.Size = new Size(163, 63);
            btnOrdenDescendete.TabIndex = 15;
            btnOrdenDescendete.Text = "Ordenar Descendente";
            btnOrdenDescendete.UseVisualStyleBackColor = false;
            // 
            // btnOrdenAscendente
            // 
            btnOrdenAscendente.BackColor = Color.Gold;
            btnOrdenAscendente.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOrdenAscendente.ForeColor = SystemColors.ControlLightLight;
            btnOrdenAscendente.Location = new Point(214, 137);
            btnOrdenAscendente.Name = "btnOrdenAscendente";
            btnOrdenAscendente.Size = new Size(163, 63);
            btnOrdenAscendente.TabIndex = 10;
            btnOrdenAscendente.Text = "Ordenar Ascendente";
            btnOrdenAscendente.UseVisualStyleBackColor = false;
            // 
            // ventanaDatos
            // 
            ventanaDatos.FormattingEnabled = true;
            ventanaDatos.ItemHeight = 15;
            ventanaDatos.Location = new Point(413, 66);
            ventanaDatos.Name = "ventanaDatos";
            ventanaDatos.Size = new Size(352, 199);
            ventanaDatos.TabIndex = 13;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(217, 83, 79);
            btnEliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(12, 204);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(163, 63);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(52, 152, 219);
            btnModificar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(12, 135);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(163, 63);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(46, 204, 113);
            btnAgregar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(117, 66);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(163, 63);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
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
            panel2.Location = new Point(525, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 153);
            panel2.TabIndex = 17;
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
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.foot;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnVolverMenu);
            panel1.Location = new Point(13, 275);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 153);
            panel1.TabIndex = 16;
            // 
            // panelFondo
            // 
            panelFondo.BackgroundImage = Properties.Resources.foot;
            panelFondo.BackgroundImageLayout = ImageLayout.Zoom;
            panelFondo.Location = new Point(269, 275);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(240, 153);
            panelFondo.TabIndex = 14;
            // 
            // MenuListas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(778, 440);
            Controls.Add(label1);
            Controls.Add(btnOrdenDescendete);
            Controls.Add(btnOrdenAscendente);
            Controls.Add(ventanaDatos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelFondo);
            Name = "MenuListas";
            Text = "Estructura de Datos (Listas)";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOrdenDescendete;
        private Button btnOrdenAscendente;
        private ListBox ventanaDatos;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnVolverMenu;
        private Panel panel2;
        private Button btnSalir;
        private Panel panel1;
        private Panel panelFondo;
    }
}