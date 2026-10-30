using System;
using System.Windows.Forms;

namespace Proyec
{
    // MENÚ PRINCIPAL: desde aquí se abre cada módulo del sistema.
    // Cada botón crea y muestra el formulario de una operación.
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
        }

        // Operación 1: fila de clientes (cola)
        private void btnAbrirCola_Click(object sender, EventArgs e)
        {
            new FrmColaClientes().Show();
        }

        // Operación 2: inventario de mercadería (lista simple)
        private void btnAbrirMercaderia_Click(object sender, EventArgs e)
        {
            new FrmMercaderia().Show();
        }

        // Operaciones 3 y 5: historial de pagos (lista doble)
        private void btnAbrirPagos_Click(object sender, EventArgs e)
        {
            new FrmPagos().Show();
        }

        // Operación 4: ronda de revisión (lista circular)
        private void btnAbrirRonda_Click(object sender, EventArgs e)
        {
            new FrmRonda().Show();
        }

        // Cierra todo el programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
