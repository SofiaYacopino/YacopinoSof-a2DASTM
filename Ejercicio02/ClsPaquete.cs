using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class ClsPaquete : ICloneable
    {
        #region "Propiedades"
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double PrecioU { get; set; }
        internal DateTime FechaPago { get; set; }
        public double Abono { get; set; }
        #endregion

        public override string ToString() => $"{Cod} - {Nombre} ({Tipo}) - Precio: {PrecioU}";

        #region "ICloneable"
        public object Clone() => this.MemberwiseClone();
        #endregion
    }
}
