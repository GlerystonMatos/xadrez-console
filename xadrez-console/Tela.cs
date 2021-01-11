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
                    string peca = tabuleiro.Peca(i, j) == null ? "- " : tabuleiro.Peca(i, j) + " ";
                    Console.Write(peca);
                }

                Console.WriteLine(" ");
            }
        }
    }
}