using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pedidos
{
    class Pedido
    {
        public int cod { get; private set; }
        public DateTime data { get; set; }
        public List<ItemPedido> itensPedido { get; set; } //Associação com Items pedido, declaração da classe Itens Pedido como lista

        public Pedido(int cod, int dia, int mes, int ano)
        {
            this.cod = cod;
            data = new DateTime(ano, mes, dia);
            itensPedido = new List<ItemPedido>();
        }

        public double valorTotal()
        {
            double soma = 0;
            for(int i=0; i<itensPedido.Count; i++)
            {
                soma = soma + itensPedido[i].subTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            string s = "Pedido: " + cod + ", data: " + data.Day + "/" + data.Month + "/" + data.Year + "\n"
                + "Itens:\n";

            for (int i=0; i< itensPedido.Count; i++)
            {
                s = s + itensPedido[i] +"\n" ;
            }
            s = s + "Total do pedido: " + valorTotal();
            return s;
        }
    }
}
