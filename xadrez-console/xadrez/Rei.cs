using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    public class Rei : Peca
    {
        private PartidaDeXadrez _partidaDeXadrez;

        public Rei(Tabuleiro tabuleiro, Cor cor, PartidaDeXadrez partidaDeXadrez) : base(tabuleiro, cor)
        {
            _partidaDeXadrez = partidaDeXadrez;
        }

        public override string ToString()
            => "R";

        private bool TesteTorreParaRoque(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);
            return peca != null && peca is Torre && peca.Cor == Cor && peca.QuantidadeMovimentos == 0;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao posicao = new Posicao(0, 0);

            // acima
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            // ne
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            // direita
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            // se
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            // abaixo
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            // so
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            // esquerda
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            // no
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            // #jogadaespecial roque
            if (QuantidadeMovimentos == 0 && !_partidaDeXadrez.Xeque)
            {
                // #jogadaespecial roque pequeno
                Posicao posicaoT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
                if (TesteTorreParaRoque(posicaoT1))
                {
                    Posicao posicao1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao posicao2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);
                    if (Tabuleiro.Peca(posicao1) == null && Tabuleiro.Peca(posicao2) == null)
                    {
                        matriz[Posicao.Linha, Posicao.Coluna + 2] = true;
                    }
                }

                // #jogadaespecial roque grande
                Posicao posicaoT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (TesteTorreParaRoque(posicaoT2))
                {
                    Posicao posicao1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao posicao2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao posicao3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);
                    if (Tabuleiro.Peca(posicao1) == null && Tabuleiro.Peca(posicao2) == null && Tabuleiro.Peca(posicao3) == null)
                    {
                        matriz[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }

            return matriz;
        }
    }
}