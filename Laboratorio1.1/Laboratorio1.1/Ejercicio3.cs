//ejrecicio numero 3: Área de un Triángulo: 
//Pide la base y la altura de un triángulo al usuario y calcula su área. 

using System;

class Ejercicio3
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa la base del triángulo: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la altura del triángulo: ");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

        Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {alturaTriangulo} es: {areaTriangulo}");

        Console.ReadLine(); // Esperar a que el usuario presione Enter antes de cerrar la consola
    }
}
