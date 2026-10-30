namespace Proyec
{
    partial class FrmMenuPrincipal
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
            this.btnAbrirCola = new System.Windows.Forms.Button();
            this.btnAbrirMercaderia = new System.Windows.Forms.Button();
            this.btnAbrirPagos = new System.Windows.Forms.Button();
            this.btnAbrirRonda = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(620, 70);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblTitulo.Text = "SISTEMA BODEGA - MENÚ PRINCIPAL";
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
            this.lblSubtitulo.Text = "Estructuras dinámicas aplicadas a una bodega de barrio (Los Olivos, 2026)";
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 3;
            // 
            // btnAbrirCola
            // 
            this.btnAbrirCola.BackColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.btnAbrirCola.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAbrirCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCola.FlatAppearance.BorderSize = 0;
            this.btnAbrirCola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirCola.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCola.Text = "1. Fila de clientes\n(Cola - lista simple)";
            this.btnAbrirCola.UseVisualStyleBackColor = false;
            this.btnAbrirCola.Location = new System.Drawing.Point(30, 95);
            this.btnAbrirCola.Name = "btnAbrirCola";
            this.btnAbrirCola.Size = new System.Drawing.Size(270, 95);
            this.btnAbrirCola.TabIndex = 4;
            this.btnAbrirCola.Click += new System.EventHandler(this.btnAbrirCola_Click);
            // 
            // btnAbrirMercaderia
            // 
            this.btnAbrirMercaderia.BackColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.btnAbrirMercaderia.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAbrirMercaderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirMercaderia.FlatAppearance.BorderSize = 0;
            this.btnAbrirMercaderia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirMercaderia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirMercaderia.Text = "2. Inventario de mercadería\n(Lista simple)";
            this.btnAbrirMercaderia.UseVisualStyleBackColor = false;
            this.btnAbrirMercaderia.Location = new System.Drawing.Point(320, 95);
            this.btnAbrirMercaderia.Name = "btnAbrirMercaderia";
            this.btnAbrirMercaderia.Size = new System.Drawing.Size(270, 95);
            this.btnAbrirMercaderia.TabIndex = 5;
            this.btnAbrirMercaderia.Click += new System.EventHandler(this.btnAbrirMercaderia_Click);
            // 
            // btnAbrirPagos
            // 
            this.btnAbrirPagos.BackColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.btnAbrirPagos.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAbrirPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirPagos.FlatAppearance.BorderSize = 0;
            this.btnAbrirPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirPagos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPagos.Text = "3. Historial de pagos\n(Lista doble)";
            this.btnAbrirPagos.UseVisualStyleBackColor = false;
            this.btnAbrirPagos.Location = new System.Drawing.Point(30, 210);
            this.btnAbrirPagos.Name = "btnAbrirPagos";
            this.btnAbrirPagos.Size = new System.Drawing.Size(270, 95);
            this.btnAbrirPagos.TabIndex = 6;
            this.btnAbrirPagos.Click += new System.EventHandler(this.btnAbrirPagos_Click);
            // 
            // btnAbrirRonda
            // 
            this.btnAbrirRonda.BackColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.btnAbrirRonda.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAbrirRonda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirRonda.FlatAppearance.BorderSize = 0;
            this.btnAbrirRonda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirRonda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirRonda.Text = "4. Ronda de revisión\n(Lista circular)";
            this.btnAbrirRonda.UseVisualStyleBackColor = false;
            this.btnAbrirRonda.Location = new System.Drawing.Point(320, 210);
            this.btnAbrirRonda.Name = "btnAbrirRonda";
            this.btnAbrirRonda.Size = new System.Drawing.Size(270, 95);
            this.btnAbrirRonda.TabIndex = 7;
            this.btnAbrirRonda.Click += new System.EventHandler(this.btnAbrirRonda_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Location = new System.Drawing.Point(230, 330);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 40);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(620, 395);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnAbrirCola);
            this.Controls.Add(this.btnAbrirMercaderia);
            this.Controls.Add(this.btnAbrirPagos);
            this.Controls.Add(this.btnAbrirRonda);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bodega - Menú principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnAbrirCola;
        private System.Windows.Forms.Button btnAbrirMercaderia;
        private System.Windows.Forms.Button btnAbrirPagos;
        private System.Windows.Forms.Button btnAbrirRonda;
        private System.Windows.Forms.Button btnSalir;
    }
}
