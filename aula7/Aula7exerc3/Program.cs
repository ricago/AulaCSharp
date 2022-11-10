using System;
using static Aula7exerc3.Pessoa;

namespace Aula7exerc3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int idade,genero;
            string codPostal,nome, sobrenome,rua,andar,localidade;

            Pessoa pessoa = new Pessoa();

            idade = pessoa.name.idade = 18;
            codPostal = pessoa.postal.codPostal = 2500+"-"+123;
            nome = pessoa.name.nome = "Ricardo";
            sobrenome = pessoa.name.sobrenme = "Henriques";
            rua = pessoa.postal.rua = "Rua";
            andar = pessoa.postal.andar = 2 + "º";
            localidade = pessoa.postal.localidade = "Caldas";
            
            Console.WriteLine("Sexo: 0-Feminino, 1-Masculino, 2-Outro");
            genero = int.Parse(Console.ReadLine());

            if (genero == (int)sexo.Feminino)
                

            if (genero == (int)sexo.Masculino)
                

            if (genero == (int)sexo.Outro)
                           

            Console.WriteLine("Nome: {0} {1}, {2} anos, genero: {7}, localidade: {3}, {4} {5}, {6}",nome,sobrenome,idade,localidade,rua,andar,codPostal,genero);
        }
    }
}