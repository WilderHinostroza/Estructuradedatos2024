//ejercicio numero 7: Suma de Números Pares: 
//Calcula la suma de los números pares en un rango especificado por el usuario. 

using System;

class Ejercicio7
{
    static void Main(string[] args)
    {

        Console.Write("Ingresa el número inicial del rango: ");
        int inicio = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el número final del rango: ");
        int fin = Convert.ToInt32(Console.ReadLine());

        int sumaPares = SumaNumerosParesEnRango(inicio, fin);

        Console.WriteLine($"La suma de los números pares en el rango [{inicio}, {fin}] es: {sumaPares}");

        Console.ReadLine(); // Esperar a que el usuario presione Enter antes de cerrar la consola
    }

    static int SumaNumerosParesEnRango(int inicio, int fin)
    {
        int suma = 0;

        for (int i = inicio; i <= fin; i++)
        {

            if (i % 2 == 0)
            {
                suma += i; 
            }
        }
        return suma;
    }
}
