//Ejercicio 4:
//Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n. 

using System;

class Program
{
    static void Main(string[] args)
    {
        ImprimirPiramideInvertida(5);
    }
    static void ImprimirPiramideInvertida(int n, int fila = 1)
    {
        if (fila > n)
            return;

        int[] numeros = new int[fila];

        LlenarArreglo(numeros, fila);

        ImprimirArreglo(numeros);

        Console.WriteLine(); 

        ImprimirPiramideInvertida(n, fila + 1);
    }

    static void LlenarArreglo(int[] arreglo, int fila, int indice = 0)
    {
        if (indice >= fila)
            return;

        arreglo[indice] = fila;
        LlenarArreglo(arreglo, fila, indice + 1);
    }
    static void ImprimirArreglo(int[] arreglo, int indice = 0)
    {
        if (indice >= arreglo.Length)
            return;

        Console.Write(arreglo[indice] + " "); 
        ImprimirArreglo(arreglo, indice + 1); 
    }
}
