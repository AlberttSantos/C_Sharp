using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pedidos
{
    class Tela
    {
        //Classe responsavel em interagir com o usuário       
        public static void mostrarMenu()
        {
            Console.WriteLine("1 - Listar produtos ordenadamente");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Cadastrar Pedido");
            Console.WriteLine("4 - Mostrar dadso de um pedido");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");
        }

        public static void mostrarProdutos()
        {
            Console.WriteLine("LISTAGEM DE PRODUTOS:");
            for (int i=0; i<Program.produtos.Count(); i++)
            {
                Console.WriteLine(Program.produtos[i]); //Exibir os elemntos na lista, igual vetor
            }
        }
        public static void cadastrarProduto()
        {
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Codigo: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Produto p = new Produto(cod,descricao,preco);
            Program.produtos.Add(p); //Adicionando o novo produto na lista
            Program.produtos.Sort(); //Ordenando novamente os produtos da lista
        }

        public static void cadastrarPedido()
        {
            //Pedido
            Console.WriteLine("Digite os dados do pedido: ");
            Console.Write("Código: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Més: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            //Instancia do pedido (cadastro dos dados do pedido)
            Pedido pedido = new Pedido(cod, dia, mes, ano);


            //Itens do Pedido
            Console.WriteLine("Quantos itens tem o pedido? ");
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i <=n; i++)
            {
                Console.WriteLine("Digite os dados do "+i+" pedido");
                Console.Write("Produto (código): ");
                int codProduto = int.Parse(Console.ReadLine());

                //Pesquisa na lista de produtos e verifica se o codigo do produto é igual o digitado (Obs: se ele não encontrar o codigo ele retorna -1)
                int pos = Program.produtos.FindIndex(x => x.codigo == codProduto); 
                if (pos == -1)
                {
                    throw new ModelException("Código do produto não encontrado: " + codProduto);
                }

                Console.Write("Quantidade: ");
                int qtd = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de desconto: ");
                double porcDesconto = double.Parse(Console.ReadLine());

                //Instancia dos Itens do Pedido
                ItemPedido itemPedido = new ItemPedido(qtd,porcDesconto,Program.produtos[pos],pedido);

                //Adicionando os "itens do pedido" no "Pedido"
                pedido.itensPedido.Add(itemPedido);
            }

            //Adicionando todos os Pedidos na lista de pedido
            Program.pedido.Add(pedido);


        }

        public static void mostrarPedido()
        {
            Console.Write("Digite o código do pedido: ");
            int codigoPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedido.FindIndex(x => x.cod == codigoPedido); //verificar se codigo existe
            if (pos == -1)
            {
                throw new ModelException("O código do pedido não exite: "+codigoPedido);
            }
            Console.WriteLine(Program.pedido[pos]);
        }

    }
}
