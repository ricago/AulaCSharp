using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Tarefas: Membros
    {

        public static Guid idTarefa { get; set; }
        public string titulo;
        public string dataInicio;
        public string dataFim;
        public string estado;

        public Tarefas()
        {
            idTarefa = Guid.NewGuid();
            //string idTarefa = System.Guid.NewGuid().ToString();
        }
        public static List<Tarefas> adicionaRegistoTarefa()
        {
            try {

            Tarefas tarefa = new Tarefas();

            Console.WriteLine("Digite o titulo da tarefa");
            tarefa.titulo = Console.ReadLine();

            Console.WriteLine("Digite a data de inicio da tarefa");

            Console.WriteLine("Digite o ano de inicio");//ano //ate 2022 ou datatime hoje e acima de 1900
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mês de inicio");//mes //ate 12 e acima de 0
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o dia de inicio");//dia //ate 31 e acima de 0
            int dia = int.Parse(Console.ReadLine());

            //adicionar tudo num só
            tarefa.dataInicio = ano + "/" + mes + "/" + dia;

            Console.WriteLine("Digite a data de fim da tarefa");

            Console.WriteLine("Digite o ano de fim");//ano //ate 2022 ou datatime hoje e acima de 1900
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mês de fim");//mes //ate 12 e acima de 0
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o dia de fim");//dia //ate 31 e acima de 0
            dia = int.Parse(Console.ReadLine());

            //adicionar tudo num

            tarefa.dataFim = ano+"/"+mes+"/"+dia;

            Console.WriteLine("Estado do projeto");
            tarefa.estado = Console.ReadLine();

                //Program.listaTarefa.Add(Membros.idMembro); //to do

                Program.listaTarefa.Add(tarefa); //adiciona tudo por ciclo
                
            foreach (Tarefas t in Program.listaTarefa)
            {
                Console.WriteLine("Id do membro: " +Membros.idMembro);
                Console.WriteLine("Id da tarefa: " +Tarefas.idTarefa);
                Console.WriteLine("Titulo da tarefa: "+t.titulo);
                Console.WriteLine("Data de inicio da tarefa: " + t.dataInicio);
                Console.WriteLine("Data de fim da Tarefa: "+t.dataFim);
                Console.WriteLine("Estado da tarefa: "+t.estado);

            }

            }catch(Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
            }
            return Program.listaTarefa;
        }

        public static List<Tarefas> removeregistoTarefa()
        {
            Tarefas tarefa = new Tarefas();

            Program.listaTarefa.Remove(tarefa);

            return Program.listaTarefa;
        }

    }
}
