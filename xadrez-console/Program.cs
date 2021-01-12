using System;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez posicaoXadrez = new PosicaoXadrez('C', 7);
                Console.WriteLine(posicaoXadrez);

                Console.WriteLine(posicaoXadrez.ToPosicao());

                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}