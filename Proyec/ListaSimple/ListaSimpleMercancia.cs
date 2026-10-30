using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Proyec.ListaSimple
{
    // OPERACIÓN 2 - INVENTARIO DE MERCADERÍA (lista enlazada simple)
    // Cada producto nuevo se agrega AL INICIO de la lista, por eso el último
    // que ingresa es el primero que se ve en la tabla.
    public class ListaSimpleMercancia
    {
        private NodoMercancia cabeza;   // Primer producto de la lista

        // Si el stock es menor o igual a este número, avisamos que hay que reponer
        public const int STOCK_MINIMO = 5;

        public ListaSimpleMercancia()
        {
            this.cabeza = null;
        }

        public bool ListaVacia()
        {
            return this.cabeza == null;
        }

        // AGREGAR: el nuevo producto pasa a ser la cabeza de la lista
        public void InsertarAlInicio(string codigo, string nombre, decimal precio, int stock, DateTime fechaHora)
        {
            NodoMercancia nuevo = new NodoMercancia(codigo, nombre, precio, stock, fechaHora);
            nuevo.Siguiente = this.cabeza;   // El nuevo apunta al que antes era el primero
            this.cabeza = nuevo;             // Y ahora el nuevo es el primero
        }

        // Compara dos códigos sin importar mayúsculas (p001 = P001)
        private bool MismoCodigo(string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        // BUSCAR: recorre la lista hasta encontrar el código (devuelve null si no existe)
        public NodoMercancia Buscar(string codigo)
        {
            NodoMercancia aux = this.cabeza;
            while (aux != null)
            {
                if (MismoCodigo(aux.Codigo, codigo))
                {
                    return aux;
                }
                aux = aux.Siguiente;
            }
            return null;
        }

        public bool ExisteCodigo(string codigo)
        {
            return Buscar(codigo) != null;
        }

        // MODIFICAR: cambia los datos del producto que tiene "codigoActual"
        public bool Modificar(string codigoActual, string nuevoCodigo, string nombre, decimal precio, int stock)
        {
            NodoMercancia nodo = Buscar(codigoActual);
            if (nodo == null)
                return false;

            nodo.Codigo = nuevoCodigo;
            nodo.Nombre = nombre;
            nodo.Precio = precio;
            nodo.Stock = stock;
            return true;
        }

        // ELIMINAR: quita un producto "saltándolo" con los enlaces
        public bool Eliminar(string codigo)
        {
            if (this.ListaVacia())
                return false;

            // Caso 1: el producto a eliminar es el primero
            if (MismoCodigo(this.cabeza.Codigo, codigo))
            {
                NodoMercancia primero = this.cabeza;
                this.cabeza = this.cabeza.Siguiente;   // La cabeza avanza al segundo
                primero.Siguiente = null;
                return true;
            }

            // Caso 2: está en medio o al final. Necesitamos recordar al ANTERIOR
            NodoMercancia anterior = this.cabeza;
            NodoMercancia aux = this.cabeza.Siguiente;
            while (aux != null)
            {
                if (MismoCodigo(aux.Codigo, codigo))
                {
                    anterior.Siguiente = aux.Siguiente;  // El anterior "salta" al que se elimina
                    aux.Siguiente = null;
                    return true;
                }
                anterior = aux;
                aux = aux.Siguiente;
            }
            return false;
        }

        // Cuenta cuántos productos distintos hay
        public int TotalProductos()
        {
            int total = 0;
            NodoMercancia aux = this.cabeza;
            while (aux != null)
            {
                total++;
                aux = aux.Siguiente;
            }
            return total;
        }

        // Suma todas las unidades en stock
        public int TotalUnidades()
        {
            int total = 0;
            NodoMercancia aux = this.cabeza;
            while (aux != null)
            {
                total += aux.Stock;
                aux = aux.Siguiente;
            }
            return total;
        }

        // Valor del inventario = suma de (precio x stock) de cada producto
        public decimal ValorInventario()
        {
            decimal total = 0;
            NodoMercancia aux = this.cabeza;
            while (aux != null)
            {
                total += aux.Precio * aux.Stock;
                aux = aux.Siguiente;
            }
            return total;
        }

        // Cuenta los productos con poco stock (hay que reponerlos)
        public int ProductosConPocoStock()
        {
            int total = 0;
            NodoMercancia aux = this.cabeza;
            while (aux != null)
            {
                if (aux.Stock <= STOCK_MINIMO)
                    total++;
                aux = aux.Siguiente;
            }
            return total;
        }

        // Muestra la lista en un DataGridView (tabla)
        public void MostrarMercancia(DataGridView dgv)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Código", typeof(string));
            tabla.Columns.Add("Nombre del Producto", typeof(string));
            tabla.Columns.Add("Precio (S/)", typeof(decimal));
            tabla.Columns.Add("Stock", typeof(int));
            tabla.Columns.Add("Fecha y Hora", typeof(DateTime));

            NodoMercancia aux = this.cabeza;
            while (aux != null)
            {
                tabla.Rows.Add(aux.Codigo, aux.Nombre, aux.Precio, aux.Stock, aux.FechaHora);
                aux = aux.Siguiente;
            }
            dgv.DataSource = tabla;
        }

        // Versión para ListBox (la dejamos por si se necesita en otro formulario)
        public void MostrarMercancia(ListBox lst)
        {
            lst.Items.Clear();
            NodoMercancia aux = this.cabeza;
            while (aux != null)
            {
                lst.Items.Add($"Código: {aux.Codigo} - Producto: {aux.Nombre} - Precio: {aux.Precio} - Stock: {aux.Stock}");
                aux = aux.Siguiente;
            }
        }

        // ---------- GUARDAR Y CARGAR EN ARCHIVO DE TEXTO ----------
        // Cada producto es UNA línea: codigo|nombre|precio|stock|fecha
        // Así los datos no se pierden al cerrar el programa.

        // Quita el símbolo | del texto para no romper el formato de la línea
        private string Limpiar(string texto)
        {
            return texto.Replace("|", " ");
        }

        // GUARDAR: recorre la lista y escribe una línea por producto
        public bool GuardarEnArchivo(string ruta)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(ruta));   // Crea la carpeta Datos si no existe

                List<string> lineas = new List<string>();
                NodoMercancia aux = this.cabeza;
                while (aux != null)
                {
                    lineas.Add(string.Join("|",
                        Limpiar(aux.Codigo),
                        Limpiar(aux.Nombre),
                        aux.Precio.ToString(CultureInfo.InvariantCulture),
                        aux.Stock.ToString(),
                        aux.FechaHora.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)));
                    aux = aux.Siguiente;
                }
                File.WriteAllLines(ruta, lineas.ToArray());
                return true;
            }
            catch (Exception)
            {
                return false;   // Si no se pudo guardar, el programa sigue funcionando
            }
        }

        // CARGAR: lee el archivo y arma la lista de nuevo
        public void CargarDesdeArchivo(string ruta)
        {
            this.cabeza = null;
            if (!File.Exists(ruta))
                return;

            string[] lineas;
            try { lineas = File.ReadAllLines(ruta); }
            catch (Exception) { return; }

            // Se lee de abajo hacia arriba porque InsertarAlInicio pone cada producto adelante:
            // así la lista queda en el mismo orden en que se guardó.
            for (int i = lineas.Length - 1; i >= 0; i--)
            {
                string[] partes = lineas[i].Split('|');
                if (partes.Length < 5)
                    continue;   // Línea vacía o dañada: se ignora

                decimal precio;
                int stock;
                DateTime fecha;
                if (decimal.TryParse(partes[2], NumberStyles.Number, CultureInfo.InvariantCulture, out precio) &&
                    int.TryParse(partes[3], out stock) &&
                    DateTime.TryParse(partes[4], CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
                {
                    InsertarAlInicio(partes[0], partes[1], precio, stock, fecha);
                }
            }
        }
    }
}
