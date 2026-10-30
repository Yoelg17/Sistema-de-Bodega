namespace Proyec
{
    partial class FrmMercaderia
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblCardProductos = new System.Windows.Forms.Label();
            this.lblCardUnidades = new System.Windows.Forms.Label();
            this.lblCardValor = new System.Windows.Forms.Label();
            this.lblCardReponer = new System.Windows.Forms.Label();
            this.dgvMercaderia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercaderia)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 95);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblTitulo.Text = "INVENTARIO DE MERCADERÍA";
            this.lblTitulo.Location = new System.Drawing.Point(24, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSubtitulo.Text = "Lista enlazada simple: cada producto nuevo entra al inicio de la lista. Los datos se guardan solos en la carpeta Datos (mercaderia.txt)";
            this.lblSubtitulo.Location = new System.Drawing.Point(27, 56);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 3;
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
            this.pnlFormulario.Location = new System.Drawing.Point(20, 110);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(960, 150);
            this.pnlFormulario.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblCodigo.BackColor = System.Drawing.Color.White;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Location = new System.Drawing.Point(20, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(20, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(170, 32);
            this.txtCodigo.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Text = "Nombre del producto";
            this.lblNombre.Location = new System.Drawing.Point(210, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(210, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 32);
            this.txtNombre.TabIndex = 8;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.Text = "Precio (S/)";
            this.lblPrecio.Location = new System.Drawing.Point(530, 10);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(530, 36);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(150, 32);
            this.txtPrecio.TabIndex = 10;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblStock.BackColor = System.Drawing.Color.White;
            this.lblStock.Text = "Stock";
            this.lblStock.Location = new System.Drawing.Point(700, 10);
            this.lblStock.Name = "lblStock";
            this.lblStock.TabIndex = 11;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(700, 36);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(140, 32);
            this.txtStock.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Location = new System.Drawing.Point(20, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 44);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Location = new System.Drawing.Point(180, 90);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 44);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Location = new System.Drawing.Point(340, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 44);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Text = "Buscar código";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Location = new System.Drawing.Point(500, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 44);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Location = new System.Drawing.Point(660, 90);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 44);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblCardProductos
            // 
            this.lblCardProductos.AutoSize = false;
            this.lblCardProductos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardProductos.ForeColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.lblCardProductos.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblCardProductos.Text = "";
            this.lblCardProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCardProductos.Location = new System.Drawing.Point(20, 268);
            this.lblCardProductos.Name = "lblCardProductos";
            this.lblCardProductos.Size = new System.Drawing.Size(225, 72);
            this.lblCardProductos.TabIndex = 18;
            // 
            // lblCardUnidades
            // 
            this.lblCardUnidades.AutoSize = false;
            this.lblCardUnidades.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardUnidades.ForeColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.lblCardUnidades.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblCardUnidades.Text = "";
            this.lblCardUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCardUnidades.Location = new System.Drawing.Point(265, 268);
            this.lblCardUnidades.Name = "lblCardUnidades";
            this.lblCardUnidades.Size = new System.Drawing.Size(225, 72);
            this.lblCardUnidades.TabIndex = 19;
            // 
            // lblCardValor
            // 
            this.lblCardValor.AutoSize = false;
            this.lblCardValor.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardValor.ForeColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.lblCardValor.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblCardValor.Text = "";
            this.lblCardValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCardValor.Location = new System.Drawing.Point(510, 268);
            this.lblCardValor.Name = "lblCardValor";
            this.lblCardValor.Size = new System.Drawing.Size(225, 72);
            this.lblCardValor.TabIndex = 20;
            // 
            // lblCardReponer
            // 
            this.lblCardReponer.AutoSize = false;
            this.lblCardReponer.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardReponer.ForeColor = System.Drawing.Color.White;
            this.lblCardReponer.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.lblCardReponer.Text = "";
            this.lblCardReponer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCardReponer.Location = new System.Drawing.Point(755, 268);
            this.lblCardReponer.Name = "lblCardReponer";
            this.lblCardReponer.Size = new System.Drawing.Size(225, 72);
            this.lblCardReponer.TabIndex = 21;
            // 
            // dgvMercaderia
            // 
            this.dgvMercaderia.BackgroundColor = System.Drawing.Color.White;
            this.dgvMercaderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercaderia.RowHeadersVisible = false;
            this.dgvMercaderia.Location = new System.Drawing.Point(20, 355);
            this.dgvMercaderia.Name = "dgvMercaderia";
            this.dgvMercaderia.Size = new System.Drawing.Size(960, 305);
            this.dgvMercaderia.TabIndex = 22;
            this.dgvMercaderia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMercaderia_CellClick);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlFormulario.Controls.Add(this.lblCodigo);
            this.pnlFormulario.Controls.Add(this.txtCodigo);
            this.pnlFormulario.Controls.Add(this.lblNombre);
            this.pnlFormulario.Controls.Add(this.txtNombre);
            this.pnlFormulario.Controls.Add(this.lblPrecio);
            this.pnlFormulario.Controls.Add(this.txtPrecio);
            this.pnlFormulario.Controls.Add(this.lblStock);
            this.pnlFormulario.Controls.Add(this.txtStock);
            this.pnlFormulario.Controls.Add(this.btnAgregar);
            this.pnlFormulario.Controls.Add(this.btnModificar);
            this.pnlFormulario.Controls.Add(this.btnEliminar);
            this.pnlFormulario.Controls.Add(this.btnBuscar);
            this.pnlFormulario.Controls.Add(this.btnLimpiar);
            // 
            // FrmMercaderia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.lblCardProductos);
            this.Controls.Add(this.lblCardUnidades);
            this.Controls.Add(this.lblCardValor);
            this.Controls.Add(this.lblCardReponer);
            this.Controls.Add(this.dgvMercaderia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMercaderia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario de mercadería";
            this.Load += new System.EventHandler(this.FrmMercaderia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercaderia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCardProductos;
        private System.Windows.Forms.Label lblCardUnidades;
        private System.Windows.Forms.Label lblCardValor;
        private System.Windows.Forms.Label lblCardReponer;
        private System.Windows.Forms.DataGridView dgvMercaderia;
    }
}
