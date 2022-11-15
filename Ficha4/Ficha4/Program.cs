using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ficha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,op,cont=0,equipa;
            string lixo;

            Eletrico equip2 = new Eletrico();
            double potencia = equip2.potencia;

            float tempo = equip2.tempo;

            string nome = equip2.nome;

            List<Eletrico> Fatura = new List<Eletrico>();
            try { 
            Console.WriteLine("Digite o numero de equipamentos eletricos: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Preencha os detalhes dos produtos\n");

            for (int i = 0; i < n; i++)
            {
                Eletrico equip = new Eletrico();

                Console.WriteLine("Digite o nome do equipamento: ");
                equip.nome = Console.ReadLine();

                Console.WriteLine("Digite a potencia por hora do equipamento em watts: ");
                do
                {
                    equip.potencia = int.Parse(Console.ReadLine());
                }
                while (equip.potencia < 0);

                Console.WriteLine("Digite o tempo de utilização do equipamento em horas: ");
                do
                {
                    equip.tempo = int.Parse(Console.ReadLine());
                }
                while (equip.tempo < 0);

                if (equip.potencia > 0 && equip.nome.Length > 0 && equip.tempo > 0)

                    Fatura.Add(equip);
            }

            
            do
            {
                Console.Clear();
                equip2.menu();
                Console.WriteLine("Digite qual a operação que deseja realizar: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                            cont = 0;
                            Console.WriteLine("Selecione o equipamento: ");
                        foreach (Eletrico equipamento in Fatura)
                        {
                            Console.WriteLine("{1} - Equipamento: {0}\n", equipamento.nome,cont);
                            cont++;
                            potencia =equipamento.potencia;
                        }
                        equipa = int.Parse(Console.ReadLine());

                            Console.WriteLine("Potencia em watts por dia: {0} watts", potencia);

                            Console.WriteLine("Pressione Enter");
                            lixo = Console.ReadLine();
                            break;

                    case 2:
                            cont = 0;
                            Console.WriteLine("Selecione o equipamento: ");
                            foreach (Eletrico equipamento in Fatura)
                            {
                                Console.WriteLine("{1} - Equipamento: {0}\n", equipamento.nome, cont);
                                cont++;
                                potencia = equipamento.potencia;
                            }
                            equipa = int.Parse(Console.ReadLine());

                            equip2.verWattsMes(ref potencia);

                            Console.WriteLine("Potencia em watts por mes: {0} watts", potencia);

                            Console.WriteLine("Pressione Enter");
                            lixo = Console.ReadLine();
                            break;

                        case 3:
                            cont = 0;
                            Console.WriteLine("Selecione o equipamento: ");
                            foreach (Eletrico equipamento in Fatura)
                            {
                                Console.WriteLine("{1} - Equipamento: {0}\n", equipamento.nome, cont);
                                cont++;
                                potencia = equipamento.potencia;
                            }
                            equipa = int.Parse(Console.ReadLine());

                            equip2.verWattsAno(ref potencia);

                            Console.WriteLine("Potencia em watts por ano: {0} watts", potencia);

                            Console.WriteLine("Pressione Enter");
                            lixo = Console.ReadLine();
                            break;

                        case 4:
                            cont = 0;
                            Console.WriteLine("Selecione o equipamento: ");
                            foreach (Eletrico equipamento in Fatura)
                            {
                                Console.WriteLine("{1} - Equipamento: {0}\n", equipamento.nome, cont);
                                cont++;
                                potencia = equipamento.potencia;
                            }
                            equipa = int.Parse(Console.ReadLine());

                            equip2.verKWattsDia(ref potencia);

                            Console.WriteLine("Potencia em kwatts por dia: {0} euros", potencia);

                            equip2.verKWattsMes(ref potencia);

                            Console.WriteLine("Potencia em kwatts por mes: {0} euros", potencia);

                            equip2.verKWattsAno(ref potencia);

                            Console.WriteLine("Potencia em kwatts por ano: {0} euros", potencia);

                            Console.WriteLine("Pressione Enter");
                            lixo = Console.ReadLine();
                            break;

                        case 5:
                            cont = 0;

                            Console.WriteLine("Selecione o equipamento: ");
                            foreach (Eletrico equipamento in Fatura)
                            {
                                Console.WriteLine("{1} - Equipamento: {0}\n", equipamento.nome, cont);
                                cont++;
                                potencia = equipamento.potencia;
                                nome=equipamento.nome;
                            }
                            equipa = int.Parse(Console.ReadLine());

                            equip2.verKWatts(ref potencia);

                            Console.WriteLine("{0}: Gastos em Kwatts por dia: {1}", nome, potencia);

                            Console.WriteLine("Pressione Enter");
                            lixo = Console.ReadLine();
                            break;

                        case 6:
                            cont = 0;
                            Console.WriteLine("Selecione o equipamento: ");
                            foreach (Eletrico equipamento in Fatura)
                            {
                                Console.WriteLine("Equipamento: {0} - Gasto em watts diarios: {1}\n", equipamento.nome, equipamento.potencia);
                            }

                            Console.WriteLine("Pressione Enter");
                            lixo = Console.ReadLine();
                            break;

                    }

            } while (op != 0);
            
            }catch(Exception e)
            {
                Console.WriteLine("Deu erro");
            }
        }
    }
}

