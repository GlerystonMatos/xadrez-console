using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Posicao posicao = new Posicao(3, 4);
            Console.WriteLine("Posição: " + posicao);
        }
    }
}