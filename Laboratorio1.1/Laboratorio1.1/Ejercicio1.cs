//ejercicio numero 1: Operaciones Básicas:
//Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 

using System;

class Ejercicio1
{
    static void Main(string[] args)
    {
        
        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicacion = num1 * num2;
                
        double division = 0;
        if (num2 != 0)
        {
            division = num1 / num2;
        }
        else
        {
            Console.WriteLine("No se puede dividir por cero.");
        }

        // Mostrar los resultados
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        if (num2 != 0)
        {
            Console.WriteLine($"División: {division}");
        }

        Console.ReadLine(); // Esperar a que el usuario presione Enter antes de cerrar la consola
    }
}
