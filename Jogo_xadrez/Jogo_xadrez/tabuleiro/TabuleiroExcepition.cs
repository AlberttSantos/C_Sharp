using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_xadrez.tabuleiro
{
    class TabuleiroExcepition : Exception
    {
        public TabuleiroExcepition(string msg) : base(msg){
        }
    }
}
