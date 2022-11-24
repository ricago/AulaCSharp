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
        public string nomeMembro;
        public string moradaMembro;
        public int telemovelMembro;
        public string emailMembro;
        public int idadeMembro;

        public static List<Membros> adicionaregistoMembros()
        {
            Membros membro = new Membros();
            MembroResponsavel membroR = new MembroResponsavel();
            MembrosEmpregado membroE = new MembrosEmpregado();

            Console.WriteLine("Digite o numero de membros da equipa");
            int i = int.Parse(Console.ReadLine());
            bool membroRes=false;

            for (int j = 0; j < i; j++)
            {
                // se é responsavel

                if (membroRes==false) { //se for true não vai perguntar mais(so aceita true ou false)
                    Console.WriteLine("O membro é Responsavel? 1-sim ou 0-não?");
                    membroRes = Convert.ToBoolean(Console.ReadLine());
                }
                //Id do membro

                Console.Clear();
                Console.WriteLine("Digite o id do membro");
                membroE.idMembro = Console.ReadLine();


                //nome membro

                    Console.WriteLine("Digite o nome do membro");
                    membroE.nomeMembro = Console.ReadLine();

                //morada do membro


                    Console.WriteLine("Digite a morada do membro");
                    membroE.moradaMembro = Console.ReadLine();


                //telemovel

                    Console.WriteLine("Digite o numero de telemovel do membro");
                    membroE.telemovelMembro = int.Parse(Console.ReadLine());


                //mail

                    Console.WriteLine("Digite o email do membro");
                    membroE.emailMembro = Console.ReadLine();

                //idade

                    Console.WriteLine("Digite a idade do membro");
                    membroE.idadeMembro = int.Parse(Console.ReadLine());


            }Program.listaMembros.Add(membroR); //adiciona tudo por ciclo

            foreach (Membros s in Program.listaMembros)
            {
                Console.WriteLine(s.idMembro);
                Console.WriteLine(s.nomeMembro);
                Console.WriteLine(s.moradaMembro);
                Console.WriteLine(s.telemovelMembro);
                Console.WriteLine(s.emailMembro);
                Console.WriteLine(s.idadeMembro);
            }

            return Program.listaMembros;
        }
    }
}
