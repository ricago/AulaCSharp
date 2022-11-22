using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Entidades
    {
        public string idTarefa;
        public string idEquipa;
        public string idMembro;
        public string idProjeto;

        public void Menu1()
        {
            Console.WriteLine("-----------------Menu--------------------");
            Console.WriteLine("| 1 - Adicionar ou Remover registos     |");
            Console.WriteLine("| 2 - Editar projetos, equipas, tarefas |");
            Console.WriteLine("| 3 - Imprimir relatorios inconcluidos  |");
            Console.WriteLine("| 4 - Relatorio Geral                   |");
            Console.WriteLine("| 0 - Encerrar                          |");
            Console.WriteLine("-----------------------------------------");
        }

    }
}
