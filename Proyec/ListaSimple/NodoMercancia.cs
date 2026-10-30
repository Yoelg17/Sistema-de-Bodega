using System;

namespace Proyec.ListaSimple
{
    // OPERACIÓN 2 - Un NODO es un producto del almacén
    public class NodoMercancia
    {
        public string Codigo;           // Código único del producto (P001, P002...)
        public string Nombre;           // Nombre (Gaseosa, Papas...)
        public decimal Precio;          // Precio de venta en soles
        public int Stock;               // Unidades disponibles
        public DateTime FechaHora;      // Cuándo se registró
        public NodoMercancia Siguiente; // Flecha hacia el siguiente producto de la lista

        public NodoMercancia(string codigo, string nombre, decimal precio, int stock, DateTime fechaHora)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
            this.FechaHora = fechaHora;
            this.Siguiente = null;
        }
    }
}
