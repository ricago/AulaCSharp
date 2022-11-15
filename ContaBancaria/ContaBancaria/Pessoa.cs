using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
	internal class Pessoa
	{
		public string Nome { get; set; }
		public DateTime DataNascimento { get; set; }

		public StrutcsEnums.Morada moradaPessoa;
	}
}
