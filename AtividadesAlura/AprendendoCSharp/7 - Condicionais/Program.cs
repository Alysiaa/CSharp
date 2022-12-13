using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeAna = 16;
        int acompanhante = 1;

        Console.WriteLine(idadeAna);
        if (idadeAna >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (acompanhante > 1)
            {
                Console.WriteLine("Está com acompanhante, pode acessar!");
            }
            else
            {
                Console.WriteLine("Não pode acessar!");
            }

            Console.WriteLine("Tecle enter para fechar!");
            Console.ReadLine();
        }

    }
}