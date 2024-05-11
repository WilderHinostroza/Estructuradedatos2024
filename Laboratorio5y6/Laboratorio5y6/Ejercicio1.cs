//Ejercicio 1:
//Escribe una función recursiva que imprima los números pares del 1 al 100. 

using System;

class Program
{
    static void Main(string[] args)
    {
        ImprimirPares(1);
    }

    static void ImprimirPares(int num)
    {
        if (num <= 100)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
            ImprimirPares(num + 1);
        }
    }
}
