using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public class ContaCorrente : Conta
	{
		public ContaCorrente ()
		{
		}

		public ContaCorrente (int numero): base (numero)
		{
		}
		public override void Deposita (double valor)
		{
			double taxa = 0.10;
			valor -= taxa;
			base.Deposita (valor);
		}

		public override bool Saca (double valor)
		{
			double taxa = 0.05;
			valor += taxa;

			if (valor > Saldo)
				return false;
			Saldo -= valor;

			return true;
		}

	}
}
