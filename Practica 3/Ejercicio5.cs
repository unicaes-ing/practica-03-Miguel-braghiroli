using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese un numero(1-10): ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("uno");
            }
            if (num == 2)
            {
                Console.WriteLine("dos");
            }
            if (num == 3)
            {
                Console.WriteLine("tres");
            }
            if (num == 4)
            {
                Console.WriteLine("cuatro");
            }
            if (num == 5)
            {
                Console.WriteLine("cinco");
            }
            if (num == 6)
            {
                Console.WriteLine("seis");
            }
            if (num == 7)
            {
                Console.WriteLine("siete");
            }
            if (num == 8)
            {
                Console.WriteLine("ocho");
            }
            if (num == 9)
            {
                Console.WriteLine("nueve");
            }
            if (num == 10)
            {
                Console.WriteLine("diez");
            }
            if (num >= 11)
            {
                Console.WriteLine("Numero no valido.");
            }
            Console.ReadLine();
        }
    }
}

