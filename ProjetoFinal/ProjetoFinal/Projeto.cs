using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Projeto:Entidades
    {
        public string idProjeto;
        public string idEquipa;
        public string nome;
        public string listaTarefas;

        public static List<Projeto> adicionaRegistoProjeto()
        {

            Projeto projeto = new Projeto();

            Console.WriteLine("Digite o id do projeto");
            projeto.idProjeto = Console.ReadLine();

            Console.WriteLine("Digite o id da equipa"); // to do
            projeto.idEquipa = Console.ReadLine();

            Console.WriteLine("Digite o nome do projeto");
            projeto.nome = Console.ReadLine();

            Console.WriteLine("Digite a lista de tarefas");
            //Program.listaProjeto.AddRange(Program.listaTarefa); //to do
            //projeto.listaTarefas = Console.ReadLine();

            return Program.listaProjeto;
        }
    }
}
