using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4
{
    class Pessoa
    {
        /*********** Propriedades ***********/
        public string nomePessoa { get; set; }
        public string numeroFiscal;
        /*********** Campos ***********/

        //private string nomePessoa; //versao normal
        public int idadePessoa;
        //private string numeroFiscal;

        public string NumeroFiscal
        {
            get { return numeroFiscal; }

            set { 
                if(value.Length == 9)
                numeroFiscal = value; 
            }
        }
    }
}
