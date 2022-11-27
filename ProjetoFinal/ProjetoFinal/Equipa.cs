using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Equipa : Membros
    {

        public static Guid idEquipa { get; set; }
        public string nomeEquipa;
        public string listaMembros;

        public Equipa()
        {
            idEquipa = Guid.NewGuid();
        }

        public static List<Equipa> adicionaregistoEquipa()
        {
            try { 
            
            Equipa equipa = new Equipa();

            Console.WriteLine("Digite o nome da equipa");
            equipa.nomeEquipa = Console.ReadLine();

            Program.listaEquipa.Add(equipa);

            foreach (Equipa s in Program.listaEquipa)
            {
                Console.WriteLine("Id da Equipa: "+Equipa.idEquipa);
                Console.WriteLine("Nome da Equipa: " + s.nomeEquipa);
                Console.WriteLine("Lista de membros: " + s.listaMembros);

            }

            }catch(Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
            }
            return Program.listaEquipa;
        }

        //função remove
        public static List<Equipa> removeregistoEquipa()
        {
            Equipa equipa = new Equipa();

            Program.listaEquipa.Remove(equipa);

            return Program.listaEquipa;
        }
    }
}
