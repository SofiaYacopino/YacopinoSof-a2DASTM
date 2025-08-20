using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public abstract class FormaPago
    {
        internal int Cod { get; set; }
        internal string Forma { get; set; }
        internal abstract double CalcularPrecio(double Precio);
    }
}
