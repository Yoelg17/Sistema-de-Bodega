namespace Proyec
{
    partial class FrmColaClientes
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
            this.lblTurno = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.lblAyudaTurno = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnVerSiguiente = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.lblEnEspera = new System.Windows.Forms.Label();
            this.lblAtendidos = new System.Windows.Forms.Label();
            this.lblProximo = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(640, 70);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblTitulo.Text = "FILA DE CLIENTES";
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
            this.lblSubtitulo.Text = "Cola: el primero en llegar es el primero en ser atendido (lista enlazada simple)";
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 3;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblTurno.Text = "Número de turno (opcional):";
            this.lblTurno.Location = new System.Drawing.Point(24, 90);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.TabIndex = 4;
            // 
            // txtTurno
            // 
            this.txtTurno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurno.Location = new System.Drawing.Point(250, 86);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(120, 30);
            this.txtTurno.TabIndex = 5;
            // 
            // lblAyudaTurno
            // 
            this.lblAyudaTurno.AutoSize = true;
            this.lblAyudaTurno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyudaTurno.ForeColor = System.Drawing.Color.Gray;
            this.lblAyudaTurno.Text = "Vacío = turno automático";
            this.lblAyudaTurno.Location = new System.Drawing.Point(380, 92);
            this.lblAyudaTurno.Name = "lblAyudaTurno";
            this.lblAyudaTurno.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(253, 185, 19);
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Text = "Llegada de cliente";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Location = new System.Drawing.Point(24, 135);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(190, 42);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAtender.ForeColor = System.Drawing.Color.White;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.FlatAppearance.BorderSize = 0;
            this.btnAtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtender.Text = "Atender cliente";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Location = new System.Drawing.Point(224, 135);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(190, 42);
            this.btnAtender.TabIndex = 8;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnVerSiguiente
            // 
            this.btnVerSiguiente.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnVerSiguiente.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnVerSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSiguiente.FlatAppearance.BorderSize = 0;
            this.btnVerSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSiguiente.Text = "Ver quién sigue";
            this.btnVerSiguiente.UseVisualStyleBackColor = false;
            this.btnVerSiguiente.Location = new System.Drawing.Point(424, 135);
            this.btnVerSiguiente.Name = "btnVerSiguiente";
            this.btnVerSiguiente.Size = new System.Drawing.Size(190, 42);
            this.btnVerSiguiente.TabIndex = 9;
            this.btnVerSiguiente.Click += new System.EventHandler(this.btnVerSiguiente_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnVaciar.ForeColor = System.Drawing.Color.White;
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciar.FlatAppearance.BorderSize = 0;
            this.btnVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.Text = "Vaciar cola";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Location = new System.Drawing.Point(24, 187);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(190, 36);
            this.btnVaciar.TabIndex = 10;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // lblEnEspera
            // 
            this.lblEnEspera.AutoSize = true;
            this.lblEnEspera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnEspera.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblEnEspera.Text = "En espera: 0";
            this.lblEnEspera.Location = new System.Drawing.Point(24, 240);
            this.lblEnEspera.Name = "lblEnEspera";
            this.lblEnEspera.TabIndex = 11;
            // 
            // lblAtendidos
            // 
            this.lblAtendidos.AutoSize = true;
            this.lblAtendidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendidos.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblAtendidos.Text = "Atendidos: 0";
            this.lblAtendidos.Location = new System.Drawing.Point(200, 240);
            this.lblAtendidos.Name = "lblAtendidos";
            this.lblAtendidos.TabIndex = 12;
            // 
            // lblProximo
            // 
            this.lblProximo.AutoSize = true;
            this.lblProximo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximo.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblProximo.Text = "Próximo turno: -";
            this.lblProximo.Location = new System.Drawing.Point(380, 240);
            this.lblProximo.Name = "lblProximo";
            this.lblProximo.TabIndex = 13;
            // 
            // lstClientes
            // 
            this.lstClientes.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.HorizontalScrollbar = true;
            this.lstClientes.ItemHeight = 18;
            this.lstClientes.Location = new System.Drawing.Point(24, 280);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(590, 240);
            this.lstClientes.TabIndex = 14;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            // 
            // FrmColaClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(640, 545);
            this.AcceptButton = this.btnRegistrar;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.lblAyudaTurno);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnVerSiguiente);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.lblEnEspera);
            this.Controls.Add(this.lblAtendidos);
            this.Controls.Add(this.lblProximo);
            this.Controls.Add(this.lstClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmColaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fila de clientes";
            this.Load += new System.EventHandler(this.FrmColaClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label lblAyudaTurno;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnVerSiguiente;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Label lblEnEspera;
        private System.Windows.Forms.Label lblAtendidos;
        private System.Windows.Forms.Label lblProximo;
        private System.Windows.Forms.ListBox lstClientes;
    }
}
