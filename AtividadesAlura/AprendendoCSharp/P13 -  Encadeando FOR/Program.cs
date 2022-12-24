using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadeando FOR");

        /*
          *
          **
          ***
          ****
          *****
          */

        for (int contlinhas = 0; contlinhas <= 9; contlinhas++)
        {
            Console.WriteLine();
            for (int contcolunas = 0; contcolunas <= 9; contcolunas++)
            {
                Console.Write("*");
                if (contcolunas >= contlinhas)
                    break;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }
}
