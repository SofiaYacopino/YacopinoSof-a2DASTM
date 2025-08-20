using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class CuentaAhorros : CuentaBancaria
    {
        private int retirosRealizados;
        private const int LIMITE_RETIROS = 3;


        public int RetirosRealizados
        {
            get { return retirosRealizados; }
            set { retirosRealizados = value; }
        }

        public CuentaAhorros() : base()
        {
            retirosRealizados = 0;
        }

        public override void Retirar(decimal monto)
        {
            if (monto <= 0)
                throw new DatosInvalidosException("El monto a retirar debe ser mayor a cero.");

            if (retirosRealizados >= LIMITE_RETIROS)
                throw new LimiteRetirosExcedidoException($"Ha excedido el límite de {LIMITE_RETIROS} retiros por mes.");

            if (monto > saldo)
                throw new FondosInsuficientesException("Fondos insuficientes para realizar el retiro.");

            saldo -= monto;
            retirosRealizados++;
        }

        public void ReiniciarContadorRetiros()
        {
            retirosRealizados = 0;
        }

        public override string ObtenerTipoCuenta()
        {
            return "Cuenta de Ahorros";
        }
    }
}
