using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Entities
{
    class Contract
    {
        public int Numero { get; private set; }
        public DateTime Data { get; private set; }
        public double ValorTotal { get; private set; }
        public List<Installment> Installment { get; set; }

        public Contract(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Installment = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installment.Add(installment);
        }

    }
}
