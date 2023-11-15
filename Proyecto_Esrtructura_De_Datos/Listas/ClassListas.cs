using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Esrtructura_De_Datos.Listas
{
    public class ClassListas
    {
        Nodo Primero = new Nodo();
        Nodo Ultimo = new Nodo();

        public ClassListas()
        {
            Primero = null;
            Ultimo = null;
        }
        public bool EstaVacia()
        {
            return Primero == null ? true : false;
        }
        public bool InsertarEnLista(string valorInsertado)
        {
            if (EstaVacia())
            {
                Nodo Nuevo = new Nodo();
                Nuevo.Valor = valorInsertado;
                Nuevo.Siguiente = null;
                Primero= Nuevo;
                Ultimo = Nuevo;
                return true;
            }
            else
            {
                Nodo Nuevo = new Nodo();
                Nuevo.Valor = valorInsertado;
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
                return true;
            }
        }
        public bool InsertarEnLista(string valorInsertado, int dondeInsertar)
        {
            if (EstaVacia())
            {
                Nodo Nuevo = new Nodo();
                Nuevo.Valor = valorInsertado;
                Nuevo.Siguiente = null;
                Primero = Nuevo;
                Ultimo = Nuevo;
                return true;
            }
            else if (LongitudLista() < dondeInsertar)
            {
                Nodo Nuevo = new Nodo();
                Nuevo.Valor = valorInsertado;
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
                return true;
            }
            else if (dondeInsertar < 0)
            {
                Nodo Nuevo = new Nodo();
                Nuevo.Valor = valorInsertado;
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
                return true;
            }
            else
            {
                Nodo Nuevo = new Nodo();
                Nuevo.Valor = valorInsertado;
                Nodo Actual = Primero;
                for (int i = 1; i < dondeInsertar; i++)
                {
                    Actual = Actual.Siguiente;
                }
                Nuevo.Siguiente = Actual.Siguiente;
                Actual.Siguiente = Nuevo;
                return true;
            }
        }

        public int LongitudLista()
        {
            if(EstaVacia())
            {
                return 0;
            }
            else
            {
                int contador = 0;
                Nodo Actual = Primero;
                while(Actual.Siguiente != null)
                {
                    contador++;
                    Actual = Actual.Siguiente;
                }
                return contador;
            }
        }

        public bool Eliminar(string valor)
        {
            if (EstaVacia())
            {
                return false;
            }
            else
            {
                Nodo Auxiliar = new Nodo();
                Nodo Actual = Primero;
                while(Actual.Valor != valor)
                {
                    Auxiliar = Actual;
                    if(Actual.Siguiente == null)
                    {
                        return false;
                    }
                    else
                    {
                        Actual = Actual.Siguiente;
                    }
                }
                if(Actual.Siguiente == null)
                {
                    Auxiliar.Siguiente = null;
                    Ultimo = Auxiliar;
                }
                else if(Primero == Ultimo)
                {
                    Primero = Ultimo = null;
                }
                else if (Primero.Valor == valor)
                {
                    Actual = Actual.Siguiente;
                    Primero.Siguiente = null;
                    Primero = Actual;
                }
                else
                {
                    Auxiliar.Siguiente = Actual.Siguiente;
                    Actual.Siguiente = null;
                }
                return true;

            }
        }
    }
}
