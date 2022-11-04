using System;

namespace aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Por valor");
            Console.WriteLine("2 - Por referencia ref");
            Console.WriteLine("3 - Por referencia");
            int op = int.Parse(Console.ReadLine());
            int soma;

            switch (op)
            {
                case 1:
                    Class1.Soma1(soma);
                    break;

                case 2:
                    Class1.Soma2(ref soma);
                    break;

                case 3:
                    Class1.Soma3(soma[0]);
                    break;
            }
        }
    }
}
