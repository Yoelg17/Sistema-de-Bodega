using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyec.ListaCircular
{
    // OPERACIÓN 4 - RONDA DE REVISIÓN (lista enlazada CIRCULAR)
    // Es como un círculo: después de la última categoría se vuelve a la primera,
    // así la ronda se repite sin tener que "empezar de nuevo" el recorrido.
    public class ListaCircularRonda
    {
        // Guardamos solo al ÚLTIMO nodo. Como el último apunta al primero,
        // el primero siempre es "ultimo.Siguiente".
        private NodoCategoria ultimo;

        // Categoría que toca revisar ahora. La ronda sigue desde aquí, no se reinicia.
        private NodoCategoria actual;

        public ListaCircularRonda()
        {
            this.ultimo = null;
            this.actual = null;
        }

        public bool ListaVacia()
        {
            return this.ultimo == null;
        }

        // Agrega una categoría al final del círculo
        public void AgregarCategoria(string categoria)
        {
            NodoCategoria nuevo = new NodoCategoria(categoria);
            if (this.ListaVacia())
            {
                // Primera categoría: se apunta a sí misma (círculo de un solo nodo)
                this.ultimo = nuevo;
                this.ultimo.Siguiente = this.ultimo;
                this.actual = nuevo;
            }
            else
            {
                // El nuevo se coloca entre el último y el primero, y pasa a ser el último
                nuevo.Siguiente = this.ultimo.Siguiente;
                this.ultimo.Siguiente = nuevo;
                this.ultimo = nuevo;
            }
        }

        // Pregunta si la categoría ya está en el círculo (no importan mayúsculas)
        public bool ExisteCategoria(string categoria)
        {
            if (this.ListaVacia())
                return false;

            NodoCategoria aux = this.ultimo.Siguiente;
            do
            {
                if (string.Equals(aux.Categoria, categoria, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                aux = aux.Siguiente;
            } while (aux != this.ultimo.Siguiente);

            return false;
        }

        // Quitar una categoría solo reasigna enlaces
        public bool EliminarCategoria(string categoria)
        {
            if (this.ListaVacia())
                return false;

            NodoCategoria anterior = this.ultimo;
            NodoCategoria aux = this.ultimo.Siguiente;
            do
            {
                if (string.Equals(aux.Categoria, categoria, StringComparison.OrdinalIgnoreCase))
                {
                    if (aux == aux.Siguiente)
                    {
                        // Era la única categoría: la lista queda vacía
                        this.ultimo = null;
                        this.actual = null;
                    }
                    else
                    {
                        // Si la revisión iba a pasar por esta categoría, pasa a la siguiente
                        if (this.actual == aux)
                        {
                            this.actual = aux.Siguiente;
                        }

                        anterior.Siguiente = aux.Siguiente;

                        // Si era la última, la nueva última es la anterior
                        if (aux == this.ultimo)
                        {
                            this.ultimo = anterior;
                        }
                    }
                    aux.Siguiente = null;
                    return true;
                }
                anterior = aux;
                aux = aux.Siguiente;
            } while (aux != this.ultimo.Siguiente);

            return false;
        }

        // Revisa la categoría que toca y avanza a la siguiente. Después de la última vuelve a la primera.
        public string RevisarSiguiente()
        {
            if (this.ListaVacia())
                return null;

            string categoria = this.actual.Categoria;
            this.actual = this.actual.Siguiente;
            return categoria;
        }

        // Cuenta cuántas categorías hay en el círculo
        public int TotalCategorias()
        {
            if (this.ListaVacia())
                return 0;

            int total = 0;
            NodoCategoria aux = this.ultimo.Siguiente;   // Empezamos en la primera
            do
            {
                total++;
                aux = aux.Siguiente;
            } while (aux != this.ultimo.Siguiente);      // Paramos al dar la vuelta completa
            return total;
        }

        // Nombre de la categoría que toca revisar (sin avanzar). Devuelve null si no hay.
        public string CategoriaActual()
        {
            if (this.ListaVacia())
                return null;
            return this.actual.Categoria;
        }

        // Vuelve a empezar la ronda desde la primera categoría
        public void ReiniciarRonda()
        {
            if (!this.ListaVacia())
                this.actual = this.ultimo.Siguiente;
        }

        // Muestra las categorías registradas, una sola vez, en el orden en que se agregaron
        public void MostrarCategorias(ListBox lst)
        {
            lst.Items.Clear();
            if (this.ListaVacia()) return;

            NodoCategoria aux = this.ultimo.Siguiente;
            do
            {
                lst.Items.Add(aux.Categoria);
                aux = aux.Siguiente;
            } while (aux != this.ultimo.Siguiente);
        }

        // Muestra la ronda desde la categoría que toca (sin reiniciar), dando las vueltas indicadas
        public void MostrarRondaRevision(ListBox lst, int vueltas)
        {
            lst.Items.Clear();
            if (this.ListaVacia() || vueltas <= 0) return;

            NodoCategoria aux = this.actual;
            int contador = 0;
            int totalNodos = 0;

            NodoCategoria temp = this.ultimo.Siguiente;
            do
            {
                totalNodos++;
                temp = temp.Siguiente;
            } while (temp != this.ultimo.Siguiente);

            do
            {
                lst.Items.Add($"Revisando categoría: {aux.Categoria}");
                aux = aux.Siguiente;
                contador++;
            } while (contador < (vueltas * totalNodos));
        }

        // ---------- GUARDAR Y CARGAR EN ARCHIVO DE TEXTO ----------
        // Cada categoría es UNA línea del archivo

        public bool GuardarEnArchivo(string ruta)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(ruta));

                List<string> lineas = new List<string>();
                if (!this.ListaVacia())
                {
                    NodoCategoria aux = this.ultimo.Siguiente;   // Empezamos en la primera
                    do
                    {
                        lineas.Add(aux.Categoria);
                        aux = aux.Siguiente;
                    } while (aux != this.ultimo.Siguiente);
                }
                File.WriteAllLines(ruta, lineas.ToArray());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void CargarDesdeArchivo(string ruta)
        {
            this.ultimo = null;
            this.actual = null;
            if (!File.Exists(ruta))
                return;

            string[] lineas;
            try { lineas = File.ReadAllLines(ruta); }
            catch (Exception) { return; }

            foreach (string linea in lineas)
            {
                string categoria = linea.Trim();
                if (categoria != "" && !ExisteCategoria(categoria))
                    AgregarCategoria(categoria);
            }
        }
    }
}
