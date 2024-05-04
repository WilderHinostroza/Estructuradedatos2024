//ejercicio numero 9: Contador de Vocales: 
//Cuenta el número de vocales en una cadena de texto. 

using System;

class Ejercicio9
{
    static void Main(string[] args)
    {

        Console.Write("Ingresa una cadena de texto: ");
        string texto = Console.ReadLine();

        int contadorVocales = ContarVocales(texto);

        Console.WriteLine($"El número de vocales en la cadena es: {contadorVocales}");

        Console.ReadLine();
    }

    static int ContarVocales(string cadena)
    {
        int contador = 0;

        cadena = cadena.ToLower();

        foreach (char c in cadena)
        {

            if (EsVocal(c))
            {
                contador++;
            }
        }
        return contador;
    }

    static bool EsVocal(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
           || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'
           || c == 'á' || c == 'é' || c == 'í' || c == 'ó' || c == 'ú';
    }
}
