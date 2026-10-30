using Proyec.ListaSimple;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyec
{
    // OPERACIÓN 2 - INVENTARIO DE MERCADERÍA
    // Aquí se registra la mercadería que llega al almacén: agregar, buscar, modificar y eliminar.
    // La lista enlazada es la fuente de datos; la tabla solo la muestra.
    public partial class FrmMercaderia : Form
    {
        private ListaSimpleMercancia listaMercaderia = new ListaSimpleMercancia();

        // Código del producto elegido en la tabla (null = ninguno elegido)
        private string codigoSeleccionado = null;

        // Archivo donde se guardan los productos (carpeta Datos junto al .exe)
        private string rutaArchivo = Path.Combine(Application.StartupPath, "Datos", "mercaderia.txt");

        public FrmMercaderia()
        {
            InitializeComponent();

            // Al abrir la pantalla se leen los productos guardados
            listaMercaderia.CargarDesdeArchivo(rutaArchivo);

            ConfigurarTabla();
        }

        private void FrmMercaderia_Load(object sender, EventArgs e)
        {
        }

        // Ajustes de la tabla: solo lectura, se selecciona la fila completa
        private void ConfigurarTabla()
        {
            dgvMercaderia.ReadOnly = true;
            dgvMercaderia.AllowUserToAddRows = false;
            dgvMercaderia.AllowUserToDeleteRows = false;
            dgvMercaderia.MultiSelect = false;
            dgvMercaderia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMercaderia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilo de la tabla: encabezado amarillo, filas más altas y filas alternadas
            dgvMercaderia.EnableHeadersVisualStyles = false;
            dgvMercaderia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMercaderia.ColumnHeadersHeight = 38;
            dgvMercaderia.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 185, 19);
            dgvMercaderia.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dgvMercaderia.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMercaderia.DefaultCellStyle.Font = new Font("Segoe UI", 10.5F);
            dgvMercaderia.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 33, 33);
            dgvMercaderia.DefaultCellStyle.SelectionForeColor = Color.FromArgb(253, 185, 19);
            dgvMercaderia.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvMercaderia.RowTemplate.Height = 30;
            ActualizarTabla();
        }

        // Vuelve a dibujar la tabla y el resumen. Los productos con poco stock se pintan de rojo claro.
        private void ActualizarTabla()
        {
            listaMercaderia.MostrarMercancia(dgvMercaderia);

            foreach (DataGridViewRow fila in dgvMercaderia.Rows)
            {
                int stock = Convert.ToInt32(fila.Cells["Stock"].Value);
                if (stock <= ListaSimpleMercancia.STOCK_MINIMO)
                    fila.DefaultCellStyle.BackColor = Color.MistyRose;
            }
            dgvMercaderia.ClearSelection();

            // Tarjetas de resumen
            lblCardProductos.Text = "PRODUCTOS" + Environment.NewLine + listaMercaderia.TotalProductos();
            lblCardUnidades.Text = "UNIDADES EN STOCK" + Environment.NewLine + listaMercaderia.TotalUnidades();
            lblCardValor.Text = "VALOR DEL INVENTARIO" + Environment.NewLine + "S/ " + listaMercaderia.ValorInventario().ToString("0.00");
            lblCardReponer.Text = "POR REPONER (stock <= " + ListaSimpleMercancia.STOCK_MINIMO + ")" + Environment.NewLine + listaMercaderia.ProductosConPocoStock();
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCodigo.Focus();
            codigoSeleccionado = null;
            dgvMercaderia.ClearSelection();
        }

        // Lee y valida precio y stock de los cuadros de texto. Devuelve false si algo está mal.
        private bool LeerDatos(out string codigo, out string nombre, out decimal precio, out int stock)
        {
            codigo = txtCodigo.Text.Trim();
            nombre = txtNombre.Text.Trim();
            precio = 0;
            stock = 0;

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, completa el código y el nombre del producto.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio) || !int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("El precio y el stock deben ser valores numéricos válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (precio < 0 || stock < 0)
            {
                MessageBox.Show("El precio y el stock no pueden ser negativos.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // AGREGAR: el producto nuevo entra al inicio de la lista
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!LeerDatos(out string codigo, out string nombre, out decimal precio, out int stock))
                return;

            // No se permiten dos productos con el mismo código
            if (listaMercaderia.ExisteCodigo(codigo))
            {
                MessageBox.Show($"Ya existe un producto con el código {codigo}.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            listaMercaderia.InsertarAlInicio(codigo, nombre, precio, stock, DateTime.Now);
            listaMercaderia.GuardarEnArchivo(rutaArchivo);   // Guardamos el cambio
            ActualizarTabla();
            LimpiarCampos();
        }

        // MODIFICAR: cambia el producto que se eligió en la tabla
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (codigoSeleccionado == null)
            {
                MessageBox.Show("Por favor, haz clic en una fila de la tabla para seleccionarla antes de modificar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!LeerDatos(out string codigo, out string nombre, out decimal precio, out int stock))
                return;

            // Si cambió el código, que no choque con el de otro producto
            bool cambioCodigo = !string.Equals(codigo, codigoSeleccionado, StringComparison.OrdinalIgnoreCase);
            if (cambioCodigo && listaMercaderia.ExisteCodigo(codigo))
            {
                MessageBox.Show($"Ya existe otro producto con el código {codigo}.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            if (listaMercaderia.Modificar(codigoSeleccionado, codigo, nombre, precio, stock))
            {
                listaMercaderia.GuardarEnArchivo(rutaArchivo);   // Guardamos el cambio
                MessageBox.Show("Producto modificado correctamente.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarTabla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se encontró el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ELIMINAR: quita el producto elegido (pide confirmación)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (codigoSeleccionado == null)
            {
                MessageBox.Show("Por favor, haz clic en una fila de la tabla para seleccionarla antes de eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show($"¿Eliminar el producto {codigoSeleccionado}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
                return;

            if (listaMercaderia.Eliminar(codigoSeleccionado))
            {
                listaMercaderia.GuardarEnArchivo(rutaArchivo);   // Guardamos el cambio
                MessageBox.Show("Producto eliminado de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarTabla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se encontró el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BUSCAR: escribe un código y se cargan los datos del producto en los cuadros
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Escribe el código que quieres buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NodoMercancia nodo = listaMercaderia.Buscar(codigo);
            if (nodo == null)
            {
                MessageBox.Show($"No existe un producto con el código {codigo}.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lo dejamos listo para modificar o eliminar
            codigoSeleccionado = nodo.Codigo;
            txtCodigo.Text = nodo.Codigo;
            txtNombre.Text = nodo.Nombre;
            txtPrecio.Text = nodo.Precio.ToString();
            txtStock.Text = nodo.Stock.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Al hacer clic en una fila, sus datos pasan a los cuadros de texto
        private void dgvMercaderia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvMercaderia.Rows[e.RowIndex];

            // Convert.ToString no falla si la celda viene vacía
            codigoSeleccionado = Convert.ToString(fila.Cells["Código"].Value);
            txtCodigo.Text = codigoSeleccionado;
            txtNombre.Text = Convert.ToString(fila.Cells["Nombre del Producto"].Value);
            txtPrecio.Text = Convert.ToString(fila.Cells["Precio (S/)"].Value);
            txtStock.Text = Convert.ToString(fila.Cells["Stock"].Value);
        }

    }
}
