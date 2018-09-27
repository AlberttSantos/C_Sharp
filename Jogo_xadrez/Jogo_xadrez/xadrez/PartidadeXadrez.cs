using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo_xadrez.tabuleiro;

namespace Jogo_xadrez.xadrez
{
    class PartidadeXadrez
    {
        public Tabuleiro tabuleiro { get; private set; }
        private int turno;
        private Cor jogadorAtual;

        public PartidadeXadrez()
        {
            tabuleiro = new Tabuleiro(8,8);
            turno = 1;
            jogadorAtual = Cor.Branco;
            colocarPecas();
        }

        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tabuleiro.retirarPeca(origem); //Retira a peca de sua origem no tabuleiro 
            p.incrementarMovimento();
            Peca pecaCapturada = tabuleiro.retirarPeca(destino); //Retira a peca de seu destino e salva na variavel "pecaCapturada"
            tabuleiro.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            //Obs: Instancia a "PosicaoXadrez" e chama o metodo "toPosicao()" para definir a posição correta das linhas e colunas da matriz
            tabuleiro.colocarPeca(new Torre(Cor.Branco, tabuleiro), new PosicaoXadrez(1, 'a').toPosicao());
            tabuleiro.colocarPeca(new Torre(Cor.Amarelo, tabuleiro), new PosicaoXadrez(8, 'a').toPosicao());
            tabuleiro.colocarPeca(new Torre(Cor.Branco, tabuleiro), new PosicaoXadrez(1, 'h').toPosicao());
            tabuleiro.colocarPeca(new Torre(Cor.Amarelo, tabuleiro), new PosicaoXadrez(8, 'h').toPosicao());

        }


    }
}
