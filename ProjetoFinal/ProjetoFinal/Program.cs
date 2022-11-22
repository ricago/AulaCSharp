using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ProjetoFinal
{
    internal class Program
    {
        public static List<string> listaEquipa = new List<string> { };
        public static List<string> listaMembros = new List<string> { };

        static void Main(string[] args)
        {
            //variaveis
            int op, op2, op3;
            string lixo;

            Entidades reg = new Entidades();
            Equipa equipa = new Equipa();
            

            string equipaId = equipa.idEquipa;
            //fim variaveis
            try
            {
                do
                {
                    Console.WriteLine("Selecione a opção desejada");

                    reg.Menu1();
                
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {

                        case 1: // Adicionar ou Remover registos
                            Console.Clear();
                            Console.WriteLine("Selecione a opção desejada");

                            Console.WriteLine("1 - Adicionar registos");
                            Console.WriteLine("2 - Remover registos");

                            op2 = int.Parse(Console.ReadLine());

                            if (op2 == 1) //adicionar registos
                            {
                                Console.Clear();
                                Console.WriteLine("Adicionar Registos");
                                
                                int opCase1;

                                Console.WriteLine("Selecione onde quer adicionar registos");

                                Console.WriteLine("1 - Equipa");
                                Console.WriteLine("2 - Membro");
                                Console.WriteLine("3 - Projeto");
                                Console.WriteLine("4 - Tarefa");

                                opCase1 = int.Parse(Console.ReadLine());

                                switch (opCase1)
                                {
                                    case 1:

                                        Console.Clear();
                                        Equipa.adicionaregistoEquipa();

                                        break;

                                    case 2:

                                        break;

                                }

                                Console.WriteLine("Pressione Enter para continuar...");
                                lixo = Console.ReadLine(); ;

                            }

                            if (op2 == 2) //remover registos
                            {
                                Console.Clear();
                                Console.WriteLine("Remover Registos");
                                Console.WriteLine("Pressione Enter para continuar...");
                                lixo = Console.ReadLine();
                            }

                            break;

                        case 2: //Editar projetos, equipas, tarefas
                            Console.Clear();
                            Console.WriteLine("Selecione a opção desejada");

                            Console.WriteLine("1 - Editar projetos");
                            Console.WriteLine("2 - Editar equipas");
                            Console.WriteLine("3 - Editar tarefas");

                            op3 = int.Parse(Console.ReadLine());

                            switch (op3)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Editar projetos");
                                    Console.WriteLine("Pressione Enter para continuar...");
                                    lixo = Console.ReadLine();
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Editar equipas");
                                    Console.WriteLine("Pressione Enter para continuar...");
                                    lixo = Console.ReadLine();
                                    break;


                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Editar tarefas");
                                    Console.WriteLine("Pressione Enter para continuar...");
                                    lixo = Console.ReadLine();
                                    break;
                            }
                            break;

                        case 3: //imprima um relatório das Tarefas que não estão concluídas e que a data de fim já terminou
                            Console.Clear();
                            Console.WriteLine("Relatorios não concluidos");
                            Console.WriteLine("Pressione Enter para continuar...");
                            lixo = Console.ReadLine();
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("Relatorios geral por entidade");
                            Console.WriteLine("Pressione Enter para continuar...");
                            lixo = Console.ReadLine();
                            break;
                    }

                }while (op >= 1 && op < 5);
                

            }catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro tenta novamente");
                }
        }
    }
}
