using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_de_Arreglos_Ordenados
{
    internal class Jerarquia
    {



        public int Max = 21;
        public string[] A;
        public int N = 0;

        public Jerarquia()
        {
            A = new string[Max];
        }

        Dictionary<char, int> letterToNumber = new Dictionary<char, int>()
        {
            { 'A', 1 }, { 'a', 2 }, { 'B', 3 }, { 'b', 4 },
            { 'C', 5 }, { 'c', 6 }, { 'D', 7 }, { 'd', 8 },
            { 'E', 9 }, { 'e', 10 }, { 'F', 11 }, { 'f', 12 },
            { 'G', 13 }, { 'g', 14 }, { 'H', 15 }, { 'h', 16 },
            { 'I', 17 }, { 'i', 18 }, { 'J', 19 }, { 'j', 20 },
            { 'K', 21 }, { 'k', 22 }, { 'L', 23 }, { 'l', 24 },
            { 'M', 25 }, { 'm', 26 }, { 'N', 27 }, { 'n', 28 },
            { 'O', 29 }, { 'o', 30 }, { 'P', 31 }, { 'p', 32 },
            { 'Q', 33 }, { 'q', 34 }, { 'R', 35 }, { 'r', 36 },
            { 'S', 37 }, { 's', 38 }, { 'T', 39 }, { 't', 40 },
            { 'U', 41 }, { 'u', 42 }, { 'V', 43 }, { 'v', 44 },
            { 'W', 45 }, { 'w', 46 }, { 'X', 47 }, { 'x', 48 },
            { 'Y', 49 }, { 'y', 50 }, { 'Z', 51 }, { 'z', 52 }
        };

        public void mostrar()
        {

            if (N == 0)
            {
                Console.WriteLine("El arreglo esta vacio");
            }
            else
            {
                int i;
                for (i = 0; i != N; i++)
                {
                    Console.WriteLine(A[i]);

                }
            }/*
            int i = 0;
            Console.WriteLine(A[i]);*/
        }
        public string buscarLineal(string letraConver)
        {
            int i = 0;
            while (i < N) // Recorre hasta que llegue al final del array
            {
                if (letraConver == A[i])
                {
                    return $"{letraConver} en el puesto numero: {i + 1} (busquedas necesarias {i + 1})";
                }
                i++; // Avanza al siguiente índice
            }

            // Si llega aquí, significa que no encontró el valor
            return "No se encontró el valor introducido";
        }
        public string buscarBinarea(string letraConver)
        {
            // Verifica que el array no esté vacío
            if (A == null || A.Length == 0 || N == 0)
            {
                return "El array está vacío, no hay elementos para buscar.";
            }

            int li = 0;
            int ls = N - 1; // El límite superior debe ser N - 1, porque los índices son de 0 a N-1
            int intentos = 0;

            // Comprobación inicial para los extremos del array
            if (A[li] == letraConver)
            {
                d = li;
                return $"{letraConver} en el puesto número: {li + 1} (búsquedas necesarias: 1)";
            }
            if (A[ls] == letraConver)
            {
                d = ls;
                return $"{letraConver} en el puesto número: {ls + 1} (búsquedas necesarias: 1)";
            }

            // Algoritmo de búsqueda binaria
            while (li <= ls)
            {
                // Calcula el punto medio
                int p = li + (ls - li) / 2;

                // Comparación personalizada
                int comparison = CompararcionPersonalizada(A[p], letraConver);
                intentos++;

                // Si el valor es encontrado en A[p]
                if (comparison == 0)
                {
                    d = p;
                    return $"{letraConver} en el puesto número: {p + 1} (búsquedas necesarias: {intentos})";
                }
                // Si A[p] es menor, se descartan los valores a la izquierda
                else if (comparison < 0)
                {
                    li = p + 1;
                }
                // Si A[p] es mayor, se descartan los valores a la derecha
                else
                {
                    ls = p - 1;
                }
            }

            // Si no se encuentra el valor
            return $"No se encontró el valor {letraConver} (búsquedas necesarias: {intentos})";
        }

        public string insertar(string letraConver)
        {
            if (N < (Max - 1))
            {
                int i = 0;
                int comparison = string.Compare(A[i], letraConver, StringComparison.Ordinal);


                while (i < N && CompararcionPersonalizada(A[i], letraConver) < 0)
                {
                    i++;
                }

                for (int k = N - 1; k >= i; k--)
                {
                    A[k + 1] = A[k]; // Desplazar los elementos hacia la derecha
                }
                A[i] = letraConver; // Insertar el nuevo valor en la posición correcta
                N++; // Incrementar el contador de elementos

                return A[i] + " en el espacio: " + i;

            }
            else
            {
                return "no se pudo, no hay espacio en el array";
            }
        }

        public int d { get; set; }

        public string eliminar(string letraConver)
        {
            if (A == null || A.Length == 0 || N == 0)
            {
                return "El array está vacío, no hay elementos para eliminar.";
            }
        

            // Realiza la búsqueda binaria para encontrar la posición de la letra
            buscarBinarea(letraConver); // Este método modifica 'd' directamente

            // Verifica si 'd' tiene un valor válido
            if (d >= 0 && d < N)
            {
                // Desplaza los elementos hacia la izquierda para eliminar el encontrado
                while (d < N - 1)
                {
                    A[d] = A[d + 1];
                    d++;
                }

                N--; // Disminuye el número de elementos
                A[N] = null; // Limpia el último elemento

                return $"El valor '{letraConver}' ha sido eliminado correctamente.";
            }
            else
            {
                // Si no se encontró el valor para eliminar
                return $"No se pudo eliminar '{letraConver}' ya que no se encuentra en el array.";
            }

        }


        public string modificar(string letraConver)
        {
            if (A == null || A.Length == 0 || N == 0)
            {
                return "El array está vacío, no hay elementos para modificar.";
            }

            // Intentar eliminar el valor existente
            string resultadoEliminacion = eliminar(letraConver);

            // Verificar si el valor fue eliminado
            if (resultadoEliminacion.Contains("eliminado correctamente"))
            {
                Console.WriteLine("\nProporcione el nuevo valor por el que se sustituirá:");
                char letra = Console.ReadKey().KeyChar;
                string nuevoValor = letra.ToString();

                // Intentar insertar el nuevo valor
                string resultadoInsercion = insertar(nuevoValor);

                return $"Modificación exitosa: '{letraConver}' fue reemplazado por '{nuevoValor}'";
            }
            else
            {
                // Si no se pudo eliminar el valor, devolver el mensaje de error
                return resultadoEliminacion;
            }
        }

        private int CompararcionPersonalizada(string letra1, string letra2)
        {
            // Comparar ignorando el caso (minúsculas vs mayúsculas)
            int resultado = string.Compare(letra1.ToLower(), letra2.ToLower(), StringComparison.Ordinal);

            // Si son iguales al ignorar el caso, dar prioridad a las minúsculas
            if (resultado == 0)
            {
                // Las minúsculas tienen prioridad
                if (char.IsLower(letra1[0]) && char.IsUpper(letra2[0]))
                {
                    return 1;
                }
                else if (char.IsUpper(letra1[0]) && char.IsLower(letra2[0]))
                {
                    return -1;
                }
            }

            // Si no son iguales al ignorar el caso, retornar el resultado de la comparación
            return resultado;
        }


    }
}