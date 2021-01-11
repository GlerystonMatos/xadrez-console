﻿namespace xadrez_console.tabuleiro
{
    public class Posicao
    {
        public int Linha { get; set; }

        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
            => Linha + ", " + Coluna;
    }
}