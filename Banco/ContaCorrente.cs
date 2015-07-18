using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public class ContaCorrente : Conta, ITributavel
	{
		public ContaCorrente ()
		{
		}

		public override void Deposita (double valor)
		{
			double taxa = 0.10;
			valor -= taxa;
			base.Deposita (valor);
		}

		public override void Saca (double valor)
		{
			if (valor <= 0.0)
				throw new ArgumentException ("valor");

			double taxa = 0.05;
			valor += taxa;

			if (valor > Saldo)
				throw new SaldoInsuficienteException ();
			Saldo -= valor;
		}

		public double CalculaTributos ()
		{
			return Saldo * 0.05;
		}
	}
}
