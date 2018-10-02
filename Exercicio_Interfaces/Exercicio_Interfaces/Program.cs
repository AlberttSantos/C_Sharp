using System;
using Exercicio_Interfaces.Entities;
using Exercicio_Interfaces.Services;
using Exercicio_Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do contrato: ");
            Console.Write("Número: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor total do contrato: ");
            int valorTotal = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de parcelas desejadas: ");
            int parcelas = int.Parse(Console.ReadLine());

            Contract contract = new Contract(numeroContrato, dataContrato, valorTotal);
            ServicoPagamento servicoPagamento = new ServicoPagamento();
            servicoPagamento.GerarParcelas(contract); //A classe de "servicoPagamento" recebe a Classe "contract" como parametro

            

        }
    }
}
