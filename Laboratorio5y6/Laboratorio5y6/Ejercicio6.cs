//Arreglos y Matrices: 
//Ejercicio6: Crea una matriz de números reales. 

using System;
class Program
{
    static void Main(string[] args)
    {
        double[,] matriz = {
            { 1.5, 2.3, 3.7 },
            { 4.2, 5.1, 6.9 },
            { 7.8, 8.6, 9.4 }
        };

        Console.WriteLine("Matriz:");
        ImprimirMatriz(matriz);
    }

    static void ImprimirMatriz(double[,] matriz)
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
