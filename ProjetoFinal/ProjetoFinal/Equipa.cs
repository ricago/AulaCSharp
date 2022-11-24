using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Equipa:Entidades
    {
        public string idEquipa;
        public string nomeEquipa;
        public string listaMembros;

        public static List<Equipa> adicionaregistoEquipa()
        {
            Equipa equipa = new Equipa();

            Console.WriteLine("Digite o id da equipa");
            equipa.idEquipa = Console.ReadLine();


            Console.WriteLine("Digite o nome da equipa");
            equipa.nomeEquipa = Console.ReadLine();


            Console.WriteLine("Digite o numero de membros da equipa");
            int i = int.Parse(Console.ReadLine());

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Digite o nome do membro");
                equipa.listaMembros = Console.ReadLine();
                
            }

            Program.listaEquipa.Add(equipa);

            foreach (Equipa s in Program.listaEquipa)
            {
                Console.WriteLine(s);
            }
            return Program.listaEquipa;
        }
    }
}
