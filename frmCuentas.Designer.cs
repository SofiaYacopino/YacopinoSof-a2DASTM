namespace Vista
{
    partial class frmCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGestion = new Label();
            lblNombreCliente = new Label();
            dgvCuentas = new DataGridView();
            btnCrearCuenta = new Button();
            btnVerMovimientos = new Button();
            gbCuentas = new GroupBox();
            lblCreditos = new Label();
            lblDebitos = new Label();
            lblSaldo = new Label();
            lblTotalCreditos = new Label();
            lblTotalDebitos = new Label();
            lblSaldoActual = new Label();
            gbResumen = new GroupBox();
            dgvMovimientos = new DataGridView();
            lblMovimiento = new Label();
            lblDescripcion = new Label();
            lblMonto = new Label();
            txtMonto = new TextBox();
            txtDescripcion = new TextBox();
            btnRegistrarDebido = new Button();
            btnRegistrarCredito = new Button();
            gbRegistrar = new GroupBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            gbCuentas.SuspendLayout();
            gbResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            gbRegistrar.SuspendLayout();
            SuspendLayout();
            // 
            // lblGestion
            // 
            lblGestion.AutoSize = true;
            lblGestion.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGestion.Location = new Point(177, 36);
            lblGestion.Margin = new Padding(4, 0, 4, 0);
            lblGestion.Name = "lblGestion";
            lblGestion.Size = new Size(165, 21);
            lblGestion.TabIndex = 0;
            lblGestion.Text = "Gestion de cuentas de:";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Times New Roman", 12.096F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreCliente.Location = new Point(369, 36);
            lblNombreCliente.Margin = new Padding(4, 0, 4, 0);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(61, 23);
            lblNombreCliente.TabIndex = 1;
            lblNombreCliente.Text = "label2";
            lblNombreCliente.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvCuentas
            // 
            dgvCuentas.BackgroundColor = Color.Snow;
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.GridColor = Color.ForestGreen;
            dgvCuentas.Location = new Point(53, 75);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersWidth = 53;
            dgvCuentas.Size = new Size(496, 385);
            dgvCuentas.TabIndex = 2;
            dgvCuentas.CellClick += dgvCuentas_SelectionChanged;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.FloralWhite;
            btnCrearCuenta.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearCuenta.Location = new Point(116, 502);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(122, 36);
            btnCrearCuenta.TabIndex = 3;
            btnCrearCuenta.Text = "Crear Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnVerMovimientos
            // 
            btnVerMovimientos.BackColor = Color.FloralWhite;
            btnVerMovimientos.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerMovimientos.Location = new Point(295, 502);
            btnVerMovimientos.Name = "btnVerMovimientos";
            btnVerMovimientos.Size = new Size(144, 36);
            btnVerMovimientos.TabIndex = 4;
            btnVerMovimientos.Text = "Ver movimientos";
            btnVerMovimientos.UseVisualStyleBackColor = false;
            btnVerMovimientos.Click += btnVerMovimientos_Click;
            // 
            // gbCuentas
            // 
            gbCuentas.Controls.Add(lblGestion);
            gbCuentas.Controls.Add(lblNombreCliente);
            gbCuentas.Controls.Add(btnCrearCuenta);
            gbCuentas.Controls.Add(btnVerMovimientos);
            gbCuentas.Controls.Add(dgvCuentas);
            gbCuentas.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbCuentas.Location = new Point(37, 28);
            gbCuentas.Name = "gbCuentas";
            gbCuentas.Size = new Size(602, 581);
            gbCuentas.TabIndex = 7;
            gbCuentas.TabStop = false;
            gbCuentas.Text = "Cuentas Corrientes";
            // 
            // lblCreditos
            // 
            lblCreditos.AutoSize = true;
            lblCreditos.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreditos.Location = new Point(116, 54);
            lblCreditos.Name = "lblCreditos";
            lblCreditos.Size = new Size(104, 21);
            lblCreditos.TabIndex = 15;
            lblCreditos.Text = "Total Creditos";
            // 
            // lblDebitos
            // 
            lblDebitos.AutoSize = true;
            lblDebitos.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDebitos.Location = new Point(116, 106);
            lblDebitos.Name = "lblDebitos";
            lblDebitos.Size = new Size(99, 21);
            lblDebitos.TabIndex = 15;
            lblDebitos.Text = "Total Debitos";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Times New Roman", 12.096F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(116, 173);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(105, 23);
            lblSaldo.TabIndex = 17;
            lblSaldo.Text = "Saldo Total";
            // 
            // lblTotalCreditos
            // 
            lblTotalCreditos.AutoSize = true;
            lblTotalCreditos.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCreditos.Location = new Point(378, 54);
            lblTotalCreditos.Name = "lblTotalCreditos";
            lblTotalCreditos.Size = new Size(52, 21);
            lblTotalCreditos.TabIndex = 18;
            lblTotalCreditos.Text = "label3";
            // 
            // lblTotalDebitos
            // 
            lblTotalDebitos.AutoSize = true;
            lblTotalDebitos.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalDebitos.Location = new Point(378, 106);
            lblTotalDebitos.Name = "lblTotalDebitos";
            lblTotalDebitos.Size = new Size(52, 21);
            lblTotalDebitos.TabIndex = 19;
            lblTotalDebitos.Text = "label5";
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Font = new Font("Times New Roman", 12.096F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldoActual.Location = new Point(378, 173);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(61, 23);
            lblSaldoActual.TabIndex = 20;
            lblSaldoActual.Text = "label6";
            // 
            // gbResumen
            // 
            gbResumen.Controls.Add(lblDebitos);
            gbResumen.Controls.Add(lblSaldoActual);
            gbResumen.Controls.Add(lblCreditos);
            gbResumen.Controls.Add(lblSaldo);
            gbResumen.Controls.Add(lblTotalDebitos);
            gbResumen.Controls.Add(lblTotalCreditos);
            gbResumen.Location = new Point(37, 615);
            gbResumen.Name = "gbResumen";
            gbResumen.Size = new Size(602, 214);
            gbResumen.TabIndex = 21;
            gbResumen.TabStop = false;
            gbResumen.Text = "Resumen";
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.BackgroundColor = Color.Snow;
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(30, 75);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.RowHeadersWidth = 53;
            dgvMovimientos.Size = new Size(553, 385);
            dgvMovimientos.TabIndex = 5;
            dgvMovimientos.CellClick += dgvCuentas_SelectionChanged;
            // 
            // lblMovimiento
            // 
            lblMovimiento.AutoSize = true;
            lblMovimiento.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMovimiento.Location = new Point(18, 490);
            lblMovimiento.Name = "lblMovimiento";
            lblMovimiento.Size = new Size(161, 21);
            lblMovimiento.TabIndex = 8;
            lblMovimiento.Text = "Registrar movimiento";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(151, 572);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 21);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(160, 649);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(56, 21);
            lblMonto.TabIndex = 10;
            lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMonto.ForeColor = Color.DeepPink;
            txtMonto.Location = new Point(333, 641);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(130, 29);
            txtMonto.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.ForeColor = Color.DeepPink;
            txtDescripcion.Location = new Point(333, 564);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(130, 29);
            txtDescripcion.TabIndex = 12;
            // 
            // btnRegistrarDebido
            // 
            btnRegistrarDebido.BackColor = Color.FloralWhite;
            btnRegistrarDebido.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarDebido.Location = new Point(82, 725);
            btnRegistrarDebido.Name = "btnRegistrarDebido";
            btnRegistrarDebido.Size = new Size(150, 34);
            btnRegistrarDebido.TabIndex = 13;
            btnRegistrarDebido.Text = "Registrar debito";
            btnRegistrarDebido.UseVisualStyleBackColor = false;
            btnRegistrarDebido.Click += btnRegistrarDebido_Click;
            // 
            // btnRegistrarCredito
            // 
            btnRegistrarCredito.BackColor = Color.FloralWhite;
            btnRegistrarCredito.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarCredito.Location = new Point(358, 725);
            btnRegistrarCredito.Name = "btnRegistrarCredito";
            btnRegistrarCredito.Size = new Size(151, 34);
            btnRegistrarCredito.TabIndex = 14;
            btnRegistrarCredito.Text = "Registrar crédito";
            btnRegistrarCredito.UseVisualStyleBackColor = false;
            btnRegistrarCredito.Click += btnRegistrarCredito_Click;
            // 
            // gbRegistrar
            // 
            gbRegistrar.Controls.Add(btnRegistrarCredito);
            gbRegistrar.Controls.Add(btnRegistrarDebido);
            gbRegistrar.Controls.Add(txtDescripcion);
            gbRegistrar.Controls.Add(txtMonto);
            gbRegistrar.Controls.Add(lblMonto);
            gbRegistrar.Controls.Add(lblDescripcion);
            gbRegistrar.Controls.Add(lblMovimiento);
            gbRegistrar.Controls.Add(dgvMovimientos);
            gbRegistrar.Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbRegistrar.Location = new Point(657, 28);
            gbRegistrar.Name = "gbRegistrar";
            gbRegistrar.Size = new Size(619, 801);
            gbRegistrar.TabIndex = 6;
            gbRegistrar.TabStop = false;
            gbRegistrar.Text = "Movimientos";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FloralWhite;
            btnSalir.Font = new Font("Segoe UI", 9.792F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1159, 835);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(101, 40);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmCuentas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1317, 874);
            Controls.Add(btnSalir);
            Controls.Add(gbCuentas);
            Controls.Add(gbRegistrar);
            Controls.Add(gbResumen);
            Font = new Font("Segoe UI", 13.8239994F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DeepPink;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCuentas";
            Text = "frmCuentas";
            Load += frmCuentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            gbCuentas.ResumeLayout(false);
            gbCuentas.PerformLayout();
            gbResumen.ResumeLayout(false);
            gbResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            gbRegistrar.ResumeLayout(false);
            gbRegistrar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblGestion;
        private Label lblNombreCliente;
        private DataGridView dgvCuentas;
        private Button btnCrearCuenta;
        private Button btnVerMovimientos;
        private GroupBox gbCuentas;
        private Label lblCreditos;
        private Label lblDebitos;
        private Label lblSaldo;
        private Label lblTotalCreditos;
        private Label lblTotalDebitos;
        private Label lblSaldoActual;
        private GroupBox gbResumen;
        private DataGridView dgvMovimientos;
        private Label lblMovimiento;
        private Label lblDescripcion;
        private Label lblMonto;
        private TextBox txtMonto;
        private TextBox txtDescripcion;
        private Button btnRegistrarDebido;
        private Button btnRegistrarCredito;
        private GroupBox gbRegistrar;
        private Button btnSalir;
    }
}