//ejercicio 8: Lista de Cuadrados: 
//Crea una lista de los cuadrados de los primeros 10 números naturales. 

using System;
using System.Collections.Generic;

class Ejercicio8
{
    static void Main(string[] args)
    {

        List<int> cuadrados = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            int cuadrado = i * i;
            cuadrados.Add(cuadrado);
        }

        Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
        foreach (int cuadrado in cuadrados)
        {
            Console.WriteLine(cuadrado);
        }

        Console.ReadLine();
    }
}
