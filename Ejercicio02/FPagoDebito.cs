using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class FPagoDebito : FormaPago
    {
        public override string ToString() => $"{Cod} - {Forma}";
        internal override double CalcularPrecio(double Precio) => Precio - (Precio * 0.25);
    }
}
