// Código completo del Form para gestionar Aviones, Pasajeros y Pasajes usando RepositorioPasajes
using System;
using System.Windows.Forms;
using ado_multiplestablas;

namespace ado_multiplestablas
{
    public partial class Form1 : Form
    {
        private RepositorioPasajes repo;

        public Form1()
        {
            InitializeComponent();
            repo = new RepositorioPasajes();
            CargarListados();
        }

        private void CargarListados()
        {
            dgvAviones.DataSource = null;
            dgvAviones.DataSource = repo.ListarAviones();

        }

       
        private void btnAgregarAvion_Click(object sender, EventArgs e)
        {
            Avion a = new Avion
            {
                Matricula = txtMatricula.Text,
                Modelo = txtModelo.Text,
                Capacidad = int.Parse(txtCapacidad.Text)
            };

            repo.AgregarAvion(a);
            CargarListados();
        }

        private void btnModificarAvion_Click(object sender, EventArgs e)
        {
            if (dgvAviones.CurrentRow == null) return;

            Avion a = (Avion)dgvAviones.CurrentRow.DataBoundItem;
            a.Matricula = txtMatricula.Text;
            a.Modelo = txtModelo.Text;
            a.Capacidad = int.Parse(txtCapacidad.Text);

            repo.ModificarAvion(a);
            CargarListados();
        }

        private void btnEliminarAvion_Click(object sender, EventArgs e)
        {
            if (dgvAviones.CurrentRow == null) return;

            Avion a = (Avion)dgvAviones.CurrentRow.DataBoundItem;
            repo.EliminarAvion(a.IdAvion);
            CargarListados();
        }

        private void dgvAviones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAviones.CurrentRow == null) return;
            Avion a = (Avion)dgvAviones.CurrentRow.DataBoundItem;

            txtMatricula.Text = a.Matricula;
            txtModelo.Text = a.Modelo;
            txtCapacidad.Text = a.Capacidad.ToString();
        }

    }
}

