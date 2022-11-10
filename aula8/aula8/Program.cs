using System;
using System.Threading.Tasks;

namespace aula8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            int op,pin,pin2;
            float saldo;
            try { 
                
                Console.WriteLine("Digite o seu nome: ");
                conta.name = Console.ReadLine();
                Console.WriteLine("Digite o seu sobrenome: ");
                conta.sobrenome = Console.ReadLine();

                string nome = conta.name + " " + conta.sobrenome;

                conta.saldoInicial(ref conta.saldo);
                conta.codigo(ref conta.pin);

                pin = conta.pin;
                saldo = conta.saldo;

                Console.WriteLine("Parabens {0}, criou a sua conta com sucesso",nome);
                do {
                    conta.Menu();
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 0:
                            break;

                        case 1:
                                conta.pin2
                                Console.Clear();
                                conta.verSaldo(ref saldo);
                                break;

                        case 2:
                                Console.Clear();
                                conta.levanta(ref saldo);
                                break;

                        case 3:
                                Console.Clear();

                                break;
                    }
                }while(op>0 || op<3);

            }catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro");
            }

        }
    }
} 
