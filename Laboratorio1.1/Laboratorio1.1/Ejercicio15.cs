//ejercicio 15: Suma de Dígitos: 
//Toma un número entero y calcula la suma de sus dígitos. 

using System;

class Ejercicio15
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int sumaDigitos = CalcularSumaDigitos(numero);

        Console.WriteLine($"La suma de los dígitos de {numero} es: {sumaDigitos}");

        Console.ReadLine();
    }

    static int CalcularSumaDigitos(int num)
    {
        int suma = 0;

        num = Math.Abs(num);

        while (num > 0)
        {
            int digito = num % 10;
            suma += digito;
            num /= 10;
        }

        return suma;
    }
}
