//ejercicio 10: Números de la Serie Fibonacci: 
//Genera los primeros 10 números de la serie Fibonacci. 

using System;

class Ejercicio10
{
    static void Main(string[] args)
    {

        Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
        for (int i = 0; i < 10; i++)
        {
            int fibonacci = Fibonacci(i);
            Console.WriteLine(fibonacci);
        }

        Console.ReadLine();
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            int a = 0;
            int b = 1;
            int resultado = 0;
            for (int i = 2; i <= n; i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }
            return resultado;
        }
    }
}
