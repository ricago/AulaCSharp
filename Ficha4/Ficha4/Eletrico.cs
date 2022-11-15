using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ficha4
{
    internal class Eletrico:Descricao
    {
        public int potencia;

        public double verWattsMes(ref double potencia)
        {
            
            potencia = potencia * 30.42;

            return potencia;

        }

        public double verWattsAno(ref double potencia)
        {

            potencia = potencia * 365;

            return potencia;

        }

        public double verKWatts(ref double potencia)
        {

            potencia = potencia / 1000;

            return potencia;

        }

        public double verKWattsDia(ref double potencia)
        {

            verKWatts(ref potencia);

            potencia=potencia * 0.22820;

            return potencia;

        }

        public double verKWattsMes(ref double potencia)
        {

            verKWattsDia(ref potencia);

            potencia = potencia * 30.42;

            return potencia;

        }

        public double verKWattsAno(ref double potencia)
        {

            verKWattsDia(ref potencia);

            potencia = potencia * 365;

            return potencia;

        }
    }
}
