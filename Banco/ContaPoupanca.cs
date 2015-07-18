using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public class ContaPoupanca : Conta
	{
		public ContaPoupanca ()
		{
		}

		public override void Saca (double valor)
		{
			if (valor <= 0.0)
				throw new ArgumentException ("valor");

			double taxa = 0.00;
			valor += taxa;

			if (valor > Saldo)
				throw new SaldoInsuficienteException ();
			Saldo -= valor;
		}

		public override void CalculaRendimento ()
		{
			double rendimento = Saldo * 0.05;
			Deposita (rendimento);
		}
	}
}
