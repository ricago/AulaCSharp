using System;

namespace Exercicios_aula_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite dois valor:");
            //try
            //{
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());

            //    if (n1 == n2)
            //    {
            //        Console.WriteLine("Os dois valores são iguais.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Os dois valor são diferentes");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Digite apenas numeros.");

            //}
            //finally
            //{
            //Console.WriteLine();
            //Console.WriteLine("O Programa correu até ao fim");
            //}
            //outro exercicio-------------------------------------------------------------------

            //Console.WriteLine("Digite a sua idade:");
            //try
            //{
            //    int idade = int.Parse(Console.ReadLine());

            //    if (idade >= 18)
            //    {
            //        Console.WriteLine("Pode votar.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Não pode votar.");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Digite apenas a sua idade.");

            //}
            //finally
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("O Programa correu até ao fim");
            //}

            //outro exerc.-------------------------------------------------------------------------------

            Console.WriteLine("Digite o numero correspodente ao dia da semana.");
            Console.WriteLine("1 - Segunda");
            Console.WriteLine("2 - Terça");
            Console.WriteLine("3 - Quarta");
            Console.WriteLine("4 - Quinta");
            Console.WriteLine("5 - Sexta");
            Console.WriteLine("6 - Sábado");
            Console.WriteLine("7 - Domingo");
            try { 
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1: 
                    Console.WriteLine("Segundo-feira :(");
                    break;
                case 2:
                    Console.WriteLine("Terça-feira :(");
                    break;
                case 3:
                    Console.WriteLine("Quarta-feira :|");
                    break;
                case 4:
                    Console.WriteLine("Quinta-feira :)");
                    break;
                case 5:
                    Console.WriteLine("Sexta-feira :D");
                    break;
                case 6:
                    Console.WriteLine("Sabado :D");
                    break;
                case 7:
                    Console.WriteLine("Domingo :(");
                    break;

                default:

                    Console.WriteLine("Existem apenas 7 dias da semana");
                    break;
            }
            }
            catch (Exception e)
            {
                Console.WriteLine("Digite apenas numeros de 1 a 7");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("O programa correu até ao fim");
            }
        }    
    }
}