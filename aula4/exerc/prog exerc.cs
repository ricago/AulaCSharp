using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace exerc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
           List<Veiculo> listaV = new List<Veiculo>();
            try { 

            Console.WriteLine("Digite o numero de carros que pretende inserir");
            int n;
            do
            {
                 n = int.Parse(Console.ReadLine());
            }
            while (n<0);

            for (int i = 0; i < n ; i++)
            {
            Veiculo veiculo1 = new Veiculo();

            Console.WriteLine("Digite a marca do veiculo: ");
            veiculo1.Marca = Console.ReadLine();

            Console.WriteLine("Digite o modelo do carro: ");
            veiculo1.modelo = Console.ReadLine();

            Console.WriteLine("Digite o ano do carro: ");
            do
            {
                veiculo1.ano = int.Parse(Console.ReadLine());
            }
            while (veiculo1.ano < 1886 && veiculo1.ano > 2022);

            Console.WriteLine("Digite a cor do carro: ");
            veiculo1.cor = Console.ReadLine();

            Console.WriteLine("Digite o estado do carro: ");
            veiculo1.estado = Console.ReadLine();
            

            if(veiculo1.Marca.Length > 0 && veiculo1.modelo.Length > 0 && veiculo1.cor.Length > 0 && veiculo1.estado.Length > 0)

                    listaV.Add(veiculo1);

            }
            
            Console.WriteLine(" ");
            foreach(Veiculo veiculo in listaV)
            {
                    Console.WriteLine("Veiculo: {0} {1} {4} de {2}, estado {3}\n", veiculo.Marca, veiculo.modelo, veiculo.ano, veiculo.estado, veiculo.cor); ;
            }
            }
            catch(Exception e)
            {
                Console.WriteLine("Digite dados validos nos respetivos campos");
            }
        }
    }
}
