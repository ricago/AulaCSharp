using System;

namespace Aula1Exerc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma, xsoma, xn1, xn2, xn3, multsoma, subsoma, modsoma;
            float divsoma;

            //exer 2.1----------------------------------------------
            //  Console.WriteLine("Digite um valor: ");

            // a = Console.ReadLine();

            //  Console.WriteLine("Digite outro valor: ");

            // b = Console.ReadLine();

            // Console.WriteLine("Valores em ordem invertida");

            //  Console.WriteLine(b+" e "+a);
            //exer 2.2 ---------------------------------------------

            //  Console.WriteLine("Digite um valor: ");

            // xn1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite outro valor: ");

            //  xn2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite outro valor: ");

            //  xn3 = int.Parse(Console.ReadLine());

            //  xsoma = xn1 * xn2 * xn3;

            // Console.WriteLine(xn1+"x"+xn2+"x"+xn3+"="+xsoma);
            // Console.WriteLine("{0} x {1} x {2} = {3}", xn1, xn2, xn3, xsoma);

            //exer 2.3-----------------------------------------------------

            Console.WriteLine("Digite um valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("Adição: {0} + {1} = {2}", n1, n2, soma);

            subsoma = n1 - n2;

            Console.WriteLine("Subtração: {0} - {1} = {2}", n1, n2, subsoma);

            divsoma = n1 / n2;

            Console.WriteLine("Divisão: {0} / {1} = {2}", n1, n2, divsoma);

            multsoma = n1 * n2;

            Console.WriteLine("Multiplicação: {0} * {1} = {2}", n1, n2, multsoma);

            modsoma = n1 % n2;

            Console.WriteLine("Modulo: {0} % {1} = {2}", n1, n2, modsoma);

            //exer 2.4-------------------------------------------------------------------------



        }
    }
}