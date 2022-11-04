using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Exerc
{
    static class Calc
    {
        //float valor1, valor2;
        
        public static float[] InsereValores(){

            Console.WriteLine("Digite um valor: ");
            float valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            float valor2 = int.Parse(Console.ReadLine());

            float[] valores = {valor1,valor2};

            return valores;

        }

        public static float Soma(/*float valor1, float valor2*/float[] valores)
        {
            float resultado;
            
            resultado = valores[0] + valores[1];
            //return valor1+valor2;
            return resultado;
        }

        public static float Subrai(/*float valor1, float valor2*/float[] valores)
        {
            float resultado;

            resultado = valores[0] - valores[1];
            return resultado;
            //return valor1-valor2;
        }

        public static float Multiplica(/*float valor1, float valor2*/float[] valores)
        {
            float resultado;

            resultado = valores[0] * valores[1];
            return resultado;
            //return valor1*valor2;
        }
        public static float Divide(/*float valor1, float valor2*/float[] valores)
        {
            float resultado;

            resultado = valores[0] / valores[1];
            return resultado;
            //return valor1/valor2;
        }

    }
}
