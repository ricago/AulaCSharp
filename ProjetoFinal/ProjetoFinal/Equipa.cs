using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Equipa : Membros
    {
        //variaveis
        public static Guid idEquipa { get; set; }
        public string nomeEquipa;
        public string IdEquipa;
        public List<Membros> ListaM = new List<Membros> { };

        //construtor Guid
        public Equipa()
        {
            idEquipa = Guid.NewGuid();
        }

        //metodo adicionar
        public static List<Equipa> adicionaregistoEquipa()
        {
            try
            {
                //poo
                Equipa equipa = new Equipa();

                //converter para string
                equipa.IdEquipa = idEquipa.ToString();

                //inserir
                Console.WriteLine("Digite o nome da equipa");
                equipa.nomeEquipa = Console.ReadLine();

                //"clonar"
                equipa.ListaM = Program.listaMembros;

                //adicionar
                Program.listaEquipa.Add(equipa);

            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
            }
            return Program.listaEquipa;
        }

        //função remove
        public static void removeregistoEquipa()
        {
            //inserir o id
            Console.WriteLine("Digite o ID que deseja eliminar: ");
            string procuraId = Console.ReadLine();

            //percorrer lista
            for (int i = 0; i < Program.listaEquipa.Count; i++)
            {
                //verificar se é igual
                if (Program.listaEquipa[i].IdEquipa == procuraId)
                {
                    //elimina
                    Program.listaEquipa.Remove(Program.listaEquipa[i]);
                }
            }

        }

        public static void imprimirRelatorioEqui()
        {
            //poo
            Equipa equipa = new Equipa();

            //imprimir
            foreach (Equipa s in Program.listaEquipa)
            {
                Console.WriteLine("Id da Equipa: " + s.IdEquipa);
                Console.WriteLine("Nome da Equipa: " + s.nomeEquipa);
                Console.WriteLine("Lista de membros: ");

                //imprimir lista de membros
                foreach (Equipa membros in equipa.ListaM)
                {
                    Console.WriteLine("Id do Membro: " + membros.IdMembro);
                    Console.WriteLine("Nome do Membro: " + membros.nomeMembro);
                }

            }
        }
    }
}
