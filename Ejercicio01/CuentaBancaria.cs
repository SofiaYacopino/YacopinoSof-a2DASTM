using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public abstract class CuentaBancaria
    {

        protected string numeroCuenta;
        protected string titular;
        protected decimal saldo;

        public string NumeroCuenta
        {
            get { return numeroCuenta; }
            set { numeroCuenta = value; }
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            protected set { saldo = value; }
        }

        public CuentaBancaria()
        {
            saldo = 0;
        }

        public virtual void Depositar(decimal monto)
        {
            if (monto <= 0)
                throw new DatosInvalidosException("El monto a depositar debe ser mayor a cero.");

            saldo += monto;
        }

        public abstract void Retirar(decimal monto);

        public virtual decimal ConsultarSaldo()
        {
            return saldo;
        }

        public abstract string ObtenerTipoCuenta();



    }
}
