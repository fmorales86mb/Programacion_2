﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    public class Sobreescrito
    {
        public override string ToString()
        {
            return "Este es mi método ToString sobreeescito";
        }
        public override bool Equals(object obj)
        {
            return (obj is Sobreescrito);
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
