using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
            => "R";
    }
}