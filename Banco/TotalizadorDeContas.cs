using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public class TotalizadorDeContas
	{
		public double ValorTotal { get; set; }

		public void Soma (Conta conta)
		{
			ValorTotal += conta.Saldo;

			conta.CalculaRendimento ();
		}
	}
}
