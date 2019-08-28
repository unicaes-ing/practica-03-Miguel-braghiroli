using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int min, segu, zona;
            decimal TieLlama, SeguAgre, PreLama;

            Console.WriteLine("COBRO POR LLAMADA");
            Console.WriteLine("Duración de su llamada");
            Console.Write("Ingrese los minutos: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese los segundos: ");
            segu = Convert.ToInt32(Console.ReadLine());

            SeguAgre = segu * .1m;
            TieLlama = min + SeguAgre;

            Console.WriteLine("\nIngrese la zona de donde se realizo la llamada");
            Console.WriteLine("[1] - Zona Occidental");
            Console.WriteLine("[2] - Zona central");
            Console.WriteLine("[3] - Zona Oriental");
            zona = Convert.ToInt32(Console.ReadLine());

            if (zona == 1)
            {
                PreLama = TieLlama * 0.32m;
                Console.WriteLine("\nCosto de la llamada: ${0}", Math.Truncate(PreLama * 100) / 100);
                Console.ReadLine();
            }
            if (zona == 2)
            {
                PreLama = TieLlama * 0.25m;
                Console.WriteLine("\nCosto de la llamada: ${0}", Math.Truncate(PreLama * 100) / 100);
                Console.ReadLine();
            }
            if (zona == 3)
            {
                PreLama = TieLlama * 0.36m;
                Console.WriteLine("\nCosto de la llamada: ${0}", Math.Truncate(PreLama * 100) / 100);
                Console.ReadLine();
            }
        }
    }
}
