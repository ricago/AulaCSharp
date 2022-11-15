using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ficha4
{
    abstract class Descricao
    {
        public string nome;
        public float tempo;

        public void menu()
        {
            Console.WriteLine("-------------------- Menu --------------------");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|Digite a operação desejada                  |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("| 1 - Ver quantidade de watts gastos por dia |");
            Console.WriteLine("| 2 - Ver quantidade de watts gastos por mês |");
            Console.WriteLine("| 3 - Ver quantidade de watts gastos por ano |");
            Console.WriteLine("| 4 - Ver Custo em euros                     |");
            Console.WriteLine("| 5 - Relatorio consumo energetico           |");
            Console.WriteLine("| 6 - Relatorio consumo energetico geral     |");
            Console.WriteLine("| 0 - Sair                                   |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("-----------------------------------------------");
        }
       
    }
}
