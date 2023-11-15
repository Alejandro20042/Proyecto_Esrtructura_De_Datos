using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Esrtructura_De_Datos.Colas
{
    public class ClassColas
    {
        public Nodo Primero = new Nodo();
        public Nodo Ultimo = new Nodo();

        public ClassColas() 
        {
            Primero = null;
            Ultimo = null;
        }

        public bool ColaVacia()
        {
            return Primero == null ? true : false;
        }

        public bool AgregarEnCola(string valor)
        {
            Nodo Nuevo = new Nodo();
            Nuevo.Valor = valor;
            if (ColaVacia())
            {
                Nuevo.Siguiente = null;
                Primero = Nuevo;
                Ultimo = Nuevo;
                return true;
            }
            else
            {
                Nuevo.Siguiente = Ultimo;
                Ultimo = Nuevo;
                return true;
            }
        }
        public string Avance()
        {
            if (ColaVacia())
            {
                return "La Cola Se Encuentra Vacía!";
            }
            else
            {
                string valor = Primero.Valor;
                Nodo Actual = Ultimo;
                Nodo Auxiliar = new Nodo();
                while (Actual.Siguiente != null)
                {
                    Auxiliar = Actual;
                    Actual = Actual.Siguiente;
                }
                Auxiliar.Siguiente = null;
                Primero = Auxiliar;
                if (Ultimo.Siguiente == null)
                    Ultimo = Primero;
                return valor;
            }
        }
    }
}
