using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Esrtructura_De_Datos.Pilas
{
    class ClassPilasDinamicas
    {
        Nodo Fondo = new Nodo();
        Nodo Cima = new Nodo();

        public ClassPilasDinamicas()
        {
            Fondo = null;
            Cima = null;
        }
        public bool PilaVacia()
        {
            return Fondo == null ? true : false;
        }
        public bool Push(string valorIngresado)
        {
            Nodo Nuevo = new Nodo();
            Nuevo.Valor = valorIngresado;
            if (PilaVacia())
            {
                Cima = Nuevo;
                Fondo = Nuevo;
                return true;
            }
            else
            {
                Cima.Siguiente = Nuevo;
                Cima = Nuevo;
                return true;
            }
        }
        public string Pop()
        {
            if (PilaVacia())
            {
                return "La pila se encuentra vacia";
            }
            else if (Cima == Fondo)
            {
                string valor = Cima.Valor;
                Cima = null;
                Fondo = null;
                return valor;
            }
            else
            {
                string valor = Cima.Valor;
                Nodo Actual = Fondo;
                Nodo Auxiliar = new Nodo();
                while(Actual.Siguiente != null)
                {
                    Auxiliar = Actual;
                    Actual = Actual.Siguiente;
                }
                Auxiliar.Siguiente = null;
                Cima = Auxiliar;
                if (Fondo.Siguiente == null)
                    Fondo = Cima;
                return valor;
            }
        }
        public string Pop(string valorTomado)
        {
            if (PilaVacia())
            {
                return "La pila se encuentra vacia";
            }
            else
            {
                ClassPilasDinamicas PilaDeApoyo = new ClassPilasDinamicas();
                while(Cima.Valor != valorTomado)
                {
                    PilaDeApoyo.Push(Pop());
                }
                Pop();
                while (!PilaDeApoyo.PilaVacia())
                {
                    Push(PilaDeApoyo.Pop());
                }
                return valorTomado;
            }
        }
        public bool LimpiarPila()
        {
            if (PilaVacia())
            {
                return false;
            }
            else
            {
                while(Fondo != null)
                {
                    Pop();
                }
                return true;
            }
        }
    }
}
