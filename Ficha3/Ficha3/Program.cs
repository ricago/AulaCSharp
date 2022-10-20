using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Ficha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exerc. 4.1-------------------------------------------------------------------------

            //float result;

            //try
            //{
            //    Console.WriteLine("Digite um valor: ");
            //    float n1 = float.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite o operador que deseja utilizar: ");
            //    Console.WriteLine("+ - Adição");
            //    Console.WriteLine("- - Adição");
            //    Console.WriteLine("* - Adição");
            //    Console.WriteLine("/ - Adição");

            //    string op = Console.ReadLine();

            //    Console.WriteLine("Digite outro valor: ");
            //    float n2 = float.Parse(Console.ReadLine());

            //    switch (op)
            //    {
            //        case "+":
            //            result = n1 + n2;
            //            Console.WriteLine(n2 + "+" + n1 + "=" + result);
            //            break;

            //        case "-":
            //            result = n1 - n2;
            //            Console.WriteLine(n2 + "-" + n1 + "=" + result);
            //            break;

            //        case "*":
            //            result = n1 * n2;
            //            Console.WriteLine(n2 + "*" + n1 + "=" + result);
            //            break;

            //        case "/":
            //            result = n1 / n2;
            //            Console.WriteLine( n2 + "/" + n1 + "=" + result);
            //            break;
            //        default:
            //            Console.WriteLine("Opção invalida");
            //            break;
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Digite apenas digitos ou operadores validos");
            //}

            //exerc. 4.2----------------------------------------------------------------------------------

            //int soma = 0;
            //Console.WriteLine("Digite o numero de alunos da turma: ");

            //int turma = int.Parse(Console.ReadLine());

            //for (int i = 0; i < turma;)
            //{
            //    try
            //    {
            //        Console.WriteLine("Digite a nota do aluno: \n");
            //        int nota = int.Parse(Console.ReadLine());
            //        soma = soma + nota;

            //        if (nota >= 0 && nota <= 45)
            //        {
            //            Console.WriteLine("Não atingiu");
            //            i++;
            //        }

            //        else if (nota >= 46 && nota <= 65)
            //        {
            //            Console.WriteLine("Atingiu com alguma dificuldade");
            //            i++;
            //        }

            //        else if (nota >= 66 && nota <= 87)
            //        {
            //            Console.WriteLine("Atingiu com  facilidade");
            //            i++;
            //        }

            //        else if (nota >= 88 && nota <= 100)
            //        {
            //            Console.WriteLine("Atingiu com muita facilidade");
            //            i++;
            //        }

            //        else
            //        {
            //            Console.WriteLine("Digite apenas numeros positivos entre 0 e 100, inclusive.");
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Digite apenas digitos.");
            //    }
            //}

            //Console.WriteLine("\nMedia da turma: ");
            //float media = soma / turma;

            //if (media >= 0 && media <= 45)
            //{
            //    Console.WriteLine("\nA turma não atingiu");
            //}

            //else if (media >= 46 && media <= 65)
            //{
            //    Console.WriteLine("\nA turma atingiu com alguma dificuldade");
            //}

            //else if (media >= 66 && media <= 87)
            //{
            //    Console.WriteLine("\nA turma atingiu com  facilidade");
            //}

            //else if (media >= 88 && media <= 100)
            //{
            //    Console.WriteLine("\nA turma atingiu com muita facilidade");
            //}

            //Console.WriteLine("A média da turma é " + media);

            //exerc. 5 ---------------------------------------------------------------------
            try
            {

                Console.WriteLine("Digite o dia de aniversário: ");
                int dia = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o mês de aniversário: ");
                int mes = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o ano de aniversário: ");
                int ano = int.Parse(Console.ReadLine());

                DateTime DataNascimento = new DateTime(ano, mes, dia);

                var today = DateTime.Today;

                var idade = today.Year - DataNascimento.Year;

                var month = today.Month - DataNascimento.Month;

                var day = today.Day - DataNascimento.Day;

                if (idade == today.Year)
                {

                    if (month < DataNascimento.Month)
                    {
                        idade = idade - 1;
                    }

                    else if (day < DataNascimento.Day)
                    {
                        idade = idade - 1;
                    }

                }
                Console.WriteLine("Idade: " + idade);

                if (idade > 15)
                {
                    Console.WriteLine("O utilizador com a data de nascimento " + DataNascimento + ", pertence ao grupo etário jovem");
                }

                else if (idade <= 15 && idade >= 64)
                {
                    Console.WriteLine("O utilizador com a data de nascimento " + DataNascimento + ", pertence ao grupo etário adulto");
                }

                else if (idade >= 65 && idade < 105)
                {
                    Console.WriteLine("O utilizador com a data de nascimento " + DataNascimento + ", pertence ao grupo etário idoso");
                }

                else
                {
                    Console.WriteLine("Digite uma idade valida");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
            }
        }
    }
}
