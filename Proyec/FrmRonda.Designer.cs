namespace Proyec
{
    partial class FrmRonda
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnEjemplo = new System.Windows.Forms.Button();
            this.lblRevisando = new System.Windows.Forms.Label();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnLimpiarHist = new System.Windows.Forms.Button();
            this.lblVueltas = new System.Windows.Forms.Label();
            this.nudVueltas = new System.Windows.Forms.NumericUpDown();
            this.btnRevisar = new System.Windows.Forms.Button();
            this.lblListaCat = new System.Windows.Forms.Label();
            this.lblListaRev = new System.Windows.Forms.Label();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.lstRonda = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudVueltas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(700, 70);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblTitulo.Text = "RONDA DE REVISIÓN DE EXISTENCIAS";
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
            this.lblSubtitulo.Text = "Lista circular: al terminar la última categoría se vuelve a la primera";
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 3;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblCategoria.Text = "Categoría";
            this.lblCategoria.Location = new System.Drawing.Point(24, 90);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.TabIndex = 4;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(110, 86);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(230, 30);
            this.txtCategoria.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Text = "Agregar categoría";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Location = new System.Drawing.Point(350, 84);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 36);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Text = "Quitar categoría";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Location = new System.Drawing.Point(510, 84);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(150, 36);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnEjemplo
            // 
            this.btnEjemplo.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnEjemplo.ForeColor = System.Drawing.Color.White;
            this.btnEjemplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemplo.FlatAppearance.BorderSize = 0;
            this.btnEjemplo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjemplo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplo.Text = "Cargar categorías de ejemplo";
            this.btnEjemplo.UseVisualStyleBackColor = false;
            this.btnEjemplo.Location = new System.Drawing.Point(24, 130);
            this.btnEjemplo.Name = "btnEjemplo";
            this.btnEjemplo.Size = new System.Drawing.Size(200, 34);
            this.btnEjemplo.TabIndex = 8;
            this.btnEjemplo.Click += new System.EventHandler(this.btnEjemplo_Click);
            // 
            // lblRevisando
            // 
            this.lblRevisando.AutoSize = true;
            this.lblRevisando.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevisando.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblRevisando.Text = "Revisando ahora: -";
            this.lblRevisando.Location = new System.Drawing.Point(24, 185);
            this.lblRevisando.Name = "lblRevisando";
            this.lblRevisando.TabIndex = 9;
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgreso.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblProgreso.Text = "Progreso de la vuelta: 0 de 0   |   Vueltas completas: 0";
            this.lblProgreso.Location = new System.Drawing.Point(24, 222);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.TabIndex = 10;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Text = "Revisar siguiente categoría";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Location = new System.Drawing.Point(24, 255);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(260, 44);
            this.btnSiguiente.TabIndex = 11;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Text = "Reiniciar ronda";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Location = new System.Drawing.Point(294, 255);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(170, 44);
            this.btnReiniciar.TabIndex = 12;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnLimpiarHist
            // 
            this.btnLimpiarHist.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnLimpiarHist.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnLimpiarHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarHist.FlatAppearance.BorderSize = 0;
            this.btnLimpiarHist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarHist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarHist.Text = "Limpiar historial";
            this.btnLimpiarHist.UseVisualStyleBackColor = false;
            this.btnLimpiarHist.Location = new System.Drawing.Point(474, 255);
            this.btnLimpiarHist.Name = "btnLimpiarHist";
            this.btnLimpiarHist.Size = new System.Drawing.Size(186, 44);
            this.btnLimpiarHist.TabIndex = 13;
            this.btnLimpiarHist.Click += new System.EventHandler(this.btnLimpiarHist_Click);
            // 
            // lblVueltas
            // 
            this.lblVueltas.AutoSize = true;
            this.lblVueltas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVueltas.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblVueltas.Text = "Ver varias vueltas seguidas:";
            this.lblVueltas.Location = new System.Drawing.Point(24, 320);
            this.lblVueltas.Name = "lblVueltas";
            this.lblVueltas.TabIndex = 14;
            // 
            // nudVueltas
            // 
            this.nudVueltas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVueltas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudVueltas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.nudVueltas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudVueltas.Location = new System.Drawing.Point(250, 316);
            this.nudVueltas.Name = "nudVueltas";
            this.nudVueltas.Size = new System.Drawing.Size(70, 30);
            this.nudVueltas.TabIndex = 15;
            // 
            // btnRevisar
            // 
            this.btnRevisar.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnRevisar.ForeColor = System.Drawing.Color.White;
            this.btnRevisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisar.FlatAppearance.BorderSize = 0;
            this.btnRevisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevisar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisar.Text = "Mostrar vueltas completas";
            this.btnRevisar.UseVisualStyleBackColor = false;
            this.btnRevisar.Location = new System.Drawing.Point(335, 312);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(230, 38);
            this.btnRevisar.TabIndex = 16;
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // lblListaCat
            // 
            this.lblListaCat.AutoSize = true;
            this.lblListaCat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCat.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblListaCat.Text = "Categorías en la ronda";
            this.lblListaCat.Location = new System.Drawing.Point(24, 365);
            this.lblListaCat.Name = "lblListaCat";
            this.lblListaCat.TabIndex = 17;
            // 
            // lblListaRev
            // 
            this.lblListaRev.AutoSize = true;
            this.lblListaRev.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaRev.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblListaRev.Text = "Historial de revisión";
            this.lblListaRev.Location = new System.Drawing.Point(354, 365);
            this.lblListaRev.Name = "lblListaRev";
            this.lblListaRev.TabIndex = 18;
            // 
            // lstCategorias
            // 
            this.lstCategorias.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.HorizontalScrollbar = true;
            this.lstCategorias.ItemHeight = 18;
            this.lstCategorias.Location = new System.Drawing.Point(24, 392);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(310, 220);
            this.lstCategorias.TabIndex = 19;
            // 
            // lstRonda
            // 
            this.lstRonda.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRonda.FormattingEnabled = true;
            this.lstRonda.HorizontalScrollbar = true;
            this.lstRonda.ItemHeight = 16;
            this.lstRonda.Location = new System.Drawing.Point(354, 392);
            this.lstRonda.Name = "lstRonda";
            this.lstRonda.Size = new System.Drawing.Size(320, 220);
            this.lstRonda.TabIndex = 20;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            // 
            // FrmRonda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(700, 635);
            this.AcceptButton = this.btnAgregar;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnEjemplo);
            this.Controls.Add(this.lblRevisando);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnLimpiarHist);
            this.Controls.Add(this.lblVueltas);
            this.Controls.Add(this.nudVueltas);
            this.Controls.Add(this.btnRevisar);
            this.Controls.Add(this.lblListaCat);
            this.Controls.Add(this.lblListaRev);
            this.Controls.Add(this.lstCategorias);
            this.Controls.Add(this.lstRonda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRonda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ronda de revisión";
            this.Load += new System.EventHandler(this.FrmRonda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVueltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnEjemplo;
        private System.Windows.Forms.Label lblRevisando;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnLimpiarHist;
        private System.Windows.Forms.Label lblVueltas;
        private System.Windows.Forms.NumericUpDown nudVueltas;
        private System.Windows.Forms.Button btnRevisar;
        private System.Windows.Forms.Label lblListaCat;
        private System.Windows.Forms.Label lblListaRev;
        private System.Windows.Forms.ListBox lstCategorias;
        private System.Windows.Forms.ListBox lstRonda;
    }
}
