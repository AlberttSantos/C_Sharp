using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Exercicio_LINQ.Entities;
using System.Globalization;

namespace Exercicio_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();

            //Instanciar lista de produtos
            List<Produto> list = new List<Produto>();

            using (StreamReader sr = File.OpenText(path)) //Abre o arquivo
            {
                while (!sr.EndOfStream) //Enquanto eu não chegar no final do arquivo
                {
                    string[] campos = sr.ReadLine().Split(',');
                    string nome = campos[0];
                    double preco = double.Parse(campos[1], CultureInfo.InvariantCulture); //Converte a string presente no arquivo para double
                    list.Add(new Produto(nome, preco)); //Adiciona os produtos na lista
                }
            }

            var avg = list.Select(x => x.Preco).DefaultIfEmpty(0.0).Average(); //Calcula a media dos produtos da lista
            Console.WriteLine("A média dos preços é: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            var nomes = list.Where(x => x.Preco < avg).OrderByDescending(x => x.Nome).Select(x => x.Nome); //Verifica se os preços estão abaixo da média dos produtos

            foreach (string n in nomes)
            {
                Console.WriteLine(n);
            }




        }



    }
}
