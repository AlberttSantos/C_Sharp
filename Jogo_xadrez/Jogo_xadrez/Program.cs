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
            
            try
            {
                PartidadeXadrez px = new PartidadeXadrez();
                while (!px.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(px.tabuleiro);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    px.executarMovimento(origem, destino);
                }
            }
            catch (TabuleiroExcepition e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
