using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    tabuleiro.Peca(i, j) == null ? Console.Write("- ") : Console.Write(tabuleiro.Peca(i, j) + " ")
                }

                Console.WriteLine(" ");
            }
        }
    }
}