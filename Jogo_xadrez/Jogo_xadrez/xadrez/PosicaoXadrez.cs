using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo_xadrez.tabuleiro;

namespace Jogo_xadrez.xadrez
{
    class PosicaoXadrez
    {
        public int linha { get; set; }
        public char coluna { get; set; }

        public PosicaoXadrez(int linha, char coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }
        
        //Seta a posição conforme o tabuleiro de xadrez
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
