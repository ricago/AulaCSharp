using System;
using static aula7exerc.Endereco;

namespace aula7exerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codpostal;
            string rua,andar,remete;

            endPostal endereco = new endPostal();
            codpostal = endereco.codPostal = 2500-123;
            andar = endereco.andar = 2+"º";
            remete = endereco.remetende = "Zé";
            rua = endereco.rua = "Rua da esquina";

            Console.WriteLine("Encomenda enviada para: {0}, {1}, andar {2}, enviado por: {3}",rua,codpostal,andar,remete);


        }
    }
}
