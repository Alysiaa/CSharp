using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 14 - Fatorial");
        int fatorial = 1;
        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }
    }
}