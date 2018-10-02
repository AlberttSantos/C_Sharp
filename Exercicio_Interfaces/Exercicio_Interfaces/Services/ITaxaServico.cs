using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Services
{
    interface ITaxaServico
    {
        double JurosSimples(double montante);
        double Taxa(double montante);
    }
}
