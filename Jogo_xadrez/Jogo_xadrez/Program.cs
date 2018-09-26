using Jogo_xadrez.tabuleiro;
using System;
using Jogo_xadrez.xadrez;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro;
            Peca p;

            tabuleiro = new Tabuleiro(8,8);

            //Adicionando uma peça no tabuleiro, instancia uma torre com uma cor e seu tabuleiro, além de sua posição no tabuleiro
            tabuleiro.colocarPeca(new Torre(Cor.Branco,tabuleiro), new Posicao(0,0));
            tabuleiro.colocarPeca(new Cavalo(Cor.Branco, tabuleiro), new Posicao(0, 1));
            tabuleiro.colocarPeca(new Bispo(Cor.Branco, tabuleiro), new Posicao(0, 2));
            tabuleiro.colocarPeca(new Rei(Cor.Branco, tabuleiro), new Posicao(0, 3));
            tabuleiro.colocarPeca(new Rainha(Cor.Branco, tabuleiro), new Posicao(0, 4));
            tabuleiro.colocarPeca(new Bispo(Cor.Branco, tabuleiro), new Posicao(0, 5));
            tabuleiro.colocarPeca(new Cavalo(Cor.Branco, tabuleiro), new Posicao(0, 6));
            tabuleiro.colocarPeca(new Torre(Cor.Branco, tabuleiro), new Posicao(0, 7));

            //Adicionando os pioes
            for(int i=0; i < 8; i++)
            {
                tabuleiro.colocarPeca(new Piao(Cor.Branco, tabuleiro), new Posicao(1, i));
            }

            Tela.imprimirTabuleiro(tabuleiro);

            Console.ReadLine();
        }
    }
}
