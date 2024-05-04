//ejercicio numero 2: Verificación de Número Par o Impar: 
//Solicita un número al usuario y determina si es par o impar. 

using System;

class Ejercicio2
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} es un número par.");
        }
        else
        {
            Console.WriteLine($"{numero} es un número impar.");
        }

        Console.ReadLine(); // Esperar a que el usuario presione Enter antes de cerrar la consola
    }
}
