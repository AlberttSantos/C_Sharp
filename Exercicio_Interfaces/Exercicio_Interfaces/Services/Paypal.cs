using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Services
{
    class Paypal : ITaxaServico
    {
        //Calcula juros por parcela de 1%
        public double JurosSimples(double montante, int meses)
        {
            return montante * 0.01 * meses;
        }

        //Calcula taxa de 2%
        public double Taxa(double montante)
        {
            return montante * 0.02;
        }
    }
}
