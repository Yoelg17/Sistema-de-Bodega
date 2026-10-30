using System;
using System.Windows.Forms;

namespace Proyec.ListaSimple
{
    // OPERACIÓN 1 - COLA DE CLIENTES (implementada con una lista enlazada simple)
    // Regla de una cola: el PRIMERO que llega es el PRIMERO que se atiende (FIFO).
    //   - Los clientes nuevos se agregan al FINAL.
    //   - Se atiende (se saca) al que está al INICIO.
    public class ListaSimpleClientes
    {
        private NodoCliente primero;   // Cliente que está al frente de la fila (el próximo a atender)
        private NodoCliente ultimo;    // Cliente que está al final de la fila (el último que llegó)

        public ListaSimpleClientes()
        {
            this.primero = null;       // La fila empieza vacía
            this.ultimo = null;
        }

        // Si "primero" no apunta a nadie no hay clientes
        public bool ListaVacia()
        {
            return this.primero == null;
        }

        // LLEGADA: agrega un cliente al final de la fila (no mueve a los demás)
        public void InsertarDetras(int turno, DateTime hora)
        {
            NodoCliente nuevo = new NodoCliente(turno, hora);

            if (this.ListaVacia())
            {
                // Si no había nadie, el nuevo es el primero Y el último a la vez
                this.primero = nuevo;
                this.ultimo = nuevo;
            }
            else
            {
                // El que estaba al final ahora apunta al nuevo, y el nuevo pasa a ser el último
                this.ultimo.Siguiente = nuevo;
                this.ultimo = nuevo;
            }
        }

        // ATENCIÓN: saca al primero de la fila y lo devuelve (null si no hay nadie)
        public NodoCliente EliminarPrimero()
        {
            if (this.ListaVacia())
                return null;

            NodoCliente atendido = this.primero;        // Guardamos al que vamos a atender
            this.primero = this.primero.Siguiente;      // El segundo pasa a ser el primero

            if (this.primero == null)
            {
                // Si ya no queda nadie, "ultimo" también debe quedar vacío
                this.ultimo = null;
            }

            atendido.Siguiente = null;                  // Lo desconectamos de la fila
            return atendido;
        }

        // Mira quién es el próximo SIN sacarlo de la fila
        public NodoCliente VerPrimero()
        {
            return this.primero;
        }

        // Cuenta cuántos clientes hay esperando (recorre la fila nodo por nodo)
        public int TotalClientes()
        {
            int total = 0;
            NodoCliente aux = this.primero;     // "aux" es un ayudante que va caminando por la fila
            while (aux != null)
            {
                total += 1;
                aux = aux.Siguiente;            // Paso al siguiente cliente
            }
            return total;
        }

        // Pregunta si un número de turno ya está en la fila (para no repetirlo)
        public bool ExisteTurno(int turnoBuscado)
        {
            NodoCliente aux = this.primero;
            while (aux != null)
            {
                if (aux.Turno == turnoBuscado)
                {
                    return true;
                }
                aux = aux.Siguiente;
            }
            return false;
        }

        // Vacía toda la fila (por ejemplo, al cerrar la bodega)
        public void VaciarCola()
        {
            // Basta con soltar las referencias: el recolector de basura libera los nodos
            this.primero = null;
            this.ultimo = null;
        }

        // Muestra la fila en un ListBox, en orden de llegada
        public void MostrarClientes(ListBox lst)
        {
            lst.Items.Clear();
            NodoCliente aux = this.primero;
            while (aux != null)
            {
                string texto = $"Turno: {aux.Turno} - Hora: {aux.Hora.ToLongTimeString()}";

                // Marcamos con una nota al que toca atender ahora
                if (aux == this.primero)
                    texto += "   <- SIGUIENTE";

                lst.Items.Add(texto);
                aux = aux.Siguiente;
            }
        }
    }
}
