using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Membros:Entidades
    {
        public string idMembro;
        public string nome;
        public string morada;
        public string telemovel;
        public string email;
        public int idade;

        public static List<string> adicionaregistoMembros()
        {
            Membros membro = new Membros();

            Console.WriteLine("Digite o id da equipa");
            membro.idEquipa = Console.ReadLine();
            Program.listaEquipa.Add(membro.idEquipa);

            Console.WriteLine("Digite o nome da equipa");
            membro.nomeEquipa = Console.ReadLine();
            Program.listaEquipa.Add(membro.nomeEquipa);

            Console.WriteLine("Digite o numero de membros da equipa");
            int i = int.Parse(Console.ReadLine());

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Digite o nome do membro");
                membro.listaMembros = Console.ReadLine();
                Program.listaEquipa.Add(membro.listaMembros);
            }

            foreach (string s in Program.listaMembros)
            {
                Console.WriteLine(s);
            }
            return Program.listaEquipa;
        }
    }
}
