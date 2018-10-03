using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Services
{
    class CalculationService
    {
        //*********** Delegates - Aula 130 ***************
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y; //Se (x > y) então (?) retorna x, se não (:) retorna y
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Square(double x)
        {
            return x * x;
        }

        //*********** Multicast Delegates - Aula 131 ***************
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y; //Se (x > y) então (?) retorna x, se não (:) retorna y
            Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double sum = x + y; //Se (x > y) então (?) retorna x, se não (:) retorna y
            Console.WriteLine(sum);
        }
    }
}
