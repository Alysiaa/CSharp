using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Cálculo de Poupança");

        double investimento = 1000;

        // rendimento de 0.50% ao mês = 0.005

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês "+ mes + " você terá: R$ " + investimento);

            mes = mes + 1;
            // faz a somatória da mesma forma
            // mes += 1
            // mes ++

        }





        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }
}