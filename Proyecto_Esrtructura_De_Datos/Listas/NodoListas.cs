using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Proyecto_Esrtructura_De_Datos.Listas
{
    public class NodoListas
    {
        private string _valor;
        private NodoListas _siguiente;

        public NodoListas()
        {
            _siguiente = null;
        }
        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public NodoListas Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}
