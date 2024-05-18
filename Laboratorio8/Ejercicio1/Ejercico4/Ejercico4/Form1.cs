using System;
using System.Collections.Generic;
using System.Linq;

namespace NumerosOrdenados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso de la función
            HashSet<int> numerosDesordenados = new HashSet<int> { 5, 2, 8, 1, 9, 3, 6 };

            HashSet<int> numerosOrdenados = ObtenerNumerosOrdenadosDeMayorAMenor(numerosDesordenados);

            Console.WriteLine("Números ordenados de mayor a menor: " + string.Join(", ", numerosOrdenados));
        }

        static HashSet<int> ObtenerNumerosOrdenadosDeMayorAMenor(HashSet<int> numeros)
        {
            List<int> listaNumerosOrdenados = numeros.ToList();
            listaNumerosOrdenados.Sort((a, b) => b.CompareTo(a));

            return new HashSet<int>(listaNumerosOrdenados);
        }
    }
}
