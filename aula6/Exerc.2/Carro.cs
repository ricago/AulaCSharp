using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc._2
{
    internal class Carro:Veiculo
    {
        public int rodas;

        public override string Display()
        {
            return $"Marca: {marca}, Modelo: {modelo}, Cor: {cor},Rodas: {rodas}";
        }
    }
}
