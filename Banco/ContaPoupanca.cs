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

		public ContaPoupanca (int numero):base (numero)
		{
		}

		public override bool Saca (double valor)
		{
			double taxa = 0.00;
			valor += taxa;

			if (valor > Saldo)
				return false;
			Saldo -= valor;

			return true;
		}

		public override void CalculaRendimento ()
		{
			double rendimento = Saldo * 0.05;
			Deposita (rendimento);
		}
	}
}
