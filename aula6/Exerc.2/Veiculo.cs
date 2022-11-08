using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc._2
{
    abstract class Veiculo
    {
        public string cor="azul";
        public string matricula;
        public string marca;
        public string modelo;

        public virtual string Display()
        {
            return $" {marca}, {modelo}, {cor}";
        }
   
    }

    
}
