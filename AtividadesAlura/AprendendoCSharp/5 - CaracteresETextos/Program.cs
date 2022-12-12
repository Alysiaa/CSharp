using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");
        Console.WriteLine("");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        Console.WriteLine("");
        string primeiraFrase = "Testeee - Curso C#!";
        Console.WriteLine(primeiraFrase);
        Console.WriteLine("");

        string vazia = "";
        Console.WriteLine(vazia);

        string lista = @"Teste para fazer uma lista:
- Teste 1;
- Teste 2;
- Teste 3;";
        Console.WriteLine(lista);
        Console.WriteLine("");

        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }
}