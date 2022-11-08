using System;
using static Aula7exerc3.Pessoa;

namespace Aula7exerc3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int idade,Genero;
            string codPostal,nome, sobrenome,rua,andar,localidade;

            Pessoa pessoa = new Pessoa();

            idade = pessoa.name.idade = 18;
            codPostal = pessoa.postal.codPostal = 2500+"-"+123;
            nome = pessoa.name.nome = "Ricardo";
            sobrenome = pessoa.name.sobrenme = "Henriques";
            rua = pessoa.postal.rua = "Rua";
            andar = pessoa.postal.andar = 2 + "º";
            localidade = pessoa.postal.localidade = "Caldas";
            
            Console.WriteLine("Sexo: 0-Feminino, 1-Masculino");
            Genero = int.Parse(Console.ReadLine());

            if (Genero == 0)
                Genero = pessoa.genero.Feminino;

            if (Genero == 1)
                Genero = pessoa.genero.Masculino;

            Console.WriteLine("");
        }
    }
}
