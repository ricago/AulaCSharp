using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Projeto : Membros
    {
        //variaveis
        public static Guid idProjeto { get; set; }
        public string IdEquipa;
        public string nome;
        public string IdProjeto;
        public List<Tarefas> ListaT = new List<Tarefas> { };

        //construtor guid
        public Projeto()
        {
            idProjeto = Guid.NewGuid();
        }

        //função add
        public static List<Projeto> adicionaRegistoProjeto()
        {
            try
            {
                //poo
                Projeto projeto = new Projeto();

                // Conversão de Guid para string
                projeto.IdProjeto = idProjeto.ToString();

                //adicionar guid de fora
                projeto.IdEquipa = Equipa.idEquipa.ToString();

                //Nome do Projeto
                Console.WriteLine("Digite o nome do projeto");
                projeto.nome = Console.ReadLine();

                //adicionar a lista de tarefas a lista de projeto
                Console.WriteLine("Adicionando a lista de tarefas");

                //"clonar" a lista
                projeto.ListaT = Program.listaTarefa;

            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
            }
            return Program.listaProjeto;
        }


        //função remove
        public static void removeregistoProjeto()
        {
            Console.WriteLine("Digite o ID que deseja eliminar: ");
            string procuraId = Console.ReadLine();

            //percorre a lista
            for (int i = 0; i < Program.listaProjeto.Count; i++)
            {
                //verifica se o id é igual ao inserido
                if (Program.listaProjeto[i].IdProjeto == procuraId)
                {
                    //elimina
                    Program.listaProjeto.Remove(Program.listaProjeto[i]);
                }
            }
        }

        public static void imprimirRelatorioProj()
        {
            //poo
            Projeto projeto = new Projeto();

            //imprimir
            foreach (Projeto p in Program.listaProjeto)
            {
                Console.WriteLine("Id do projeto: " + p.IdProjeto);
                Console.WriteLine("Id da equipa: " + p.IdEquipa);
                Console.WriteLine("Nome do projeto: " + p.nome);
                Console.WriteLine("Lista de Tarefas");

                foreach (Tarefas tarefa in projeto.ListaT)
                {
                    Console.WriteLine("Id da tarefa: " + tarefa.IdTarefa);
                    Console.WriteLine("Estado da tarefa: " + tarefa.estado);
                }
            }
        }
    }
}
