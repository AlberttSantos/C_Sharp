using System;
using Exercicio_Interfaces.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Services
{
    class ServicoPagamento
    {
        public void GerarParcelas(Contract contract)
        {
            double valorParcela = contract.ValorTotal / contract.installment.Parcelas;
        }
    }
}
