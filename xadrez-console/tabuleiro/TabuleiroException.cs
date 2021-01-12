using System;

namespace xadrez_console.tabuleiro
{
    public class TabuleiroException : Exception
    {
        public TabuleiroException(string mensagem) : base(mensagem)
        {
        }
    }
}