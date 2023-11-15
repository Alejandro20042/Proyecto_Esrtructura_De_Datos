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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Ventana = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 204, 113);
            button1.Location = new Point(12, 59);
            button1.Name = "button1";
            button1.Size = new Size(163, 63);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Location = new Point(505, 316);
            button2.Name = "button2";
            button2.Size = new Size(154, 52);
            button2.TabIndex = 1;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(52, 152, 219);
            button3.Location = new Point(12, 158);
            button3.Name = "button3";
            button3.Size = new Size(163, 63);
            button3.TabIndex = 2;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(217, 83, 79);
            button4.Location = new Point(12, 261);
            button4.Name = "button4";
            button4.Size = new Size(163, 63);
            button4.TabIndex = 3;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox Ventana;
    }
}