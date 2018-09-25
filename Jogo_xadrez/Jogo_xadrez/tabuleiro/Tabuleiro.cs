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
    }
}
