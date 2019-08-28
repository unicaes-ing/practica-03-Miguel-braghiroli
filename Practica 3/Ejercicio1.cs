using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            int H;
            float M, S;
            Console.Write("Ingrese el tiempo a convertir: ");
            H = Convert.ToInt32(Console.ReadLine());

            if (H < 0)
            {
                Console.ReadKey();
            }
            else
            {
                M = H * 60;
                Console.WriteLine("los minutos son {0}", M);
                S = M * 60;
                Console.WriteLine("los segundos son {0}", S);
                Console.ReadKey();
            }
        }
    }
}
