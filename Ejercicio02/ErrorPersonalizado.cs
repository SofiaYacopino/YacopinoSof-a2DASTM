using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class ErrorPersonalizado : Exception
    {
        public override string Message => "Ya tiene contratado el pack seleccionado";
    }
}
