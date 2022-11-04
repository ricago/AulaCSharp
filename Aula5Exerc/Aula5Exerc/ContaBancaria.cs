using System;

namespace Aula5Exerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;

            Conta conta = new Conta();

            float saldo = conta.saldo;

            Console.WriteLine("1 - Ver saldo");
            Console.WriteLine("2 - Fazer Debito");
            Console.WriteLine("3 - Fazer Credito");
            Console.WriteLine("0 - Sair\n");

            try { 
            do {

                Console.WriteLine("Digite uma operação");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        conta.VerSaldo(saldo);
                        break;

                    case 2:

                        conta.DebitaSaldo(saldo);
                        break;

                    case 3:

                        conta.CreditoSaldo(saldo);
                        break;

                    case 0:

                        Console.WriteLine("Até á proxima.");
                        break;
                }
                
            } while (op > 0 || op < 4);

            }catch(Exception e)
            {
                Console.WriteLine("Digite valores validos");
            }

        }   
    }

}
    
