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
    enum sexo
        {
            Feminino,Masculino
        }
    class Pessoa
    {
        public endPostal postal;
        public Nome name;
        public sexo genero;
        
    
    }
}
