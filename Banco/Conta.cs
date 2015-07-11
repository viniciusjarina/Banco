using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public abstract class Conta
	{
		static int numeroDeContas;

		public Conta ()
		{
			Conta.numeroDeContas++;
			Titular = new Cliente ();
			Numero = Conta.numeroDeContas;
		}

		public static int ProximaConta ()
		{
			return Conta.numeroDeContas + 1;
		}

		public int Numero { get; set; }

		public double  Saldo { get; protected set; }

		public Cliente Titular { get; set; }

		public abstract bool Saca (double valor);

		public virtual void Deposita (double valor)
		{
			Saldo += valor;
		}

		public bool Transfere (Conta destino, double valor)
		{
			Conta origem = this;
			// Primeiro faz o saque da própria conta (this)
			bool saqueOk = this.Saca (valor);
		 // bool saqueOk = origem.Saca (valor);
			if (!saqueOk)
				return false; // Caso o saque tenha falhado.
			destino.Deposita (valor);
			return true;
		}

		public virtual void CalculaRendimento ()
		{

		}
	}
}
