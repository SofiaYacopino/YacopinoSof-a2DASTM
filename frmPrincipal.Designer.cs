namespace Parcial2_YacopinoSofia
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSistema = new Label();
            btnGestionClientes = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.BackColor = Color.SeaShell;
            lblSistema.Font = new Font("Times New Roman", 21.8879986F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSistema.ForeColor = Color.HotPink;
            lblSistema.Location = new Point(270, 111);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(617, 43);
            lblSistema.TabIndex = 0;
            lblSistema.Text = "Sistema de Gestión Cuentas Corrientes";
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.BackColor = Color.FloralWhite;
            btnGestionClientes.Font = new Font("Segoe UI", 12.096F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestionClientes.Location = new Point(452, 301);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(208, 70);
            btnGestionClientes.TabIndex = 2;
            btnGestionClientes.Text = "Gestionar Clientes";
            btnGestionClientes.UseVisualStyleBackColor = false;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FloralWhite;
            btnSalir.Font = new Font("Segoe UI", 9.792F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(951, 467);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 40);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1135, 543);
            Controls.Add(btnSalir);
            Controls.Add(btnGestionClientes);
            Controls.Add(lblSistema);
            ForeColor = Color.DeepPink;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSistema;
        private Button btnGestionClientes;
        private Button btnSalir;
    }
}
