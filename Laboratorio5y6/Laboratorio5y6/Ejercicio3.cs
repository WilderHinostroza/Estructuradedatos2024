//3) Ejercicio 3:
//Escribe una función recursiva que imprima la pirámide de números del 1 al n. 

using System;
class Program
{
    static void Main(string[] args)
    {
        ImprimirPiramide(5);
    }

    static void ImprimirPiramide(int n)
    {
        ImprimirFilas(1, n);
    }

    static void ImprimirFilas(int fila, int n)
    {
        if (fila > n)
            return;

        ImprimirNumeros(1, fila);
        Console.WriteLine();
        ImprimirFilas(fila + 1, n); 
    }

    static void ImprimirNumeros(int numero, int limite)
    {
        if (numero > limite)
            return;

        Console.Write(numero + " ");
        ImprimirNumeros(numero + 1, limite);
    }
}
