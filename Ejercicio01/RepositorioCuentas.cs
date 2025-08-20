using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class RepositorioCuentas
    {
        private List<CuentaBancaria> cuentas;

        public RepositorioCuentas()
        {
            cuentas = new List<CuentaBancaria>();
        }

        public void AgregarCuenta(CuentaBancaria cuenta)
        {
            if (cuenta == null)
                throw new DatosInvalidosException("La cuenta no puede ser nula.");

            if (string.IsNullOrWhiteSpace(cuenta.NumeroCuenta))
                throw new DatosInvalidosException("El número de cuenta no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(cuenta.Titular))
                throw new DatosInvalidosException("El titular no puede estar vacío.");

            if (ExisteCuenta(cuenta.NumeroCuenta))
                throw new DatosInvalidosException("Ya existe una cuenta con ese número.");

            cuentas.Add(cuenta);
        }

        public CuentaBancaria BuscarCuenta(string numeroCuenta)
        {
            return cuentas.FirstOrDefault(c => c.NumeroCuenta == numeroCuenta);
        }

        public bool ExisteCuenta(string numeroCuenta)
        {
            return cuentas.Any(c => c.NumeroCuenta == numeroCuenta);
        }

        public List<CuentaBancaria> ObtenerTodasLasCuentas()
        {
            return cuentas.ToList();
        }

        public void EliminarCuenta(string numeroCuenta)
        {
            var cuenta = BuscarCuenta(numeroCuenta);
            if (cuenta != null)
            {
                cuentas.Remove(cuenta);
            }
        }
    }
}
