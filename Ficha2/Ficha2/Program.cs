using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace Ficha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exerc 1-------------------------------------------------------------
            // string frase;

            // Console.WriteLine("Digite uma frase");
            // frase = Console.ReadLine();

            // Console.WriteLine(frase.ToUpper()); // Tudo maiusculo
            // Console.WriteLine(frase.Substring(0,1));//Primeira letra
            // Console.WriteLine(frase.Length);//numero de caracteres

            // exerc 2 ---------------------------------------------------------------

            //string frase, addfrase;
            //int palavra;
            //frase = "Lorem Ipsum dolor sit amet sit";
            //Console.WriteLine(frase);

            //Console.WriteLine("Posição da palavra amet " + frase.IndexOf("amet"));//posição dentro da string

            //Console.WriteLine("Digite uma frase: ");//inserir uma frase antes da palavra do a)
            //addfrase = Console.ReadLine();

            //palavra = frase.IndexOf("amet");

            //frase = frase.Insert(palavra, addfrase);

            //Console.WriteLine(frase);

            //exerc. 3 ------------------------------------------------------------------------------

            string frase/* frase2,*/;

            frase = "Salvador.Benedita,, Vicente; Teresa";

            Console.WriteLine(frase);

            string[] separador = new string[] { ",", ";", "." };

            string[] frase2 = frase.Split(separador, StringSplitOptions.RemoveEmptyEntries);
            

            frase = string.Join(", ", frase2);

            Console.WriteLine(frase);
        }
    }
}
