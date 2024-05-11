//2) Ejercicio 2:
//Escribe una función recursiva que imprima la suma de los números del 1 al n. 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("La suma de los números del 1 al 10 es: " + SumaNumeros(10));
    }

    static int SumaNumeros(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        return n + SumaNumeros(n - 1);
    }
}
