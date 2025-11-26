namespace ado_multiplestablas
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabAviones = new TabPage();
            txtModelo = new TextBox();
            txtMatricula = new TextBox();
            btnModificarAvion = new Button();
            btnEliminarAvion = new Button();
            btnAgregarAvion = new Button();
            lblModelo = new Label();
            lblMatricula = new Label();
            dgvAviones = new DataGridView();
            tabPasajeros = new TabPage();
            tabPasajes = new TabPage();
            lblCapacidad = new Label();
            txtCapacidad = new TextBox();
            tabControl1.SuspendLayout();
            tabAviones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAviones).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAviones);
            tabControl1.Controls.Add(tabPasajeros);
            tabControl1.Controls.Add(tabPasajes);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(972, 530);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "Aviones";
            // 
            // tabAviones
            // 
            tabAviones.Controls.Add(txtCapacidad);
            tabAviones.Controls.Add(lblCapacidad);
            tabAviones.Controls.Add(txtModelo);
            tabAviones.Controls.Add(txtMatricula);
            tabAviones.Controls.Add(btnModificarAvion);
            tabAviones.Controls.Add(btnEliminarAvion);
            tabAviones.Controls.Add(btnAgregarAvion);
            tabAviones.Controls.Add(lblModelo);
            tabAviones.Controls.Add(lblMatricula);
            tabAviones.Controls.Add(dgvAviones);
            tabAviones.ForeColor = SystemColors.ActiveCaptionText;
            tabAviones.Location = new Point(4, 30);
            tabAviones.Name = "tabAviones";
            tabAviones.Padding = new Padding(3);
            tabAviones.Size = new Size(964, 496);
            tabAviones.TabIndex = 0;
            tabAviones.Text = "Aviones";
            tabAviones.UseVisualStyleBackColor = true;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(200, 147);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(130, 29);
            txtModelo.TabIndex = 7;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(200, 69);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(130, 29);
            txtMatricula.TabIndex = 6;
            // 
            // btnModificarAvion
            // 
            btnModificarAvion.Location = new Point(340, 446);
            btnModificarAvion.Name = "btnModificarAvion";
            btnModificarAvion.Size = new Size(98, 30);
            btnModificarAvion.TabIndex = 5;
            btnModificarAvion.Text = "Modificar";
            btnModificarAvion.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAvion
            // 
            btnEliminarAvion.Location = new Point(185, 446);
            btnEliminarAvion.Name = "btnEliminarAvion";
            btnEliminarAvion.Size = new Size(98, 30);
            btnEliminarAvion.TabIndex = 4;
            btnEliminarAvion.Text = "Eliminar";
            btnEliminarAvion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAvion
            // 
            btnAgregarAvion.Location = new Point(25, 446);
            btnAgregarAvion.Name = "btnAgregarAvion";
            btnAgregarAvion.Size = new Size(98, 30);
            btnAgregarAvion.TabIndex = 3;
            btnAgregarAvion.Text = "Agregar";
            btnAgregarAvion.UseVisualStyleBackColor = true;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.ForeColor = SystemColors.ActiveCaptionText;
            lblModelo.Location = new Point(53, 147);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(63, 21);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.ForeColor = SystemColors.ActiveCaptionText;
            lblMatricula.Location = new Point(53, 77);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(75, 21);
            lblMatricula.TabIndex = 1;
            lblMatricula.Text = "Matricula";
            // 
            // dgvAviones
            // 
            dgvAviones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAviones.Location = new Point(352, 6);
            dgvAviones.Name = "dgvAviones";
            dgvAviones.RowHeadersWidth = 53;
            dgvAviones.Size = new Size(587, 425);
            dgvAviones.TabIndex = 0;
            // 
            // tabPasajeros
            // 
            tabPasajeros.Location = new Point(4, 30);
            tabPasajeros.Name = "tabPasajeros";
            tabPasajeros.Padding = new Padding(3);
            tabPasajeros.Size = new Size(964, 496);
            tabPasajeros.TabIndex = 1;
            tabPasajeros.Text = "Pasajeros";
            tabPasajeros.UseVisualStyleBackColor = true;
            // 
            // tabPasajes
            // 
            tabPasajes.Location = new Point(4, 30);
            tabPasajes.Name = "tabPasajes";
            tabPasajes.Size = new Size(964, 496);
            tabPasajes.TabIndex = 2;
            tabPasajes.Text = "Pasajes";
            tabPasajes.UseVisualStyleBackColor = true;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.ForeColor = SystemColors.ActiveCaptionText;
            lblCapacidad.Location = new Point(53, 223);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(82, 21);
            lblCapacidad.TabIndex = 8;
            lblCapacidad.Text = "Capacidad";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(200, 223);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(130, 29);
            txtCapacidad.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 555);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabAviones.ResumeLayout(false);
            tabAviones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAviones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabAviones;
        private TabPage tabPasajeros;
        private TabPage tabPasajes;
        private DataGridView dgvAviones;
        private TextBox txtModelo;
        private TextBox txtMatricula;
        private Button btnModificarAvion;
        private Button btnEliminarAvion;
        private Button btnAgregarAvion;
        private Label lblModelo;
        private Label lblMatricula;
        private TextBox txtCapacidad;
        private Label lblCapacidad;
    }
}
