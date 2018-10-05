using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq.Entities;

namespace Linq
{
    class Program
    {
        //Imprime resultado na tela
        static void Print<T>(string mensagem, IEnumerable<T> colecao) //Metodo generico
        {
            Console.WriteLine(mensagem);
            foreach (T m in colecao)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //************ Introdução ao LINQ *****************
            ////Especifica a fonte de dados
            //int[] numeros = new int[] { 1, 2, 3, 4, 5, 6 };

            ////Defini a consulta
            //var resultado = numeros.Where(x => x % 2 == 0).Select(x => x * 10); //"Where" filtra os elementos da fonte de dados //"Select" Seleciona um elemento do vetor e retorna um resultado

            ////Executar a consulta
            //foreach(int n in resultado)
            //{
            //    Console.WriteLine(n);
            //}



            //************ LINQ com Lambda - Aula 137 *****************
            Categoria c1 = new Categoria() { Id = 1, Nome = "Ferramentas", Tier = 1 };
            Categoria c2 = new Categoria() { Id = 2, Nome = "Computadores", Tier = 1 };
            Categoria c3 = new Categoria() { Id = 3, Nome = "Eletronicos", Tier = 1 };


            List<Produto> Lista = new List<Produto>() {
                new Produto() { Id = 1, Nome = "Notebook", Preco = 1300, Categoria = c2 },
                new Produto() { Id = 2, Nome = "Chave de fenda", Preco=50, Categoria=c1 },
                new Produto() { Id = 3, Nome = "Tablet", Preco=1000, Categoria=c2 },
                new Produto() { Id = 4, Nome = "Air book", Preco=800, Categoria=c2 },
                new Produto() { Id = 5, Nome = "Camera", Preco=800, Categoria=c3 },
                new Produto() { Id = 6, Nome = "Canivete", Preco=135, Categoria=c1 }
            };

            //var result1 = Lista.Where(x => x.Categoria.Tier == 1 && x.Preco < 900); //Verifica se a categoria é do tier 1 && se o preço é < que 900
            var result1 =
                from x in Lista
                where x.Categoria.Tier == 1 && x.Preco < 900
                select x;

            Print("Tier 1 e Preço < 900: ", result1);


            //var result2 = Lista.Where(x => x.Categoria.Nome == "Ferramentas").Select(x => x.Nome); //Retorna o nome do produto cujo a categoria é == a "Ferramentas"
            var result2 = 
                from x in Lista
                where x.Categoria.Nome == "Ferramentas"
                select x.Nome;

            Print("Nomes dos Produtos da Categoria Ferramentas: ", result2);


            //Retorna produtos que começam com a letra "C" e seleciona o Nome, Preço e Nome da Categoria para retornar (Obs: É preciso colocar o "Objeto anonimo == new {}" para selecionar mais de um elemento)
            //var result3 = Lista.Where(x => x.Nome.StartsWith("C")).Select(x => new { x.Nome, x.Preco, NomeCategoria = x.Categoria.Nome }); //"NomeCategoria" é um apelido para o campo 
            var result3 =
                from x in Lista
                where x.Nome.StartsWith("C")
                select new { x.Nome, x.Preco, NomeCategoria = x.Categoria.Nome };

            Print("Produtos começados com a letra C: ", result3);


            //var result4 = Lista.Where(x => x.Categoria.Tier == 1).OrderBy(x => x.Preco).ThenBy(x => x.Nome); //"OrderBy" ordena os valores por preço, "Thenby" depois ordena por nome 
            var result4 =
                from x in Lista
                where x.Categoria.Tier == 1
                orderby x.Nome
                orderby x.Preco
                select x;

            Print("Produtos de Tier 1, ordenados por Preço: ", result4);


            //var result5 = result4.Skip(2).Take(3); //Pula os primeiros 2 campos e pega os proximos 3
            var result5 = (from x in Lista
                           where x.Categoria.Tier == 1
                           orderby x.Nome
                           orderby x.Preco
                           select x).Skip(2).Take(3); //Pula os primeiros 2 campos e pega os proximos 3

            Print("Pula os 2 primeiros elementos e pega 3 elementos: ", result5);


            var result6 = Lista.FirstOrDefault(); //Retorna o primeiro elemento, caso não tenha retorna Default (nulo)
            Console.WriteLine("Priemiro Item: " + result6);
            var result7 = Lista.Where(x => x.Preco > 3000).FirstOrDefault();
            Console.WriteLine("Primeiro Item: " + result7); //Retorna null pois não tem nenhum elemento na lista

            var result8 = Lista.Where(x => x.Id == 3).Select(x => x.Nome).SingleOrDefault();
            Console.WriteLine("Elemento cujo o ID é 3: " + result8);



            //Operações de agregação - Aula 138
            var result9 = Lista.Max(x => x.Preco);
            Console.WriteLine("Preço maximo: " + result9);

            var result10 = Lista.Where(x => x.Categoria.Id == 1).Sum(x => x.Preco);
            Console.WriteLine("Soma dos preços dos produtos da Categoria 1: " + result10);

            var result11 = Lista.Where(x => x.Categoria.Id == 1).Average(x => x.Preco);
            Console.WriteLine("Media dos preços dos produtos da Categoria 1: " + result11);

            var result12 = Lista.Where(x => x.Categoria.Id == 5).Select(x => x.Preco).DefaultIfEmpty(0.0).Average(); //Se não existir a categoria ou não possuir nenhum preço retorna 0 como default
            Console.WriteLine("Media dos preços dos produtos da Categoria 5: " + result12);


            //Função Aggregate
            var result13 = Lista.Where(x => x.Categoria.Id == 1).Select(x => x.Preco).Aggregate((x, y) => x + y);
            Console.WriteLine("Somas dos produtos da categoria 1 com Aggregate: " + result13);

            var result14 = Lista.Where(x => x.Categoria.Id == 9).Select(x => x.Preco).Aggregate(0.0, (x, y) => x + y); //Utiliza-se 0.0 (valor padrão inicial) antes da função no Aggregate caso algum valor não seja valido
            Console.WriteLine("Somas dos produtos da categoria 1 com Aggregate: " + result14);

            //GruoBy
            Console.WriteLine();
            //var result15 = Lista.GroupBy(x => x.Categoria);

            var result15 =
                from x in Lista 
                group x by x.Categoria;       
                

            foreach (IGrouping<Categoria, Produto> categoria in result15) //Cada elemento tem uma chave (Categoria) e uma coleção (Produtos)
            {
                Console.WriteLine("Categoria " + categoria.Key.Nome + ": "); //Imprimindo a chave (Nome da categoria)
                foreach (Produto p in categoria)
                {
                    Console.WriteLine(p); //Imprimindo a coleção que esta dentro da categoria            
                }
                Console.WriteLine();
            }


        }
    }
}
