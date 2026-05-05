using Dsw2026Ej8.Problema_1;
using Dsw2026Ej8.Problema_2;
using Dsw2026Ej8.Problema_3;
using Dsw2026Ej8.Problema_4;
using Dsw2026Ej8.Problema_5;
using Dsw2026Ej8.Problema_6;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROBLEMA 1
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("Problema 1");
            ProductHelper p1 = new ProductHelper();
            Console.WriteLine(p1.ObtenerEtiquetaProducto(92344, "Coca Cola", 67m));
            Console.WriteLine(" ");

            //PROBLEMA 2
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("Problema 2");
            Problema2 p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(545771, "Sprite", -10230, 67.5m));
            Console.WriteLine(" ");

            //Problema 3
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("Problema 3");
            Product miProduct = new Product();
            miProduct._description = "descripcion";

            Problema3 p3 = new Problema3();

            string resultadop3 = p3.CompararCopias(5, miProduct);
            Console.WriteLine(resultadop3);
            Console.WriteLine(" ");

            //Problema 4
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("Este problema es el 4");
            Problema4 p4 = new Problema4();
            Console.WriteLine(p4.CalcularPromedio(8, null, 9));
            Console.WriteLine(" ");

            //Problema 5
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("Este problema es el 4 + 1");
            Problema5 problema5 = new Problema5();

            Sale ventaMinorista = new RetailSale { _monto = 500m };
            Sale ventaMayorista = new WholesaleSale { _monto = 300m };

            decimal totalMinorista = problema5.ObtenerImporteFinal(ventaMinorista);
            decimal totalMayorista = problema5.ObtenerImporteFinal(ventaMayorista);

            Console.WriteLine($"Total sin descuento: {totalMinorista:C}");
            Console.WriteLine($"Total 10% descuento: {totalMayorista:C}");
            Console.WriteLine(" ");

            //Problema 6
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("Este problema es el 4 + 2");

            Problema6 p6 = new Problema6();

            string pruebaNormal = p6.NormalizarCodigoProducto(" ac 574 x ");
            Console.WriteLine($"Prueba Normal = '{pruebaNormal}'");

            string pruebaNull = p6.NormalizarCodigoProducto(null);
            Console.WriteLine($"Prueba de Null = '{pruebaNull}'");
        }
    }
}
