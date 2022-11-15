using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
	abstract class Conta
	{
		public Pessoa Titular { get; set; }
		public float Saldo { get; set; }

		public void VerSaldo()
		{
			Console.WriteLine("O seu saldo é {0}", Saldo);
		}
	}
}
