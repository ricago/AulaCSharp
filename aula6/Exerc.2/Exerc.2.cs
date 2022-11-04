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

            int rodas;
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Mota");

            Console.WriteLine("Selecione o veiculo desejado: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Rodas: {0}, Cor: {1}, Matricula: {2}, Marca: {3},  Modelo: {4}", carro.rodas,carro.cor,carro.marca,carro.modelo,carro.matricula);
                    break;

                case 2:
                    Console.WriteLine("Rodas: {0}, Cor: {1}, Matricula: {2}, Marca: {3},  Modelo: {4}", mota.rodas, mota.cor, mota.marca, mota.modelo, mota.matricula);
                    break;
            }
        }
    }
}
