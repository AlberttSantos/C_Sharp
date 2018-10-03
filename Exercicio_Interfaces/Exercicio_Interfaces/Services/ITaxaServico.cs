using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Services
{
    interface ITaxaServico
    {
        double JurosSimples(double montante, int meses);
        double Taxa(double montante);
    }
}
