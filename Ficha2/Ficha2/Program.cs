using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace Ficha2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string frase, addfrase;
            int palavra;

            //exerc. 1-------------------------------------------------------------

            //Console.WriteLine("Digite uma frase");
            //frase = Console.ReadLine();

            //Console.WriteLine(frase.ToUpper()); // Tudo maiusculo
            //Console.WriteLine(frase.Substring(0, 1));//Primeira letra
            //Console.WriteLine(frase.Length);//numero de caracteres

            // exerc. 2 ---------------------------------------------------------------

            //frase = "Lorem Ipsum dolor sit amet sit";
            //Console.WriteLine(frase);

            //Console.WriteLine("Posição da palavra amet " + frase.IndexOf("amet"));//posição dentro da string

            //Console.WriteLine("Digite uma frase: ");//inserir uma frase antes da palavra do a)
            //addfrase = Console.ReadLine();

            //palavra = frase.IndexOf("amet");

            //frase = frase.Insert(palavra, addfrase + " ");

            //Console.WriteLine(frase);

            //exerc. 3 ------------------------------------------------------------------------------

            //frase = "Salvador.Benedita,, Vicente; Teresa";

            //Console.WriteLine(frase);

            //string[] separador = new string[] { ",", ";", "." };

            //string[] frase2 = frase.Split(separador, StringSplitOptions.RemoveEmptyEntries);

            ///*foreach(string x in frase2)
            //  {
            //       Console.WriteLine(x);
            //   }*/

            //frase = string.Join(", ", frase2);

            //Console.WriteLine(frase);

            //exerc. 4 -------------------------------------------------------------------------------

            //int[] NImpares = new int[] {1,3,5,7,9};
            //Array.Reverse(NImpares);

            ////foreach(int x in NImpares)
            ////{
            ////    Console.WriteLine(x);
            ////}

            //Console.WriteLine(NImpares[1]);

            //exerc. 5 -----------------------------------------------------------------------------------

            List<int> idades = new List<int>();//a)

            Console.WriteLine("Digite o numero de alunos que pretende inserir: ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as idades dos alunos da turma xpto");

            for (int i = 0; i < n; i++)
            {
                idades.Add(int.Parse(Console.ReadLine()));//lê a idade e adiciona a lista
            }
            
            //int min = idades.Min();

            Console.WriteLine("O aluno mais novo tem {0} anos",/*min*/idades.Min());

            int max = idades.Max();//b)

           // int max2 = max - 20;

            Console.WriteLine("O aluno mais velho com menos 20 anos tem {0} anos", max-20);

           // int SizeTurma = idades.Count;//c)

            Console.WriteLine("A turma tem {0} alunos",/*SizeTurma*/idades.Count);
        }
    }
}
