using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    public class Sale
    {
        public decimal _monto { get; set; }

        public virtual decimal CalculateTotal()
        {
            return _monto;
        }
    }
}
