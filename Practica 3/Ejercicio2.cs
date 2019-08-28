using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Random i = new Random(DateTime.Now.Millisecond);
            int iAleatorio = i.Next(100);
            Console.WriteLine(iAleatorio);

            if (iAleatorio %2 == 0)
            {
                Console.Write("Cifra Par");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Cifra Impar");
                Console.ReadKey();
            }
        }
    }
}
