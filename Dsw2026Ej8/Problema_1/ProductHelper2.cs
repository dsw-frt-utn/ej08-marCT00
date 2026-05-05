using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_1
{
    public partial class ProductHelper
    {
        private const string FormatoMoneda = "C";
        private string FormatearPrecioMoneda(decimal price)
        {
            return price.ToString(FormatoMoneda);
        }
    }
}
