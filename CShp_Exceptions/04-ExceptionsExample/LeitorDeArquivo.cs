using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _04_ExceptionsExample
{
    class LeitorDeArquivo
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            //simulando arquivo não encontrado

            throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

            throw new IOException();

            return "Linha do arquivo";          
        }
        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
