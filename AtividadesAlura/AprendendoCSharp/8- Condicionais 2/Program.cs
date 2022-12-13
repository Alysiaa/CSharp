using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Condicionais 2");

        int idadeAna = 16;
        int acompanhante = 3;

        Console.WriteLine(idadeAna);

        // colocando a condição "ou" para diminuir o código = ||
        // condição "e" = &&

        bool acompanhado = acompanhante > 2;
        bool grupo = true;

        if (idadeAna >= 18 || acompanhante > 2)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode acessar!");
        }

        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }

}
