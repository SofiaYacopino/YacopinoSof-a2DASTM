using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class ClsCliente : ICalcular
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public ClsLocalidad oLoc { get; set; }
        public FormaPago oFPago { get; set; }
        internal List<ClsPaquete> LPaquetes = new List<ClsPaquete>();

        // Constructor vacío
        public ClsCliente() { }

        // Constructor sobrecargado
        public ClsCliente(int _Cod, string _Nom, string _Ape)
        {
            Codigo = _Cod; Nombre = _Nom; Apellido = _Ape;
        }

        public double CalcularTotal(ClsCliente oCliente)
        {
            double MontoPagado = 0;
            foreach (ClsPaquete item in oCliente.LPaquetes)
                MontoPagado += item.Abono;
            return MontoPagado;
        }

        // delegado
        public delegate void DelInformar(List<ClsCliente> Lcli);
        public DelInformar Informar;

        public override string ToString() =>
            $"[{Codigo}] {Nombre} {Apellido} - {oLoc.Nombre} - Pago: {oFPago.Forma}";
    }
}
