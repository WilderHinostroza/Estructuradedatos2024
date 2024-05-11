//Ejercicio 7: Crea una matriz de números complejos. 

using System;

struct NumeroComplejo
{
    public double Real;
    public double Imaginario;

    public NumeroComplejo(double real, double imaginario)
    {
        Real = real;
        Imaginario = imaginario;
    }
    public override string ToString()
    {
        if (Imaginario >= 0)
            return $"{Real} + {Imaginario}i";
        else
            return $"{Real} - {-Imaginario}i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        NumeroComplejo[,] matriz = {
            { new NumeroComplejo(1.5, 2.3), new NumeroComplejo(3.7, -4.2) },
            { new NumeroComplejo(-5.1, 6.9), new NumeroComplejo(7.8, 8.6) }
        };

        Console.WriteLine("Matriz de números complejos:");
        ImprimirMatriz(matriz);
    }

    static void ImprimirMatriz(NumeroComplejo[,] matriz)
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
