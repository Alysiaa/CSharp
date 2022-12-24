using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Investimento");

        double fatorRendimento = 1.005;
        double valor = 1000;

        for (int anos=1; anos<= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes ++)
            {
                valor *= fatorRendimento;
            }
            fatorRendimento = fatorRendimento + 0.001;
        }

        Console.WriteLine("Depois de 5 anos o valor será de R$ " + valor);

        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }
}
