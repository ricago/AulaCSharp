using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ProjetoFinal
{
    internal class Program
    {
        //listas globais
        public static List<Equipa> listaEquipa = new List<Equipa> { };
        public static List<Membros> listaMembros = new List<Membros> { };
        public static List<Projeto> listaProjeto = new List<Projeto> { };
        public static List<Tarefas> listaTarefa = new List<Tarefas> { };

        static void Main(string[] args)
        {
            //variaveis
            int op, op2, op3,op4;
            string lixo;

            //poo
            Entidades reg = new Entidades();

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
                            Console.WriteLine("0 - Voltar ao menu");

                            //selecionar opção
                            op2 = int.Parse(Console.ReadLine());

                            if (op2 == 1) //adicionar registos
                            {
                                Console.Clear();
                                Console.WriteLine("Adicionar Registos");

                                int opCase1;

                                Console.WriteLine("Selecione onde quer adicionar registos");

                                Console.WriteLine("1 - Membro");
                                Console.WriteLine("2 - Equipa");
                                Console.WriteLine("3 - Projeto");
                                Console.WriteLine("4 - Tarefa");
                                Console.WriteLine("0 - Voltar ao menu");

                                opCase1 = int.Parse(Console.ReadLine());

                                switch (opCase1)
                                {
                                    case 1:

                                        Console.Clear();
                                        Membros.adicionaregistoMembros();
                                        break;

                                    case 2:
                                        Console.Clear();
                                        Equipa.adicionaregistoEquipa();
                                        break;

                                    case 3:

                                        Console.Clear();
                                        Projeto.adicionaRegistoProjeto();
                                        break;

                                    case 4:
                                        Console.Clear();
                                        Tarefas.adicionaRegistoTarefa();
                                        break;

                                }

                                Console.WriteLine("Pressione Enter para continuar...");
                                lixo = Console.ReadLine(); ;

                            }

                            if (op2 == 2) //remover registos
                            {
                                Console.Clear();
                                Console.WriteLine("Remover Registos");
                                int opRemove;

                                Console.WriteLine("Selecione onde quer remover registos");

                                Console.WriteLine("1 - Equipa");
                                Console.WriteLine("2 - Membro");
                                Console.WriteLine("3 - Projeto");
                                Console.WriteLine("4 - Tarefa");
                                Console.WriteLine("0 - Voltar ao menu");

                                opRemove = int.Parse(Console.ReadLine());

                                switch (opRemove)
                                {
                                    case 1:

                                        Console.Clear();
                                        Equipa.removeregistoEquipa();
                                        Console.WriteLine("Pressione Enter para continuar...");
                                        lixo = Console.ReadLine();
                                        break;

                                    case 2:

                                        Console.Clear();
                                        Membros.removeregistoMembro();
                                        Console.WriteLine("Pressione Enter para continuar...");
                                        lixo = Console.ReadLine();
                                        break;


                                    case 3:

                                        Console.Clear();
                                        Projeto.removeregistoProjeto();
                                        Console.WriteLine("Pressione Enter para continuar...");
                                        lixo = Console.ReadLine();
                                        break;

                                    case 4:

                                        Console.Clear();
                                        Tarefas.removeregistoTarefa();
                                        Console.WriteLine("Pressione Enter para continuar...");
                                        lixo = Console.ReadLine();
                                        break;
                                }
                                break;
                            }
                            break;

                        case 2: //Editar projetos, equipas, tarefas
                            Console.Clear();
                            Console.WriteLine("Selecione a opção desejada");

                            Console.WriteLine("1 - Editar projetos");
                            Console.WriteLine("2 - Editar equipas");
                            Console.WriteLine("3 - Editar tarefas");
                            Console.WriteLine("0 - Voltar ao menu");

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

                        case 4: // Relatorio Geral
                            Console.Clear();
                            Console.WriteLine("Relatorios geral por entidade");

                            Console.WriteLine("1 - Imprimir membros");
                            Console.WriteLine("2 - Imprimir equipas");
                            Console.WriteLine("3 - Imprimir tarefas");
                            Console.WriteLine("4 - Imprimir projetos");
                            Console.WriteLine("0 - Voltar ao menu");

                            op4 = int.Parse(Console.ReadLine());

                            switch (op4)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Imprimir Membros");
                                    Membros.imprimirRelatorioMem();
                                    Console.WriteLine("Pressione Enter para continuar...");
                                    lixo = Console.ReadLine();
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Imprimir Equipa");
                                    Equipa.imprimirRelatorioEqui();
                                    Console.WriteLine("Pressione Enter para continuar...");
                                    lixo = Console.ReadLine();
                                    break;


                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Imprimir Tarefas");
                                    Tarefas.imprimirRelatorioTar();
                                    Console.WriteLine("Pressione Enter para continuar...");
                                    lixo = Console.ReadLine();
                                    break;

                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("Imprimir Projetos");
                                    Projeto.imprimirRelatorioProj();
                                    Console.WriteLine("Pressione Enter para continuar...");
                                    lixo = Console.ReadLine();
                                    break;
                            }
                            break;

                            Console.WriteLine("Pressione Enter para continuar...");
                            lixo = Console.ReadLine();
                            break;
                    }
                } while (op >= 1 && op < 5);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro tenta novamente");
            }
        }
    }
}
