using Proyec.ListaDoble;
using System;
using System.IO;
using System.Windows.Forms;

namespace Proyec
{
    // OPERACIONES 3 y 5 - HISTORIAL DE PAGOS
    // Operación 3: registrar pagos (Yape, Plin o efectivo) y anular el último.
    // Operación 5: corregir el medio de pago de un pago ya registrado y recorrer el historial.
    // Si no hay internet, el pago queda "Pendiente" y se confirma luego con "Sincronizar".
    public partial class FrmPagos : Form
    {
        private ListaDoblePagos listaPagos = new ListaDoblePagos();

        private int contadorId = 1;             // ID único creciente (un ID anulado no se reutiliza)
        private bool mostrandoAtras = false;    // En qué sentido se muestra la lista

        // Archivo donde se guardan los pagos (carpeta Datos junto al .exe)
        private string rutaArchivo = Path.Combine(Application.StartupPath, "Datos", "pagos.txt");

        public FrmPagos()
        {
            InitializeComponent();
            cboMedioPago.SelectedIndex = 0;     // Empieza en "Efectivo"

            // Al abrir la pantalla se leen los pagos guardados y el ID sigue donde se quedó
            listaPagos.CargarDesdeArchivo(rutaArchivo);
            contadorId = listaPagos.MayorId() + 1;
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            ActualizarPantalla();
        }

        // Guarda todos los pagos en el archivo de texto (se llama después de cada cambio)
        private void GuardarDatos()
        {
            listaPagos.GuardarEnArchivo(rutaArchivo);
        }

        // Muestra la lista en el sentido elegido y actualiza el resumen
        private void ActualizarPantalla()
        {
            if (mostrandoAtras)
                listaPagos.MostrarHaciaAtras(lstPagos);
            else
                listaPagos.MostrarHaciaAdelante(lstPagos);

            lblResumen.Text =
                $"Pagos: {listaPagos.TotalPagos()}   |   Yape: {listaPagos.ContarPorMedio("Yape")}   |   Plin: {listaPagos.ContarPorMedio("Plin")}   |   Efectivo: {listaPagos.ContarPorMedio("Efectivo")}" +
                Environment.NewLine +
                $"Total vendido: S/ {listaPagos.TotalMonto():0.00}   |   Pendientes de confirmar: {listaPagos.ContarPendientes()}";
        }

        // REGISTRAR: agrega el pago al final del historial
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // El monto debe ser un número mayor a 0
            if (!decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingresa un monto válido (mayor a 0).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            string medio = cboMedioPago.SelectedItem.ToString();

            // Sin internet el pago queda pendiente; con internet se confirma al instante
            string estado = chkSinInternet.Checked ? ListaDoblePagos.PENDIENTE : ListaDoblePagos.CONFIRMADO;

            listaPagos.InsertarDetras(contadorId, DateTime.Now, medio, monto, estado);
            contadorId++;

            txtMonto.Clear();
            txtMonto.Focus();
            GuardarDatos();
            ActualizarPantalla();
        }

        // ANULAR ÚLTIMO: quita el pago más reciente (duplicado, error o reintento fallido)
        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            if (listaPagos.ListaVacia())
            {
                MessageBox.Show("No hay pagos registrados.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult r = MessageBox.Show("¿Anular el último pago registrado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
                return;

            NodoDoblePago eliminado = listaPagos.EliminarUltimo();
            MessageBox.Show($"Se eliminó el último pago.\nID: {eliminado.IdTransaccion}\nMedio: {eliminado.MedioPago}\nMonto: S/ {eliminado.Monto:0.00}",
                            "Pago eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GuardarDatos();
            ActualizarPantalla();
        }

        // CORREGIR (Operación 5): cambia el medio de pago del ID indicado
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Usa el medio elegido en la lista desplegable como el nuevo medio
            string nuevoMedio = cboMedioPago.SelectedItem.ToString();

            if (listaPagos.ModificarMedioPago(id, nuevoMedio))
            {
                MessageBox.Show($"El pago {id} ahora es: {nuevoMedio}.", "Pago modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Clear();
                GuardarDatos();
                ActualizarPantalla();
            }
            else
            {
                MessageBox.Show($"No existe un pago con el ID {id}.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // SINCRONIZAR: confirma los pagos que quedaron pendientes por falta de internet
        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            int pendientes = listaPagos.ContarPendientes();
            if (pendientes == 0)
            {
                MessageBox.Show("No hay pagos pendientes.", "Sincronizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int confirmados = listaPagos.SincronizarPendientes();
            MessageBox.Show($"Volvió el internet: se confirmaron {confirmados} pago(s), del más antiguo al más nuevo.", "Sincronizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GuardarDatos();
            ActualizarPantalla();
        }

        // CARGAR VISITA: carga los 11 pagos que se observaron el 4 de septiembre (5:40 a 5:59 p. m.)
        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            if (!listaPagos.ListaVacia())
            {
                MessageBox.Show("Para cargar la visita el historial debe estar vacío. Anula los pagos actuales primero.", "Historial con datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // minuto de la hora 17 (5 p. m.), medio de pago, monto REFERENCIAL
            // (el medio del 3.er pago de las 5:40 no se registró en campo: queda "Efectivo" provisional para corregirlo con la Operación 5)
            object[,] visita =
            {
                { 40, "Yape", 3.50m },     { 40, "Efectivo", 5.00m }, { 40, "Efectivo", 2.00m },
                { 45, "Yape", 4.50m },     { 47, "Efectivo", 3.00m }, { 48, "Plin", 6.00m },
                { 48, "Yape", 3.50m },     { 59, "Yape", 2.50m },     { 59, "Yape", 7.00m },
                { 59, "Efectivo", 4.00m }, { 59, "Yape", 3.00m }
            };

            for (int i = 0; i < visita.GetLength(0); i++)
            {
                DateTime hora = DateTime.Today.AddHours(17).AddMinutes((int)visita[i, 0]);
                listaPagos.InsertarDetras(contadorId, hora, (string)visita[i, 1], (decimal)visita[i, 2], ListaDoblePagos.CONFIRMADO);
                contadorId++;
            }
            GuardarDatos();
            ActualizarPantalla();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            mostrandoAtras = false;
            ActualizarPantalla();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            mostrandoAtras = true;
            ActualizarPantalla();
        }

        // Al elegir una línea de la lista, su ID pasa al cuadro "ID del pago a corregir"
        private void lstPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPagos.SelectedItem == null)
                return;

            // Cada línea empieza así: "ID: 5 - Hora: ..."
            string linea = lstPagos.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            if (partes.Length > 1)
                txtId.Text = partes[1];
        }

    }
}
