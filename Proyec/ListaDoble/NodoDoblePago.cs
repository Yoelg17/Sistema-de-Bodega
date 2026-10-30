using System;

namespace Proyec.ListaDoble
{
    // OPERACIÓN 3 y 5 - Un NODO es un pago registrado en la bodega.
    // Tiene DOS flechas: una al pago de adelante (Siguiente) y otra al de atrás (Anterior).
    public class NodoDoblePago
    {
        public int IdTransaccion;       // Código único del pago (1, 2, 3...)
        public DateTime Hora;           // Hora en que se registró
        public string MedioPago;        // Yape, Plin o Efectivo
        public decimal Monto;           // Cuánto pagó el cliente (en soles)
        public string Estado;           // "Confirmado" o "Pendiente" (si no había internet)
        public NodoDoblePago Siguiente; // Flecha hacia el pago más NUEVO
        public NodoDoblePago Anterior;  // Flecha hacia el pago más ANTIGUO

        public NodoDoblePago(int idTransaccion, DateTime hora, string medioPago, decimal monto, string estado)
        {
            this.IdTransaccion = idTransaccion;
            this.Hora = hora;
            this.MedioPago = medioPago;
            this.Monto = monto;
            this.Estado = estado;
            this.Siguiente = null;
            this.Anterior = null;
        }

        // Constructor corto (el del informe): el pago nace confirmado y sin monto
        public NodoDoblePago(int idTransaccion, DateTime hora, string medioPago)
            : this(idTransaccion, hora, medioPago, 0m, "Confirmado")
        {
        }
    }
}
