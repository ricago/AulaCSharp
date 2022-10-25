using System;

namespace aula4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.NumeroFiscal = "123456789";
            pessoa1.nomePessoa = "aaaaa";
            Console.WriteLine("Numero fiscal: {0}",pessoa1.NumeroFiscal);
            Console.WriteLine("Nome: {0}", pessoa1.nomePessoa);
        }
    }
}
