using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Tarefas:Entidades
    {
        /*public string idTarefa;
        public string idMembro;*/
        public string titulo;
        public string dataInicio;
        public string dataFim;
        public string estado;


        public static List<Tarefas> adicionaRegistoTarefa()
        {
            Tarefas tarefa = new Tarefas();

            /*Console.WriteLine("Digite o id da Tarefa"); // to do
            tarefa.idTarefa = Console.ReadLine();

            Console.WriteLine("Digite o id da equipa");// to do
            tarefa.idMembro = Console.ReadLine();*/

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

            Program.listaTarefa.Add(tarefa); //adiciona tudo por ciclo

            foreach (Tarefas t in Program.listaTarefa)
            {
                //Console.WriteLine(t.idMembro);
                //Console.WriteLine(t.idTarefa);
                Console.WriteLine(t.titulo);
                Console.WriteLine(t.dataInicio);
                Console.WriteLine(t.dataFim);
                Console.WriteLine(t.estado);
            }
            
            return Program.listaTarefa;
        }
    }
}
