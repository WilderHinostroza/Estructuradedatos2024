//ejercicio 12: Palíndromo: 
//Verifica si una palabra ingresada por el usuario es un palíndromo. 

using System;

class Ejercicio12
{
    static void Main(string[] args)
    {

        Console.Write("Ingresa una palabra para verificar si es un palíndromo: ");
        string palabra = Console.ReadLine();

        bool esPalindromo = EsPalindromo(palabra);

        if (esPalindromo)
        {
            Console.WriteLine($"{palabra} es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"{palabra} no es un palíndromo.");
        }

        Console.ReadLine();
    }
    static bool EsPalindromo(string palabra)

    {

        palabra = palabra.ToLower();

        string palabraInvertida = InvertirCadena(palabra);

        return palabra == palabraInvertida;
    }

    static string InvertirCadena(string cadena)
    {
        char[] caracteres = cadena.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}
