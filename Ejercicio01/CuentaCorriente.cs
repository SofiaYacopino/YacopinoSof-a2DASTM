using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class CuentaCorriente : CuentaBancaria
    {
        private decimal limiteCredito;
        private const decimal LIMITE_SOBREGIRO = 100000;

        public decimal LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }

        public CuentaCorriente() : base()
        {
            limiteCredito = LIMITE_SOBREGIRO;
        }

        public override void Retirar(decimal monto)
        {
            if (monto <= 0)
                throw new DatosInvalidosException("El monto a retirar debe ser mayor a cero.");

            decimal saldoDisponible = saldo + limiteCredito;

            if (monto > saldoDisponible)
                throw new FondosInsuficientesException($"Fondos insuficientes. Saldo disponible: ${saldoDisponible:N2}");

            saldo -= monto;
        }

        public decimal ObtenerSaldoDisponible()
        {
            return saldo + limiteCredito;
        }

        public override string ObtenerTipoCuenta()
        {
            return "Cuenta Corriente";
        }
    }
}
