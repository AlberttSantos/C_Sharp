using System;
using System.IO; //Necessário para trabalhar com arquivos

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt"; //Caminho onde esta o arquivo
            string targetPath = @"c:\temp\file2.txt";
            string path = @"c:\temp";
            string path2 = @"c:\temp\teste.txt";

            FileStream fs = null;
            StreamReader sr = null;            

            try
            {
                //************** Cópia e leirura dos arquivos ****************
                //FileInfo fileinfo = new FileInfo(sourcePath); //Instanciando a classe "FileInfo" passando o arquivo "sourcPath" como parametro
                //fileinfo.CopyTo(targetPath); //Realiza uma copia do arquivo para algum diretorio definido
                //string[] lines = File.ReadAllLines(sourcePath); //Ler todas as linas utilizando a classe "file" e salva em um vetor de string
                //foreach (string linhas in lines) //A string "linhas" recebe os dados contidos no vetor "lines" a cada iteração (Executa o "console.write" para cada posição do vetor "lines")
                //{
                //    Console.Write(linhas);
                //}

                //************** FileStream and StreamReader ****************
                //fs = new FileStream(sourcePath, FileMode.Open); //Instancia do "FileStream" associando um arquivo com a finalidade de abrir o mesmo
                //sr = new StreamReader(fs); //Instancia o StreamReader()
                //while (!sr.EndOfStream)
                //{
                //    string linha = sr.ReadLine(); //StreamReader consegue fazer diversas operações
                //    Console.WriteLine(linha);
                //}

                //Console.ReadLine();
                //************** StreamWriter ****************
                //string[] lines = File.ReadAllLines(sourcePath);

                ////Instanciando o "StreamWrite" utilizando o "File"
                //using (StreamWriter sw = File.AppendText(targetPath))//"using" serve para abrir e fechar a conexão automaticamente (OBS: "AppendText" serve para adicionar ao final do arquivo)
                //{
                //    foreach(string line in lines)
                //    {
                //        sw.WriteLine(line.ToUpper()); //Escreve no arquivo com letra maiuscua
                //    }                    
                //}

                //************** Directory and DirectoryInfo ****************
                ////Lista folders
                //var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //Lista todas as subpastas da pasta raiz
                //Console.WriteLine("Folders: ");
                //foreach(string s in folders)
                //{
                //    Console.WriteLine(s);
                //}

                ////Lista files 
                //var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //Lista todas as subpastas da pasta raiz
                //Console.WriteLine("Files: ");
                //foreach (string s in files)
                //{
                //    Console.WriteLine(s);
                //}

                ////Criar folder
                //Directory.CreateDirectory(path + "\\Teste\\teste2");

                //************** Path ****************
                Console.WriteLine("DirectorySeparetorChar: " + Path.DirectorySeparatorChar); //Mostra o caracter de sepração
                Console.WriteLine("GetDirectoryName: " +Path.GetDirectoryName(path2)); //Mostra o caminho dos diretorios
                Console.WriteLine("GetFileName: "+Path.GetFileName(path2));
                Console.WriteLine("GetExtension: " + Path.GetExtension(path2));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path2));

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ocorrido");
                Console.WriteLine(e.Message);
                Console.ReadLine();                
            }
            finally
            {
                //if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}
