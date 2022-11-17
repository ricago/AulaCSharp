using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace aula9
{
    internal class Dicionario
    {
        static void Main(string[] args)
        {
            int op, num;
            string nome;

            try
            {
                Dictionary<string, int> ListaAlunos = new Dictionary<string, int>();
                do
                {

                    Console.WriteLine("1 - Adicionar aluno");
                    Console.WriteLine("2 - Remover aluno");
                    Console.WriteLine("0 - Sair");

                    Console.WriteLine("Selecione a sua operação");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.Clear();

                            Console.WriteLine("Digite o numero de alunos que deseja adicionar: ");
                            int nAlunos = int.Parse(Console.ReadLine());

                            for(int i = 0; i < nAlunos; i++) { 
                            Console.WriteLine("Digite o nome do aluno");
                            nome = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Digite o numero do aluno");
                                num = int.Parse(Console.ReadLine());
                            } while (num < 0);
                            ListaAlunos.Add(nome, num);
                            Console.WriteLine("O aluno {0} foi adicionado com o numero {1}.", nome,num);
                            }
                            Console.WriteLine("Pressione Enter para continuar");
                            string lixo = Console.ReadLine();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Digite o aluno que deseja remover: ");
                            string remover = Console.ReadLine();

                            if (ListaAlunos.ContainsKey(remover))
                            {
                                ListaAlunos.Remove(remover);
                                Console.WriteLine("O aluno {0} foi removido.", remover);
                            }
                            else
                            {
                                Console.WriteLine("O aluno {0} não existe.", remover);
                            }
                            break;
                    }
                } while (op != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
            }
        }
    }
}
