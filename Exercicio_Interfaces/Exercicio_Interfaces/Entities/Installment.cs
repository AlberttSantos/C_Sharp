using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Entities
{
    class Installment
    {
        public double ValorParcela { get; private set; }
        public DateTime Vencimento { get; private set; }        
                
        public Installment(double parcelas, DateTime vencimento)
        {
            ValorParcela = parcelas;
            this.Vencimento = vencimento;
        }

        public override string ToString()
        {
            return Vencimento.ToString("dd/MM/yyyy")+" - "+ValorParcela;
        }
    }
}
