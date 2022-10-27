using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4
{
    //class Pessoa
    //{
        ///*********** Propriedades ***********/
        //public string nomePessoa { get; set; }
        //public string numeroFiscal;
        ///*********** Campos ***********/

        ////private string nomePessoa; //versao normal
        //public int idadePessoa;
        ////private string numeroFiscal;

        //public string NumeroFiscal
        //{
        //    get { return numeroFiscal; }

        //    set { 
        //        if(value.Length == 9)
        //        numeroFiscal = value; 
        //    }
        //}

        //--------------------------------------------------------------------------------------

        internal class Veiculo
        {

            ///*public string marca*/;
            public string modelo;
            public int ano;
            public string cor;
            public string estado;
            //public string veiculo;
            //private string modelo;
            private string marca;
            //private int ano;

            //public string Modelo
            //{
            //    get { return modelo; }

            //    set { modelo = value; }
            //}

            //public string Marca
            //{
            //    get { return marca; }

            //    set { marca = value; }
            //}
            public string Marca
            {
                get;

                set;
            }
            //public int Ano
            //{
            //    get { return ano; }

            //    set { ano = value; }
            //}

            //public int Cor
            //{
            //    get { return cor; }

            //    set { cor = value; }
            //}

            //public int Estado
            //{
            //    get { return estado; }

            //    set { estado = value; }
            //}

            public void CarroSucesso()
            {
                Console.WriteLine("{0} criado com sucesso", Marca);
            }

        public Veiculo1(string marca)
        {
            Marca = marca;
        }

        }
}
//}
