using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate.Services;
using Delegate.Entities;


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
            //double a = 7;
            //double b = 5;

            //OperacaoNumeriaBinariaVoid op = CalculationService.ShowSum; // O delegate recebe a referencia do metodo "CalculationService.Sum"
            //op += CalculationService.ShowMax; //Adiciona mais uma referencia no delegate

            //op(a, b); //Chama as duas referencias na ordem



            //*********** Delegate Predicate - Aula 132 ***************
            //List<Product> list = new List<Product>();

            //list.Add(new Product("TV", 1700.00));
            //list.Add(new Product("Celular", 1200.00));
            //list.Add(new Product("Mouse", 30.00));
            //list.Add(new Product("Teclado", 89.90));

            //////Resolução com função lambda
            ////list.RemoveAll(produto => produto.Preco >= 100); // "=>" tal que (Remove todos produtos maior ou igual a cem)
            ////foreach (Product p in list)
            ////{
            ////    Console.WriteLine(p);
            ////}

            ////Resolução com Predicate
            //list.RemoveAll(ProductTest); //Remove os elementos da lista que a função retorna como verdadeiro
            //foreach (Product p in list)
            //{
            //    Console.WriteLine(p);
            //}



            //*********** Delegate Action - Aula 133 ***************
            List<Product> lista = new List<Product>();

            lista.Add(new Product("TV", 300.00));
            lista.Add(new Product("Celular", 100.00));
            lista.Add(new Product("Mouse", 30.00));
            lista.Add(new Product("Teclado", 89.90));

            //Exemplo declarando um Action
            Action<Product> act = p => { p.Preco += p.Preco * 0.1; }; //Utiliza-se as chaves para mostrar que é do tipo "Void"

            lista.ForEach(act); //Percorre a lista e executa o "UpdatePrice"
            foreach (Product p in lista)
            {
                Console.WriteLine(p);
            }
        }

        //Resolução com Predicate
        public static bool ProductTest(Product p) //Função Predicate (Recebe um obejeto e retorna um boleano)
        {
            return p.Preco >= 100;
        }

        //Resolução Action
        //public static void UpdatePrice(Product p)
        //{
        //    p.Preco += p.Preco * 0.1; // += recebe oq já tinha
        //}
    }
}
