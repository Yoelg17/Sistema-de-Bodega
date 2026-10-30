using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Proyec.ListaDoble
{
    // OPERACIÓN 3 y 5 - HISTORIAL DE PAGOS (lista doblemente enlazada)
    // Como cada pago conoce al de adelante y al de atrás:
    //   - Se puede anular el ÚLTIMO pago rápido (Operación 3)
    //   - Se puede recorrer en los dos sentidos y corregir pagos (Operación 5)
    public class ListaDoblePagos
    {
        public const string CONFIRMADO = "Confirmado";
        public const string PENDIENTE = "Pendiente";

        private NodoDoblePago primero;  // Pago más antiguo
        private NodoDoblePago ultimo;   // Pago más reciente

        public ListaDoblePagos()
        {
            this.primero = null;
            this.ultimo = null;
        }

        public bool ListaVacia()
        {
            return this.primero == null;
        }

        // REGISTRAR: agrega un pago al final (siempre es el más nuevo)
        public void InsertarDetras(int idTransaccion, DateTime hora, string medioPago, decimal monto, string estado)
        {
            NodoDoblePago nuevo = new NodoDoblePago(idTransaccion, hora, medioPago, monto, estado);

            if (this.ListaVacia())
            {
                this.primero = nuevo;
                this.ultimo = nuevo;
            }
            else
            {
                this.ultimo.Siguiente = nuevo;   // El último actual apunta hacia adelante al nuevo
                nuevo.Anterior = this.ultimo;    // El nuevo apunta hacia atrás al último actual
                this.ultimo = nuevo;             // El nuevo es ahora el último
            }
        }

        // Versión corta (la del informe): sin monto y confirmado
        public void InsertarDetras(int idTransaccion, DateTime hora, string medioPago)
        {
            InsertarDetras(idTransaccion, hora, medioPago, 0m, CONFIRMADO);
        }

        // ANULAR: quita el último pago. Es rápido porque el último conoce a su anterior
        public NodoDoblePago EliminarUltimo()
        {
            if (this.ListaVacia())
                return null;

            NodoDoblePago eliminado = this.ultimo;

            if (this.primero == this.ultimo)
            {
                // Era el único pago: la lista queda vacía
                this.primero = null;
                this.ultimo = null;
            }
            else
            {
                this.ultimo = this.ultimo.Anterior;  // El penúltimo pasa a ser el último
                this.ultimo.Siguiente = null;        // Y ya no apunta al eliminado
                eliminado.Anterior = null;
            }
            return eliminado;
        }

        // OPERACIÓN 5 - Busca un pago por su ID (devuelve null si no existe)
        public NodoDoblePago BuscarPorId(int idTransaccion)
        {
            NodoDoblePago aux = this.primero;
            while (aux != null)
            {
                if (aux.IdTransaccion == idTransaccion)
                    return aux;
                aux = aux.Siguiente;
            }
            return null;
        }

        // OPERACIÓN 5 - Corrige el medio de pago de un pago ya registrado
        public bool ModificarMedioPago(int idTransaccion, string nuevoMedioPago)
        {
            NodoDoblePago nodo = BuscarPorId(idTransaccion);
            if (nodo == null)
                return false;

            nodo.MedioPago = nuevoMedioPago;   // Solo cambia el dato; los enlaces no se tocan
            return true;
        }

        // SINCRONIZAR: cuando vuelve el internet, confirma los pagos pendientes.
        // Se recorre desde el más antiguo: el primero en quedar pendiente es el primero
        // en enviarse (igual que una cola). Devuelve cuántos se confirmaron.
        public int SincronizarPendientes()
        {
            int confirmados = 0;
            NodoDoblePago aux = this.primero;
            while (aux != null)
            {
                if (aux.Estado == PENDIENTE)
                {
                    aux.Estado = CONFIRMADO;
                    confirmados++;
                }
                aux = aux.Siguiente;
            }
            return confirmados;
        }

        // ---------- Datos para el resumen de la pantalla ----------

        public int TotalPagos()
        {
            int total = 0;
            NodoDoblePago aux = this.primero;
            while (aux != null)
            {
                total++;
                aux = aux.Siguiente;
            }
            return total;
        }

        // Cuántos pagos se hicieron con un medio (Yape, Plin o Efectivo)
        public int ContarPorMedio(string medio)
        {
            int total = 0;
            NodoDoblePago aux = this.primero;
            while (aux != null)
            {
                if (aux.MedioPago == medio)
                    total++;
                aux = aux.Siguiente;
            }
            return total;
        }

        public int ContarPendientes()
        {
            int total = 0;
            NodoDoblePago aux = this.primero;
            while (aux != null)
            {
                if (aux.Estado == PENDIENTE)
                    total++;
                aux = aux.Siguiente;
            }
            return total;
        }

        // Suma de dinero de todos los pagos
        public decimal TotalMonto()
        {
            decimal total = 0;
            NodoDoblePago aux = this.primero;
            while (aux != null)
            {
                total += aux.Monto;
                aux = aux.Siguiente;
            }
            return total;
        }

        // ---------- Mostrar en pantalla ----------

        private string Texto(NodoDoblePago p)
        {
            return $"ID: {p.IdTransaccion} - Hora: {p.Hora:HH:mm:ss} - Pago: {p.MedioPago} - S/ {p.Monto:0.00} - {p.Estado}";
        }

        // Recorre usando la flecha Siguiente: del más antiguo al más nuevo
        public void MostrarHaciaAdelante(ListBox lst)
        {
            lst.Items.Clear();
            NodoDoblePago aux = this.primero;
            while (aux != null)
            {
                lst.Items.Add(Texto(aux));
                aux = aux.Siguiente;
            }
        }

        // Recorre usando la flecha Anterior: del más nuevo al más antiguo
        public void MostrarHaciaAtras(ListBox lst)
        {
            lst.Items.Clear();
            NodoDoblePago aux = this.ultimo;
            while (aux != null)
            {
                lst.Items.Add(Texto(aux));
                aux = aux.Anterior;
            }
        }

        // ---------- GUARDAR Y CARGAR EN ARCHIVO DE TEXTO ----------
        // Cada pago es UNA línea: id|hora|medio|monto|estado

        // Devuelve el ID más alto guardado (para que el siguiente pago no repita ID)
        public int MayorId()
        {
            int mayor = 0;
            NodoDoblePago aux = this.primero;
            while (aux != null)
            {
                if (aux.IdTransaccion > mayor)
                    mayor = aux.IdTransaccion;
                aux = aux.Siguiente;
            }
            return mayor;
        }

        // GUARDAR: escribe los pagos del más antiguo al más nuevo
        public bool GuardarEnArchivo(string ruta)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(ruta));

                List<string> lineas = new List<string>();
                NodoDoblePago aux = this.primero;
                while (aux != null)
                {
                    lineas.Add(string.Join("|",
                        aux.IdTransaccion.ToString(),
                        aux.Hora.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                        aux.MedioPago,
                        aux.Monto.ToString(CultureInfo.InvariantCulture),
                        aux.Estado));
                    aux = aux.Siguiente;
                }
                File.WriteAllLines(ruta, lineas.ToArray());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // CARGAR: lee el archivo y vuelve a armar la lista doble
        public void CargarDesdeArchivo(string ruta)
        {
            this.primero = null;
            this.ultimo = null;
            if (!File.Exists(ruta))
                return;

            string[] lineas;
            try { lineas = File.ReadAllLines(ruta); }
            catch (Exception) { return; }

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split('|');
                if (partes.Length < 5)
                    continue;   // Línea vacía o dañada

                int id;
                DateTime hora;
                decimal monto;
                if (int.TryParse(partes[0], out id) &&
                    DateTime.TryParse(partes[1], CultureInfo.InvariantCulture, DateTimeStyles.None, out hora) &&
                    decimal.TryParse(partes[3], NumberStyles.Number, CultureInfo.InvariantCulture, out monto))
                {
                    InsertarDetras(id, hora, partes[2], monto, partes[4]);
                }
            }
        }
    }
}
