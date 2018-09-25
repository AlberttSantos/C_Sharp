using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pedidos
{
    class Produto : IComparable //"IComparable" serve para fazer comparações dentro de uma lista, ele implementa o metodo "CompareTo"
    {
        public int codigo { get; private set; }
        public string descricao { get; private set; }
        public double preco { get; private set; }

        public Produto(int codigo, string descricao, double preco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public override string ToString()
        {
            return codigo + ", " + descricao + ", " + preco.ToString("F2");
        }

        public int CompareTo(object obj) //Metodo para comparação dos produtos, é preciso para ordenar a lista
        {
            Produto outro;
            outro = (Produto)obj; //Conversao explicita do "obj" para "produto"

            //Compara a descrição do produto que estou atualmente com a descrição do produto que passei no argumento
            //Se os valores comparados forem iguais o "CompareTo" retorna 0, se o primeiro for menor que o segundo ele retorna um valor negativo, se ao contrario retorna um valor positivo
            int resultado = descricao.CompareTo(outro.descricao); 

            if (resultado != 0){ //Se o resultado for igual a 0 (Se as descrições forem iguais ele tem que ordenar pelo preço)
                return resultado;
            }
            else
            {
                return -preco.CompareTo(outro.preco); //Compara o preco do produto com o outro de forma decrescente
            }
            
        }       
    }
}
