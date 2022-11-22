using System;
using System.Reflection.Metadata.Ecma335;

namespace ProjetoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            string lixo;

            Entidades reg = new Entidades();
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
                            int op2;

                            Console.WriteLine("1 - Adicionar registos");
                            Console.WriteLine("2 - Remover registos");

                            op2 = int.Parse(Console.ReadLine());

                            if (op2 == 1) //adicionar registos
                            {
                                Console.Clear();
                                Console.WriteLine("Adicionar Registos");
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
                            int op3;
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
