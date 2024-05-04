//ejercicio 14: Cálculo del Área de un Círculo: 
//Pide el radio de un círculo al usuario y calcula su área. 

using System;

class Ejercicio14
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area = CalcularAreaCirculo(radio);

        Console.WriteLine($"El área del círculo con radio {radio} es: {area}");

        Console.ReadLine();
    }

    static double CalcularAreaCirculo(double radio)
    {

        return Math.PI * Math.Pow(radio, 2);
    }
}
