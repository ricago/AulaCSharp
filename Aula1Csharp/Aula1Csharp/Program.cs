using System;

namespace Aula1Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //exercicio 1.1 ---------------------------

            Console.WriteLine("Hello");

            //exercicio 1.2 ---------------------------

            int n1, n2, soma, valor;

            n1 = 3;

            n2 = 2;

            soma = n1 + n2;

            Console.WriteLine(n1 + "+" + n2 + "=" + soma);

            //exercicio 1.3 ----------------------------------

            Console.WriteLine("Digite um valor: ");

            valor = int.Parse(Console.ReadLine());
            Console.WriteLine(valor);

        }
    }
}