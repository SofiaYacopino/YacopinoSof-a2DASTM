using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using static Entidades.Movimiento;

namespace Vista
{
    public partial class frmCuentas : Form
    {
        private Cliente cliente;
        private ControladoraCuenta cuentaControladora;
        private CuentaCorriente cuentaSeleccionada = null;

        public frmCuentas(Cliente clienteRecibido)
        {
            InitializeComponent();
            cliente = clienteRecibido;
            cuentaControladora = new ControladoraCuenta();
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            lblNombreCliente.Text = $"{cliente.Nombre} {cliente.Apellido}";

            ActualizarGrillaCuentas();

            OcultarDetalle();
        }


        private void OcultarDetalle()
        {
            dgvMovimientos.Visible = false;
            gbResumen.Visible = false;
            gbRegistrar.Visible = false;
        }

        private void MostrarDetalle()
        {
            dgvMovimientos.Visible = true;
            gbResumen.Visible = true;
            gbRegistrar.Visible = true;
        }

        private void ActualizarGrillaCuentas()
        {
            dgvCuentas.DataSource = null;
            var listaCuentas = cuentaControladora.ListarCuentas().Where(c => c.ClienteId == cliente.Id).ToList();
            dgvCuentas.DataSource = listaCuentas;

            if (dgvCuentas.Columns["Cliente"] != null) dgvCuentas.Columns["Cliente"].Visible = false;
            if (dgvCuentas.Columns["ClienteId"] != null) dgvCuentas.Columns["ClienteId"].Visible = false;
            if (dgvCuentas.Columns["Movimientos"] != null) dgvCuentas.Columns["Movimientos"].Visible = false;

            if (dgvCuentas.Rows.Count > 0)
            {
                dgvCuentas.Rows[0].Selected = true;
                cuentaSeleccionada = (CuentaCorriente)dgvCuentas.Rows[0].DataBoundItem;
            }
            else
            {
                cuentaSeleccionada = null;
            }
        }


        private void CargarDetalleDeCuenta()
        {
            if (cuentaSeleccionada == null) return;

            var cuentaCompleta = cuentaControladora.ObtenerHistorialCompleto(cuentaSeleccionada.Id);

            dgvMovimientos.DataSource = null;

            if (cuentaCompleta != null)
            {

                var movimientosParaMostrar = cuentaCompleta.Movimientos.Select(m => new
                {
                    CuentaID = cuentaSeleccionada.Id,
                    Fecha = m.Fecha,
                    Tipo = m.Tipo,
                    Descripcion = m.Descripcion,
                    Monto = m.Monto
                }).ToList();

                dgvMovimientos.DataSource = movimientosParaMostrar;
            }

            ResumenCuentaViewModel resumen = cuentaControladora.ObtenerResumenDeCuenta(cuentaSeleccionada.Id);

            if (resumen != null)
            {
                lblTotalCreditos.Text = resumen.TotalCreditos.ToString();
                lblTotalDebitos.Text = resumen.TotalDebitos.ToString();
                lblSaldoActual.Text = resumen.SaldoActual.ToString();


                if (resumen.SaldoActual < 0)
                {
                    lblSaldoActual.ForeColor = Color.Red;
                }
                else
                {
                    lblSaldoActual.ForeColor = Color.Green;
                }
            }
        }


        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string resultado = cuentaControladora.CrearCuenta(cliente.DNI);
            MessageBox.Show(resultado);
            ActualizarGrillaCuentas();
        }


        private void dgvCuentas_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuentas.CurrentRow != null && dgvCuentas.CurrentRow.DataBoundItem != null)
            {
                cuentaSeleccionada = (CuentaCorriente)dgvCuentas.CurrentRow.DataBoundItem;
            }

        }

        private void RegistrarMovimiento(TipoMovimiento tipo)
        {
            if (cuentaSeleccionada == null)
            {
                MessageBox.Show("Error: No hay una cuenta seleccionada.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, ingrese una descripción.");
                return;
            }
            decimal monto;
            if (!decimal.TryParse(txtMonto.Text, out monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un monto válido y positivo.");
                return;
            }

            string resultado = cuentaControladora.RegistrarMovimiento(cuentaSeleccionada.Id, txtDescripcion.Text, monto, tipo);


            MessageBox.Show(resultado);

            if (resultado.Contains("éxito"))
            {
                // Refresca los dos paneles
                CargarDetalleDeCuenta();
                ActualizarGrillaCuentas();

                txtDescripcion.Text = "";
                txtMonto.Text = "";
            }
        }

        private void btnRegistrarDebido_Click(object sender, EventArgs e)
        {
            RegistrarMovimiento(TipoMovimiento.Debito);
        }

        private void btnRegistrarCredito_Click(object sender, EventArgs e)
        {
            RegistrarMovimiento(TipoMovimiento.Credito);
        }

        private void btnVerMovimientos_Click(object sender, EventArgs e)
        {

            if (cuentaSeleccionada == null)
            {
                MessageBox.Show("Por favor, seleccione una cuenta de la grilla para ver sus movimientos.");
            }
            else
            {
                CargarDetalleDeCuenta();
                MostrarDetalle();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

