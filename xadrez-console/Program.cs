using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tabuleiro);
            Console.ReadLine();
        }
    }
}