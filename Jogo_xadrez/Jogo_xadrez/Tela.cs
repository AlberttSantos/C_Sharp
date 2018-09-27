using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo_xadrez.tabuleiro;

namespace Jogo_xadrez
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8 - i+ " ");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (tabuleiro.peca(i,j)==null) {
                        Console.Write("- ");
                    }
                    else {
                        imprimirPeca(tabuleiro.peca(i,j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        //Imprimir as peças conforme cor
        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branco)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor; //Pega a cor atual do sistema
                Console.ForegroundColor = ConsoleColor.Yellow; //Define uma nova cor para a cor do sistema
                Console.Write(peca);
                Console.ForegroundColor = aux; //Volta a cor original do sistema
            }
        }
    }
}
