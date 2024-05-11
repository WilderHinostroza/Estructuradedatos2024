//Ejercicio 8: Crea una matriz de matrices. 

using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] matrizDeMatrices = new int[3][];

        matrizDeMatrices[0] = new int[] { 1, 2, 3 };
        matrizDeMatrices[1] = new int[] { 4, 5 };
        matrizDeMatrices[2] = new int[] { 6, 7, 8, 9 };

        ImprimirMatrizDeMatrices(matrizDeMatrices);
    }

    static void ImprimirMatrizDeMatrices(int[][] matrizDeMatrices)
    {
        for (int i = 0; i < matrizDeMatrices.Length; i++)
        {
            for (int j = 0; j < matrizDeMatrices[i].Length; j++)
            {
                Console.Write(matrizDeMatrices[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
