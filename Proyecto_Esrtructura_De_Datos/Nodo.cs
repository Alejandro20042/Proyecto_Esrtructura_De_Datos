using System;

namespace Proyecto_Esrtructura_De_Datos
{
    public class Nodo
    {
        private string _valor;
        private Nodo _siguiente;

        public Nodo()
        {
            _siguiente = null;
        }
        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public Nodo Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}
