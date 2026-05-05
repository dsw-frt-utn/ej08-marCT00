using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_1
{
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            // Se utiliza el método auxiliar definido en la otra parte de la clase
            string formattedPrice = FormatearPrecioMoneda(price);
            return $"[{code}] {description} - {formattedPrice}";
        }
    }
}
