using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IComparable.Entities
{
    class Funcionario : IComparable //Interface para comparar objetos
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(string csvFuncionario)
        {
            string[] vet = csvFuncionario.Split(',');
            Name = vet[0];
            Salary = double.Parse(vet[1]);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2");
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario)) //Se o parametro for diferente de funcionario
            {
                throw new ArgumentException("Erro de comparação, objeto não é do tipo funcionario");
            }
            Funcionario outro = obj as Funcionario;
            //return -Salary.CompareTo(outro.Salary); //Ordem decrescente
            return Salary.CompareTo(outro.Salary); //Ordem crescente
        }
    }
}
