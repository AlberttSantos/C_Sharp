using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comparison.Entities;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();
            lista.Add(new Product("TV", 1200));
            lista.Add(new Product("Notebook", 2500));
            lista.Add(new Product("Celular", 800));

            // Comparison<Product> comp = CompareProduct; //Salva a referencia do metodo em uma variavel
            Comparison<Product> comparison = (p1, p2) => p1.Nome.CompareTo(p2.Nome); //Função lambda (Função anonima)

            lista.Sort(comparison);

            foreach(Product p in lista)
            {
                Console.WriteLine(p);
            }
        }
        //static int CompareProduct(Product p1, Product p2)
        //{
        //    return p1.Nome.CompareTo(p2.Nome);
        //}
    }
}
