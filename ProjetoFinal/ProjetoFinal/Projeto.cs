using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Projeto: Membros
    {

        Guid idProjeto = Guid.NewGuid();
        Guid idEquipa = Guid.NewGuid();
        public string nome;
        public string listaTarefas;

        

        public static List<Projeto> adicionaRegistoProjeto()
        {
            try
            {
                Projeto projeto = new Projeto();

                Console.WriteLine("Digite o nome do projeto");
                projeto.nome = Console.ReadLine();

                Console.WriteLine("Digite a lista de tarefas");
                //Program.listaProjeto.AddRange(Program.listaTarefa); //to do
                //projeto.listaTarefas = Console.ReadLine();

                foreach (Projeto p in Program.listaProjeto)
                {
                    Console.WriteLine("Id do projeto: "+p.idProjeto);
                    Console.WriteLine("Id da equipa: "+p.idEquipa);
                    Console.WriteLine("Nome do projeto: "+p.nome);
                    Console.WriteLine("Lista de Tarefas"+p.listaTarefas);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
            }
            return Program.listaProjeto;
        }
    }
}
