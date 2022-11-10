using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula8
{
     internal class Conta
     {
        public float saldo;
        public string name;
        public string sobrenome;
        public int pin;

        public void Menu()
        {
            Console.WriteLine("------------------- Menu -------------------");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|Digite a operação desejada                 |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("| 1 - Ver saldo                             |");
            Console.WriteLine("| 2 - Fazer levantamento                    |");
            Console.WriteLine("| 3 - Realizar depósito                     |");
            Console.WriteLine("| 0 - Sair                                  |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("---------------------------------------------");
        }

        public void verSaldo(ref float saldo)
        {
            Console.WriteLine("O seu saldo atual é {0}",saldo);
        }

        public float levanta(ref float saldo)
        {
            int levantar;

            Console.WriteLine("Quanto quer levantar: ");
            levantar = int.Parse(Console.ReadLine());

            saldo = saldo - levantar;

            return saldo;
        }

        public float saldoInicial(ref float saldo)
        {
            Console.WriteLine("Qual o seu saldo inicial: ");
            saldo = float.Parse(Console.ReadLine());

            return saldo;
        }

        public int codigo(ref int pin)
        {
            Console.WriteLine("Defina o seu pin: ");
            pin = int.Parse(Console.ReadLine());

            return pin;
        }

        public int digitaPin(ref int pin2)
        {
            Console.WriteLine("Digite o seu pin: ");
            pin2 = int.Parse(Console.ReadLine());

            return pin2;
        }
     }
}