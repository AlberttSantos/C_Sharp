using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo_xadrez.tabuleiro;

namespace Jogo_xadrez.xadrez
{
     class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor){ }

        private bool podeMover(Posicao posicao)
        {
            Peca p = tabuleiro.peca(posicao);
            return p == null || p.cor != this.cor; //Verifica se a posição esta livre ou (||) se a cor da peça (p.cor) é diferente da cor do rei (this.cor)
        }

        public override string ToString()
        {
            return "R";
        }

        public override bool[,] movimentosPosiveis() //Sobrescrevendo o metodo da classe
        {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0,0);

            //Mover pra cima
            pos.definirValores(pos.linha -1, pos.coluna);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            //Mover pra baixo
            pos.definirValores(pos.linha + 1, pos.coluna);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            //Mover pra Direita
            pos.definirValores(pos.linha, pos.coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            //Mover pra Esquerda
            pos.definirValores(pos.linha, pos.coluna -1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            //NE
            pos.definirValores(pos.linha - 1, pos.coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            //SE
            pos.definirValores(pos.linha + 1, pos.coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            //SO
            pos.definirValores(pos.linha + 1, pos.coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            //NO
            pos.definirValores(pos.linha - 1, pos.coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            return mat;
        }

    }


}
