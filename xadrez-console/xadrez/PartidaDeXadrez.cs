using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    public class PartidaDeXadrez
    {
        public Tabuleiro Tabuleiro { get; private set; }

        public int Turno { get; private set; }

        public Cor JogadorAtual { get; private set; }

        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = Tabuleiro.RetirarPeca(origem);
            peca.IncrementarQuantidadeMovimentos();

            Peca pecaCapturada = Tabuleiro.RetirarPeca(destino);
            Tabuleiro.ColocarPeca(peca, destino);
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutarMovimento(origem, destino);
            Turno++;
            MudaJogador();
        }

        public void ValidarPosicaoOrigem(Posicao posicao)
        {
            if (Tabuleiro.Peca(posicao) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            }

            if (JogadorAtual != Tabuleiro.Peca(posicao).Cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }

            if (!Tabuleiro.Peca(posicao).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida!");
            }
        }

        public void ValidarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!Tabuleiro.Peca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        private void MudaJogador()
        {
            if (JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else if (JogadorAtual == Cor.Preta)
            {
                JogadorAtual = Cor.Branca;
            }
        }

        private void ColocarPecas()
        {
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('C', 1).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('C', 2).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('D', 2).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('E', 2).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('E', 1).ToPosicao());
            Tabuleiro.ColocarPeca(new Rei(Tabuleiro, Cor.Branca), new PosicaoXadrez('D', 1).ToPosicao());

            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('C', 7).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('C', 8).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('D', 7).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('E', 7).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('E', 8).ToPosicao());
            Tabuleiro.ColocarPeca(new Rei(Tabuleiro, Cor.Preta), new PosicaoXadrez('D', 8).ToPosicao());
        }
    }
}