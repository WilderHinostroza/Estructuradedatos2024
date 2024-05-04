//ejerccicio 13: Generador de Tablas de Multiplicar: 
//Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 

using System;

class Ejercicio13
{
    static void Main(string[] args)
    {

        Console.Write("Ingresa un número para generar su tabla de multiplicar: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }

        Console.ReadLine();
    }
}
