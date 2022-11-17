using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Linq
    {
        static void Main(string[] args)
        {
            List<int> num = new() {55,-2,0,19,43,25,5,99};

            var desce = num.OrderByDescending(x => x).ToList();

            var maiores = desce.Take(5);

            foreach (var numero in maiores)
            {
                Console.WriteLine(numero);
            }
        }
    }
}