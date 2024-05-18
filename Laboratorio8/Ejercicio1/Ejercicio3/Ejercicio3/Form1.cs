using System;
using System.Collections.Generic;
using System.Linq;

namespace ConjuntoDivisibles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso de la función
            HashSet<int> numeros = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int divisor = 3;

            HashSet<int> divisibles = EncontrarDivisibles(numeros, divisor);

            Console.WriteLine("Números divisibles por " + divisor + ": " + string.Join(", ", divisibles));
        }

        static HashSet<int> EncontrarDivisibles(HashSet<int> numeros, int divisor)
        {
            HashSet<int> divisibles = new HashSet<int>();

            foreach (int num in numeros)
            {
                if (num % divisor == 0)
                {
                    divisibles.Add(num);
                }
            }

            return divisibles;
        }
    }
}

