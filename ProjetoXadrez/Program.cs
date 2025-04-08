using System;
using tabuleiro;
namespace ProjetoXadrez
{

    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Console.ReadLine();

            Tela.ImprimirTabuleiro(tabuleiro);
            Console.ReadLine();
        }
    }



}

