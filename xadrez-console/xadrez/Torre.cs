using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
            => "T";
    }
}