using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            
            return _monto * 0.90m; //10% de descuento
        }
    }
}
