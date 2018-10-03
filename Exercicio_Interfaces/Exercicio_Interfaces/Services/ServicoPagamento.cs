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
        ITaxaServico _taxaServico;

        public ServicoPagamento(ITaxaServico taxaServico)
        {
            _taxaServico = taxaServico;
        }

        public void GerarParcelas(Contract contract, int meses)
        {
            double valorParcela = contract.ValorTotal / meses;

            for (int i = 1; i <= meses; i++)
            {
                DateTime date = contract.Data.AddMonths(i);
                double calcJurosSimples = valorParcela + _taxaServico.JurosSimples(valorParcela, i);
                double calcTaxa = calcJurosSimples + _taxaServico.Taxa(calcJurosSimples);
                contract.AddInstallment(new Installment(calcTaxa, date));
            }
            //carRental.Invoice = new Invoice(basicPayment, tax); //Processando o Invoice

        }
    }
}
