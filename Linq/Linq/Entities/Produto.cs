using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Entities
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Preco.ToString("F2") + ", " + Categoria.Nome + ", " + Categoria.Tier;
        }
    }
}
