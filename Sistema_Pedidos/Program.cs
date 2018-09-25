using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pedidos
{
    class Program
    {
        public static List<Produto> produtos = new List<Produto>(); //lista estatica do tipo produto desponivel para todo o programa
        public static List<Pedido> pedido = new List<Pedido>();
        static void Main(string[] args)
        {
            int opcao = 0;
            produtos.Add(new Produto(1004, "Sofá de três lugares", 2000.00));
            produtos.Add(new Produto(1001, "Cadeira Simples", 500.00));
            produtos.Add(new Produto(1002, "Mesa Retangular", 600.00));
            produtos.Add(new Produto(1003, "Mesa Retangular", 900.00));
            
            produtos.Sort(); //Serve para ordenar os elementos na lista, exige a implementação do "IComparable" e o metodo "CompareTo"

            while (opcao != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Erro inesperado" + e.Message);
                    opcao = 0;
                }

                if (opcao == 1) {
                    Tela.mostrarProdutos();
                }
                else if (opcao == 2) {

                    //Verifica se os valores cadastrados estão corretos, se não dispara mensagem de exceção
                    try
                    {
                        Tela.cadastrarProduto();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado" + e.Message);                        
                    }
                }
                else if (opcao == 3) {
                    try
                    {
                        Tela.cadastrarPedido();
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine("Erro de négocio: "+e.Message);
                    }   
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }

                }
                else if (opcao == 4)
                {
                    try
                    {
                        Tela.mostrarPedido();
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine("Erro de négocio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 5){
                    Console.WriteLine("Fim do programa!");
                }
                else{
                    Console.WriteLine("Opção invalida! ");
                }
                Console.ReadLine();
            }
          
            
        }
    }
}
