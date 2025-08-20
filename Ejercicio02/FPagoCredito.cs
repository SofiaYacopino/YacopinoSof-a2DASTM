using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{

    internal class FPagoCredito : FormaPago
    {
        public override string ToString() => $"{Cod} - {Forma}";
        internal override double CalcularPrecio(double Precio) => Precio * 1.1;
    }
}