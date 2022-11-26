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
        public int ano;
        public int mes;
        public int dia;

        public static List<Membros> adicionaregistoMembros()
        {
            Membros membro = new Membros();

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

                /*Console.Clear(); // to do
                Console.WriteLine("Digite o id do membro");
                membro.idMembro = Console.ReadLine();*/


                //nome membro

                    Console.WriteLine("Digite o nome do membro");
                    membro.nomeMembro = Console.ReadLine();

                //morada do membro


                    Console.WriteLine("Digite a morada do membro");
                    membro.moradaMembro = Console.ReadLine();


                //telemovel

                    Console.WriteLine("Digite o numero de telemovel do membro");
                    membro.telemovelMembro = int.Parse(Console.ReadLine());


                //mail

                    Console.WriteLine("Digite o email do membro");
                    membro.emailMembro = Console.ReadLine();

                //idade
                

                var today = DateTime.Today;

                Console.WriteLine("Digite o ano de nascimento");
                membro.ano = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o mês de nascimento");
                membro.mes = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o dia de nascimento");
                membro.dia = int.Parse(Console.ReadLine());

                DateTime DataNascimento = new DateTime(membro.ano, membro.mes, membro.dia);

                var idade2 = today.Year - DataNascimento.Year;

                var month = today.Month - DataNascimento.Month;

                var day = today.Day - DataNascimento.Day;

                if (idade2 == today.Year)
                {

                    if (month < DataNascimento.Month)
                    {
                        idade2 = idade2 - 1;
                    }

                    else if (day < DataNascimento.Day)
                    {
                        idade2 = idade2 - 1;
                    }
                }

                membro.idadeMembro = idade2;

            }
            Program.listaMembros.Add(membro); //adiciona tudo por ciclo

            foreach (Membros s in Program.listaMembros)
            {
                //Console.WriteLine(s.idMembro);
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
