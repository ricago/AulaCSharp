using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Membros
    {

        Guid idMembro = Guid.NewGuid();
        public string nomeMembro;
        public string emailMembro;
        public int idadeMembro;
        public int ano;
        public int mes;
        public int dia;
        public string morada;
        public int telemovel;


        /*public struct moradaMembro
        {

            public int codigoPostal { get; set; }
            public string rua { get; set; }


        }*/

        /*public struct telemovelMembro
        {
            public int indicativo;
            public int numero;
        }*/

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
                    Console.WriteLine("O membro é Responsavel? true-sim ou false-não?");
                    membroRes = Convert.ToBoolean(Console.ReadLine());
                }

                //nome membro

                    Console.WriteLine("Digite o nome do membro");
                    membro.nomeMembro = Console.ReadLine();

                //morada do membro


                    Console.WriteLine("Digite a rua do membro");
                    string rua= Console.ReadLine();

                    Console.WriteLine("Digite a rua do membro");
                    int codigoPostal = int.Parse(Console.ReadLine());

                    membro.morada = rua+" "+codigoPostal;

                    
                //telemovel

                Console.WriteLine("Digite o numero de telemovel do membro");
                int indicativo = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o numero de telemovel do membro");
                int numero = int.Parse(Console.ReadLine());

                membro.telemovel = indicativo+numero;

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
                Console.WriteLine("Id do membro: " + s.idMembro);
                Console.WriteLine("Nome do membro: " + s.nomeMembro);
                Console.WriteLine("Morada da membro: " + s.morada);
                Console.WriteLine("Numero da telemovel: " + s.telemovel);
                Console.WriteLine("Email do membro: " + s.emailMembro);
                Console.WriteLine("Idade do membro: " + s.idadeMembro);
            }

            return Program.listaMembros;
        }
    }
}
