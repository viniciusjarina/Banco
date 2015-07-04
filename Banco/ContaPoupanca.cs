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
			double taxa = 0.10;
			return base.Saca (valor + taxa);
		}

		public override void CalculaRendimento ()
		{
			double rendimento = Saldo * 0.05;
			Deposita (rendimento);
		}
	}
}
