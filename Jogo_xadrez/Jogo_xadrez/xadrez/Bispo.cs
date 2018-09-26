using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jogo_xadrez.tabuleiro;

namespace Jogo_xadrez.xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "B";
        }
    }


}