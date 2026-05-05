using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_2
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {

            var claseAnonima = new { Code = productCode, Description = productDescription, Quantity = quantity, Total = quantity <= 0 ? 0m : quantity * unitPrice };

            return $"{claseAnonima.Code}-{claseAnonima.Description}-{claseAnonima.Total}";
        }

    }
}
