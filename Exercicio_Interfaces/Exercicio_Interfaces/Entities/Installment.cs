using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Entities
{
    class Installment
    {
        public int Parcelas { get; private set; }
        public DateTime vencimento { get; private set; }        
                
        public Installment(int parcelas, DateTime vencimento)
        {
            Parcelas = parcelas;
            this.vencimento = vencimento;
        }

        public override string ToString()
        {
            return "Parcelas: "+vencimento+" - ";
        }
    }
}
