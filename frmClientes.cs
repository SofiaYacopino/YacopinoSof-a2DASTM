using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Controladora;

namespace Vista
{
    public partial class frmClientes : Form
    {
        private ControladoraCliente clienteControladora;
        private Cliente clienteSeleccionado = null;
        public frmClientes()
        {
            InitializeComponent();
            clienteControladora = new ControladoraCliente();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarGrilla()
        {
            dgvClientes.DataSource = null; 

            dgvClientes.DataSource = clienteControladora.ListarClientes(); 

            if (dgvClientes.Columns["CuentasCorrientes"] != null)
            {
                dgvClientes.Columns["CuentasCorrientes"].Visible = false;
            }
            if (dgvClientes.Columns["Id"] != null)
            {
                dgvClientes.Columns["Id"].Visible = false; 
            }
        }


        private void LimpiarFormulario()
        {
            clienteSeleccionado = null;

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtTelefono.Text = "";

            dgvClientes.ClearSelection();

            txtNombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvClientes.Rows[e.RowIndex];
                clienteSeleccionado = (Cliente)fila.DataBoundItem;

                txtNombre.Text = clienteSeleccionado.Nombre;
                txtApellido.Text = clienteSeleccionado.Apellido;
                txtDNI.Text = clienteSeleccionado.DNI;
                txtTelefono.Text = clienteSeleccionado.Telefono;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                MessageBox.Show("Está viendo los datos de un cliente. Presione 'Nuevo' primero si desea agregar uno.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El DNI y el Nombre son obligatorios.");
                return;
            }

            try
            {
                string resultado = clienteControladora.AltaCliente(
                    txtNombre.Text,
                    txtApellido.Text,
                    txtDNI.Text,
                    txtTelefono.Text
                );

                MessageBox.Show(resultado);

                if (resultado.Contains("éxito"))
                {
                    ActualizarGrilla();
                    LimpiarFormulario(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista para modificar.");
                return;
            }

            try
            {
                string resultado = clienteControladora.ModificarCliente(
                    clienteSeleccionado.Id, 
                    txtNombre.Text,          
                    txtApellido.Text,
                    txtDNI.Text,
                    txtTelefono.Text
                );

                MessageBox.Show(resultado);

                if (resultado.Contains("éxito"))
                {
                    ActualizarGrilla();
                    LimpiarFormulario(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista para eliminar.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar a {clienteSeleccionado.Nombre} {clienteSeleccionado.Apellido}?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                string resultado = clienteControladora.BajaCliente(clienteSeleccionado.Id);

                MessageBox.Show(resultado);

                if (resultado.Contains("éxito"))
                {
                    ActualizarGrilla();
                    LimpiarFormulario(); 
                }
            }
        }

        private void btnVerCuentas_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista para ver sus cuentas.");
                return;
            }
            this.Hide();

    
            frmCuentas formGestion = new frmCuentas(clienteSeleccionado);

            formGestion.ShowDialog();

            this.Show();
        }
    }
}
