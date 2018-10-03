using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate.Services;

namespace Delegate
{
    class Program
    {

        delegate double OperacaoNumeriaBinaria(double n1, double n2); //Declaração do delegate de tipo double
        delegate void OperacaoNumeriaBinariaVoid(double n1, double n2); //Declaração do delegate de tipo void

        static void Main(string[] args)
        {
            //*********** Delegates - Aula 130 ***************
            //double a = 10;
            //double b = 5;

            //OperacaoNumeriaBinaria op_sum = CalculationService.Sum; // O delegate recebe a referencia do metodo "CalculationService.Sum"
            //OperacaoNumeriaBinaria op_max = CalculationService.Max;

            //Console.WriteLine(op_sum(a, b));
            //Console.WriteLine(op_max(a, b));

            //*********** Multicast Delegates - Aula 131 ***************
            double a = 7;
            double b = 5;

            OperacaoNumeriaBinariaVoid op = CalculationService.ShowSum; // O delegate recebe a referencia do metodo "CalculationService.Sum"
            op += CalculationService.ShowMax; //Adiciona mais uma referencia no delegate

            op(a, b); //Chama as duas referencias na ordem

        }
    }
}
