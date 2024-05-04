//ejercicio 11: Ordenamiento de Lista: 
//Ordena una lista de números ingresados por el usuario de menor a mayor. 

using System;
using System.Collections.Generic;

class Ejercicio11
{
    static void Main(string[] args)
    {

        List<int> numeros = new List<int>();
        Console.WriteLine("Ingresa una lista de números (escribe 'fin' para terminar):");
        while (true)
        {
            string entrada = Console.ReadLine();
            if (entrada.ToLower() == "fin")
            {
                break;
            }
            else
            {
                if (int.TryParse(entrada, out int numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Ingresa un número válido o escribe 'fin' para terminar.");
                }
            }
        }

        numeros.Sort();

        Console.WriteLine("Lista ordenada de menor a mayor:");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}
