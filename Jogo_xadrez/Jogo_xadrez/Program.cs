using Jogo_xadrez.tabuleiro;
using System;
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
            Tabuleiro t;

            t = new Tabuleiro(10,2);
            Tela.imprimirTabuleiro(t);

            Console.ReadLine();
        }
    }
}
