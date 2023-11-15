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
        NodoListas Primero = new NodoListas();
        NodoListas Ultimo = new NodoListas();

        public ClassListas()
        {
            Primero = null;
            Ultimo = null;
        }
        public bool EstaVacia()
        {
            return Primero == null ? true : false;
        }
        public bool InsertarEnFinalDeLista(string valorInsertado)
        {
            if (EstaVacia())
            {
                Primero.Valor = valorInsertado;
                Ultimo = Primero;
                return true;
            }
            else
            {
                NodoListas Nuevo = new NodoListas();
                Nuevo.Valor = valorInsertado;
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
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
                NodoListas Actual = Primero;
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
                NodoListas Auxiliar;
                NodoListas Actual = Primero;
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

                return true;

            }
        }
    }
}
