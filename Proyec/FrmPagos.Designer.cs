namespace Proyec
{
    partial class FrmPagos
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
            this.lblMedio = new System.Windows.Forms.Label();
            this.cboMedioPago = new System.Windows.Forms.ComboBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.chkSinInternet = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminarUltimo = new System.Windows.Forms.Button();
            this.btnSincronizar = new System.Windows.Forms.Button();
            this.btnEjemplo = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lstPagos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 70);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblTitulo.Text = "HISTORIAL DE PAGOS";
            this.lblTitulo.Location = new System.Drawing.Point(16, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSubtitulo.Text = "Lista doblemente enlazada: se recorre hacia adelante y hacia atrás";
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 3;
            // 
            // lblMedio
            // 
            this.lblMedio.AutoSize = true;
            this.lblMedio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedio.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblMedio.Text = "Medio de pago";
            this.lblMedio.Location = new System.Drawing.Point(24, 90);
            this.lblMedio.Name = "lblMedio";
            this.lblMedio.TabIndex = 4;
            // 
            // cboMedioPago
            // 
            this.cboMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedioPago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMedioPago.FormattingEnabled = true;
            this.cboMedioPago.Items.AddRange(new object[] {"Efectivo", "Yape", "Plin"});
            this.cboMedioPago.Location = new System.Drawing.Point(24, 114);
            this.cboMedioPago.Name = "cboMedioPago";
            this.cboMedioPago.Size = new System.Drawing.Size(170, 30);
            this.cboMedioPago.TabIndex = 5;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblMonto.Text = "Monto (S/)";
            this.lblMonto.Location = new System.Drawing.Point(210, 90);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.TabIndex = 6;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(210, 114);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(120, 30);
            this.txtMonto.TabIndex = 7;
            // 
            // chkSinInternet
            // 
            this.chkSinInternet.AutoSize = true;
            this.chkSinInternet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSinInternet.Text = "Sin internet (queda pendiente)";
            this.chkSinInternet.UseVisualStyleBackColor = true;
            this.chkSinInternet.Location = new System.Drawing.Point(350, 118);
            this.chkSinInternet.Name = "chkSinInternet";
            this.chkSinInternet.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Text = "Registrar pago";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Location = new System.Drawing.Point(24, 160);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(170, 40);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminarUltimo
            // 
            this.btnEliminarUltimo.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnEliminarUltimo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUltimo.FlatAppearance.BorderSize = 0;
            this.btnEliminarUltimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUltimo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUltimo.Text = "Anular último pago";
            this.btnEliminarUltimo.UseVisualStyleBackColor = false;
            this.btnEliminarUltimo.Location = new System.Drawing.Point(204, 160);
            this.btnEliminarUltimo.Name = "btnEliminarUltimo";
            this.btnEliminarUltimo.Size = new System.Drawing.Size(170, 40);
            this.btnEliminarUltimo.TabIndex = 10;
            this.btnEliminarUltimo.Click += new System.EventHandler(this.btnEliminarUltimo_Click);
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnSincronizar.ForeColor = System.Drawing.Color.White;
            this.btnSincronizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSincronizar.FlatAppearance.BorderSize = 0;
            this.btnSincronizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSincronizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSincronizar.Text = "Sincronizar pendientes";
            this.btnSincronizar.UseVisualStyleBackColor = false;
            this.btnSincronizar.Location = new System.Drawing.Point(384, 160);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(200, 40);
            this.btnSincronizar.TabIndex = 11;
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // btnEjemplo
            // 
            this.btnEjemplo.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnEjemplo.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnEjemplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemplo.FlatAppearance.BorderSize = 0;
            this.btnEjemplo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjemplo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplo.Text = "Cargar visita";
            this.btnEjemplo.UseVisualStyleBackColor = false;
            this.btnEjemplo.Location = new System.Drawing.Point(594, 160);
            this.btnEjemplo.Name = "btnEjemplo";
            this.btnEjemplo.Size = new System.Drawing.Size(142, 40);
            this.btnEjemplo.TabIndex = 12;
            this.btnEjemplo.Click += new System.EventHandler(this.btnEjemplo_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblId.Text = "ID del pago a corregir";
            this.lblId.Location = new System.Drawing.Point(24, 222);
            this.lblId.Name = "lblId";
            this.lblId.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(200, 218);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(90, 30);
            this.txtId.TabIndex = 14;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Text = "Cambiar medio de pago de ese ID";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Location = new System.Drawing.Point(300, 214);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(300, 38);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnAdelante.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdelante.FlatAppearance.BorderSize = 0;
            this.btnAdelante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdelante.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdelante.Text = "Ver hacia adelante  >>";
            this.btnAdelante.UseVisualStyleBackColor = false;
            this.btnAdelante.Location = new System.Drawing.Point(24, 264);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(200, 36);
            this.btnAdelante.TabIndex = 16;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnAtras.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Text = "<<  Ver hacia atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Location = new System.Drawing.Point(234, 264);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(200, 36);
            this.btnAtras.TabIndex = 17;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblResumen.Text = "";
            this.lblResumen.Location = new System.Drawing.Point(24, 312);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.TabIndex = 18;
            // 
            // lstPagos
            // 
            this.lstPagos.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPagos.FormattingEnabled = true;
            this.lstPagos.HorizontalScrollbar = true;
            this.lstPagos.ItemHeight = 16;
            this.lstPagos.Location = new System.Drawing.Point(24, 360);
            this.lstPagos.Name = "lstPagos";
            this.lstPagos.Size = new System.Drawing.Size(712, 300);
            this.lstPagos.TabIndex = 19;
            this.lstPagos.SelectedIndexChanged += new System.EventHandler(this.lstPagos_SelectedIndexChanged);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            // 
            // FrmPagos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(760, 685);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblMedio);
            this.Controls.Add(this.cboMedioPago);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.chkSinInternet);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEliminarUltimo);
            this.Controls.Add(this.btnSincronizar);
            this.Controls.Add(this.btnEjemplo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.lstPagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de pagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblMedio;
        private System.Windows.Forms.ComboBox cboMedioPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.CheckBox chkSinInternet;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminarUltimo;
        private System.Windows.Forms.Button btnSincronizar;
        private System.Windows.Forms.Button btnEjemplo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.ListBox lstPagos;
    }
}
