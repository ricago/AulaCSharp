using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7exerc3
{ 
    public struct Nome
        {
            public string nome;
            public string sobrenme;
            public int idade;
        }

        public struct endPostal
        {
            public string codPostal;
            public string rua;
            public string andar;
            public string localidade;
        }
    public enum sexo
        {
            Feminino=0,Masculino=1,Outro=2
        }
    class Pessoa
    {
        public endPostal postal;
        public Nome name;
        public int sexo;
        
   
    }
}