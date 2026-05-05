using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_4
{
    public class Problema4
    {

        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int?[] notas = { nota1, nota2, nota3 };

            int suma = 0;
            int cantidadValidas = 0;

            foreach (int? nota in notas)
            {

                if (nota.HasValue && nota.Value >= 0 && nota.Value <= 10)
                {
                    suma += nota.Value;
                    cantidadValidas++;
                }
            }

            return cantidadValidas == 0 ? 0 : (double)suma / cantidadValidas;
        }
    }
}
