using System;
using System.Collections.Generic;
using System.ComponentModel;

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
            while (n>0);

            for (int i = 0; i < n ; i++)
            {
            Veiculo veiculo1 = new Veiculo();

            Console.WriteLine("Digite a marca do veiculo: ");
            veiculo1.marca = Console.ReadLine();

            Console.WriteLine("Digite o modelo do carro: ");
            veiculo1.modelo = Console.ReadLine();

            Console.WriteLine("Digite o ano do carro: ");
            do
            {
                veiculo1.ano = int.Parse(Console.ReadLine());
            }
            while (veiculo1.ano < 1886 && veiculo1.ano > 2022);

            listaV.Add(veiculo1);

            }

            //Console.WriteLine("O veiculo é um {0} {1} de {2}",veiculo1.marca, veiculo1.modelo,veiculo1.ano);
            
            Console.WriteLine(" ");
            foreach(Veiculo veiculo in listaV)
            {
                Console.WriteLine("Veiculo: "+veiculo.marca+" "+veiculo.modelo+" de "+veiculo.ano+"\n");
            }
            }
            catch(Exception e)
            {
                Console.WriteLine("Digite dados validos nos respetivos campos");
            }
        }
    }
}
