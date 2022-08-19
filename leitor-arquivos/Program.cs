using System;
using System.IO;

namespace leitor_arquivos
{
    class Program
    {
        public static void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = $@"C:\Estudos\Funcoes-Recursivas\arquivos\arq{numeroArquivo}.txt";
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            
            var arquivoComCaminho2 = $@"C:\Estudos\Funcoes-Recursivas\arquivos\arq{numeroArquivo + 1}.txt";
            
            if (File.Exists(arquivoComCaminho2))
                LerArquivo(numeroArquivo +1);
        }
        
        static void Main(string[] args)
        {
            LerArquivo(1);
        }
    }
}