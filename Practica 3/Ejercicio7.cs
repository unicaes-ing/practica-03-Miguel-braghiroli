using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {
            decimal UI, UF, UC;
            int Opc1, Opc2;

            do
            {
                Console.Clear();
                Console.WriteLine("Conversion de Unidades");
                Console.WriteLine("Seleccione la unidad de medida");
                Console.WriteLine("[1] - Onzas ");
                Console.WriteLine("[2] - Libras ");
                Console.WriteLine("[3] - Gramos ");
                Console.WriteLine("[4] - Toneladas ");
                Console.Write("\nSeleccion de opcion: ");
                Opc1 = Convert.ToInt32(Console.ReadLine());
                if (Opc1 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la unidad de medida: [1] - Onzas");
                    Console.WriteLine("\nSeleccione a que unidad quiere convertir Onzas");
                    do
                    {
                        Console.WriteLine("[1] - Libras");
                        Console.WriteLine("[2] - Gramos");
                        Console.WriteLine("[3] - Toneladas");
                        Console.WriteLine("[4] - Regresar al menu principal");
                        Console.Write("\nSeleccion de opcion: ");
                        Opc2 = Convert.ToInt32(Console.ReadLine());
                        if (Opc2 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Onzas/libras");
                            Console.Write("Ingrese el numero de onzas: ");
                            UI = Convert.ToDecimal(Console.ReadLine());
                            UF = UI / 16;
                            UC = Math.Truncate(UF * 100) / 100;
                            Console.WriteLine("Las {0} onzas son equivalentes a {1} libras", UI, UC);
                            Console.ReadKey();
                        }
                        else
                        {
                            if (Opc2 == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Onzas/Gramos");
                                Console.Write("Ingrese el numero de onzas: ");
                                UI = Convert.ToDecimal(Console.ReadLine());
                                UF = UI * 28.35m;
                                UC = Math.Truncate(UF * 100) / 100;
                                Console.WriteLine("Las {0} onzas son equivalentes a {1} gramos", UI, UC);
                                Console.ReadKey();
                            }
                            else
                            {
                                if (Opc2 == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Onzas/Toneladas");
                                    Console.Write("Ingrese el numero de onzas: ");
                                    UI = Convert.ToDecimal(Console.ReadLine());
                                    UF = UI / 35273.962m;
                                    UC = Math.Truncate(UF * 100) / 100;
                                    Console.WriteLine("Las {0} onzas son equivalentes a {1} toneladas", UI, UC);
                                    Console.ReadKey();
                                }
                            }
                        }
                    } while (Opc2 >= 4);
                }
                if (Opc1 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la unidad de medida: [2] - Libras");
                    Console.WriteLine("\nSeleccione a que unidad quiere convertir Libras");
                    do
                    {
                        Console.WriteLine("[1] - Onzas");
                        Console.WriteLine("[2] - Gramo");
                        Console.WriteLine("[3] - Tonelada");
                        Console.WriteLine("[4] - Regresar al menu principal");
                        Console.Write("\nSeleccion de opcion: ");
                        Opc2 = Convert.ToInt32(Console.ReadLine());
                        if (Opc2 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Libras/Onzas");
                            Console.Write("Ingrese el numero de libras: ");
                            UI = Convert.ToDecimal(Console.ReadLine());
                            UF = UI * 16;
                            UC = Math.Truncate(UF * 100) / 100;
                            Console.WriteLine("Las {0} libras son equivalentes a {1} onzas", UI, UC);
                            Console.ReadKey();
                        }
                        else
                        {
                            if (Opc2 == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Libras/Gramos");
                                Console.Write("Ingrese el numero de libras: ");
                                UI = Convert.ToDecimal(Console.ReadLine());
                                UF = UI * 453.592m;
                                UC = Math.Truncate(UF * 100) / 100;
                                Console.WriteLine("Las {0} libras son equivalentes a {1} gramos", UI, UC);
                                Console.ReadKey();
                            }
                            else
                            {
                                if (Opc2 == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Libras/Toneladas");
                                    Console.Write("Ingrese el numero de libras: ");
                                    UI = Convert.ToDecimal(Console.ReadLine());
                                    UF = UI / 2204.62m;
                                    UC = Math.Truncate(UF * 100) / 100;
                                    Console.WriteLine("Las {0} libras son equivalentes a {1} toneladas", UI, UC);
                                    Console.ReadKey();
                                }
                            }
                        }
                    } while (Opc2 >= 4);
                }
                if (Opc1 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la unidad de medida: [3] - Gramos");
                    Console.WriteLine("\nSeleccione a que unidad quiere convertir Gramos");
                    do
                    {
                        Console.WriteLine("[1] - Onzas");
                        Console.WriteLine("[2] - Libras");
                        Console.WriteLine("[3] - Tonelada");
                        Console.WriteLine("[4] - Regresar al menu principal");
                        Console.Write("\nSeleccion de opcion: ");
                        Opc2 = Convert.ToInt32(Console.ReadLine());
                        if (Opc2 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Gramos/Onzas");
                            Console.Write("Ingrese el numero de gramos: ");
                            UI = Convert.ToDecimal(Console.ReadLine());
                            UF = UI / 28.35m;
                            UC = Math.Truncate(UF * 100) / 100;
                            Console.WriteLine("Los {0} gramos son equivalentes a {1} onzas", UI, UC);
                            Console.ReadKey();
                        }
                        else
                        {
                            if (Opc2 == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Gramos/Libras");
                                Console.Write("Ingrese el numero de gramos: ");
                                UI = Convert.ToDecimal(Console.ReadLine());
                                UF = UI / 453.592m;
                                UC = Math.Truncate(UF * 100) / 100;
                                Console.WriteLine("Los {0} gramos son equivalentes a {1} libras", UI, UC);
                                Console.ReadKey();
                            }
                            else
                            {
                                if (Opc2 == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Gramos/Toneladas");
                                    Console.Write("Ingrese el numero de gramos: ");
                                    UI = Convert.ToDecimal(Console.ReadLine());
                                    UF = UI / 1000000m;
                                    UC = Math.Truncate(UF * 100) / 100;
                                    Console.WriteLine("Los {0} gramos son equivalentes a {1} toneladas", UI, UC);
                                    Console.ReadKey();
                                }
                            }
                        }
                    } while (Opc2 >= 4);
                }
                if (Opc1 == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la unidad de medida: [4] - Toneladas");
                    Console.WriteLine("\nSeleccione a que unidad quiere convertir Toneladas");
                    do
                    {
                        Console.WriteLine("[1] - Onzas");
                        Console.WriteLine("[2] - Libras");
                        Console.WriteLine("[3] - Gramos");
                        Console.WriteLine("[4] - Regresar al menu principal");
                        Console.Write("\nSeleccion de opcion: ");
                        Opc2 = Convert.ToInt32(Console.ReadLine());
                        if (Opc2 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Toneladas/Onzas");
                            Console.Write("Ingrese el numero de toneldas: ");
                            UI = Convert.ToDecimal(Console.ReadLine());
                            UF = UI * 35273.962m;
                            UC = Math.Truncate(UF * 100) / 100;
                            Console.WriteLine("Las {0} toneladas son equivalentes a {1} onzas", UI, UC);
                            Console.ReadKey();
                        }
                        else
                        {
                            if (Opc2 == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Toneladas/Libras");
                                Console.Write("Ingrese el numero de toneladas: ");
                                UI = Convert.ToDecimal(Console.ReadLine());
                                UF = UI * 2204.623m;
                                UC = Math.Truncate(UF * 100) / 100;
                                Console.WriteLine("Las {0} toneladas son equivalentes a {1} libras", UI, UC);
                                Console.ReadKey();
                            }
                            else
                            {
                                if (Opc2 == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Toneladas/Gramos");
                                    Console.Write("Ingrese el numero de toneladas: ");
                                    UI = Convert.ToDecimal(Console.ReadLine());
                                    UF = UI * 1000000m;
                                    UC = Math.Truncate(UF * 100) / 100;
                                    Console.WriteLine("Las {0} toneladas son equivalentes a {1} gramos", UI, UC);
                                    Console.ReadKey();
                                }
                            }
                        }
                    } while (Opc2 >= 4);
                }
            } while (Opc1 >= 5);
        }
    }
}
