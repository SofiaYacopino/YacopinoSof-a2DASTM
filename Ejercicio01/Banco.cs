using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class Banco
    {
        private RepositorioCuentas repositorio;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // public Nombre {get; set;}

        public Banco()
        {
            repositorio = new RepositorioCuentas();
            nombre = "Banco Nacional";
        }

        public void CrearCuentaAhorros(string numeroCuenta, string titular)
        {
            try
            {
                var cuenta = new CuentaAhorros();
                cuenta.NumeroCuenta = numeroCuenta;
                cuenta.Titular = titular;
                repositorio.AgregarCuenta(cuenta);
            }
            catch (Exception ex)
            {
                throw new DatosInvalidosException($"Error al crear cuenta de ahorros: {ex.Message}");
            }
        }

        public void CrearCuentaCorriente(string numeroCuenta, string titular)
        {
            try
            {
                var cuenta = new CuentaCorriente();
                cuenta.NumeroCuenta = numeroCuenta;
                cuenta.Titular = titular;
                repositorio.AgregarCuenta(cuenta);
            }
            catch (Exception ex)
            {
                throw new DatosInvalidosException($"Error al crear cuenta corriente: {ex.Message}");
            }
        }

        public void RealizarDeposito(string numeroCuenta, decimal monto)
        {
            var cuenta = repositorio.BuscarCuenta(numeroCuenta);
            if (cuenta == null)
                throw new DatosInvalidosException("Cuenta no encontrada.");

            cuenta.Depositar(monto);
        }

        public void RealizarRetiro(string numeroCuenta, decimal monto)
        {
            var cuenta = repositorio.BuscarCuenta(numeroCuenta);
            if (cuenta == null)
                throw new DatosInvalidosException("Cuenta no encontrada.");

            cuenta.Retirar(monto);
        }

        public decimal ConsultarSaldo(string numeroCuenta)
        {
            var cuenta = repositorio.BuscarCuenta(numeroCuenta);
            if (cuenta == null)
                throw new DatosInvalidosException("Cuenta no encontrada.");

            return cuenta.ConsultarSaldo();
        }

        public CuentaBancaria ObtenerCuenta(string numeroCuenta)
        {
            return repositorio.BuscarCuenta(numeroCuenta);
        }

        public List<CuentaBancaria> ObtenerTodasLasCuentas()
        {
            return repositorio.ObtenerTodasLasCuentas();
        }
    }
}
