namespace Vista
{
    partial class frmClientes
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
            grbIngreso = new GroupBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTelefono = new Label();
            lblDNI = new Label();
            txtTelefono = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            dgvClientes = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            btnVerCuentas = new Button();
            grbIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // grbIngreso
            // 
            grbIngreso.BackColor = Color.FloralWhite;
            grbIngreso.Controls.Add(lblNombre);
            grbIngreso.Controls.Add(lblApellido);
            grbIngreso.Controls.Add(lblTelefono);
            grbIngreso.Controls.Add(lblDNI);
            grbIngreso.Controls.Add(txtTelefono);
            grbIngreso.Controls.Add(txtDNI);
            grbIngreso.Controls.Add(txtApellido);
            grbIngreso.Controls.Add(txtNombre);
            grbIngreso.Location = new Point(43, 25);
            grbIngreso.Name = "grbIngreso";
            grbIngreso.Size = new Size(473, 421);
            grbIngreso.TabIndex = 0;
            grbIngreso.TabStop = false;
            grbIngreso.Text = "Ingreso de datos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(67, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(67, 149);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 21);
            lblApellido.TabIndex = 10;
            lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(67, 336);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 21);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(67, 240);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(37, 21);
            lblDNI.TabIndex = 8;
            lblDNI.Text = "DNI";
            // 
            // txtTelefono
            // 
            txtTelefono.ForeColor = Color.DeepPink;
            txtTelefono.Location = new Point(255, 336);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(130, 29);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextChanged += textBox4_TextChanged;
            // 
            // txtDNI
            // 
            txtDNI.ForeColor = Color.DeepPink;
            txtDNI.Location = new Point(255, 240);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(130, 29);
            txtDNI.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.ForeColor = Color.DeepPink;
            txtApellido.Location = new Point(255, 149);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(130, 29);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.DeepPink;
            txtNombre.Location = new Point(255, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 29);
            txtNombre.TabIndex = 4;
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = Color.Snow;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(608, 12);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 53;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(509, 486);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FloralWhite;
            btnAgregar.Location = new Point(171, 495);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 30);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FloralWhite;
            btnEliminar.Location = new Point(440, 495);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FloralWhite;
            btnModificar.Location = new Point(313, 495);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 30);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FloralWhite;
            btnNuevo.Location = new Point(43, 495);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(98, 30);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnVerCuentas
            // 
            btnVerCuentas.BackColor = Color.FloralWhite;
            btnVerCuentas.Location = new Point(761, 516);
            btnVerCuentas.Name = "btnVerCuentas";
            btnVerCuentas.Size = new Size(210, 36);
            btnVerCuentas.TabIndex = 5;
            btnVerCuentas.Text = "Ver cuentas del cliente";
            btnVerCuentas.UseVisualStyleBackColor = false;
            btnVerCuentas.Click += btnVerCuentas_Click;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1159, 582);
            Controls.Add(btnVerCuentas);
            Controls.Add(btnNuevo);
            Controls.Add(grbIngreso);
            Controls.Add(dgvClientes);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            ForeColor = Color.DeepPink;
            Name = "frmClientes";
            Text = "frmClientes";
            TransparencyKey = Color.FromArgb(255, 192, 255);
            Load += frmClientes_Load;
            grbIngreso.ResumeLayout(false);
            grbIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbIngreso;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblDNI;
        private TextBox txtTelefono;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private DataGridView dgvClientes;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
        private Button btnVerCuentas;
    }
}