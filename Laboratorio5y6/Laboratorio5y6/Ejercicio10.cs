//Ejercicio 10: Suma dos matrices de diferentes tamaños. 

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrizA = {
            {1, 2, 3},
            {4, 5, 6}
        };

        int[,] matrizB = {
            {7, 8},
            {9, 10},
            {11, 12}
        };

        if (matrizA.GetLength(0) != matrizB.GetLength(0) || matrizA.GetLength(1) != matrizB.GetLength(1))
        {
            Console.WriteLine("No se pueden sumar las matrices porque tienen tamaños diferentes.");
            return;
        }

        int filas = matrizA.GetLength(0);
        int columnas = matrizA.GetLength(1);
        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }

        Console.WriteLine("Matriz resultado de la suma:");
        ImprimirMatriz(resultado);
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
