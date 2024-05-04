//ejercicio numero 5: Número Primo: 
//Verifica si un número ingresado por el usuario es primo o no. 
using System;

class Ejercicio5
{
    static void Main(string[] args)
    {

        Console.Write("Ingresa un número para verificar si es primo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool esPrimo = EsPrimo(numero);

        if (esPrimo)
        {
            Console.WriteLine($"{numero} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un número primo.");
        }

        Console.ReadLine(); // Esperar a que el usuario presione Enter antes de cerrar la consola
    }

    static bool EsPrimo(int n)
    {

        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
