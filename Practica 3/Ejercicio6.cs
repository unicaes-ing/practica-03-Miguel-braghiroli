using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            string producto;
            decimal precio, precioC, descuento;
            int cantidad;

            Console.WriteLine("DESCUENTO");
            Console.Write("Ingrese el nombre del producto: ");
            producto = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: $");
            precio = Convert.ToDecimal(Console.ReadLine());
            Console.Write("¿cual es la cantidad de sus productos? ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            precioC = precio * cantidad;

            if (precioC > 0 && precioC <= 100)
            {
                Console.WriteLine("\nNo aplica el descuento");
                Console.WriteLine("Producto:{0}", producto);
                Console.WriteLine("Total a pagar: ${0}", precioC);
            }

            if (precioC > 100.01m && precioC <= 200)
            {
                Console.WriteLine("\nAplica al 12% de descuento");
                descuento = precioC * 0.12m;
                Console.WriteLine("Producto:{0}", producto);
                Console.WriteLine("Total a pagar: ${0}", precioC - descuento);
            }

            if (precioC > 200.01m && precioC <= 500)
            {
                Console.WriteLine("\nAplica al 15% de descuento");
                descuento = precioC * 0.15m;
                Console.WriteLine("Producto:{0}", producto);
                Console.WriteLine("Total a pagar: ${0}", precioC - descuento);
            }

            if (precioC > 500.01m)
            {
                Console.WriteLine("\nAplica al 20% de descuento");
                descuento = precioC * 0.20m;
                Console.WriteLine("Producto:{0}", producto);
                Console.WriteLine("Total a pagar: ${0}", precioC - descuento);
            }
            Console.ReadKey();
        }
    }





}