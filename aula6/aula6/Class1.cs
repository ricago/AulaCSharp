using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula6
{
    internal class Class1
    {

        public static float Soma1(int soma)
        {

            soma = 1 + 1;
            return soma;
        }

        public static float Soma2(ref int soma)
        {

            soma = 1 + 1;
            return soma;
        }

        public static float Soma3(int[] soma)
        {
            soma[0] = 1 + 1;
            return soma[0];
        }
    }
}
