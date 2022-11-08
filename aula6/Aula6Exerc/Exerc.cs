using System;

namespace Aula6Exerc
{
    internal class Exerc
    {
        static void Main(string[] args)
        {
            int op;
            //Calc calculo = new Calc();         
            //float valor1, valor2;
            float[] resultado;

            Console.WriteLine("---------------Menu---------------");
            Console.WriteLine("1 - Soma                          ");
            Console.WriteLine("2 - Subtração                     ");
            Console.WriteLine("3 - Multiplicação                 ");
            Console.WriteLine("4 - Divisão                       ");
            Console.WriteLine("0 - Sair                          ");
            try { 
            do
            {

                Console.WriteLine("\nDigite uma operação: ");
                op = int.Parse(Console.ReadLine());

                    //Console.WriteLine("Digite um valor: ");
                    //valor1 = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Digite outro valor: ");
                    //valor2 = int.Parse(Console.ReadLine());
                    resultado = Calc.InsereValores();
                    switch (op)
                    {
                    case 1:
                            //Console.WriteLine("Digite um valor: ");
                            //valor1 = int.Parse(Console.ReadLine());
                            //Console.WriteLine("Digite outro valor: ");
                            //valor2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Resultado: {0}",Calc.Soma(resultado));
                            break;

                        case 2:
                            //Console.WriteLine("Digite um valor: ");
                            //valor1 = int.Parse(Console.ReadLine());
                            //Console.WriteLine("Digite outro valor: ");
                            //valor2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Resultado: {0}",Calc.Subrai(resultado));
                            break;

                        case 3:
                            //Console.WriteLine("Digite um valor: ");
                            //valor1 = int.Parse(Console.ReadLine());
                            //Console.WriteLine("Digite outro valor: ");
                            //valor2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Resultado: {0}",Calc.Multiplica(resultado));
                            break;

                        case 4:
                            //Console.WriteLine("Digite um valor: ");
                            //valor1 = int.Parse(Console.ReadLine());
                            //Console.WriteLine("Digite outro valor: ");
                            //valor2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Resultado: {0}",Calc.Divide(resultado));
                            break;

                        case 0:
                        break;
                    }
            } while(op != 0 || op!= 1 || op != 2 || op != 3 || op != 4);

            }
            catch(Exception)
            {
                Console.WriteLine("Digite valores validos");
            }
        }
    }
}
