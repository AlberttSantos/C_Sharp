using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo_xadrez.tabuleiro;
using Jogo_xadrez.xadrez;

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
                    imprimirPeca(tabuleiro.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        //public static void imprimirTabuleiro(Tabuleiro tabuleiro, bool[,] posicoesPossiveis)
        //{
        //    ConsoleColor fundoOriginal = Console.BackgroundColor;
        //    ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

        //    for (int i = 0; i < tabuleiro.linhas; i++)
        //    {
        //        Console.Write(8 - i + " ");
        //        for (int j = 0; j < tabuleiro.colunas; j++)
        //        {
        //            if(posicoesPossiveis[i, j])
        //            {
        //                Console.BackgroundColor = fundoAlterado;
        //            }
        //            else
        //            {
        //                Console.BackgroundColor = fundoOriginal;
        //            }
        //            imprimirPeca(tabuleiro.peca(i, j));
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("  a b c d e f g h");
        //    Console.BackgroundColor = fundoOriginal;
        //}

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char linha = s[0];
            int coluna = int.Parse(s[1]+"");//Pegar o segundo valor digitado pelo usuário
            return new PosicaoXadrez(linha, coluna);

        }

        //Imprimir as peças conforme cor
        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                //Imprimir peça da cor Braca
                if (peca.cor == Cor.Branco)
                {
                    Console.Write(peca);
                }
                //Imprimir peça da cor Amarela
                else
                {
                    ConsoleColor aux = Console.ForegroundColor; //Pega a cor atual do sistema
                    Console.ForegroundColor = ConsoleColor.Yellow; //Define uma nova cor para a cor do sistema
                    Console.Write(peca);
                    Console.ForegroundColor = aux; //Volta a cor original do sistema
                }
                Console.Write(" ");
             }
         }
    }
}
