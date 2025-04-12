using System;
using System.Reflection.PortableExecutable;
using tabuleiro;
using Xadrez;
namespace ProjetoXadrez
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                Console.ReadLine();

                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 7));
                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));
                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(3, 5));
                

                Tela.ImprimirTabuleiro(tabuleiro);
                Console.ReadLine();


            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }



}

