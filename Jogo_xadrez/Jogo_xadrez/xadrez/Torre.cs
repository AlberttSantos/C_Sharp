using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo_xadrez.tabuleiro;

namespace Jogo_xadrez.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override bool[,] movimentosPosiveis() //Sobrescrevendo o metodo da classe
        {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            //Mover pra cima
            pos.definirValores(pos.linha - 1, pos.coluna);
            while(podeMover(pos) && tabuleiro.posicaoValida(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if(tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) //If para parar o "While" caso exista alguma peça na posição
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            //Mover pra baixo
            pos.definirValores(pos.linha + 1, pos.coluna);
            while (podeMover(pos) && tabuleiro.posicaoValida(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) //If para parar o "While" caso exista alguma peça na posição
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            //Mover pra Direita
            pos.definirValores(pos.linha, pos.coluna + 1);
            while (podeMover(pos) && tabuleiro.posicaoValida(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) //If para parar o "While" caso exista alguma peça na posição
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            //Mover pra Esquerda
            pos.definirValores(pos.linha, pos.coluna - 1);
            while (podeMover(pos) && tabuleiro.posicaoValida(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) //If para parar o "While" caso exista alguma peça na posição
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }

            return mat;
        }
        private bool podeMover(Posicao posicao)
        {
            Peca p = tabuleiro.peca(posicao);
            return p == null || p.cor != this.cor; //Verifica se a posição esta livre ou (||) se a cor da peça (p.cor) é diferente da cor do rei (this.cor)
        }

        public override string ToString()
        {
            return "T";
        }
    }


}