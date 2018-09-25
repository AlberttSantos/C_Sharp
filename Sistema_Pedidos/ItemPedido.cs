using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pedidos
{
    class ItemPedido
    {
        public int quantidade { get; set; }
        public double porcDesconto { get; set; }
        public Produto produto { get; set; } //Associando a classe "ItemPedido" a classe "Produto"
        public Pedido pedido { get; set; } //Associando a classe "ItemPedido" a classe "Pedido"

        public ItemPedido(int quantidade, double porcDesconto, Produto produto, Pedido pedido)
        {
            this.quantidade = quantidade;
            this.porcDesconto = porcDesconto;
            this.produto = produto;
            this.pedido = pedido;
        }
        public double subTotal()
        {
            double desconto = produto.preco * porcDesconto / 100.00; //Calculo da do desconto
            return (produto.preco - desconto) * quantidade;
        }

        public override string ToString()
        {
            return produto.descricao + ", Preço: " + produto.preco + ", Quantidade: " + this.quantidade + ", Desconto: " + this.porcDesconto + "%, SubTotal: " + subTotal(); ;
        }
    }
}
