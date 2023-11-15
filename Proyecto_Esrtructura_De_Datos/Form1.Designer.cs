namespace Proyecto_Esrtructura_De_Datos
{
    partial class Form1
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
            btnSiguiente = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            Ventana = new ListBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(46, 204, 113);
            btnAgregar.Location = new Point(12, 59);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(163, 63);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.Gold;
            btnSiguiente.Location = new Point(505, 316);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(154, 52);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += button2_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(52, 152, 219);
            btnModificar.Location = new Point(12, 158);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(163, 63);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(217, 83, 79);
            btnEliminar.Location = new Point(12, 261);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(163, 63);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button4_Click;
            // 
            // Ventana
            // 
            Ventana.FormattingEnabled = true;
            Ventana.ItemHeight = 15;
            Ventana.Location = new Point(366, 46);
            Ventana.Name = "Ventana";
            Ventana.Size = new Size(401, 244);
            Ventana.TabIndex = 4;
            Ventana.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(800, 450);
            Controls.Add(Ventana);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Estructura de Datos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnSiguiente;
        private Button btnModificar;
        private Button btnEliminar;
        private ListBox Ventana;
    }
}