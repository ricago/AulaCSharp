using System;

namespace ContaBancaria
{
	internal class Program
	{
		static void Main(string[] args)
		{

			ContaCorrente contaCorrente = new ContaCorrente() { };

			contaCorrente.Saldo = 1000;
			contaCorrente.Titular = new Pessoa
			{
				DataNascimento = DateTime.Now,
				Nome = "Zé Manel"
			};
			contaCorrente.VerSaldo();

		}
	}
}
