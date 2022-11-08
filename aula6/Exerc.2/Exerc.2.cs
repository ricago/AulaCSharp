using System;

namespace Exerc._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mota mota = new Mota();
            Carro carro = new Carro();

            mota.marca = "Yamaha";
            carro.marca = "Fiat";
            carro.modelo = "Punto";
            mota.modelo = "coisa";
            mota.cor = "verde";
            mota.rodas = 2;
            carro.rodas = 4;

            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Mota");

            Console.WriteLine("Selecione o veiculo desejado: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine(carro.Display());
                    break;

                case 2:
                    Console.WriteLine(mota.Display());
                    break;
            }
        }
    }
}
