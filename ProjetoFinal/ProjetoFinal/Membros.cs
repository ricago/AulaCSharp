using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Membros
    {
        //variaveis
        public static Guid idMembro { get; set; }
        public string nomeMembro;
        public string emailMembro;
        public int idadeMembro;
        public int ano;
        public int mes;
        public int dia;
        public string moradaMembro;
        public int telemovelMembro;
        public string IdMembro;

        //construtor guid
        public Membros()
        {
            idMembro = Guid.NewGuid();

        }

        //struct da morada
        public struct morada
        {

            public static int codigoPostal { get; set; }
            public static string rua { get; set; }


        }

        //struct do telemovel
        public struct telemovel
        {
            public static int indicativo { get; set; }
            public static int numero { get; set; }
        }

        //metodo adicionar
        public static List<Membros> adicionaregistoMembros()
        {
            //poo
            Membros membro = new Membros();

            //converter para string
            membro.IdMembro = idMembro.ToString();

            //inserir dados
            Console.WriteLine("Digite o numero de membros da equipa");
            int i = int.Parse(Console.ReadLine());
            bool membroRes = false;

            //verifica se é responsavel
            for (int j = 0; j < i; j++)
            {
                //se for true não vai perguntar mais(so aceita true ou false)

                if (membroRes == false)
                {
                    Console.WriteLine("O membro é Responsavel? true-sim ou false-não?");
                    membroRes = Convert.ToBoolean(Console.ReadLine());
                }

                //nome membro

                Console.WriteLine("Digite o nome do membro");
                membro.nomeMembro = Console.ReadLine();

                //morada do membro

                Console.WriteLine("Digite a rua do membro");
                morada.rua = Console.ReadLine();

                Console.WriteLine("Digite o codigo postal por estenso do membro");
                morada.codigoPostal = int.Parse(Console.ReadLine());

                //juntar tudo
                membro.moradaMembro = morada.rua + " " + morada.codigoPostal;


                //telemovel

                Console.WriteLine("Digite o indicativo do numero do membro");
                telemovel.indicativo = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o numero de telemovel do membro");
                telemovel.numero = int.Parse(Console.ReadLine());

                //juntar tudo
                membro.telemovelMembro = telemovel.indicativo + telemovel.numero;

                //mail

                Console.WriteLine("Digite o email do membro");
                membro.emailMembro = Console.ReadLine();

                //idade
                //dia de Hoje mesmo

                var today = DateTime.Today;

                do {
                    Console.WriteLine("Digite o ano de nascimento");
                    membro.ano = int.Parse(Console.ReadLine());
                } while (membro.ano <1940 || membro.ano>2022);

                do {
                    Console.WriteLine("Digite o mês de nascimento");
                    membro.mes = int.Parse(Console.ReadLine());
                } while (membro.mes <12 || membro.mes > 0);

                do {
                    Console.WriteLine("Digite o dia de nascimento");
                    membro.dia = int.Parse(Console.ReadLine());
                } while (membro.dia<31 || membro.dia>0);

                //data de nascimento em datetime
                DateTime DataNascimento = new DateTime(membro.ano, membro.mes, membro.dia);

                //calculo
                var idade2 = today.Year - DataNascimento.Year;

                var month = today.Month - DataNascimento.Month;

                var day = today.Day - DataNascimento.Day;

                //se ja fez anos ou não
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
                //adicionar á variavel
                membro.idadeMembro = idade2;

            }

            Program.listaMembros.Add(membro); //adiciona tudo por ciclo



            return Program.listaMembros;
        }

        //metodo remover
        public static void removeregistoMembro()
        {
            //inserir o ID
            Console.WriteLine("Digite o ID que deseja eliminar: ");
            string procuraId = Console.ReadLine();

            //percorre a lista 
            for (int i = 0; i < Program.listaProjeto.Count; i++)
            {
                //verifica se é igual
                if (Program.listaMembros[i].IdMembro == procuraId)
                {
                    //elimina
                    Program.listaMembros.Remove(Program.listaMembros[i]);
                }
            }
        }

        public static void imprimirRelatorioMem()
        {
            //imprimir
            foreach (Membros s in Program.listaMembros)
            {
                Console.WriteLine("Id do membro: " + s.IdMembro);
                Console.WriteLine("Nome do membro: " + s.nomeMembro);
                Console.WriteLine("Morada da membro: " + s.moradaMembro);
                Console.WriteLine("Numero da telemovel: " + s.telemovelMembro);
                Console.WriteLine("Email do membro: " + s.emailMembro);
                Console.WriteLine("Idade do membro: " + s.idadeMembro);
            }
        }
    }
}
