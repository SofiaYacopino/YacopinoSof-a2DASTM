﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class LimiteRetirosExcedidoException : Exception
    {
        public LimiteRetirosExcedidoException(string mensaje) : base(mensaje) { }
    }
}
