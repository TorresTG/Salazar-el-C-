using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_de_Arreglos_Ordenados
{


    internal class Program
    {


        static void Main(string[] args)
        {

            Jerarquia jerarca = new Jerarquia();
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Práctica de Autómatas Finitos Deterministas");
                Console.WriteLine();
                Console.WriteLine("=== Menú Principal ===");
                Console.WriteLine("(1) Reiniciar arreglo Arreglo");
                Console.WriteLine("(2) Ver Arreglo");
                Console.WriteLine("(3) Buscar");
                Console.WriteLine("(4) Insertar");
                Console.WriteLine("(5) Eliminar");
                Console.WriteLine("(6) Modificar");
                Console.WriteLine("(7) Creditos");
                Console.WriteLine("(8) Salir");
                Console.WriteLine();
                Console.Write("Selecciona una opción: ");

                // lee opción
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Borrando arreglo...");
                            jerarca.N = 0;
                            Console.WriteLine("");
                            Console.WriteLine("pulse una tecla para seguir con el programa");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Opcion para mostrar el arreglo:");
                            Console.WriteLine("");
                            jerarca.mostrar();
                            Console.ReadKey();

                            break;
                        case 3:

                            int opcion2 = 0;

                            Console.WriteLine("Escoja el tipo de busqueda que desea utilizar");
                            Console.WriteLine();
                            Console.WriteLine("--- Menú Principal ---");
                            Console.WriteLine("(1) Lineal Optimizada");
                            Console.WriteLine("(2) Busqueda binaria");
                            Console.WriteLine("(3) Salir");
                            Console.WriteLine();
                            Console.Write("Selecciona una opción: ");
                            if (int.TryParse(Console.ReadLine(), out opcion2) && opcion2 >= 1 && opcion2 <= 2)
                            {
                                if(jerarca.N == 1)
                                {

                                }

                                switch (opcion2)
                                {
                                    case 1:
                                        Console.WriteLine();
                                        Console.WriteLine("--");
                                        Console.WriteLine("Introduzca la letra que quiere buscar");
                                        Console.WriteLine("--");
                                        Console.WriteLine();
                                        char letra2 = Console.ReadKey().KeyChar;
                                        Console.WriteLine();

                                        if (char.IsLetter(letra2))
                                        {
                                            string p = Convert.ToString(letra2);
                                            Console.WriteLine($"La letra que buscada {jerarca.buscarLineal(p)}");
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("Por favor, introduzca solo una letra válida.");
                                        }
                                        Console.WriteLine("presione una tecla para continuar");
                                        opcion2 = 0;
                                        Console.ReadKey();
                                        break;
                                    case 2:

                                        Console.WriteLine();
                                        Console.WriteLine("Introduzca la letra que quiere buscar");
                                        Console.WriteLine();
                                        char letra3 = Console.ReadKey().KeyChar;
                                        Console.WriteLine();

                                        if (char.IsLetter(letra3))
                                        {
                                            string p = Convert.ToString(letra3);
                                            Console.WriteLine($"La letra que introdujo es: {jerarca.buscarBinarea(p)}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Por favor, introduzca solo una letra válida.");
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("presione una tecla para continuar");
                                        opcion2 = 0;
                                        Console.ReadKey();

                                        break;
                                    default:
                                        Console.Clear();
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Por favor ingrese un número.");
                            }

                            break;
                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("----");
                            Console.WriteLine("Introduzca la letra que quiere Insertar en el array");
                            Console.WriteLine("----");
                            char letra4 = Console.ReadKey().KeyChar;
                            Console.WriteLine();

                            if (char.IsLetter(letra4))
                            {
                                string p = Convert.ToString(letra4);
                                Console.WriteLine($"La letra que introdujo es: {jerarca.insertar(p)}");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Por favor, introduzca solo una letra válida.");
                            }


                            break;
                        case 5:
                            Console.WriteLine();
                            Console.WriteLine("introduzca el valor que quiere eliminar del arreglo");
                            Console.WriteLine();
                            char letra5 = Console.ReadKey().KeyChar;
                            string w = Convert.ToString(letra5);
                            Console.WriteLine( jerarca.eliminar(w));

                            Console.WriteLine();
                            Console.WriteLine("presione enter para continuar");
                            Console.ReadKey();
                            break;
                        case 6:
                            Console.WriteLine();
                            Console.WriteLine("introduzca el valor que quiere modificar del arreglo");
                            Console.WriteLine();
                            char letra6 = Console.ReadKey().KeyChar;
                            string z = Convert.ToString(letra6);
                            Console.WriteLine(jerarca.modificar(z));

                            break;
                        case 7:
                            Console.WriteLine(); Console.WriteLine();
                            Console.WriteLine("Créditos");
                            Console.WriteLine("Dante Raziel Basurto Saucedo");
                            Console.WriteLine("Tobias Gabriel Rodriguez Lujan");
                            Console.WriteLine("Ana Luisa De León Azpilcueta");
                            Console.WriteLine(); Console.WriteLine();
                            break;
                        case 8:

                            Console.WriteLine("Saliendo del programa...");
                            Console.ReadKey();

                            break;
                        default:

                            Console.WriteLine("Opción no válida");

                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor ingrese un número.");
                }



            } while (opcion != 7);


        }
    }
}
