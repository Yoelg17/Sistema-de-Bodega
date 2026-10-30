using Proyec.ListaCircular;
using System;
using System.IO;
using System.Windows.Forms;

namespace Proyec
{
    // OPERACIÓN 4 - RONDA DE REVISIÓN DE EXISTENCIAS
    // La dueña de la bodega revisa el almacén por categorías (Gaseosas, Papas, Galletas, Abarrotes...)
    // y, al terminar la última, vuelve a empezar por la primera. Eso es una lista CIRCULAR.
    //
    // Cómo se usa:
    //   1) Agrega las categorías que se revisan (o usa "Cargar categorías de ejemplo").
    //   2) Presiona "Revisar siguiente categoría": avanza de una en una y completa vueltas.
    //   3) "Mostrar vueltas completas" muestra de golpe varias vueltas de la ronda.
    public partial class FrmRonda : Form
    {
        private ListaCircularRonda ronda = new ListaCircularRonda();

        private int revisadasEnVuelta = 0;   // Categorías revisadas en la vuelta actual
        private int vueltasCompletas = 0;    // Veces que se dio la vuelta entera al círculo

        // Archivo donde se guardan las categorías (carpeta Datos junto al .exe)
        private string rutaArchivo = Path.Combine(Application.StartupPath, "Datos", "categorias.txt");

        public FrmRonda()
        {
            InitializeComponent();

            // Al abrir la pantalla se leen las categorías guardadas
            ronda.CargarDesdeArchivo(rutaArchivo);
        }

        private void FrmRonda_Load(object sender, EventArgs e)
        {
            ronda.MostrarCategorias(lstCategorias);
            ActualizarEtiquetas();
        }

        // Actualiza los textos de "Revisando ahora" y de progreso
        private void ActualizarEtiquetas()
        {
            if (ronda.ListaVacia())
            {
                lblRevisando.Text = "Revisando ahora: -";
                lblProgreso.Text = "Agrega al menos una categoría para empezar.";
                return;
            }

            // Mostramos la categoría que tocará revisar con el siguiente clic
            lblProgreso.Text = $"Próxima a revisar: {ronda.CategoriaActual()}   |   Progreso de la vuelta: {revisadasEnVuelta} de {ronda.TotalCategorias()}   |   Vueltas completas: {vueltasCompletas}";
        }

        // AGREGAR: la categoría entra al final del círculo
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string categoria = txtCategoria.Text.Trim();

            if (string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Por favor, escribe el nombre de la categoría.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ronda.ExisteCategoria(categoria))
            {
                MessageBox.Show($"La categoría \"{categoria}\" ya está en la ronda.", "Categoría duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoria.Focus();
                return;
            }

            ronda.AgregarCategoria(categoria);
            ronda.GuardarEnArchivo(rutaArchivo);   // Guardamos el cambio
            ronda.MostrarCategorias(lstCategorias);

            txtCategoria.Clear();
            txtCategoria.Focus();
            ActualizarEtiquetas();
        }

        // QUITAR: saca una categoría del círculo
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string categoria = txtCategoria.Text.Trim();

            if (string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Escribe el nombre de la categoría que quieres quitar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ronda.EliminarCategoria(categoria))
            {
                MessageBox.Show($"No existe la categoría \"{categoria}\" en la ronda.", "No encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ronda.GuardarEnArchivo(rutaArchivo);   // Guardamos el cambio
            ronda.MostrarCategorias(lstCategorias);

            // Al cambiar el tamaño del círculo, el conteo de la vuelta empieza de nuevo
            revisadasEnVuelta = 0;

            if (ronda.ListaVacia())
                lstRonda.Items.Clear();

            txtCategoria.Clear();
            txtCategoria.Focus();
            ActualizarEtiquetas();
        }

        // REVISAR SIGUIENTE: revisa la categoría que toca y avanza (la ronda continúa donde se quedó)
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (ronda.ListaVacia())
            {
                MessageBox.Show("Primero agrega al menos una categoría a la ronda.", "Ronda vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string categoria = ronda.RevisarSiguiente();
            lblRevisando.Text = "Revisando ahora: " + categoria;
            lstRonda.Items.Add($"Revisando categoría: {categoria}");

            revisadasEnVuelta++;

            // Si ya se revisaron todas, se completó una vuelta y el círculo vuelve a la primera
            if (revisadasEnVuelta >= ronda.TotalCategorias())
            {
                vueltasCompletas++;
                revisadasEnVuelta = 0;
                lstRonda.Items.Add($"--- Vuelta {vueltasCompletas} completa: se vuelve a la primera categoría ---");
            }

            lstRonda.TopIndex = lstRonda.Items.Count - 1;   // Baja la lista hasta el último mensaje
            ActualizarEtiquetas();
        }

        // MOSTRAR VUELTAS: muestra varias vueltas de la ronda de una sola vez
        private void btnRevisar_Click(object sender, EventArgs e)
        {
            if (ronda.ListaVacia())
            {
                MessageBox.Show("Primero agrega al menos una categoría a la ronda.", "Ronda vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Reemplaza el contenido del historial con la simulación de N vueltas
            ronda.MostrarRondaRevision(lstRonda, (int)nudVueltas.Value);
        }

        // REINICIAR: la ronda vuelve a empezar desde la primera categoría
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (ronda.ListaVacia())
                return;

            ronda.ReiniciarRonda();
            revisadasEnVuelta = 0;
            vueltasCompletas = 0;
            lblRevisando.Text = "Revisando ahora: -";
            lstRonda.Items.Clear();
            ActualizarEtiquetas();
        }

        private void btnLimpiarHist_Click(object sender, EventArgs e)
        {
            lstRonda.Items.Clear();
        }

        // EJEMPLO: las 4 categorías que repone la dueña según la visita
        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            string[] ejemplo = { "Gaseosas", "Papas", "Galletas", "Abarrotes" };
            foreach (string cat in ejemplo)
            {
                if (!ronda.ExisteCategoria(cat))
                    ronda.AgregarCategoria(cat);
            }
            ronda.GuardarEnArchivo(rutaArchivo);
            ronda.MostrarCategorias(lstCategorias);
            ActualizarEtiquetas();
        }

    }
}
