using Proyec.ListaSimple;
using System;
using System.Windows.Forms;

namespace Proyec
{
    // OPERACIÓN 1 - FILA DE CLIENTES
    // Este formulario controla la fila de la bodega:
    //   "Llegada de cliente" -> el cliente se pone al final de la fila.
    //   "Atender cliente"    -> se atiende al que está primero y sale de la fila.
    // El formulario solo captura datos y muestra resultados; la lógica está en ListaSimpleClientes.
    public partial class FrmColaClientes : Form
    {
        // La fila de clientes (lista enlazada simple que funciona como cola)
        private ListaSimpleClientes colaClientes = new ListaSimpleClientes();

        private int siguienteTurno = 1;   // Turno que se asigna solo cuando el cuadro está vacío
        private int totalAtendidos = 0;   // Cuántos clientes se atendieron en esta sesión

        public FrmColaClientes()
        {
            InitializeComponent();
        }

        private void FrmColaClientes_Load(object sender, EventArgs e)
        {
            ActualizarPantalla();
        }

        // Refresca la lista y los contadores de la pantalla
        private void ActualizarPantalla()
        {
            colaClientes.MostrarClientes(lstClientes);
            lblEnEspera.Text = "En espera: " + colaClientes.TotalClientes();
            lblAtendidos.Text = "Atendidos: " + totalAtendidos;

            NodoCliente proximo = colaClientes.VerPrimero();
            lblProximo.Text = proximo == null ? "Próximo turno: -" : "Próximo turno: " + proximo.Turno;
        }

        // LLEGADA: el cliente entra al final de la fila
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int turno;

            if (string.IsNullOrWhiteSpace(txtTurno.Text))
            {
                // Si no escribió nada, usamos el siguiente turno automático
                turno = siguienteTurno;
            }
            else if (!int.TryParse(txtTurno.Text, out turno) || turno <= 0)
            {
                // No es un número válido (o es 0 o negativo)
                MessageBox.Show("Por favor, ingresa un número de turno válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTurno.Focus();
                return;
            }

            // No se permiten dos clientes con el mismo turno en la fila
            if (colaClientes.ExisteTurno(turno))
            {
                MessageBox.Show($"El turno número {turno} ya se encuentra en la cola. Por favor, ingresa uno diferente.", "Turno Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTurno.Clear();
                txtTurno.Focus();
                return;
            }

            // Agregamos al cliente al final de la fila con la hora actual
            colaClientes.InsertarDetras(turno, DateTime.Now);

            // El turno automático siempre sigue después del mayor usado
            if (turno >= siguienteTurno)
                siguienteTurno = turno + 1;

            txtTurno.Clear();
            txtTurno.Focus();
            ActualizarPantalla();
        }

        // ATENDER: sale el primero de la fila
        private void btnAtender_Click(object sender, EventArgs e)
        {
            NodoCliente atendido = colaClientes.EliminarPrimero();

            if (atendido == null)
            {
                MessageBox.Show("La cola de clientes está vacía.", "Sin Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            totalAtendidos++;

            // Calculamos cuánto esperó el cliente desde que llegó
            TimeSpan espera = DateTime.Now - atendido.Hora;

            MessageBox.Show($"Atendiendo cliente - Turno: {atendido.Turno}\nHora de llegada: {atendido.Hora.ToLongTimeString()}\nTiempo de espera: {espera.Minutes} min {espera.Seconds} s",
                            "Cliente Atendido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarPantalla();
        }

        // VER SIGUIENTE: muestra quién sigue sin sacarlo de la fila
        private void btnVerSiguiente_Click(object sender, EventArgs e)
        {
            NodoCliente proximo = colaClientes.VerPrimero();

            if (proximo == null)
                MessageBox.Show("No hay clientes esperando.", "Cola vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"El próximo en ser atendido es el turno {proximo.Turno}\n(llegó a las {proximo.Hora.ToLongTimeString()}).",
                                "Próximo cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // VACIAR: borra toda la fila (por ejemplo al cerrar la bodega)
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (colaClientes.ListaVacia())
            {
                MessageBox.Show("La cola ya está vacía.", "Sin Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult r = MessageBox.Show("¿Seguro que deseas vaciar toda la fila de clientes?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                colaClientes.VaciarCola();
                ActualizarPantalla();
            }
        }

    }
}
