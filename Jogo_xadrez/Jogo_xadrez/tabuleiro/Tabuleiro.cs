using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_xadrez.tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        //Define o tamanho do tabuleiro e instancia uma matriz para montar o mesmo
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //Metodo para retornar uma peca
        public Peca peca(int linhas, int colunas)
        {
            return pecas[linhas, colunas];
        }

        public Peca peca(Posicao posicao)
        {
            return pecas[posicao.linha, posicao.coluna];
        }

        public void colocarPeca(Peca p, Posicao posicao)
        {
            if (existePeca(posicao))
            {
                throw new TabuleiroExcepition("Já existe uma peça nessa possição! ");
            }
                pecas[posicao.linha, posicao.coluna] = p; //Coloca a peça "p" na posicao setada
                p.posicao = posicao;            
        }

        public Peca retirarPeca(Posicao posicao)
        {
            if (peca(posicao) == null)
            {
                return null;
            }
            peca(posicao).posicao = null; //Marca a posição do tabuleiro como nulo
            pecas[posicao.linha, posicao.coluna] = null; //Marca a posicção da peca como nulo
            return peca(posicao);

        }

        //Testa se a posição da peça "cabe no tabuleiro"
        public bool posicaoValida(Posicao posicao)
        {
            if (posicao.linha < 0 || posicao.coluna < 0 || posicao.linha >= linhas || posicao.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao posicao)
        {
            if (!posicaoValida(posicao)) //Se a posição não (!) for valida lança uma execeção
            {
                throw new TabuleiroExcepition("Posição inválida");
            }
        }
        public bool existePeca(Posicao posicao)
        {
            validarPosicao(posicao); //Testa se a posicao é valida
            return peca(posicao) != null; // Verifica se o metodo que define a posição da peça esta nulo (Se tiver alguma peça retorna a mesma)
        }

    }
}
