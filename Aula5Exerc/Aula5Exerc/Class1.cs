using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5Exerc
{
    internal class Class1
    {
        public float saldo;
        public Class1()
        {
            Random random = new Random();

            saldo = random.Next();
            Console.WriteLine($"Saldo da conta = {saldo}");
        }
        
        public float VerSaldo(float saldo)
        {  
            
            Console.WriteLine("O seu saldo é {0} euros\n",saldo);
            
            return saldo;
        }

        public float DebitaSaldo(float saldo)
        {
            int retiraSaldo;
            Console.WriteLine("Digite quanto quer levantar: \n");
            retiraSaldo = int.Parse(Console.ReadLine());
            saldo = saldo - retiraSaldo;
            
            Console.WriteLine("O seu saldo é {0}\n",saldo);
            
            return saldo;
        }

        public float CreditoSaldo(float saldo)
        {
            int poeSaldo;

            Console.WriteLine("Digite quanto quer depositar: \n");
            poeSaldo = int.Parse(Console.ReadLine());
            saldo = saldo + poeSaldo;

            Console.WriteLine("O seu saldo é {0}\n", saldo);
            
            return saldo;
        }
    }
}
