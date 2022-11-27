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
        Equipa idEquipa;
        public string nome;
        public string listaTarefas;

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
                Projeto projeto = new Projeto();

                Console.WriteLine("Digite o nome do projeto");
                projeto.nome = Console.ReadLine();

                Console.WriteLine("Digite a lista de tarefas");
                //Program.listaProjeto.AddRange(Program.listaTarefa); //to do
                //projeto.listaTarefas = Console.ReadLine();

                foreach (Projeto p in Program.listaProjeto)
                {
                    Console.WriteLine("Id do projeto: "+Projeto.idProjeto);
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


        //função remove
        public static List<Projeto> removeregistoProjeto()
        {
            Projeto projeto = new Projeto();

            /* Console.WriteLine("Digite o ID que deseja eliminar: ");
            Guid procuraId = Guid.Parse(Console.ReadLine());

           for(int i =0; i < Program.listaProjeto.Count; i++) // to do
            {
                if (Program.listaProjeto[i].)
                {

                }
            }*/
           

            Program.listaProjeto.Remove(projeto);

            return Program.listaProjeto;
        }
    }
}
