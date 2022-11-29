using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Tarefas : Membros
    {
        //variaveis
        public static Guid idTarefa { get; set; }
        public string titulo;
        public string dataInicio;
        public string dataFim;
        public string estado;
        public string IdTarefa;

        //construtor guid
        public Tarefas()
        {
            idTarefa = Guid.NewGuid();

        }

        //enum do estado da tarefa
        enum estadoTarefa
        {
            Concluido = 1, Inconcluido = 0
        }

        //adiciona tarefa
        public static List<Tarefas> adicionaRegistoTarefa()
        {
            try
            {
                //variaveis para juntar
                int ano, mes, dia;

                //poo
                Tarefas tarefa = new Tarefas();

                //converte para string
                tarefa.IdTarefa = idTarefa.ToString();

                //inserir dados
                Console.WriteLine("Digite o titulo da tarefa");
                tarefa.titulo = Console.ReadLine();

                Console.WriteLine("Digite a data de inicio da tarefa");
                do //ano //ate 2022 ou datatime hoje e acima de 1900
                {
                    Console.WriteLine("Digite o ano de inicio");
                    ano = int.Parse(Console.ReadLine());
                } while (ano < 1970 || ano > 2022);

                do //mes //ate 12 e acima de 0
                {
                    Console.WriteLine("Digite o mês de inicio");
                    mes = int.Parse(Console.ReadLine());
                } while (mes < 1 || mes > 12);

                do //dia //ate 31 e acima de 0
                {
                    Console.WriteLine("Digite o dia de inicio");
                    dia = int.Parse(Console.ReadLine());
                } while (dia < 1 || dia > 31);

                //adicionar tudo num só
                tarefa.dataInicio = ano + "/" + mes + "/" + dia;


                Console.WriteLine("Digite a data de fim da tarefa");
                do //ano //ate 2022 ou datatime hoje e acima de 1900
                {
                    Console.WriteLine("Digite o ano de  da tarefa");
                    ano = int.Parse(Console.ReadLine());
                } while (ano < 1970 || ano > 2022);

                do //mes //ate 12 e acima de 0
                {
                    Console.WriteLine("Digite o mês de  da tarefa");
                    mes = int.Parse(Console.ReadLine());
                } while (mes < 1 || mes > 12);

                do //dia //ate 31 e acima de 0
                {
                    Console.WriteLine("Digite o dia de fim da tarefa");
                    dia = int.Parse(Console.ReadLine());
                } while (dia < 1 || dia > 31);

                //adicionar tudo num só

                tarefa.dataFim = ano + "/" + mes + "/" + dia;

                // do {
                Console.WriteLine("Estado do projeto  1 - Concluido  0 - Inconcluido");
                tarefa.estado = Console.ReadLine();
                // } while (tarefa.estado != "1" || tarefa.estado != "0");

                //adicionar guid de fora
                tarefa.IdMembro = Membros.idMembro.ToString();

                Program.listaTarefa.Add(tarefa); //adiciona tudo por ciclo



            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
            }
            return Program.listaTarefa;
        }

        //metodo remove
        public static void removeregistoTarefa()
        {
            //inserir id
            Console.WriteLine("Digite o ID que deseja eliminar: ");
            string procuraId = Console.ReadLine();

            //percorrer lista
            for (int i = 0; i < Program.listaProjeto.Count; i++)
            {
                //verifica se é igual
                if (Program.listaProjeto[i].IdProjeto == procuraId)
                {
                    //elimina
                    Program.listaProjeto.Remove(Program.listaProjeto[i]);
                }
            }
        }

        public static void imprimirRelatorioTar()
        {

            //imprimir
            foreach (Tarefas t in Program.listaTarefa)
            {
                Console.WriteLine("Id do membro: " + t.IdMembro);
                Console.WriteLine("Id da tarefa: " + t.IdTarefa);
                Console.WriteLine("Titulo da tarefa: " + t.titulo);
                Console.WriteLine("Data de inicio da tarefa: " + t.dataInicio);
                Console.WriteLine("Data de fim da Tarefa: " + t.dataFim);
                Console.WriteLine("Estado da tarefa: " + t.estado);

            }
        }
    }
}
