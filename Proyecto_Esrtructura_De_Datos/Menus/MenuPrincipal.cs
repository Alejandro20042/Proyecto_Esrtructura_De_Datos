using Proyecto_Esrtructura_De_Datos.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Esrtructura_De_Datos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMenuArrays_Click(object sender, EventArgs e)
        {
            wdwArrays menuArrays = new wdwArrays();
            this.Hide();
            menuArrays.Show();
        }
        private void btnMenuListas_Click(object sender, EventArgs e)
        {
            //MenuPilas menu = new MenuPilas()
            //{

            //}
        }
    }
}
