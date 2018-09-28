using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_xadrez.tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimento { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.qtdMovimento = 0;
        }

        public void incrementarMovimento()
        {
            qtdMovimento++;
        }

        public abstract bool[,] movimentosPosiveis();           
        

    }
}
