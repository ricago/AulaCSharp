using System;

namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo-----------------------------------------------------------------------

            //string nome = "João";
            //string tempoAtual = "Chuva";
            //string temperaturaAtual = "18º";

            //Console.WriteLine("Ola {0}. Hoje o dia está de {1}. Estão {2}", "João", "Chuva", "18º");
            //Console.WriteLine("Ola {0}. Hoje o dia está de {1}. Estão {2}",nome,tempoAtual,temperaturaAtual);

            //Console.WriteLine($"Ola {nome}. Hoje o dia está de {tempoAtual}. Estão {temperaturaAtual}");
            //---------------------------------------------------------------------------------------------------------
            //Console.WriteLine("Indique o numero para calcular o cubo");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //double resultado = CalculaCubo(numero);
            //Console.WriteLine(resultado);

            //static double CalculaCubo(int numeroCalcular)
            //{
            //    return Math.Pow(numeroCalcular, 3);

            //}

            //----------------------------------------------------------------------------------------------

            //            if(args.Length > 1)
            //{
            //                throw new ArgumentException("Tem um argumento a mais");
            //}
            //----------------------------------------------------------------------------------------------------

            try
            {
                if (args.Length > 1)
                {
                    throw new ArgumentException("Tem um argumento a mais"); ;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine(Inner);
            }
            finally
            {
                ;
            }


        }
    }
}
