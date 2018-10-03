using System;
using System.IO;
using System.Collections.Generic;
using Interface_IComparable.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path)) //Abre o arquivo no caminho especificado
                {
                    List<Funcionario> list = new List<Funcionario>(); //Declara e instancia um lista
                    while (!sr.EndOfStream) //Enquando não chegar no final do arquivo
                    {
                        list.Add(new Funcionario(sr.ReadLine())); //Lê a linha do arquivo e instancia a lista de funcionario
                    }
                    list.Sort(); //Metodo para ordenar lista

                    foreach (Funcionario s in list)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
