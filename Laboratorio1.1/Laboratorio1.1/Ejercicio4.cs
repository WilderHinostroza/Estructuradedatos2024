//ejercicio 4: Calculadora de Factorial:
//Crea una función que calcule la factorial de un número. 

using System;

class Ejercicio4

{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número para calcular su factorial: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        long factorial = CalcularFactorial(numero);
        Console.WriteLine($"El factorial de {numero} es: {factorial}");

        Console.ReadLine();
    }

    static long CalcularFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * CalcularFactorial(n - 1);
        }
    }
}

