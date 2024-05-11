//5) Ejercicio 2:
//Escribe una función recursiva que imprima la tabla de multiplicar del n. 

using System;
class Program
{
    static void Main(string[] args)
    {
        ImprimirTablaMultiplicar(5);
    }
    static void ImprimirTablaMultiplicar(int n, int multiplicador = 1)
    {
        if (multiplicador > 10) 
            return;

        Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");

        ImprimirTablaMultiplicar(n, multiplicador + 1);
    }
}
