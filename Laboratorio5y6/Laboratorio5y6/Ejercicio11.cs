//Ejercicio 11: Multiplica una matriz por un número.
//
using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        int numero = 2;

        int[,] resultado = MultiplicarMatrizPorNumero(matriz, numero);

        Console.WriteLine("Matriz resultado:");
        ImprimirMatriz(resultado);
    }

    static int[,] MultiplicarMatrizPorNumero(int[,] matriz, int numero)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz[i, j] * numero;
            }
        }

        return resultado;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

