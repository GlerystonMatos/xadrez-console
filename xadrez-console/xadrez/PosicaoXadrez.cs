using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    public class PosicaoXadrez
    {
        public char Coluna { get; set; }

        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
            => new Posicao(8 - Linha, Coluna - 'A');

        public override string ToString()
            => "" + Coluna + Linha;
    }
}