//ejercicio 6:Inversión de Cadena: 
//Toma una cadena de texto y muestra su inversión. 
using System;

class Ejercicio6
{
    static void Main(string[] args)
    {

        Console.Write("Ingresa una cadena de texto: ");
        string texto = Console.ReadLine();

        string textoInvertido = InvertirCadena(texto);

        Console.WriteLine($"La cadena invertida es: {textoInvertido}");

        Console.ReadLine();
    }

    static string InvertirCadena(string cadena)
    {
        char[] caracteres = cadena.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}
