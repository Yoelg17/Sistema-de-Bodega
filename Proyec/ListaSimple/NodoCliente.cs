using System;

namespace Proyec.ListaSimple
{
    // OPERACIÓN 1 - Un NODO es "una cajita" de la fila de clientes.
    // Cada cliente que llega a la bodega es un nodo.
    public class NodoCliente
    {
        public int Turno;              // Número de turno del cliente (1, 2, 3...)
        public DateTime Hora;          // Hora a la que llegó
        public NodoCliente Siguiente;  // Flecha hacia el cliente que está DETRÁS en la fila

        public NodoCliente(int turno, DateTime hora)
        {
            this.Turno = turno;
            this.Hora = hora;
            this.Siguiente = null;     // Al crearse, todavía no hay nadie detrás de él
        }
    }
}
