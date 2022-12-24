using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Cálculo de Poupança 2");
        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você terá: R$ " + investimento);

            mes = mes + 1;
            // faz a somatória da mesma forma
            // mes += 1
            // mes ++

        }
*/

        double investimento = 1000;

        // rendimento de 0.50% ao mês = 0.005
        for (int mes = 1; mes <= 12; mes++)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você terá: R$ " + investimento);
        }
        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }
}