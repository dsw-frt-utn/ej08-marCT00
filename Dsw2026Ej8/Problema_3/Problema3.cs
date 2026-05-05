using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_3
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValue = originalValue;

            copiaValue++;

            Product copiaProduct = product;

            copiaProduct._description = "Esta descripcion es nueva";

            return $"{originalValue}-{copiaValue}-{product._description}";
        }
    }
}
